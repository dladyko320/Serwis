using Serwis.Enums;
using Serwis.Models;
using System.Linq;

namespace Serwis.DatabaseOperations
{
    class RepairPositionsManagement
    {
        private SerwisContext _serwisContext;
        private static RepairPositionsManagement _instance;

        public RepairPositionsManagement(SerwisContext serwisContext)
        {
            _serwisContext = serwisContext;
        }

        public static RepairPositionsManagement GetInstance()
        {
            if (_instance == null)
            {
                _instance = new RepairPositionsManagement(SerwisContext.GetContext());
            }
            return _instance;
        }

        public void AddPosition(string description, EPositionType type, int cost, int income)
        {
            _serwisContext.RepairPosition.Add(new RepairPosition { Description = description, Type = type, Cost = cost, Income = income });
            _serwisContext.SaveChanges();
        }

        public void DeletePosition(int id)
        {
            _serwisContext.RepairPosition.Remove(_serwisContext.RepairPosition.Single(a => a.PositionId == id));
            _serwisContext.SaveChanges();
        }
    }
}
