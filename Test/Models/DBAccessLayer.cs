using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Configuration;
using Test.Models;
using System.Data.Odbc;
using System.Globalization;
using System.Data.OleDb;

namespace Test.Models
{
    public class DBAccessLayer
    {
        Query q = new Query();
        SqlConnection con = new SqlConnection("data source =.; initial catalog = Screening; integrated security = True;");



        OdbcConnection con1 = new OdbcConnection("Dsn=crreg;uid=tmh;pwd=tmh;Trusted_Connection=Yes;");

        public string AddRecord(Main main)
        {
            string constr = ConfigurationManager.ConnectionStrings["DbEntity"].ConnectionString;
            string queryString = "INSERT INTO REGLIB.SCR_DEMO (P_ID,FNAME,MNAME,LNAME,AGE,SEX,EDU_ID,MAR_ID,REL_ID,OCC_ID,ADDRESS,PINCODE,REC_DATE,PHC,DISTRICT)VALUES('" + main.Demos.P_ID + "','" + main.Demos.FNAME + "','" + main.Demos.MNAME + "','" + main.Demos.LNAME + "','" + main.Demos.AGE + "','" + main.Demos.SEX + "','" + main.Demos.EDU_ID + "','" + main.Demos.MAR_ID + "','" + main.Demos.REL_ID + "','" + main.Demos.OCC_ID + "','" + main.Demos.ADDRESS + "','" + main.Demos.PINCODE + "','" + main.Demos.REC_DATE.Date.ToShortDateString() + "','" + main.Demos.PHC + "','" + main.Demos.DISTRICT + "')";

            OdbcCommand cmd = new OdbcCommand(queryString);

            using (OdbcConnection connection = new OdbcConnection(constr))
            {
                cmd.Connection = connection;
                connection.Open();
                cmd.Parameters.AddWithValue("P_ID", main.Demos.P_ID != null ? main.Demos.P_ID : (object)DBNull.Value);

                cmd.Parameters.AddWithValue("FNAME", main.Demos.FNAME != null ? main.Demos.FNAME : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("MNAME", main.Demos.MNAME != null ? main.Demos.MNAME : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("LNAME", main.Demos.LNAME != null ? main.Demos.LNAME : (object)DBNull.Value);
              

                // cmd.Parameters.AddWithValue("AGE", main.Demos.AGE != null ? main.Demos.AGE : (object)DBNull.Value); 
                if (main.Demos.AGE == null)
                {
                    cmd.Parameters.AddWithValue("AGE", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("AGE", main.Demos.AGE);
                }
              //  cmd.Parameters.AddWithValue("SEX", main.Demos.SEX != null ? main.Demos.SEX : (object)DBNull.Value);
                if (main.Demos.SEX == null)
                {
                    cmd.Parameters.AddWithValue("SEX", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("SEX", main.Demos.SEX);
                }
                //cmd.Parameters.AddWithValue("EDU_ID", main.Demos.EDU_ID != null);
                if (main.Demos.EDU_ID == null)
                {
                    cmd.Parameters.AddWithValue("EDU_ID", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("EDU_ID", main.Demos.EDU_ID);
                }
               // cmd.Parameters.AddWithValue("MAR_ID", main.Demos.MAR_ID != null);
                if (main.Demos.MAR_ID == null)
                {
                    cmd.Parameters.AddWithValue("MAR_ID", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("MAR_ID", main.Demos.MAR_ID);
                }
                //cmd.Parameters.AddWithValue("REL_ID", main.Demos.REL_ID != null);
                if (main.Demos.REL_ID == null)
                {
                    cmd.Parameters.AddWithValue("REL_ID", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("REL_ID", main.Demos.REL_ID);
                }
                //cmd.Parameters.AddWithValue("OCC_ID", main.Demos.OCC_ID != null);
                if (main.Demos.OCC_ID == null)
                {
                    cmd.Parameters.AddWithValue("OCC_ID", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("OCC_ID", main.Demos.OCC_ID);
                }
                cmd.Parameters.AddWithValue("ADDRESS", main.Demos.ADDRESS != null ? main.Demos.ADDRESS : (object)DBNull.Value);
                //    cmd.Parameters.AddWithValue("PINCODE", main.Demos.PINCODE != null ? main.Demos.PINCODE : (object)DBNull.Value);
                if (main.Demos.PINCODE == null)
                {
                    cmd.Parameters.AddWithValue("PINCODE", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("PINCODE", main.Demos.PINCODE);
                }
                //   cmd.Parameters.AddWithValue("PHC", main.Demos.PHC != null ? main.Demos.PHC : (object)DBNull.Value);
                if (main.Demos.PHC == null)
                {
                    cmd.Parameters.AddWithValue("PHC", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("PHC", main.Demos.PHC);
                }
                // cmd.Parameters.AddWithValue("DISTRICT", main.Demos.DISTRICT != null ? main.Demos.DISTRICT : (object)DBNull.Value);
                if (main.Demos.DISTRICT == null)
                {
                    cmd.Parameters.AddWithValue("DISTRICT", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("DISTRICT", main.Demos.DISTRICT);
                }
                cmd.Parameters.AddWithValue("REC_DATE", OdbcType.DateTime).Value = main.Demos.REC_DATE.Date.ToShortDateString();

                // Complaints properties
                //cmd.Parameters.AddWithValue("@C_id", main.Demos.P_ID ?? (object)DBNull.Value);
                //cmd.Parameters.AddWithValue("@Red_patch_mouth", SqlDbType.Bit).Value = main.Complaints.Red_patch_mouth;
                //cmd.Parameters.AddWithValue("@White_patch_mouth", SqlDbType.Bit).Value = main.Complaints.White_patch_mouth;
                //cmd.Parameters.AddWithValue("@Ulcer", SqlDbType.Bit).Value = main.Complaints.Ulcer;
                //cmd.Parameters.AddWithValue("@Leukoplakia", SqlDbType.Bit).Value = main.Complaints.Leukoplakia;
                //cmd.Parameters.AddWithValue("@Erythroplakia", SqlDbType.Bit).Value = main.Complaints.Erythroplakia;
                //cmd.Parameters.AddWithValue("@Extract_socket", SqlDbType.Bit).Value = main.Complaints.Extract_socket;
                //cmd.Parameters.AddWithValue("@Diff_chewing", SqlDbType.Bit).Value = main.Complaints.Diff_chewing;
                //cmd.Parameters.AddWithValue("@Diff_swallowing", SqlDbType.Bit).Value = main.Complaints.Diff_swallowing;
                //cmd.Parameters.AddWithValue("@Diff_speaking", SqlDbType.Bit).Value = main.Complaints.Diff_speaking;
                //cmd.Parameters.AddWithValue("@Diff_moving_tongue", SqlDbType.Bit).Value = main.Complaints.Diff_moving_tongue;
                //cmd.Parameters.AddWithValue("@Diff_spicy_food", SqlDbType.Bit).Value = main.Complaints.Diff_spicy_food;
                //cmd.Parameters.AddWithValue("@Change_voice", SqlDbType.Bit).Value = main.Complaints.Change_voice;
                //cmd.Parameters.AddWithValue("@Breast_Lump", SqlDbType.Bit).Value = main.Complaints.Breast_Lump;
                //cmd.Parameters.AddWithValue("@Nipple_discharge", SqlDbType.Bit).Value = main.Complaints.Nipple_discharge;
                //cmd.Parameters.AddWithValue("@Foul_smelling", SqlDbType.Bit).Value = main.Complaints.Foul_smelling;
                //cmd.Parameters.AddWithValue("@Post_coidal_bleeding", SqlDbType.Bit).Value = main.Complaints.Post_coidal_bleeding;
                //cmd.Parameters.AddWithValue("@Spotting", SqlDbType.Bit).Value = main.Complaints.Spotting;
                //cmd.Parameters.AddWithValue("@Abnormal_bleeding", SqlDbType.Bit).Value = main.Complaints.Abnormal_bleeding;
                //cmd.Parameters.AddWithValue("@Others", SqlDbType.Bit).Value = main.Complaints.Others;
                //cmd.Parameters.AddWithValue("@Other_specify", main.Complaints.Others_specify ?? (object)DBNull.Value);

                cmd.ExecuteNonQuery();
               // con.Close();
                return ("Data save Successfully");

            }
        }




      
        public string EditRecord(Main main)
        {

            string query = q.UpdateDemo(main.Demos);
            try
            {
                OdbcCommand cmd = new OdbcCommand(query, con1);
                cmd.Connection = con1;

                OdbcParameter paramId = new OdbcParameter();
                paramId.ParameterName = "@P_ID";
                paramId.Value = main.Demos.P_ID;
                cmd.Parameters.Add(paramId);

                OdbcParameter paramFNAME = new OdbcParameter();
                paramFNAME.ParameterName = "@FNAME";
                paramFNAME.Value = main.Demos.FNAME;
                cmd.Parameters.Add(paramFNAME);

                OdbcParameter paramMname = new OdbcParameter();
                paramMname.ParameterName = "@MNAME";
                paramMname.Value = main.Demos.MNAME;
                cmd.Parameters.Add(paramMname);

                OdbcParameter paramLname = new OdbcParameter();
                paramLname.ParameterName = "@LNAME";
                paramLname.Value = main.Demos.LNAME;
                cmd.Parameters.Add(paramLname);

                OdbcParameter paramAge = new OdbcParameter();
                paramAge.ParameterName = "@AGE";
                paramAge.Value = main.Demos.AGE;
                cmd.Parameters.Add(paramAge);

                OdbcParameter paramSex = new OdbcParameter();
                paramSex.ParameterName = "@SEX";
                paramSex.Value = main.Demos.SEX;
                cmd.Parameters.Add(paramSex);

                OdbcParameter paramEdu = new OdbcParameter();
                paramEdu.ParameterName = "@EDU_ID";
                paramEdu.Value = main.Demos.EDU_ID;
                cmd.Parameters.Add(paramEdu);

                OdbcParameter paramMarital = new OdbcParameter();
                paramMarital.ParameterName = "@MAR_ID";
                paramMarital.Value = main.Demos.MAR_ID;
                cmd.Parameters.Add(paramMarital);

                OdbcParameter paramReli = new OdbcParameter();
                paramReli.ParameterName = "@REL_ID";
                paramReli.Value = main.Demos.REL_ID;
                cmd.Parameters.Add(paramReli);

                OdbcParameter paramOccup = new OdbcParameter();
                paramOccup.ParameterName = "@OCC_ID";
                paramOccup.Value = main.Demos.OCC_ID;
                cmd.Parameters.Add(paramOccup);

                OdbcParameter paramAddress = new OdbcParameter();
                paramAddress.ParameterName = "@ADDRESS";
                paramAddress.Value = main.Demos.ADDRESS;
                cmd.Parameters.Add(paramAddress);

                OdbcParameter paramPin = new OdbcParameter();
                paramPin.ParameterName = "@PINCODE";
                paramPin.Value = main.Demos.PINCODE;
                cmd.Parameters.Add(paramPin);


                OdbcParameter paramRecdate = new OdbcParameter();
                paramRecdate.ParameterName = "@REC_DATE";
                paramRecdate.Value = main.Demos.REC_DATE.ToLongDateString();
                cmd.Parameters.Add(paramRecdate);

                OdbcParameter paramPhc = new OdbcParameter();
                paramPhc.ParameterName = "@PHC";
                paramPhc.Value = main.Demos.PHC;
                cmd.Parameters.Add(paramPhc);


                OdbcParameter paramDist = new OdbcParameter();
                paramDist.ParameterName = "@DISTRICT";
                paramDist.Value = main.Demos.DISTRICT;
                cmd.Parameters.Add(paramDist);

                

                //SqlParameter paramCId = new SqlParameter();
                //paramCId.ParameterName = "@C_id";
                //paramCId.Value = main.Complaints.P_ID;
                //cmd.Parameters.Add(paramCId);

                //SqlParameter paramRPM = new SqlParameter();
                //paramRPM.ParameterName = "@Red_patch_mouth";
                //paramRPM.Value = main.Complaints.Red_patch_mouth;
                //cmd.Parameters.Add(paramRPM);

                //SqlParameter paramWPM = new SqlParameter();
                //paramWPM.ParameterName = "@White_patch_mouth";
                //paramWPM.Value = main.Complaints.White_patch_mouth;
                //cmd.Parameters.Add(paramWPM);

                //SqlParameter paramulcr = new SqlParameter();
                //paramulcr.ParameterName = "@Ulcer";
                //paramulcr.Value = main.Complaints.Ulcer;
                //cmd.Parameters.Add(paramulcr);

                //SqlParameter paramLeu = new SqlParameter();
                //paramLeu.ParameterName = "@Leukoplakia";
                //paramLeu.Value = main.Complaints.Leukoplakia;
                //cmd.Parameters.Add(paramLeu);

                //SqlParameter paramEry = new SqlParameter();
                //paramEry.ParameterName = "@Erythroplakia";
                //paramEry.Value = main.Complaints.Erythroplakia;
                //cmd.Parameters.Add(paramEry);

                //SqlParameter paramExtr = new SqlParameter();
                //paramExtr.ParameterName = "@Extract_socket";
                //paramExtr.Value = main.Complaints.Extract_socket;
                //cmd.Parameters.Add(paramExtr);

                //SqlParameter paramDiffChe = new SqlParameter();
                //paramDiffChe.ParameterName = "@Diff_chewing";
                //paramDiffChe.Value = main.Complaints.Diff_chewing;
                //cmd.Parameters.Add(paramDiffChe);

                //SqlParameter paramDiffSwall = new SqlParameter();
                //paramDiffSwall.ParameterName = "@Diff_swallowing";
                //paramDiffSwall.Value = main.Complaints.Diff_swallowing;
                //cmd.Parameters.Add(paramDiffSwall);

                //SqlParameter paramDiffSpeak = new SqlParameter();
                //paramDiffSpeak.ParameterName = "@Diff_speaking";
                //paramDiffSpeak.Value = main.Complaints.Diff_speaking;
                //cmd.Parameters.Add(paramDiffSpeak);

                //SqlParameter paramDiffMovTon = new SqlParameter();
                //paramDiffMovTon.ParameterName = "@Diff_moving_tongue";
                //paramDiffMovTon.Value = main.Complaints.Diff_moving_tongue;
                //cmd.Parameters.Add(paramDiffMovTon);

                //SqlParameter paramDiffSpifod = new SqlParameter();
                //paramDiffSpifod.ParameterName = "@Diff_spicy_food";
                //paramDiffSpifod.Value = main.Complaints.Diff_spicy_food;
                //cmd.Parameters.Add(paramDiffSpifod);

                //SqlParameter paramChgVoice = new SqlParameter();
                //paramChgVoice.ParameterName = "@Change_voice";
                //paramChgVoice.Value = main.Complaints.Change_voice;
                //cmd.Parameters.Add(paramChgVoice);

                //SqlParameter paramBrLup = new SqlParameter();
                //paramBrLup.ParameterName = "@Breast_Lump";
                //paramBrLup.Value = main.Complaints.Breast_Lump;
                //cmd.Parameters.Add(paramBrLup);

                //SqlParameter paramNipDis = new SqlParameter();
                //paramNipDis.ParameterName = "@Nipple_discharge";
                //paramNipDis.Value = main.Complaints.Nipple_discharge;
                //cmd.Parameters.Add(paramNipDis);

                //SqlParameter paramFolsmell = new SqlParameter();
                //paramFolsmell.ParameterName = "@Foul_smelling";
                //paramFolsmell.Value = main.Complaints.Foul_smelling;
                //cmd.Parameters.Add(paramFolsmell);

                //SqlParameter paramPocoBled = new SqlParameter();
                //paramPocoBled.ParameterName = "@Post_coidal_bleeding";
                //paramPocoBled.Value = main.Complaints.Post_coidal_bleeding;
                //cmd.Parameters.Add(paramPocoBled);

                //SqlParameter paramSpot = new SqlParameter();
                //paramSpot.ParameterName = "@Spotting";
                //paramSpot.Value = main.Complaints.Spotting;
                //cmd.Parameters.Add(paramSpot);

                //SqlParameter paramAbBleed = new SqlParameter();
                //paramAbBleed.ParameterName = "@Abnormal_bleeding";
                //paramAbBleed.Value = main.Complaints.Abnormal_bleeding;
                //cmd.Parameters.Add(paramAbBleed);

                //SqlParameter paramOther = new SqlParameter();
                //paramOther.ParameterName = "@Others";
                //paramOther.Value = main.Complaints.Others;
                //cmd.Parameters.Add(paramOther);

                //SqlParameter paramOthrSpec = new SqlParameter();
                //paramOthrSpec.ParameterName = "@Other_specify";
                //paramOthrSpec.Value = main.Complaints.Others_specify;
                //cmd.Parameters.Add(paramOthrSpec);


                con1.Open();
                cmd.ExecuteNonQuery();
                return ("Data Update Successfully");

            }
            catch (Exception ex)
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message.ToString());
            }

        }




        //get master data by name//
        public List<masters> Getmaster(string name)
        {
            List<masters> master = new List<masters>();
            string constr = ConfigurationManager.ConnectionStrings["DbEntity"].ConnectionString;
            using (OdbcConnection con = new OdbcConnection(constr))
            {

                string query = q.masterlist(name);
                using (OdbcCommand cmd = new OdbcCommand(query, con))
                {
                    con.Open();

                    using (OdbcDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            master.Add(new masters
                            {
                                NAME = sdr["NAME"].ToString(),
                                INDEX = int.Parse(sdr["INDEX"].ToString()),
                                VALUE = sdr["VALUE"].ToString()
                            });

                        }

                    }
                    con.Close();
                }
            }
            return master;
        }



     
      

        public List<Main> GetRecords()
        {
            List<Main> main = new List<Main>();
            string constr = ConfigurationManager.ConnectionStrings["DbEntity"].ConnectionString;

            using (OdbcConnection con = new OdbcConnection(constr))
            {
                //   string query = q.Getallrecords();
                string query = q.Getalldemo();
                using (OdbcCommand cmd = new OdbcCommand(query, con))
                {
                    con.Open();
                    using (OdbcDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            main.Add(new Main
                            {
                                Demos = new Demo
                                {
                                    P_ID = Convert.ToString(sdr["P_ID"]).Trim(),
                                    FNAME = Convert.ToString(sdr["FNAME"]),
                                    MNAME = Convert.ToString(sdr["Mname"]),
                                    LNAME = Convert.ToString(sdr["Lname"]),
                                  //  SEX = Convert.ToString(sdr["Sex"]),
                                    SEX = ((Convert.IsDBNull(sdr["SEX"])) ? 0 : Convert.ToInt32(sdr["SEX"])),
                                    EDU_ID = ((Convert.IsDBNull(sdr["EDU_ID"])) ? 0 : Convert.ToInt32(sdr["EDU_ID"])),
                                    MAR_ID = ((Convert.IsDBNull(sdr["MAR_ID"])) ? 0 : Convert.ToInt32(sdr["MAR_ID"])),
                                    // Marital_id = int.Parse(sdr["Marital_id"].ToString()),
                                    REL_ID = ((Convert.IsDBNull(sdr["REL_ID"])) ? 0 : Convert.ToInt32(sdr["REL_ID"])),
                                    //  Religion_id = int.Parse(sdr["Religion_id"].ToString()),
                                    // Occupation_id = int.Parse(sdr["Occupation_id"].ToString()),
                                    OCC_ID = ((Convert.IsDBNull(sdr["OCC_ID"])) ? 0 : Convert.ToInt32(sdr["OCC_ID"])),
                                    ADDRESS = sdr["ADDRESS"].ToString(),
                                    // Pincode = int.Parse(sdr["Pincode"].ToString()),
                                    PINCODE = ((Convert.IsDBNull(sdr["PINCODE"])) ? 0 : Convert.ToInt32(sdr["PINCODE"])),
                                    //  Age = int.Parse(sdr["Age"].ToString()),
                                    AGE = ((Convert.IsDBNull(sdr["AGE"])) ? 0 : Convert.ToInt32(sdr["AGE"])),
                                    DISTRICT= ((Convert.IsDBNull(sdr["DISTRICT"])) ? 0 : Convert.ToInt32(sdr["DISTRICT"])),
                                    PHC= ((Convert.IsDBNull(sdr["PHC"])) ? 0 : Convert.ToInt32(sdr["PHC"])),
                                    REC_DATE = ((Convert.IsDBNull(sdr["REC_DATE"])) ? DateTime.MinValue : Convert.ToDateTime(sdr["REC_DATE"])),


                                },
                                //Complaints = new complaints
                                //{

                                //    P_ID = Convert.ToString(sdr["P_ID"]),
                                //    Red_patch_mouth = Convert.ToBoolean(sdr["Red_patch_mouth"]),
                                //    White_patch_mouth = Convert.ToBoolean(sdr["White_patch_mouth"]),
                                //    Ulcer = Convert.ToBoolean(sdr["Ulcer"]),
                                //    Leukoplakia = Convert.ToBoolean(sdr["Leukoplakia"]),
                                //    Erythroplakia = Convert.ToBoolean(sdr["Erythroplakia"]),
                                //    Extract_socket = Convert.ToBoolean(sdr["Extract_socket"]),
                                //    Diff_chewing = Convert.ToBoolean(sdr["Diff_chewing"]),
                                //    Diff_swallowing = Convert.ToBoolean(sdr["Diff_swallowing"]),
                                //    Diff_speaking = Convert.ToBoolean(sdr["Diff_speaking"]),
                                //    Diff_moving_tongue = Convert.ToBoolean(sdr["Diff_moving_tongue"]),
                                //    Diff_spicy_food = Convert.ToBoolean(sdr["Diff_spicy_food"]),
                                //    Change_voice = Convert.ToBoolean(sdr["Change_voice"]),
                                //    Breast_Lump = Convert.ToBoolean(sdr["Breast_Lump"]),
                                //    Nipple_discharge = Convert.ToBoolean(sdr["Nipple_discharge"]),
                                //    Foul_smelling = Convert.ToBoolean(sdr["Foul_smelling"]),
                                //    Post_coidal_bleeding = Convert.ToBoolean(sdr["Post_coidal_bleeding"]),
                                //    Spotting = Convert.ToBoolean(sdr["Spotting"]),
                                //    Abnormal_bleeding = Convert.ToBoolean(sdr["Abnormal_bleeding"]),
                                //    Others = Convert.ToBoolean(sdr["Others"]),
                                //    Others_specify = sdr["Others_specify"].ToString(),

                                //}

                            });
                        }
                        return main;
                    }
                }
            }
        }


       


    }
}
