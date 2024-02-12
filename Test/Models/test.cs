using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Test.Models
{
    [Table("SCR_DEMO")]
    public class test
    {
        public string P_ID { get; set; }
        public string FNAME { get; set; }
        public int? EDU_ID { get; set; }
        public int? AGE { get; set; }
        public DateTime REC_DATE { get; set; }
    }
}