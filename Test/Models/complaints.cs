using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Test.Models
{
    [Table("Complaints")]
    public class complaints
    {
        [Key]
        public string P_id { get; set; }
        [Display(Name = "Red Patch in Mouth")]
        //  public int Red_patch_mouth { get; set; }
        public bool Red_patch_mouth { get; set; } 

        [Display(Name = "White Patch in Mouth")]
        public bool White_patch_mouth { get; set; } 


        [Display(Name = "Lump/swelling in Mouth")]
        public bool Swelling_mouth { get; set; }



        [Display(Name = "Ulcer for more than 3 weeks (long_standing ulcer)")]
        public bool Ulcer { get; set; }
        [Display(Name = "Non-homogeneous Leukoplakia")]
        public bool Leukoplakia { get; set; }
        [Display(Name = "Non-homogeneous Erythroplakia")]
        public bool Erythroplakia { get; set; }

        [Display(Name = "Non-healing extracion socket")]
        public bool Extract_socket { get; set; }
        [Display(Name = "Difficulty in Chewing")]
        public bool Diff_chewing { get; set; }
        [Display(Name = "Difficulty in swallowing")]
        public bool Diff_swallowing { get; set; }

        [Display(Name = "Difficulty in speaing")]
        public bool Diff_speaking { get; set; }
        [Display(Name = "Difficulty in moving tongue")]
        public bool Diff_moving_tongue { get; set; }
        [Display(Name = "Difficulty in tolerating spicy food")]
        public bool Diff_spicy_food { get; set; }
        [Display(Name = "Changes in voice")]
        public bool Change_voice { get; set; }
        [Display(Name = "H/o Breast Lump")]
        public bool Breast_Lump { get; set; }
        [Display(Name = "H/o Nipple discharge")]
        public bool Nipple_discharge { get; set; }
        [Display(Name = "H/o foul smelling vaginal discharge")]

        public bool Foul_smelling { get; set; }
        [Display(Name = "H/o post coital bleeding")]
        public bool Post_coidal_bleeding { get; set; }
        [Display(Name = "H/o Spotting")]
        public bool Spotting { get; set; }
        [Display(Name = "H/o Abnormal bleeding pattern")]
        public bool Abnormal_bleeding { get; set; }

        public bool Others { get; set; }

        public string Others_specify { get; set; } = string.Empty;






    }
}