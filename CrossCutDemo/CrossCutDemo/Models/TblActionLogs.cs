using System;
using System.Collections.Generic;

namespace CrossCutDemo.Models
{
    public partial class TblActionLogs
    {
        public int Id { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public string Ipaddress { get; set; }
    }
}
