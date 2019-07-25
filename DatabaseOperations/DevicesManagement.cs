using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serwis.Models;
using Serwis.Enums;

namespace Serwis.DatabaseOperations
{
    class DevicesManagement
    {
        private SerwisContext _serwisContext;
        private static DevicesManagement _instance;

        public DevicesManagement(SerwisContext serwisContext)
        {
            _serwisContext = serwisContext;
        }

        public static DevicesManagement GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DevicesManagement(SerwisContext.GetContext());
            }
            return _instance;
        }

        public void AddDevice(string name, EDeviceType type, string imei, string annotation)
        {

            if (string.IsNullOrWhiteSpace(name) == false)
            {
                _serwisContext.Devices.Add(new Device { Name = name,
                    Type = type,
                    Imei = imei,
                    Annotation = annotation  });
                _serwisContext.SaveChanges();
            }
            else
            {
                MessageBox.Show(Messages.DevicesManagement_EmptyName);
            }

        }

        public void UpdateDeviceById(int id, string newName, int newType, string newImei, string newAnnotation)
        {
            Enum.TryParse<EDeviceType>(newType.ToString(), out var deviceType);

            Device currentDevice = _serwisContext.Devices.FirstOrDefault(x => x.DeviceId == id);
            Device newDevice = new Device { DeviceId = id, Name = newName, Type = deviceType, Imei = newImei, Annotation = newAnnotation };
            _serwisContext.Entry(currentDevice).CurrentValues.SetValues(newDevice);
            _serwisContext.SaveChanges();
            MessageBox.Show(Messages.ChangesSaved);

        }

        public void DeleteDevice(int id)
        {
            var deviceRepairs = _serwisContext.Repairs.Where(x => x.Device.DeviceId == id).ToList();
            if (deviceRepairs.Count == 0)
            {
                _serwisContext.Devices.Remove(_serwisContext.Devices.Single(a => a.DeviceId == id));
                _serwisContext.SaveChanges();
            }
            else
            {
                MessageBox.Show(Messages.DevicesManagement_DeviceHaveHistory);
            }
        }

    }
}

