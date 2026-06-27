using OpenTabletDriver.Plugin.Tablet;

namespace OpenTabletDriver.Configurations.Parsers.Huion
{
    public struct KamvasPro16StripReport : IDeviceReport
    {
        public KamvasPro16StripReport(byte[] data)
        {
            Raw = data;

            byte wheelData = data[5];
            if (wheelData != 0) Position = wheelData - 1u;
        }

        public byte[] Raw { get; set; }
        public uint? Position { get; set; }
    }
}
