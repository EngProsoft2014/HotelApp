using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.Models
{
    public class HistoryModel
    {
        public int EmplyeeId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string? Statues { get; set; }
    }
}
