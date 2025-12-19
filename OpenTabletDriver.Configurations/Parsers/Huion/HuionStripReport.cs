using OpenTabletDriver.Plugin.Tablet.Strip;

namespace OpenTabletDriver.Configurations.Parsers.Huion
{
    public class HuionStripReport : IAbsoluteStripReport
    {
        public HuionStripReport(byte[] data) {

            Raw = data;

            byte wheelData = data[5];
            if (wheelData != 0)
                Position = wheelData - 1u;
        }

        public byte[] Raw { get; set; }
        public uint? Position { get; set; }
    }
}
