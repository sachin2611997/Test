﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Query
    {
        public string InsertDemo()
        {
            return ("INSERT INTO dbo.Demographic (P_ID,FNAME,Mname,Lname,Sex,Education_id,Marital_id,Religion_id,Occupation_id,Address,Pincode,Age)VALUES(@P_ID, @FNAME, @Mname, @Lname, @Sex, @Education_id, @Marital_id, @Religion_id, @Occupation_id, @Address, @Pincode, @Age)");
        }

        public string InsertComplaint()
        {
            return ("INSERT INTO dbo.Complaints (P_ID,Red_patch_mouth,White_patch_mouth,Ulcer,Leukoplakia,Erythroplakia,Extract_socket ,Diff_chewing,Diff_swallowing,Diff_speaking,Diff_moving_tongue,Diff_spicy_food,Change_voice,Breast_Lump,Nipple_discharge ,Foul_smelling,Post_coidal_bleeding,Spotting,Abnormal_bleeding,Others,Others_specify) VALUES(@C_id, @Red_patch_mouth, @White_patch_mouth, @Ulcer, @Leukoplakia, @Erythroplakia, @Extract_socket, @Diff_chewing, @Diff_swallowing, @Diff_speaking, @Diff_moving_tongue, @Diff_spicy_food, @Change_voice, @Breast_Lump, @Nipple_discharge, @Foul_smelling, @Post_coidal_bleeding, @Spotting, @Abnormal_bleeding, @Others, @Other_specify)");
        }


        public string Getallrecords()
        {
            return ("select d.P_ID,d.FNAME,d.Mname,d.Lname,d.Sex,d.Education_id,d.Marital_id,d.Religion_id,d.Occupation_id,d.Address,d.Pincode,d.Age,c.Red_patch_mouth,c.White_patch_mouth,c.Ulcer,c.Leukoplakia,c.Erythroplakia,c.Extract_socket,c.Diff_chewing,c.Diff_swallowing,c.Diff_speaking,c.Diff_moving_tongue,c.Diff_spicy_food,c.Change_voice,c.Breast_Lump,c.Nipple_discharge,c.Foul_smelling,c.Post_coidal_bleeding,c.Spotting,c.Abnormal_bleeding,c.Others,c.Others_specify from Demographic as d left join Complaints as c on d.P_ID = c.P_ID; ");
        }

        public string gettest()
        {
            return ("select * from REGLIB.SCR_DEMO");
        }

        public string inserttest()
        {
            return "INSERT INTO REGLIB.SCR_DEMO (P_ID,FNAME,EDU_ID,AGE,REC_DATE) VALUES (@P_ID, @FNAME, @EDU_ID, @AGE, @REC_DATE)";
        }

        public string updatetest()
        {
            return "UPDATE REGLIB.SCR_DEMO SET P_ID=@P_ID, FNAME=@FNAME, EDU_ID=@EDU_ID, AGE=@AGE, REC_DATE=@REC_DATE WHERE P_ID=@P_ID";
        }



        //homecontroller 

        public string educationlist()
        {
            return "select * from REGLIB.MASTER WHERE NAME=Education";
        }

        public string occupationlist()
        {
            return "select * from REGLIB.MASTER WHERE NAME=Occupation";
        }
        public string maritallist()
        {
            return "select * from REGLIB.MASTER WHERE NAME=Marital";
        }
        public string religionlist()
        {
            return "select * from REGLIB.MASTER WHERE NAME=Religion";
        }
        public string statuslist()
        {
            return "select * from REGLIB.MASTER WHERE NAME=Status";
        }
        public string relativelist()
        {
            return "select * from REGLIB.MASTER WHERE NAME=Relative";
        }
        public string menopauselist()
        {
            return "select * from REGLIB.MASTER WHERE NAME=Menopause";
        }
        public string hygienelist()
        {
            return "select * from REGLIB.MASTER WHERE NAME=Hygiene";
        }
        public string conditionlist()
        {
            return "select * from REGLIB.MASTER WHERE NAME=Condition";
        }
        public string habitlist()
        {
            return "select * from REGLIB.MASTER WHERE NAME=Habit";
        }
        public string lifeStylelist()
        {
            return "select * from REGLIB.MASTER WHERE NAME=LifeStyle";
        }
        
    }
}