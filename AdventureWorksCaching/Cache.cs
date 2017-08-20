using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

using Memcached.ClientLibrary;

namespace AdventureWorksCaching
{
    /// <summary>
    /// Thread Safe Singleton Cache Class
    /// </summary>
    public sealed class Cache
    {
        static readonly Cache instance = new Cache(); //  Locks var until assignment is complete for double safety
        private static object syncRoot = new Object();
        private static string cacheHostPort;
        private static SockIOPool pool = SockIOPool.GetInstance();
        //private static double settingCacheExpirationTimeInMinutes;
        private Cache() { }

        /// <summary>
        /// Singleton Cache Instance
        /// </summary>
        public static Cache Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            InitializeInstance();

                        }
                    }
                }
                return instance;
            }
        }

        private static void InitializeInstance()
        {

            //instance = new Cache();

        }

        /// <summary>
        /// Writes Key Value Pair to Cache
        /// </summary>
        /// <param name="Key">Key to associate Value with in Cache</param>
        /// <param name="Value">Value to be stored in Cache associated with Key</param>
        public void Write(string Key, object Value)
        {
            MemcachedClient mc = new MemcachedClient();
            mc.EnableCompression = false;

            mc.Set(Key, Value);

            SockIOPool.GetInstance().Shutdown();
        }

        /// <summary>
        /// Returns Value stored in Cache
        /// </summary>
        /// <param name="Key"></param>
        /// <returns>Value stored in cache</returns>
        public object Read(string Key)
        {
            cacheHostPort = ConfigurationManager.AppSettings["CacheHostPort"].ToString();
            if (cacheHostPort == null)
                throw new Exception("Please enter a host and port combination for the cache in app.config, under 'CacheHostPort' using the format ###.###.###.###:######");

            //TODO
            //if (!Double.TryParse(appSettings["CacheExpirationTimeInMinutes"], out settingCacheExpirationTimeInMinutes))
            //    throw new Exception("Please enter how many minutes the cache should be kept in app.config, under 'CacheExpirationTimeInMinutes'");

            string[] serverList = { cacheHostPort };

            //SockIOPool pool = SockIOPool.GetInstance();
            pool.SetServers(serverList);

            pool.InitConnections = 3;
            pool.MinConnections = 3;
            pool.MaxConnections = 5;

            pool.SocketConnectTimeout = 1000;
            pool.SocketTimeout = 3517;

            pool.MaintenanceSleep = 30;
            pool.Failover = true;

            pool.Nagle = false;
            pool.Initialize();

            int timeout = pool.SocketTimeout;

            MemcachedClient mc = new MemcachedClient();
            mc.EnableCompression = false;

            object returnObj = mc.Get(Key);

            SockIOPool.GetInstance().Shutdown();

            return returnObj;
        }

        /// <summary>
        /// Returns Value stored in Cache, null if non existent
        /// </summary>
        /// <param name="Key"></param>
        /// <returns>Value stored in cache</returns>
        public object TryRead(string Key)
        {
            try
            {
                MemcachedClient mc = new MemcachedClient();
                mc.EnableCompression = false;

                object returnObj = mc.Get(Key);

                SockIOPool.GetInstance().Shutdown();

                return returnObj;
            }
            catch (Exception)
            {
                return null;
            }

        }

    }
}
