namespace Nop.Services.Payments
{
    /// <summary>
    /// ֧����������
    /// </summary>
    public enum PaymentMethodType
    {
        /// <summary>
        /// ���и�����Ϣ������վ������
        /// </summary>
        Standard = 10,
        /// <summary>
        /// �ͻ����ض��򵽵�������վ������ɸ���
        /// </summary>
        Redirection = 15,
        /// <summary>
        /// Button
        /// </summary>
        Button = 20,
    }
}
