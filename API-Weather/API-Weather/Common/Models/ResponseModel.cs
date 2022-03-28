using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Weather.Common.Models
{
    public class ResponseModel
    {
        public int cnt { get; set; }
        public List<DataModel> list { get; set; }
    }
}