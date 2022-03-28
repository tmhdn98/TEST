using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Weather.Common.Models
{
    public class ResponseConvertModel
    {
        //request status true:success, false: failed
        public int statusCode { get; set; }
        //response message
        public string message { get; set; }
        public List<ResultModel> data { get; set; }
        ////respone error code
        //public int errorCode { get; set; }
        ////output result from backend
        //public int output { get; set; }
        ////data result already encrypted
        //public int totalRecord { get; set; }
        //public int limit { get; set; }
        //public int page { get; set; }
    }
}