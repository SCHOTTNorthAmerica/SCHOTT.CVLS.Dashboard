using SCHOTT.Core.Threading;
using SCHOTT.CVLS.Ethernet.Binary;
using SCHOTT.CVLS.Serial;
using SCHOTT.WinForms.Docking;

namespace SCHOTT.CVLS.Dashboard.PluginInterface
{
    /// <summary>
    /// Interface for CVLS Dashboard Plugins
    /// </summary>
    public interface IDashboard
    {
        /// <summary>
        /// The plugin initialization function called when loading plugins in the dashboard.
        /// </summary>
        /// <param name="closingWorker">Any child threads that follow the SCHOTT ClosingWorker pattern will be added to this object.</param>
        /// <param name="dockingObject">Any DockingContent forms to be accessed will be added to this object.</param>
        /// <param name="binarySocket">The Dashboard Binary Socket for the plugin to use.</param>
        /// <param name="cvlsThreadedComPort">The Dashboard Serial Connection for the plugin to use.</param>
        void InitializePlugin(ClosingWorker closingWorker, Docking dockingObject, BinarySocket binarySocket, CVLSThreadedComPort cvlsThreadedComPort);
    }
}
