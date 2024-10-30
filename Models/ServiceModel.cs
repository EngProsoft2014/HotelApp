using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.Models
{
    public class ServiceModel
    {
        public string? ServiceName { get; set; }
        public bool IsSelectes { get; set; } = false;
        public int OrderCount { get; set; }
    }
}
