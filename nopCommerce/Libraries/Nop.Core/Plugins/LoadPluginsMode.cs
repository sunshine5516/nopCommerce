namespace Nop.Core.Plugins
{
    /// <summary>
    /// Represents a mode to load plugins
    /// </summary>
    public enum LoadPluginsMode
    {
        /// <summary>
        /// ��������
        /// </summary>
        All = 0,
        /// <summary>
        /// ֻ���ذ�װ��
        /// </summary>
        InstalledOnly = 10,
        /// <summary>
        /// ֻ����δ��װ��
        /// </summary>
        NotInstalledOnly = 20
    }
}