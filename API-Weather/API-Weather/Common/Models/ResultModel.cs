using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Weather.Common.Models
{
    public class ResultModel
    {
        public int cityId { get; set; }
        public string cityName { get; set; }
        public string weatherMain { get; set; }
        public string weatherDescription { get; set; }
        public string weatherIcon { get; set; }
        public string mainTemp { get; set; }
        public string mainHumidity { get; set; }
    }
}