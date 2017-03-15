using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nop.Core.Caching
{
    /// <summary>
    /// Extensions
    /// </summary>
    public static class CacheExtensions
    {
        /// <summary>
        ///��ȡ�������Ŀ�� ��������ڻ����У�����ز�������
        /// </summary>
        /// <typeparam name="T">����</typeparam>
        /// <param name="cacheManager">���������</param>
        /// <param name="key">key</param>
        /// <param name="acquire">���ػ���ķ���</param>
        /// <returns>������</returns>
        public static T Get<T>(this ICacheManager cacheManager, string key, Func<T> acquire)
        {
            return Get(cacheManager, key, 60, acquire);
        }

        /// <summary>
        /// �����ȡ����
        /// </summary>
        /// <typeparam name="T">����</typeparam>
        /// <param name="cacheManager">���������</param>
        /// <param name="key">Cache key</param>
        /// <param name="cacheTime">Cache time in minutes (0 - do not cache)</param>
        /// <param name="acquire">���ӻ������ȡ��������ʱ����ִ����������acquire��ȡ���ݡ�</param>
        /// <returns>Cached item</returns>
        public static T Get<T>(this ICacheManager cacheManager, string key, int cacheTime, Func<T> acquire)
        {
            if (cacheManager.IsSet(key))
            {
                return cacheManager.Get<T>(key);
            }

            var result = acquire();
            if (cacheTime > 0)
                cacheManager.Set(key, result, cacheTime);
            return result;
        }

        /// <summary>
        /// ����patternɾ������
        /// </summary>
        /// <param name="cacheManager">����</param>
        /// <param name="pattern">Pattern</param>
        /// <param name="keys">���еĻ���</param>
        public static void RemoveByPattern(this ICacheManager cacheManager, string pattern, IEnumerable<string> keys)
        {
            var regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach (var key in keys.Where(p => regex.IsMatch(p.ToString())).ToList())
                cacheManager.Remove(key);
        }
    }
}
