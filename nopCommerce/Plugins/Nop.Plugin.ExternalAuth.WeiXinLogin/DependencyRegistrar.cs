using Autofac;
using Autofac.Core;
using DaBoLang.Nop.Plugin.ExternalAuth.WeiXin.Services;
using Nop.Core.Caching;
using Nop.Core.Configuration;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;

namespace DaBoLang.Nop.Plugin.ExternalAuth.WeiXin
{
    /// <summary>
    /// �����ռ䣺DaBoLang.Nop.Plugin.ExternalAuth.WeiXin
    /// ��    �ƣ�DependencyRegistrar
    /// ��    �ܣ�����ע��
    /// ��    ϸ��
    /// ��    ����1.0.0.0
    /// �ļ����ƣ�DependencyRegistrar.cs
    /// ����ʱ�䣺2017-08-08 03:07
    /// �޸�ʱ�䣺2017-08-09 03:43
    /// ��    �ߣ�����
    /// ��ϵ��ʽ��http://www.cnblogs.com/yaoshangjin
    /// ˵    ����
    /// </summary>
    public class DependencyRegistrar : IDependencyRegistrar
    {
        /// <summary>
        /// Register services and interfaces
        /// </summary>
        /// <param name="builder">Container builder</param>
        /// <param name="typeFinder">Type finder</param>
        /// <param name="config">Config</param>
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            builder.RegisterType<WeiXinExternalAuthService>().As<IWeiXinExternalAuthService>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("nop_cache_static")).InstancePerLifetimeScope();
        }

        /// <summary>
        /// Order of this dependency registrar implementation
        /// </summary>
        public int Order
        {
            get { return 1; }
        }
    }
}
