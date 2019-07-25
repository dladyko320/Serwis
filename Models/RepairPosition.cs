using System.ComponentModel.DataAnnotations;
using Serwis.Enums;

namespace Serwis.Models
{
    public class RepairPosition
    {   [Key]
        public int PositionId { get; set; }
        public string Description { get; set; }
        public EPositionType Type { get; set; }
        public int Cost { get; set; }
        public int Income { get; set; }
    }
}
