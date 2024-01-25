using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Query
    {
        public string InsertDemo()
        {
            return ("INSERT INTO dbo.Demographic (P_id,Fname,Mname,Lname,Sex,Education_id,Marital_id,Religion_id,Occupation_id,Address,Pincode,Age)VALUES(@P_id, @Fname, @Mname, @Lname, @Sex, @Education_id, @Marital_id, @Religion_id, @Occupation_id, @Address, @Pincode, @Age)");
        }

        public string InsertComplaint()
        {
            return ("INSERT INTO dbo.Complaints (P_id,Red_patch_mouth,White_patch_mouth,Ulcer,Leukoplakia,Erythroplakia,Extract_socket ,Diff_chewing,Diff_swallowing,Diff_speaking,Diff_moving_tongue,Diff_spicy_food,Change_voice,Breast_Lump,Nipple_discharge ,Foul_smelling,Post_coidal_bleeding,Spotting,Abnormal_bleeding,Others,Others_specify) VALUES(@C_id, @Red_patch_mouth, @White_patch_mouth, @Ulcer, @Leukoplakia, @Erythroplakia, @Extract_socket, @Diff_chewing, @Diff_swallowing, @Diff_speaking, @Diff_moving_tongue, @Diff_spicy_food, @Change_voice, @Breast_Lump, @Nipple_discharge, @Foul_smelling, @Post_coidal_bleeding, @Spotting, @Abnormal_bleeding, @Others, @Other_specify)");
        }

    }
}