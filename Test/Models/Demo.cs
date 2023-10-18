using System.ComponentModel.DataAnnotations;
namespace Test.Models

{
    public class Demo
    {
        [Key]
        public string P_id { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public int? Age { get; set; }
        public string Sex { get; set; } = null;
        [Display(Name = "Education")]
        public int? Education_id { get; set; }
        [Display(Name = "Marital Status")]
        public int? Mariatal_id { get; set; }
        [Display(Name = "Religion")]
        public int? Religion_id { get; set; }
        [Display(Name = "Occupation")]
        public int? Occupation_id { get; set; }
        public string Address { get; set; } = null;
        public int? Pincode { get; set; }

    }
}