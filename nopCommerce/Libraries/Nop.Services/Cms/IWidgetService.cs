using System.Collections.Generic;

namespace Nop.Services.Cms
{
    /// <summary>
    /// Widget����ӿ�
    /// </summary>
    public partial interface IWidgetService
    {
        /// <summary>
        /// ���ػС����
        /// </summary>
        /// <param name="storeId">����ָ���Ĵ洢�м��ؼ�¼; 0�������м�¼</param>
        /// <returns>Widgets</returns>
        IList<IWidgetPlugin> LoadActiveWidgets(int storeId = 0);

        /// <summary>
        /// ���ػС����
        /// </summary>
        /// <param name="widgetZone">Widget zone</param>
        /// <param name="storeId">����ָ���Ĵ洢�м��ؼ�¼; 0�������м�¼</param>
        /// <returns>Widgets</returns>
        IList<IWidgetPlugin> LoadActiveWidgetsByWidgetZone(string widgetZone, int storeId = 0);

        /// <summary>
        /// ��ϵͳ���Ƽ���С����
        /// </summary>
        /// <param name="systemName">System name</param>
        /// <returns>Found widget</returns>
        IWidgetPlugin LoadWidgetBySystemName(string systemName);

        /// <summary>
        /// ��������С����
        /// </summary>
        /// <param name="storeId">Load records allowed only in a specified store; pass 0 to load all records</param>
        /// <returns>Widgets</returns>
        IList<IWidgetPlugin> LoadAllWidgets(int storeId = 0);
    }
}
