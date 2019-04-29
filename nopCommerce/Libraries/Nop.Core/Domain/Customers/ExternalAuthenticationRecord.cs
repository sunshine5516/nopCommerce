namespace Nop.Core.Domain.Customers
{
    /// <summary>
    /// �ⲿ�����֤��¼
    /// </summary>
    public partial class ExternalAuthenticationRecord : BaseEntity
    {
        /// <summary>
        /// �û�ID
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// �ⲿ�����֤
        /// </summary>
        public string ExternalIdentifier { get; set; }

        /// <summary>
        /// �ⲿ�����֤����
        /// </summary>
        public string ExternalDisplayIdentifier { get; set; }

        /// <summary>
        /// OAuthToken
        /// </summary>
        public string OAuthToken { get; set; }

        /// <summary>
        /// OAuthAccessToken
        /// </summary>
        public string OAuthAccessToken { get; set; }

        /// <summary>
        /// provider����
        /// </summary>
        public string ProviderSystemName { get; set; }
        
        /// <summary>
        /// Gets or sets the customer
        /// </summary>
        public virtual Customer Customer { get; set; }
    }

}
