namespace Nop.Core.Domain.Customers
{
    /// <summary>
    /// ע������ö����
    /// </summary>
    public enum UserRegistrationType
    {
        /// <summary>
        /// ��׼�ʻ�����
        /// </summary>
        Standard = 1,
        /// <summary>
        /// ע�����Ҫ�����ʼ���֤
        /// </summary>
        EmailValidation = 2,
        /// <summary>
        /// �û�Ӧ�ɹ���Ա��׼
        /// </summary>
        AdminApproval = 3,
        /// <summary>
        /// ע�ᱻ����
        /// </summary>
        Disabled = 4,
    }
}
