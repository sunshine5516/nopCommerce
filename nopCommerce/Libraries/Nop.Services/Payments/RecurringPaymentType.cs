namespace Nop.Services.Payments
{
    /// <summary>
    /// ���ڸ�������
    /// </summary>
    public enum RecurringPaymentType
    {
        /// <summary>
        /// ��֧��
        /// </summary>
        NotSupported = 0,
        /// <summary>
        /// ��ѡ
        /// </summary>
        Manual = 10,
        /// <summary>
        /// �Զ�����֧������վ�㴦���
        /// </summary>
        Automatic = 20
    }
}
