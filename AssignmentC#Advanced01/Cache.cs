using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentC_Advanced01
{


    #region Q20 - CacheItem 
    //public class CacheItem<TValue>
    //{
    //    public TValue Value { get; set; }
    //    public DateTime Expiration { get; set; }

    //    public bool IsExpired => DateTime.Now > Expiration;
    //}

    //public class Cache<TKey, TValue>
    //{
    //    private Dictionary<TKey, CacheItem<TValue>> cache = new Dictionary<TKey, CacheItem<TValue>>();
    //    private TimeSpan defaultExpiration;

    //    public Cache(TimeSpan expiration)
    //    {
    //        defaultExpiration = expiration;
    //    }

    //    // Add or update a cache 
    //    public void Add(TKey key, TValue value)
    //    {
    //        cache[key] = new CacheItem<TValue>
    //        {
    //            Value = value,
    //            Expiration = DateTime.Now.Add(defaultExpiration)
    //        };
    //    }

    //    // Get a value 
    //    public TValue Get(TKey key)
    //    {
    //        if (cache.ContainsKey(key))
    //        {
    //            var item = cache[key];
    //            if (!item.IsExpired)
    //            {
    //                return item.Value;
    //            }
    //            else
    //            {
    //                cache.Remove(key); 
    //            }
    //        }
    //        return default(TValue); 
    //    }

    //    // Remove
    //    public bool Remove(TKey key)
    //    {
    //        return cache.Remove(key);
    //    }


    //    public bool Contains(TKey key)
    //    {
    //        if (cache.ContainsKey(key))
    //        {
    //            if (!cache[key].IsExpired)
    //                return true;

    //            cache.Remove(key); 
    //        }
    //        return false;
    //    }
    //} 
    #endregion
}
