using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class history
    {
        public string P_ID { get; set; }
        [Display(Name ="Family History")]
        public bool Fam_hist { get; set; }
        public int Relative1 { get; set; }

        [Display(Name = "Relative1 Site ")]
        public int Rel1_site { get; set; }


        public int Relative2 { get; set; }


        [Display(Name = "Relative2 Site ")]
        public int Rel2_site { get; set; }
        
        public int Relative3 { get; set; }

        [Display(Name = "Relative3 Site ")]
        public int Rel3_site { get; set; }


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

        [Display(Name = "Are you breast feeding your children?")]
        public int Br_feed { get; set; }

        [Display(Name = "Age at Menarche")]
        public int Menar_age{ get; set; }

        [Display(Name = "Age at Marriage")]
        public int Mary_age { get; set; }

        [Display(Name = "Age at First Delivery")]
        public int Delv_age { get; set; }

        [Display(Name = "Nulliparous")]
        public bool Nul_par { get; set; }


        [Display(Name = "Contraceptive")]
        public bool Contracep { get; set; }

        [Display(Name = "Oral Contraceptive")]
        public bool Hor_oral { get; set; }


        [Display(Name = "Injective Contraceptive")]
        public bool Hor_injec { get; set; }

        [Display(Name = "IUD Contraceptive")]
        public bool  Hor_IUD { get; set; }

        [Display(Name = "Barrier")]
        public bool Barrier { get; set; }


        [Display(Name = "Tubectomy")]
        public bool Tubeco { get; set; }

        [Display(Name = "Withdrawl")]
        public bool Withdrawl { get; set; }


        [Display(Name = "Safe Period Method")]
        public bool Safe_perid { get; set; }


        [Display(Name = "Vasecomy")]
        public bool Vasecto { get; set; }
        
                [Display(Name = "Contraceptive Details Specify")]
        public string Contra_spce { get; set; }
        [Display(Name = "Do you chew tobacco?")]
        public int Chewing { get; set; }
        public bool Pan { get; set; }
        public bool Gutkha { get; set; }
        [Display(Name = "Betal Nut")]
        public bool Betal_nut { get; set; }
        [Display(Name = "Pan Masala")]
        public bool Pan_masala { get; set; }
        public bool Tobacco { get; set; }
        public bool Masheri { get; set; }

        public bool khaini { get; set; }
        [Display(Name = "Chewing Status")]
        public int Chew_time { get; set; }

        [Display(Name = "Duration in years")]
        public string Chew_dur { get; set; }
        [Display(Name = "Tobacco Details")]
        public string Tobac_det { get; set; }
        [Display(Name = "Do you Smoke?")]
        public int Smoking { get; set; }
        public bool Beedi { get; set; }
        [Display(Name = "Cigratte")]
        public bool Cigar { get; set; }
        [Display(Name = "Pipe")]
        public bool Smk_pipe { get; set; }
        public bool Hukka { get; set; }

        public bool chiroot { get; set; }

        public bool Chilum { get; set; }
        public bool Snuff { get; set; }

        public bool chutta { get; set; }
        [Display(Name = "Smoke Status")]
        public int Smok_time { get; set; }
        [Display(Name = "Duration in years")]
        public int Smok_dur { get; set; }
        [Display(Name = "Smoke Details")]
        public string Smok_det { get; set; }
        [Display(Name = "Do you Drink?")]
        public int Drink { get; set; }
        [Display(Name = "Drink Status")]
        public int Drnk_time { get; set; }
        [Display(Name = "Type of alcohol")]
        public string Drnk_ty { get; set; }
        [Display(Name = "Duration in years")]
        public int Drnk_dur { get; set; }
        [Display(Name = "Life Style")]
        public int Lfe_styl { get; set; }
        [Display(Name = "Sugical History")]
        public string Surg_hist { get; set; }















    }
}