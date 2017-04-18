using System.Web;

namespace Nop.Core
{
    /// <summary>
    /// Represents a common helper
    /// </summary>
    public partial interface IWebHelper
    {
        /// <summary>
        /// Get URL referrer
        /// </summary>
        /// <returns>URL referrer</returns>
        string GetUrlReferrer();

        /// <summary>
        /// ��ȡ������IP��ַ
        /// </summary>
        /// <returns>URL referrer</returns>
        string GetCurrentIpAddress();

        /// <summary>
        /// ��ȡ��ǰҳ������
        /// </summary>
        /// <param name="includeQueryString">�Ƿ������ѯ�ַ���</param>
        /// <returns>Page name</returns>
        string GetThisPageUrl(bool includeQueryString);

        /// <summary>
        /// ��ȡ��ǰҳ������
        /// </summary>
        /// <param name="includeQueryString">�Ƿ������ѯ�ַ���</param>
        /// <param name="useSsl">�Ƿ���SSL������ҳ��</param>
        /// <returns>Page name</returns>
        string GetThisPageUrl(bool includeQueryString, bool useSsl);

        /// <summary>
        /// ��ǰ�����Ƿ�ȫ
        /// </summary>
        /// <returns>true - secured, false - not secured</returns>
        bool IsCurrentConnectionSecured();

        /// <summary>
        /// ͨ�����ƻ�ȡ����������
        /// </summary>
        /// <param name="name">Name</param>
        /// <returns>����������</returns>
        string ServerVariables(string name);

        /// <summary>
        /// ��ȡ����λ��
        /// </summary>
        /// <param name="useSsl">Use SSL</param>
        /// <returns>Store host location</returns>
        string GetStoreHost(bool useSsl);

        /// <summary>
        /// Gets store location
        /// </summary>
        /// <returns>Store location</returns>
        string GetStoreLocation();

        /// <summary>
        /// Gets store location
        /// </summary>
        /// <param name="useSsl">Use SSL</param>
        /// <returns>Store location</returns>
        string GetStoreLocation(bool useSsl);

        /// <summary>
        /// ����������Դ��cms���治��Ҫ����ĵ�����Դ֮һ���򷵻�true��
        /// </summary>
        /// <param name="request">HTTP Request</param>
        /// <returns>True if the request targets a static resource file.</returns>
        /// <remarks>
        /// These are the file extensions considered to be static resources:
        /// .css
        ///	.gif
        /// .png 
        /// .jpg
        /// .jpeg
        /// .js
        /// .axd
        /// .ashx
        /// </remarks>
        bool IsStaticResource(HttpRequest request);

        /// <summary>
        /// �޸Ĳ�ѯ�ַ���
        /// </summary>
        /// <param name="url">Ҫ�޸ĵ�url</param>
        /// <param name="queryStringModification">��ѯ�ַ����޸�</param>
        /// <param name="anchor">Anchor</param>
        /// <returns>�µ�url</returns>
        string ModifyQueryString(string url, string queryStringModification, string anchor);

        /// <summary>
        /// ��url��ɾ����ѯ�ַ���
        /// </summary>
        /// <param name="url">Ҫ�޸ĵ�url</param>
        /// <param name="queryString">Ҫɾ���Ĳ�ѯ�ַ���</param>
        /// <returns>�µ�url</returns>
        string RemoveQueryString(string url, string queryString);

        /// <summary>
        /// ͨ�����ƻ�ȡ��ѯ�ַ���ֵ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">����</param>
        /// <returns>��ѯ�ַ���ֵ</returns>
        T QueryString<T>(string name);

        /// <summary>
        /// ��������Ӧ�ó�����
        /// </summary>
        /// <param name="makeRedirect">�������Ƿ�Ӧ���ض���</param>
        /// <param name="redirectUrl">�ض�����ַ; ���Ҫ�ض��򵽵�ǰҳ��URL����Ϊ���ַ���</param>
        void RestartAppDomain(bool makeRedirect = false, string redirectUrl = "");

        /// <summary>
        /// �ͻ����Ƿ��ض�����λ��
        /// </summary>
        bool IsRequestBeingRedirected { get; }

        /// <summary>
        /// �ͻ����Ƿ�ʹ��POST�ض�����λ��
        /// </summary>
        bool IsPostBeingDone { get; set; }
    }
}
