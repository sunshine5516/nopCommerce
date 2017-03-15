using System;

namespace Nop.Core.Caching
{
    /// <summary>
    /// �������ӿ�
    /// </summary>
    public interface ICacheManager : IDisposable
    {
        /// <summary>
        /// ͨ��Key��ȡ�����value 
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="key">key</param>
        /// <returns>��Key��Ӧ��value</returns>
        T Get<T>(string key);

        /// <summary>
        /// ��ӻ���
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="data">Data</param>
        /// <param name="cacheTime">����ʱ��</param>
        void Set(string key, object data, int cacheTime);

        /// <summary>
        /// ����key�жϻ���ʱ����� 
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>Result</returns>
        bool IsSet(string key);

        /// <summary>
        /// �Ƴ�����
        /// </summary>
        /// <param name="key">/key</param>
        void Remove(string key);

        /// <summary>
        /// Removes items by pattern
        /// </summary>
        /// <param name="pattern">pattern</param>
        void RemoveByPattern(string pattern);

        /// <summary>
        /// ɾ�����л���
        /// </summary>
        void Clear();
    }
}
