namespace OsDotNet.Devices;

public interface IMemoryDevice : IDevice
{
    public void Seek(long position);
    public byte[] Read(long byteCount);
    public void Write(byte[] bytes);
}