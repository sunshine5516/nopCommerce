using System;
using System.Collections.Generic;
using Nop.Core.Domain.Catalog;

namespace Nop.Services.Payments
{
    /// <summary>
    /// Represents a payment info holder
    /// </summary>
    [Serializable]
    public partial class ProcessPaymentRequest
    {
        public ProcessPaymentRequest()
        {
            this.CustomValues = new Dictionary<string, object>();
        }

        /// <summary>
        /// StoreId
        /// </summary>
        public int StoreId { get; set; }

        /// <summary>
        /// CustomerId
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// ��ȡ�����ö���Ψһ��ʶ���� �ڶ�����δ����ʱʹ�ã��������ز����ͻ��ض��򵽵�������ַ��
        /// </summary>
        public Guid OrderGuid { get; set; }

        /// <summary>
        /// ��ȡ�����ö����ܼ�
        /// </summary>
        public decimal OrderTotal { get; set; }

        /// <summary>
        /// /// <summary>
        /// ��ȡ�����ø��ʽId
        /// </summary>
        /// </summary>
        public string PaymentMethodSystemName { get; set; }

        #region ���ʽ�������� 

        /// <summary>
        /// ��ȡ���������ÿ����ͣ�Visa��Master Card��...���� ���û�б�֧������ʹ�ã����ǽ�������
        /// </summary>
        public string CreditCardType { get; set; }

        /// <summary>
        /// ��ȡ���������ÿ�����������
        /// </summary>
        public string CreditCardName { get; set; }

        /// <summary>
        /// ��ȡ���������ÿ�����
        /// </summary>
        public string CreditCardNumber { get; set; }

        /// <summary>
        /// ��ȡ���������ÿ��������
        /// </summary>
        public int CreditCardExpireYear { get; set; }

        /// <summary>
        /// ��ȡ���������ÿ������·�
        /// </summary>
        public int CreditCardExpireMonth { get; set; }

        /// <summary>
        /// ��ȡ���������ÿ�CVV2������ֵ֤��
        /// </summary>
        public string CreditCardCvv2 { get; set; }

        #endregion

        #region ���ڸ���

        /// <summary>
        /// ����������ظ��ģ����ȡ�����ó�ʼ������������ʶ��
        /// </summary>
        public int InitialOrderId { get; set; }
        
        /// <summary>
        /// Gets or sets the cycle length
        /// </summary>
        public int RecurringCycleLength { get; set; }

        /// <summary>
        /// Gets or sets the cycle period
        /// </summary>
        public RecurringProductCyclePeriod RecurringCyclePeriod { get; set; }

        /// <summary>
        /// Gets or sets the total cycles
        /// </summary>
        public int RecurringTotalCycles { get; set; }

        #endregion

        /// <summary>
        /// �ͻ��ֵ䣬������Կ��Դ洢����ͻ���Ϣ
        /// </summary>
        public Dictionary<string, object> CustomValues { get; set; }
    }
}
