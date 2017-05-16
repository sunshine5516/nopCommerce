using System;
using System.Collections.Generic;

namespace Nop.Core.Caching
{
    /// <summary>
    /// ��ʾNopNullCache����ʵ�ֽӿڣ��������κ����ݣ�
    /// </summary>
    public partial class NopNullCache : ICacheManager
    {
        /// <summary>
        /// ��ȡ��������ָ����������ֵ��
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="key">The key of the value to get.</param>
        /// <returns>��ָ�����������ֵ</returns>
        public virtual T Get<T>(string key)
        {
            return default(T);
        }

        /// <summary>
        /// ��Ӽ�ֵ��
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="data">Data</param>
        /// <param name="cacheTime">����ʱ��</param>
        public virtual void Set(string key, object data, int cacheTime)
        {
        }

        /// <summary>
        /// ����key�жϻ���ʱ�����
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>Result</returns>
        public bool IsSet(string key)
        {
            return false;
        }

        /// <summary>
        /// �Ƴ�����
        /// </summary>
        /// <param name="key">/key</param>
        public virtual void Remove(string key)
        {
        }

        /// <summary>
        /// Removes items by pattern
        /// </summary>
        /// <param name="pattern">pattern</param>
        public virtual void RemoveByPattern(string pattern)
        {
        }

        /// <summary>
        /// ��ջ�������
        /// </summary>
        public virtual void Clear()
        {
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public virtual void Dispose()
        {
        }

        T ICacheManager.Get<T>(string key)
        {
            throw new NotImplementedException();
        }

        List<KeyValuePair<string, object>> ICacheManager.GetAll<T>()
        {
            throw new NotImplementedException();
        }

        void ICacheManager.Set(string key, object data, int cacheTime)
        {
            throw new NotImplementedException();
        }

        bool ICacheManager.IsSet(string key)
        {
            throw new NotImplementedException();
        }

        void ICacheManager.Remove(string key)
        {
            throw new NotImplementedException();
        }

        void ICacheManager.RemoveByPattern(string pattern)
        {
            throw new NotImplementedException();
        }

        void ICacheManager.Clear()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}