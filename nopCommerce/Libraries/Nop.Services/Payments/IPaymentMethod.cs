using System;
using System.Collections.Generic;
using System.Web.Routing;
using Nop.Core.Domain.Orders;
using Nop.Core.Plugins;

namespace Nop.Services.Payments
{
    /// <summary>
    /// �ṩ�����������غͷ����Ľӿ�
    /// </summary>
    public partial interface IPaymentMethod : IPlugin
    {
        #region Methods

        /// <summary>
        /// ������
        /// </summary>
        /// <param name="processPaymentRequest">Payment info required for an order processing</param>
        /// <returns>Process payment result</returns>
        ProcessPaymentResult ProcessPayment(ProcessPaymentRequest processPaymentRequest);

        /// <summary>
        /// Post�ύ������������Ҫ�ض��򵽵�������ַ�ĸ�������ʹ�ã�
        /// </summary>
        /// <param name="postProcessPaymentRequest">Payment info required for an order processing</param>
        void PostProcessPayment(PostProcessPaymentRequest postProcessPaymentRequest);

        /// <summary>
        /// �ڽ����ڼ��Ƿ�Ӧ���ظ��ʽ
        /// </summary>
        /// <param name="cart">Shoping cart</param>
        /// <returns>true - hide; false - display.</returns>
        bool HidePaymentMethod(IList<ShoppingCartItem> cart);

        /// <summary>
        ///������
        /// </summary>
        /// <param name="cart">Shoping cart</param>
        /// <returns>Additional handling fee</returns>
        decimal GetAdditionalHandlingFee(IList<ShoppingCartItem> cart);

        /// <summary>
        /// ��ȡ������
        /// </summary>
        /// <param name="capturePaymentRequest">��������</param>
        /// <returns>������</returns>
        CapturePaymentResult Capture(CapturePaymentRequest capturePaymentRequest);

        /// <summary>
        /// �˿�
        /// </summary>
        /// <param name="refundPaymentRequest">�˿�����</param>
        /// <returns>Result</returns>
        RefundPaymentResult Refund(RefundPaymentRequest refundPaymentRequest);

        /// <summary>
        /// Voids a payment
        /// </summary>
        /// <param name="voidPaymentRequest">Request</param>
        /// <returns>Result</returns>
        VoidPaymentResult Void(VoidPaymentRequest voidPaymentRequest);

        /// <summary>
        /// �����ڸ���
        /// </summary>
        /// <param name="processPaymentRequest">������������ĸ�����Ϣ</param>
        /// <returns>������</returns>
        ProcessPaymentResult ProcessRecurringPayment(ProcessPaymentRequest processPaymentRequest);

        /// <summary>
        /// ȡ�����ڸ���
        /// </summary>
        /// <param name="cancelPaymentRequest">Request</param>
        /// <returns>Result</returns>
        CancelRecurringPaymentResult CancelRecurringPayment(CancelRecurringPaymentRequest cancelPaymentRequest);

        /// <summary>
        /// �ͻ����¶�����δ��ɺ��Ƿ������ɸ�������ض��򸶿ʽ��
        /// </summary>
        /// <param name="order">����</param>
        /// <returns>Result</returns>
        bool CanRePostProcessPayment(Order order);

        /// <summary>
        ///��ȡ��Ӧ�����õ�·��
        /// </summary>
        /// <param name="actionName">Action name</param>
        /// <param name="controllerName">Controller name</param>
        /// <param name="routeValues">Route values</param>
        void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues);

        /// <summary>
        /// ��ȡ������Ϣ��·��
        /// </summary>
        /// <param name="actionName">Action name</param>
        /// <param name="controllerName">Controller name</param>
        /// <param name="routeValues">Route values</param>
        void GetPaymentInfoRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues);

        Type GetControllerType();

        #endregion

        #region ����

        /// <summary>
        /// Gets a value indicating whether capture is supported
        /// </summary>
        bool SupportCapture { get; }

        /// <summary>
        /// �Ƿ�֧�ֲ����˿�
        /// </summary>
        bool SupportPartiallyRefund { get; }

        /// <summary>
        /// �Ƿ�֧���˿�
        /// </summary>
        bool SupportRefund { get; }

        /// <summary>
        /// Gets a value indicating whether void is supported
        /// </summary>
        bool SupportVoid { get; }

        /// <summary>
        /// ��ȡ���ڸ��ʽ�ĸ��ʽ
        /// </summary>
        RecurringPaymentType RecurringPaymentType { get; }

        /// <summary>
        ///��ȡ���ʽ����
        /// </summary>
        PaymentMethodType PaymentMethodType { get; }

        /// <summary>
        /// ָʾ�Ƿ�Ҫ��ʾ�˲���ĸ�����Ϣҳ��
        /// </summary>
        bool SkipPaymentInfo { get; }

        #endregion
    }
}
