namespace Nop.Core.Domain.Media
{
    /// <summary>
    /// ͼƬʵ��
    /// </summary>
    public partial class Picture : BaseEntity
    {
        /// <summary>
        /// ͼƬ������
        /// </summary>
        public byte[] PictureBinary { get; set; }

        /// <summary>
        /// ͼƬMIME����
        /// </summary>
        public string MimeType { get; set; }

        /// <summary>
        /// ͼƬ��SEO�Ѻõ��ļ���
        /// </summary>
        public string SeoFilename { get; set; }

        /// <summary>
        /// ��img��HTMLԪ�صġ�alt�����ԡ� ���Ϊ�գ���ʹ��Ĭ�Ϲ��������Ʒ���ƣ�
        /// </summary>
        public string AltAttribute { get; set; }

        /// <summary>
        /// ��img��HTMLԪ�صġ�title�����ԡ� ���Ϊ�գ���ʹ��Ĭ�Ϲ��������Ʒ���ƣ�
        /// </summary>
        public string TitleAttribute { get; set; }

        /// <summary>
        /// ͼƬ�Ƿ����µ�
        /// </summary>
        public bool IsNew { get; set; }
    }
}
