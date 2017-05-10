namespace Nop.Core.Domain.Seo
{
    /// <summary>
    /// URL��¼
    /// </summary>
    public partial class UrlRecord : BaseEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        public int EntityId { get; set; }

        /// <summary>
        /// entity name
        /// </summary>
        public string EntityName { get; set; }

        /// <summary>
        /// slug
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// ��¼�Ƿ��ڻ״̬��ֵ
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// languageId
        /// </summary>
        public int LanguageId { get; set; }
    }
}
