using System;
using System.Collections.Generic;
using System.Configuration;

using Memcached.ClientLibrary;

namespace AdventureWorksCaching
{
    public class Memcached
    {
        public Memcached()
        {
            string cacheHostPort = ConfigurationManager.AppSettings["CacheHostPort"].ToString();

            string[] serverlist = { cacheHostPort };

            SockIOPool pool = SockIOPool.GetInstance();
            pool.SetServers(serverlist);

            pool.InitConnections = 3;
            pool.MinConnections = 3;
            pool.MaxConnections = 5;

            pool.SocketConnectTimeout = 1000;
            pool.SocketTimeout = 3000;

            pool.MaintenanceSleep = 30;
            pool.Failover = true;

            pool.Nagle = false;
            pool.Initialize();
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
            //Read cache
            MemcachedClient mc = new MemcachedClient();
            mc.EnableCompression = false;

            object cacheObj = mc.Get("saludo");

            SockIOPool.GetInstance().Shutdown();

            return cacheObj;
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
