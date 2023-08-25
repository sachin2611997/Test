using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Test.Models
{
    [Table("Test")]
    public class test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CaseNo { get; set; }
        public DateTime RegisDate { get; set; }
        public string Sex { get; set; }
        public int  Gender { get; set; }

    }
}