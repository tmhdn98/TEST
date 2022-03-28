using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Weather.Common.Models
{
    public class DataModel
    {
        public CoordModel coord { get; set; }
        public SysModel sys { get; set; }
        public List<WeatherModel> weather { get; set; }
        public MainModel main { get; set; }
        public int visibility { get; set; }
        public WindModel wind { get; set; }
        public CloudsModel clouds { get; set; }
        public int dt { get; set; }
        public int id { get; set; }
        public string name { get; set; }


    }
}