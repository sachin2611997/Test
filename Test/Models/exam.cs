using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class exam
    {
        public string P_ID { get; set; }


        [Display(Name = "Height in cm")]
        public int Height { get; set; }


        [Display(Name = "Weight in kg")]
        public int Weight { get; set; }


        [Display(Name = "Oral Hygiene")]
        public int hygiene { get; set; }

        [Display(Name = "Oral Cavity")]
        public int Cavity { get; set; }

        [Display(Name = "Aphthous Ulcer")]
        public bool Aphthous { get; set; }


        [Display(Name = "Geographical Tongue")]
        public bool Geo_Tongu { get; set; }

        [Display(Name = "Oral Candidiasis")]
        public bool Candisis { get; set; }

        [Display(Name = "Melanoplakia")]
        public bool Melanoplak { get; set; }


        [Display(Name = "Fordyce Granules")]
        public bool For_Granul { get; set; }



        [Display(Name = "Others")]
        public bool Other_abn { get; set; }


        [Display(Name = "Others Specify")]
        public string Other_spc { get; set; }


        //Precancerous


        [Display(Name = "Leukoplakia")]
        public bool Leukoplak { get; set; }

        [Display(Name = "Erythroplakia")]
        public bool Erythropla { get; set; }

        [Display(Name = "Submucous Fibrosis")]
        public bool Sub_fibro { get; set; }

        [Display(Name = "Suspicious Ulcer")]
        public bool Sus_ulcer { get; set; }


        [Display(Name = "Suspicious growth")]
        public bool Sus_growth { get; set; }




        [Display(Name = "Neck Nodes")]
        public int Neck_node { get; set; }



        [Display(Name = "Other Findings")]
        public string Oth_find { get; set; }


        [Display(Name = "Upper Lip")]
        public bool RUpp_lip { get; set; }

        [Display(Name = "Lower Lip")]
        public bool RLow_lip { get; set; }

        [Display(Name = "Labial Mucosa")]
        public bool RLab_muc { get; set; }

        [Display(Name = "Tongue Dorsal Surface")]
        public bool RTong_dor { get; set; }

        [Display(Name = "Tongue Ventral Surface")]
        public bool RTong_vent { get; set; }

        [Display(Name = "Hard Palate")]
        public bool RH_palate { get; set; }


        [Display(Name = "Soft Palate")]
        public bool RS_palate { get; set; }

        [Display(Name = "Floor of Mouth")]
        public bool RFom { get; set; }

        [Display(Name = "Lingual Sulcus")]
        public bool RLin_sul { get; set; }

        [Display(Name = "Upper Gum")]
        public bool RUpp_gum { get; set; }

        [Display(Name = "Lower Gum")]
        public bool RLow_gum { get; set; }



        [Display(Name = "Buccal Mucosa")]
        public bool RBmucosa{ get; set; }


        [Display(Name = "Upper Sulcus")]
        public bool RUpp_sul { get; set; }

        [Display(Name = "Lower Sulcus")]
        public bool RLow_sul { get; set; }

        //LEFT SIDE

        [Display(Name = "Upper Lip")]
        public bool LUpp_lip { get; set; }

        [Display(Name = "Lower Lip")]
        public bool LLow_lip { get; set; }

        [Display(Name = "Labial Mucosa")]
        public bool LLab_muc { get; set; }

        [Display(Name = "Tongue Dorsal Surface")]
        public bool LTong_dor { get; set; }

        [Display(Name = "Tongue Ventral Surface")]
        public bool LTong_vent { get; set; }

        [Display(Name = "Hard Palate")]
        public bool LH_palate { get; set; }


        [Display(Name = "Soft Palate")]
        public bool LS_palate { get; set; }

        [Display(Name = "Floor of Mouth")]
        public bool LFom { get; set; }

        [Display(Name = "Lingual Sulcus")]
        public bool LLin_sul { get; set; }

        [Display(Name = "Upper Gum")]
        public bool LUpp_gum { get; set; }

        [Display(Name = "Lower Gum")]
        public bool LLow_gum { get; set; }



        [Display(Name = "Buccal Mucosa")]
        public bool LBmucosa { get; set; }


        [Display(Name = "Upper Sulcus")]
        public bool LUpp_sul { get; set; }

        [Display(Name = "Lower Sulcus")]
        public bool LLow_sul { get; set; }

        
    }
}