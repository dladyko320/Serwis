using Serwis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Serwis.DatabaseOperations
{
    public class RepairsManagement
    {
        private RepairPositionsManagement _repairPosition;
        private SerwisContext _serwisContext;
        private static RepairsManagement _instance;

        public RepairsManagement(SerwisContext serwisContext)
        {
            _serwisContext = serwisContext;
        }

        public static RepairsManagement GetInstance()
        {
            if (_instance == null)
            {
                _instance = new RepairsManagement(SerwisContext.GetContext());
            }
            return _instance;
        }

        public void AddRepair(Repair repair)
        {
            if (repair == null) return;

            _serwisContext.Repairs.Add(repair);
            _serwisContext.SaveChanges();
        }

        public void AddRepair(Device device, Client client, int income, List<RepairPosition> repairPositions)
        {
            _serwisContext.Repairs.Add(new Repair{ StartDate = DateTime.Now, Client = client, Device = device, Income = income, RepairPositions = repairPositions });
            _serwisContext.SaveChanges();
        }

        public void UpdateRepairById(int id, Device device, Client client, int income, List<RepairPosition> repairPositions, DateTime? endDate, DateTime startDate)
        {
            Repair currentRepair = _serwisContext.Repairs.FirstOrDefault(x => x.RepairId == id);

            if (endDate == null)
            {
                Repair newRepair = new Repair
                {
                    RepairId = id,
                    Device = device,
                    Client = client,
                    Income = income,
                    RepairPositions = repairPositions,
                    StartDate = startDate
                };

                _serwisContext.Entry(currentRepair).CurrentValues.SetValues(newRepair);
                _serwisContext.SaveChanges();
            }
            else
            {
                Repair newRepair = new Repair { RepairId = id, Device = device, Client = client, Income = income, RepairPositions = repairPositions, StartDate = startDate, EndDate = endDate };
                _serwisContext.Entry(currentRepair).CurrentValues.SetValues(newRepair);
                _serwisContext.SaveChanges();
            }
        }
        
        public void DeleteRepair(int id)
        {
            Repair repair = _serwisContext.Repairs.FirstOrDefault(a => a.RepairId == id);
            _serwisContext.Repairs.Remove(repair);
            _serwisContext.SaveChanges();
        }

        public void EndRepair(int id)
        {
            Repair currentRepair = _serwisContext.Repairs.FirstOrDefault(x => x.RepairId == id);
            if (currentRepair.EndDate == null)
            {
                Repair newRepair = new Repair { RepairId = currentRepair.RepairId, StartDate = currentRepair.StartDate, RepairPositions = currentRepair.RepairPositions, Client = currentRepair.Client, Device = currentRepair.Device, Income = currentRepair.Income, EndDate = DateTime.Now };
                _serwisContext.Entry(currentRepair).CurrentValues.SetValues(newRepair);
                _serwisContext.SaveChanges();
            }
            else
            {
                MessageBox.Show(Messages.RepairsManagement_RepairClosed);
            }

        }
    }
}
