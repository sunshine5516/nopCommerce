using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;

namespace Nop.Core.Caching
{
    /// <summary>
    /// MemoryCacheManagerʵ�� ����������HTTP����֮����л���Ĺ����������ڻ��棩
    /// Represents a manager for caching between HTTP requests (long term caching)
    /// </summary>
    public partial class MemoryCacheManager : ICacheManager
    {
        /// <summary>
        /// �������
        /// </summary>
        protected ObjectCache Cache
        {
            get
            {
                return MemoryCache.Default;
            }
        }
        public virtual List<KeyValuePair<string, object>> GetAll<T>()
        {
            var keyValues = new List<KeyValuePair<string, object>>();
            IEnumerable<KeyValuePair<string, object>>
                items = Cache.AsEnumerable();
            foreach (KeyValuePair<string, object> item in items)
            {
                keyValues.Add(new System.Collections.Generic.KeyValuePair<string, object>(item.Key, item.Value));
            }
            return keyValues;
        }
        /// <summary>
        /// ͨ��Key��ȡ�����value 
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="key">The key of the value to get.</param>
        /// <returns>��Key��Ӧ��value.</returns>
        public virtual T Get<T>(string key)
        {
            

            //Cache.
            return (T)Cache[key];
        }
        //public virtual 
        /// <summary>
        /// ��ֵ����ӻ���
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="data">Data</param>
        /// <param name="cacheTime">����ʱ��</param>
        public virtual void Set(string key, object data, int cacheTime)
        {
            if (data == null)
                return;

            var policy = new CacheItemPolicy();
            policy.AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(cacheTime);
            Cache.Add(new CacheItem(key, data), policy);
        }

        /// <summary>
        /// ����key�жϻ���ʱ����� 
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>Result</returns>
        public virtual bool IsSet(string key)
        {
            return (Cache.Contains(key));
        }

        /// <summary>
        /// �Ƴ�����
        /// </summary>
        /// <param name="key">/key</param>
        public virtual void Remove(string key)
        {
            Cache.Remove(key);
        }

        /// <summary>
        /// ����patternɾ��������
        /// </summary>
        /// <param name="pattern">pattern</param>
        public virtual void RemoveByPattern(string pattern)
        {
            this.RemoveByPattern(pattern, Cache.Select(p => p.Key));
        }

        /// <summary>
        /// ɾ�����л���
        /// </summary>
        public virtual void Clear()
        {
            foreach (var item in Cache)
                Remove(item.Key);
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public virtual void Dispose()
        {
        }
    }
}