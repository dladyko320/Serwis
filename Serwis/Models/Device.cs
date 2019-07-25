using Serwis.Enums;

namespace Serwis.Models
{
    public class Device
    {
        public int DeviceId { get; set; }
        public string Name { get; set; }
        public EDeviceType Type { get; set; }
        public string Imei { get; set; }
        public string Annotation { get; set; }
    }
}  
