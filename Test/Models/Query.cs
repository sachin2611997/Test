using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Query
    {
        public string InsertDemo(Demo d)
        {
            return ("INSERT INTO REGLIB.SCR_DEMO (P_ID,FNAME,MNAME,LNAME,AGE,SEX,EDU_ID,MAR_ID,REL_ID,OCC_ID,ADDRESS,PINCODE,REC_DATE,PHC,DISTRICT)VALUES('"+d.P_ID+ "','" + d.FNAME + "','" + d.MNAME + "','" + d.LNAME + "','" + d.AGE  + "','" + d.SEX + "','" + d.EDU_ID + "','" + d.MAR_ID + "','" + d.REL_ID + "','" + d.OCC_ID + "','" + d.ADDRESS + "','" + d.PINCODE + "','" + d.REC_DATE.ToString("dd/MM/yyyy") + "','" + d.PHC + "','" + d.DISTRICT + "')");
        }

        public string InsertComplaint()
        {
            return ("INSERT INTO dbo.Complaints (P_ID,Red_patch_mouth,White_patch_mouth,Ulcer,Leukoplakia,Erythroplakia,Extract_socket ,Diff_chewing,Diff_swallowing,Diff_speaking,Diff_moving_tongue,Diff_spicy_food,Change_voice,Breast_Lump,Nipple_discharge ,Foul_smelling,Post_coidal_bleeding,Spotting,Abnormal_bleeding,Others,Others_specify) VALUES(@C_id, @Red_patch_mouth, @White_patch_mouth, @Ulcer, @Leukoplakia, @Erythroplakia, @Extract_socket, @Diff_chewing, @Diff_swallowing, @Diff_speaking, @Diff_moving_tongue, @Diff_spicy_food, @Change_voice, @Breast_Lump, @Nipple_discharge, @Foul_smelling, @Post_coidal_bleeding, @Spotting, @Abnormal_bleeding, @Others, @Other_specify)");
        }

        public string UpdateDemo(Demo d)
        {
            return ("UPDATE REGLIB.SCR_DEMO SET P_ID='" + d.P_ID + "',FNAME='" + d.FNAME + "',MNAME='" + d.MNAME + "',LNAME='" + d.LNAME + "',AGE='" + d.AGE + "',SEX='" + d.SEX + "',EDU_ID='" + d.EDU_ID + "',MAR_ID='" + d.MAR_ID + "',REL_ID='" + d.REL_ID + "',OCC_ID='" + d.OCC_ID + "',ADDRESS='" + d.ADDRESS + "',PINCODE='" + d.PINCODE + "',REC_DATE='" + d.REC_DATE.Date.ToLongDateString() + "',PHC='" + d.PHC + "',DISTRICT='" + d.DISTRICT + "'");
        }

        public string Getallrecords()
        {
            return ("select d.P_ID,d.FNAME,d.MNAME,d.LNAME,d.AGE,d.SEX,d.EDU_ID,d.MAR_ID,d.REL_ID,d.OCC_ID,d.ADDRESS,d.PINCODE,d.REC_DATE,d.PHC,d.PHC,c.Red_patch_mouth,c.White_patch_mouth,c.Ulcer,c.Leukoplakia,c.Erythroplakia,c.Extract_socket,c.Diff_chewing,c.Diff_swallowing,c.Diff_speaking,c.Diff_moving_tongue,c.Diff_spicy_food,c.Change_voice,c.Breast_Lump,c.Nipple_discharge,c.Foul_smelling,c.Post_coidal_bleeding,c.Spotting,c.Abnormal_bleeding,c.Others,c.Others_specify from REGLIB.SCR_DEMO as d left join Complaints as c on d.P_ID = c.P_ID; ");
        }

        public string Getalldemo()
        {
            return ("select P_ID,FNAME,MNAME,LNAME,AGE,SEX,EDU_ID,MAR_ID,REL_ID,OCC_ID,ADDRESS,PINCODE,REC_DATE,PHC,DISTRICT from REGLIB.SCR_DEMO");

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

        public string masterlist(string name)
        {
            return " select * from REGLIB.MASTER where NAME='"+name+"'";
        }

      
        
    }
}