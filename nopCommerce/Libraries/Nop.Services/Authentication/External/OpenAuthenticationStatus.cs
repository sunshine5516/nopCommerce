//Contributor:  Nicholas Mayne


namespace Nop.Services.Authentication.External
{
    /// <summary>
    /// ������Ȩ״̬
    /// </summary>
    public enum OpenAuthenticationStatus
    {
        Unknown,
        Error,
        Authenticated,
        RequiresRedirect,
        AssociateOnLogon,
        AutoRegisteredEmailValidation,
        AutoRegisteredAdminApproval,
        AutoRegisteredStandard,
    }
}