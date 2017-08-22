using System;
using System.Collections.Generic;
using System.Configuration;

using BeIT.MemCached;

namespace AdventureWorksCaching
{
    public class Cache
    {
        public Cache()
        {
            string cacheHostPort = ConfigurationManager.AppSettings["CacheHostPort"].ToString();

            MemcachedClient.Setup("MyCache", new string[] { cacheHostPort });

            //Get the instance we just set up so we can use it. You can either store this reference yourself in
            //some field, or fetch it every time you need it, it doesn't really matter.
            MemcachedClient cache = MemcachedClient.GetInstance("MyCache");

            ////Change client settings to values other than the default like this:
            cache.SendReceiveTimeout = 5000;
            cache.ConnectTimeout = 5000;
            cache.MinPoolSize = 1;
            cache.MaxPoolSize = 5;


            object result = cache.Get("demo");
            string result1 = System.Text.Encoding.UTF8.GetString((byte[])result);
            //if (result[0] != null && result[0] is int)

            //----------------
            // Using a client.
            //----------------

            //Set some items
            //Console.Out.WriteLine("Storing some items.");
            //cache.Set("mystring", "The quick brown fox jumped over the lazy dog.");
            //cache.Set("myarray", new string[] { "This is the first string.", "This is the second string." });
            //cache.Set("myinteger", 4711);
            //cache.Set("mydate", new DateTime(2008, 02, 23));
            ////Use custom hash
            //cache.Set("secondstring", "Flygande bäckasiner söka hwila på mjuka tufvor", 4711);

            //Get a string
            //string str = cache.Get("mystring") as string;
            //if (str != null)
            //{
            //    Console.Out.WriteLine("Fetched item with key: mystring, value: " + str);
            //}

            ////Get an object
            //string[] array = cache.Get("myarray") as string[];
            //if (array != null)
            //{
            //    Console.Out.WriteLine("Fetched items with key: myarray, value 1: " + array[0] + ", value 2: " + array[1]);
            //}

            ////Get several values at once
            //object[] result = cache.Get(new string[] { "myinteger", "mydate" });
            //if (result[0] != null && result[0] is int)
            //{
            //    Console.Out.WriteLine("Fetched item with key: myinteger, value: " + (int)result[0]);
            //}
            //if (result[1] != null && result[1] is DateTime)
            //{
            //    Console.Out.WriteLine("Fetched item with key: mydate, value: " + (DateTime)result[1]);
            //}

            //str = cache.Get("secondstring", 4711) as string;
            //if (str != null)
            //{
            //    Console.Out.WriteLine("Fetched item with key and custom hash: secondstring, value: " + str);
            //}
        }

        /// <summary>
        /// Writes Key Value Pair to Cache
        /// </summary>
        /// <param name="Key">Key to associate Value with in Cache</param>
        /// <param name="Value">Value to be stored in Cache associated with Key</param>
        public void Write(string Key, object Value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns Value stored in Cache
        /// </summary>
        /// <param name="Key"></param>
        /// <returns>Value stored in cache</returns>
        public object Read(string Key)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns Value stored in Cache, null if non existent
        /// </summary>
        /// <param name="Key"></param>
        /// <returns>Value stored in cache</returns>
        public object TryRead(string Key)
        {
            throw new NotImplementedException();

        }
    }
}
