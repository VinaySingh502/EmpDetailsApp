using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class RequestFrom
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string VacationHours { get; set; }
    }

    public class ResponseFrom
    {
        public string Status { get; set; }
        public string Message { get; set; }
       
    }
}