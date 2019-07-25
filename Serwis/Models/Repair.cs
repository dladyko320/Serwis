using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Serwis.Models
{
    public class Repair
    {
        [Key]
        public int RepairId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Device Device { get; set; }
        public Client Client { get; set; }
        public int Income { get; set; }

        public Repair()
        {
            RepairPositions = new List<RepairPosition>();
        }

        public virtual ICollection<RepairPosition> RepairPositions { get; set; }
    }
}
