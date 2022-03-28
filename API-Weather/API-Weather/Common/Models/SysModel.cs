using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Weather.Common.Models
{
    public class SysModel
    {
        public string country { get; set; }
        public double timezone { get; set; }
        public double sunrise { get; set; }
        public double sunset { get; set; }
    }
}