namespace Nop.Core.Domain.Customers
{
    /// <summary>
    /// Represents the customer login result enumeration
    /// </summary>
    public enum CustomerLoginResults
    {
        /// <summary>
        /// ��¼�ɹ�
        /// </summary>
        Successful = 1,
        /// <summary>
        /// �ͻ������ڣ������ʼ����û�����
        /// </summary>
        CustomerNotExist = 2,
        /// <summary>
        /// Wrong password
        /// </summary>
        WrongPassword = 3,
        /// <summary>
        /// �ʻ���δ����
        /// </summary>
        NotActive = 4,
        /// <summary>
        /// Customer has been deleted 
        /// </summary>
        Deleted = 5,
        /// <summary>
        /// Customer not registered 
        /// </summary>
        NotRegistered = 6,
    }
}
