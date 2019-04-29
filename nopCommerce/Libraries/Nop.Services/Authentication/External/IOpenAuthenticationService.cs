//Contributor:  Nicholas Mayne

using System.Collections.Generic;
using Nop.Core.Domain.Customers;

namespace Nop.Services.Authentication.External
{
    /// <summary>
    /// ���ŷ�����Ȩ�ӿ�
    /// </summary>
    public partial interface IOpenAuthenticationService
    {
        /// <summary>
        /// �������п�������Ȩ����
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns>��Ȩ����</returns>
        IList<IExternalAuthenticationMethod> LoadActiveExternalAuthenticationMethods(int storeId = 0);

        /// <summary>
        /// ���������Ƽ������е���Ȩ����
        /// </summary>
        /// <param name="systemName">ϵͳ��</param>
        /// <returns>Found external authentication method</returns>
        IExternalAuthenticationMethod LoadExternalAuthenticationMethodBySystemName(string systemName);

        /// <summary>
        /// �������е���Ȩ����
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns>External authentication methods</returns>
        IList<IExternalAuthenticationMethod> LoadAllExternalAuthenticationMethods(int storeId = 0);


        bool AccountExists(OpenAuthenticationParameters parameters);

        void AssociateExternalAccountWithUser(Customer customer, OpenAuthenticationParameters parameters);

        Customer GetUser(OpenAuthenticationParameters parameters);

        IList<ExternalAuthenticationRecord> GetExternalIdentifiersFor(Customer customer);

        void DeletExternalAuthenticationRecord(ExternalAuthenticationRecord externalAuthenticationRecord);

        void RemoveAssociation(OpenAuthenticationParameters parameters);
    }
}