using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class history
    {
        public string P_id { get; set; }
        [Display(Name ="Family History")]
        public bool Fam_hist { get; set; }
        public string Relative1 { get; set; }
        public string Relative2 { get; set; }

        public string Relative3 { get; set; }
        public int Med_hist { get; set; }
        public bool Cancer { get; set; }

        [Display(Name = "Diabetes")]
        public bool Diabet { get; set; }

        [Display(Name = "Hypertension")]
        public bool Hyperten { get; set; }
        public bool Thyroid { get; set; }
        [Display(Name = "Other Co-morbidity")]
        public bool Comor_oth { get; set; }
        [Display(Name = "H/O Any Medical Treatment")]
        public string Hist_med { get; set; }
        [Display(Name = "Hypothyroid/Hyperthyroid")]
        public string Thy_desc{ get; set; }
        [Display(Name = "Other Co-morbidity Specify")]
        public string Comor_spec { get; set; }

        [Display(Name = "Menopause Status")]
        public int Menopause { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Lmp_dt { get; set;}
        [Display(Name = "Menopause since")]
        public int Menopau_yr { get; set; }

        [Display(Name = "Hysterectomy")]
                public int Hystrect { get; set; }

        public int G { get; set; }

        public int P { get; set; }

        public int L { get; set; }
        public int A { get; set; }
        public int LSCS { get; set; }
        public int FTND { get; set; }
        public int Br_feed { get; set; }
        public string Contra_spce { get; set; }
        public int Chewing { get; set; }
        public int Pan { get; set; }
        public int Gutkha { get; set; }
        public int Betal_nut { get; set; }
        public int Pan_masala { get; set; }
        public int Tobacco { get; set; }
        public int Masheri { get; set; }

        public int Chew_time { get; set; }
        public string Chew_dur { get; set; }
        public string Tobac_det { get; set; }
        public int Smoking { get; set; }
        public int Beedi { get; set; }
        public int Cigar { get; set; }
        public int Smk_pipe { get; set; }
        public int Hukka { get; set; }
        public int Chilum  { get; set; }
        public int Snuff { get; set; }
        public int Smok_time { get; set; }
        public int Smok_dur { get; set; }
        public string Smok_det { get; set; }

        public int Drink { get; set; }
        public int Drnk_time { get; set; }
        public string Drnk_ty { get; set; }
        public int Drnk_dur { get; set; }
        public int Lfe_styl { get; set; }
        public string Surg_hist { get; set; }
        public int Rel1_site { get; set; }
        public int Rel2_site { get; set; }
        public int Rel3_site { get; set; }
        public int Lve_Bir { get; set; }
        public int Abortion { get; set; }















    }
}