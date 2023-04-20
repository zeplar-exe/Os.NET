using OsDotNet.Devices;

namespace OsDotNet;

public class SystemInstance
{
    private IDevice[] Devices { get; }

    public SystemInstance()
    {
        Devices = new IDevice[2048];
    }

    public long InstallDevice(IDevice device)
    {
        return 0;
    }

    public void UninstallDevice(long id)
    {
        
    }
}