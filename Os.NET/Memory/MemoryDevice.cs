using OsDotNet.Devices;

namespace OsDotNet.Memory;

public class MemoryDevice : IMemoryDevice
{
    private long Cursor { get; set; }
    private byte[] Bytes { get; }

    public MemoryDevice(long size)
    {
        Bytes = new byte[size];
    }
    
    public DeviceInfo GetInfo()
    {
        return new DeviceInfo { DisplayName = "Builtin_Memory_Device" };
    }

    public void Seek(long position)
    {
        Cursor = position;
    }

    public byte[] Read(long byteCount)
    {
        var readBytes = new byte[byteCount];

        for (var i = 0; i < byteCount; i++)
        {
            readBytes[i] = Bytes[Cursor + i];
        }
        
        return readBytes;
    }

    public void Write(byte[] bytes)
    {
        for (var i = 0; i < bytes.Length; i++)
        {
            Bytes[Cursor + i] = bytes[i];
        }
    }
}