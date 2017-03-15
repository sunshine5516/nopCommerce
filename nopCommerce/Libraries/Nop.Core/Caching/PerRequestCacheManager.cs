using System.Collections;
using System.Web;
using System.Linq;

namespace Nop.Core.Caching
{
    /// <summary>
    /// ��ʾ��HTTP�����ڼ仺��Ĺ����������ڻ��棩
    /// Represents a manager for caching during an HTTP request (short term caching)
    /// </summary>
    public partial class PerRequestCacheManager : ICacheManager
    {
        private readonly HttpContextBase _context;

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="context">Context</param>
        public PerRequestCacheManager(HttpContextBase context)
        {
            this._context = context;
        }

        /// <summary>
        /// ����NopRequestCache�����ʵ��
        /// </summary>
        protected virtual IDictionary GetItems()
        {
            if (_context != null)
                return _context.Items;

            return null;
        }

        /// <summary>
        /// ��ȡ��������ָ����������ֵ��
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="key">key</param>
        /// <returns>��ָ�����������ֵ��</returns>
        public virtual T Get<T>(string key)
        {
            var items = GetItems();
            if (items == null)
                return default(T);

            return (T)items[key];
        }
        /// <summary>
        /// ��Ӽ�ֵ��
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="data">Data</param>
        /// <param name="cacheTime">����ʱ��</param>
        public virtual void Set(string key, object data, int cacheTime)
        {
            var items = GetItems();
            if (items == null)
                return;

            if (data != null)
            {
                if (items.Contains(key))
                    items[key] = data;
                else
                    items.Add(key, data);
            }
        }

        /// <summary>
        /// ����key�жϻ���ʱ����� 
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>Result</returns>
        public virtual bool IsSet(string key)
        {
            var items = GetItems();
            if (items == null)
                return false;
            
            return (items[key] != null);
        }

        /// <summary>
        /// �Ƴ�����
        /// </summary>
        /// <param name="key">/key</param>
        public virtual void Remove(string key)
        {
            var items = GetItems();
            if (items == null)
                return;

            items.Remove(key);
        }

        /// <summary>
        /// Removes items by pattern
        /// </summary>
        /// <param name="pattern">pattern</param>
        public virtual void RemoveByPattern(string pattern)
        {
            var items = GetItems();
            if (items == null)
                return;

            this.RemoveByPattern(pattern, items.Keys.Cast<object>().Select(p => p.ToString()));
        }

        /// <summary>
        /// ��ջ�������
        /// </summary>
        public virtual void Clear()
        {
            var items = GetItems();
            if (items == null)
                return;

            items.Clear();
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public virtual void Dispose()
        {
        }
    }
}
