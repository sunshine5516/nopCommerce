using Autofac;
using Autofac.Core;
using Nop.Core.Caching;
using Nop.Core.Configuration;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Plugin.Widgets.NivoSlider.Controllers;

namespace Nop.Plugin.Widgets.NivoSlider.Infrastructure
{
    /// <summary>
    /// ����ע��
    /// </summary>
    public class DependencyRegistrar : IDependencyRegistrar
    {
        /// <summary>
        /// ע�����ͽӿ�
        /// </summary>
        /// <param name="builder">����</param>
        /// <param name="typeFinder">����</param>
        /// <param name="config">Config</param>
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            //we cache presentation models between requests
            builder.RegisterType<WidgetsNivoSliderController>()
                .WithParameter(ResolvedParameter.ForNamed<ICacheManager>("nop_cache_static"));
        }

        /// <summary>
        /// ʵ��˳��
        /// </summary>
        public int Order
        {
            get { return 2; }
        }
    }
}
