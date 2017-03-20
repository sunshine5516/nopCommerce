using System.Collections.Generic;
using Nop.Core.Domain.Orders;

namespace Nop.Services.Payments
{
    /// <summary>
    /// �������ӿ�
    /// </summary>
    public partial interface IPaymentService
    {
        /// <summary>
        /// ������Ч�ĸ��ʽ
        /// </summary>
        /// <param name="filterByCustomerId">���ͻ�ɸѡ���ʽ; null��������</param>
        /// <param name="storeId">����ָ�����̵���������ؼ�¼; 0�������м�¼</param>
        /// <param name="filterByCountryId">����ָ������/������������ؼ�¼; 0�������м�¼</param>
        /// <returns>Payment methods</returns>
        IList<IPaymentMethod> LoadActivePaymentMethods(int? filterByCustomerId = null, int storeId = 0, int filterByCountryId = 0);

        /// <summary>
        /// ��ϵͳ���ظ��ʽ
        /// </summary>
        /// <param name="systemName">System name</param>
        /// <returns>Found payment provider</returns>
        IPaymentMethod LoadPaymentMethodBySystemName(string systemName);

        /// <summary>
        /// �������и����ṩ��
        /// </summary>
        /// <param name="storeId">����ָ�����̵���������ؼ�¼; 0�������м�¼</param>
        /// <param name="filterByCountryId">����ָ������/������������ؼ�¼; 0�������м�¼</param>
        /// <returns>Payment providers</returns>
        IList<IPaymentMethod> LoadAllPaymentMethods(int storeId = 0, int filterByCountryId = 0);

        /// <summary>
        /// ��ȡ��������ʹ���ض����ʽ�Ĺ���/������ʶ���б�
        /// </summary>
        /// <param name="paymentMethod">֧������</param>
        /// <returns>A list of country identifiers</returns>
        IList<int> GetRestictedCountryIds(IPaymentMethod paymentMethod);

        /// <summary>
        /// ��������ʹ���ض����ʽ�Ĺ���/����
        /// </summary>
        /// <param name="paymentMethod">֧������</param>
        /// <param name="countryIds">A list of country identifiers</param>
        void SaveRestictedCountryIds(IPaymentMethod paymentMethod, List<int> countryIds);


        /// <summary>
        /// ������
        /// </summary>
        /// <param name="processPaymentRequest">������������ĸ�����Ϣ</param>
        /// <returns>������</returns>
        ProcessPaymentResult ProcessPayment(ProcessPaymentRequest processPaymentRequest);

        /// <summary>
        /// Post�ύ������������Ҫ�ض��򵽵�������ַ�ĸ�������ʹ�ã�
        /// </summary>
        /// <param name="postProcessPaymentRequest">������������ĸ�����Ϣ</param>
        void PostProcessPayment(PostProcessPaymentRequest postProcessPaymentRequest);

        /// <summary>
        /// �ͻ����¶�����δ��ɺ��Ƿ������ɸ�������ض��򸶿ʽ��
        /// </summary>
        /// <param name="order">Order</param>
        /// <returns>Result</returns>
        bool CanRePostProcessPayment(Order order);


        /// <summary>
        /// ������
        /// </summary>
        /// <param name="cart">Shoping cart</param>
        /// <param name="paymentMethodSystemName">Payment method system name</param>
        /// <returns>Additional handling fee</returns>
        decimal GetAdditionalHandlingFee(IList<ShoppingCartItem> cart, string paymentMethodSystemName);



        /// <summary>
        /// Gets a value indicating whether capture is supported by payment method
        /// </summary>
        /// <param name="paymentMethodSystemName">Payment method system name</param>
        /// <returns>A value indicating whether capture is supported</returns>
        bool SupportCapture(string paymentMethodSystemName);

        /// <summary>
        /// ��ȡ������
        /// </summary>
        /// <param name="capturePaymentRequest">Capture payment request</param>
        /// <returns>Capture payment result</returns>
        CapturePaymentResult Capture(CapturePaymentRequest capturePaymentRequest);



        /// <summary>
        /// �Ƿ�֧�ֲ����˿�
        /// </summary>
        /// <param name="paymentMethodSystemName">Payment method system name</param>
        /// <returns>A value indicating whether partial refund is supported</returns>
        bool SupportPartiallyRefund(string paymentMethodSystemName);

        /// <summary>
        /// �Ƿ�֧���˿�
        /// </summary>
        /// <param name="paymentMethodSystemName">Payment method system name</param>
        /// <returns>A value indicating whether refund is supported</returns>
        bool SupportRefund(string paymentMethodSystemName);

        /// <summary>
        /// �˿�
        /// </summary>
        /// <param name="refundPaymentRequest">Request</param>
        /// <returns>Result</returns>
        RefundPaymentResult Refund(RefundPaymentRequest refundPaymentRequest);



        /// <summary>
        /// Gets a value indicating whether void is supported by payment method
        /// </summary>
        /// <param name="paymentMethodSystemName">Payment method system name</param>
        /// <returns>A value indicating whether void is supported</returns>
        bool SupportVoid(string paymentMethodSystemName);

        /// <summary>
        /// Voids a payment
        /// </summary>
        /// <param name="voidPaymentRequest">Request</param>
        /// <returns>Result</returns>
        VoidPaymentResult Void(VoidPaymentRequest voidPaymentRequest);



        /// <summary>
        /// Gets a recurring payment type of payment method
        /// </summary>
        /// <param name="paymentMethodSystemName">Payment method system name</param>
        /// <returns>A recurring payment type of payment method</returns>
        RecurringPaymentType GetRecurringPaymentType(string paymentMethodSystemName);

        /// <summary>
        /// �����ڸ���
        /// </summary>
        /// <param name="processPaymentRequest">Payment info required for an order processing</param>
        /// <returns>Process payment result</returns>
        ProcessPaymentResult ProcessRecurringPayment(ProcessPaymentRequest processPaymentRequest);

        /// <summary>
        ///ȡ�����ڸ���
        /// </summary>
        /// <param name="cancelPaymentRequest">Request</param>
        /// <returns>Result</returns>
        CancelRecurringPaymentResult CancelRecurringPayment(CancelRecurringPaymentRequest cancelPaymentRequest);


        /// <summary>
        /// Gets masked credit card number
        /// </summary>
        /// <param name="creditCardNumber">Credit card number</param>
        /// <returns>Masked credit card number</returns>
        string GetMaskedCreditCardNumber(string creditCardNumber);
        
    }
}
