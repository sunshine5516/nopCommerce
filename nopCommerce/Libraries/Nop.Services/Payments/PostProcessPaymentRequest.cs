using Nop.Core.Domain.Orders;

namespace Nop.Services.Payments
{
    /// <summary>
    /// post����������
    /// </summary>
    public partial class PostProcessPaymentRequest
    {
        /// <summary>
        /// ��ȡ�����ö����� �ڶ����ѱ���ʱʹ�ã����ͻ��ض��򵽵�������ַ�ĸ������أ�
        /// </summary>
        public Order Order { get; set; }
    }
}
