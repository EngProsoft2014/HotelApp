using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.Helpers
{
    public class ErrorsResult
    {
        public int? statusCode { get; set; }
        public string? title { get; set; }
        public string? message { get; set; }
        public string? titleAr { get; set; }
        public string? messageAr { get; set; }
    }
}
