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
            try
            {
               string query= q.InsertDemo();
               string query1 = q.InsertComplaint();
             

                SqlCommand cmd = new SqlCommand(query, con);
                SqlCommand cmd1 = new SqlCommand(query1, con);
                //Demo properties
              //  cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@P_ID", main.Demos.P_ID ?? (object)DBNull.Value);
                
                cmd.Parameters.AddWithValue("@FNAME", main.Demos.FNAME?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Mname", main.Demos.MNAME ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Lname", main.Demos.LNAME ?? (object)DBNull.Value);
                //  cmd.Parameters.AddWithValue("@Age", main.Demos.Age);
                cmd.Parameters.AddWithValue("@Sex", main.Demos.SEX ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Education_id", main.Demos.EDU_ID ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Marital_id", main.Demos.MAR_ID ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Religion_id", main.Demos.REL_ID ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Occupation_id", main.Demos.OCC_ID ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", main.Demos.ADDRESS ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Pincode", main.Demos.PINCODE ?? (object)DBNull.Value);

                cmd.Parameters.AddWithValue("@Age", main.Demos.AGE ?? (object)DBNull.Value);
                // Complaints properties
                cmd1.Parameters.AddWithValue("@C_id", main.Demos.P_ID ?? (object)DBNull.Value);
                cmd1.Parameters.AddWithValue("@Red_patch_mouth", SqlDbType.Bit).Value= main.Complaints.Red_patch_mouth;
                cmd1.Parameters.AddWithValue("@White_patch_mouth", SqlDbType.Bit).Value = main.Complaints.White_patch_mouth;
                cmd1.Parameters.AddWithValue("@Ulcer", SqlDbType.Bit).Value = main.Complaints.Ulcer;
                cmd1.Parameters.AddWithValue("@Leukoplakia", SqlDbType.Bit).Value = main.Complaints.Leukoplakia;
                cmd1.Parameters.AddWithValue("@Erythroplakia", SqlDbType.Bit).Value = main.Complaints.Erythroplakia;
                cmd1.Parameters.AddWithValue("@Extract_socket", SqlDbType.Bit).Value = main.Complaints.Extract_socket;
                cmd1.Parameters.AddWithValue("@Diff_chewing", SqlDbType.Bit).Value = main.Complaints.Diff_chewing;
                cmd1.Parameters.AddWithValue("@Diff_swallowing", SqlDbType.Bit).Value = main.Complaints.Diff_swallowing;
                cmd1.Parameters.AddWithValue("@Diff_speaking", SqlDbType.Bit).Value = main.Complaints.Diff_speaking;
                cmd1.Parameters.AddWithValue("@Diff_moving_tongue", SqlDbType.Bit).Value = main.Complaints.Diff_moving_tongue;
                cmd1.Parameters.AddWithValue("@Diff_spicy_food", SqlDbType.Bit).Value = main.Complaints.Diff_spicy_food;
                cmd1.Parameters.AddWithValue("@Change_voice", SqlDbType.Bit).Value = main.Complaints.Change_voice;
                cmd1.Parameters.AddWithValue("@Breast_Lump", SqlDbType.Bit).Value = main.Complaints.Breast_Lump;
                cmd1.Parameters.AddWithValue("@Nipple_discharge", SqlDbType.Bit).Value = main.Complaints.Nipple_discharge;
                cmd1.Parameters.AddWithValue("@Foul_smelling", SqlDbType.Bit).Value = main.Complaints.Foul_smelling;
                cmd1.Parameters.AddWithValue("@Post_coidal_bleeding", SqlDbType.Bit).Value = main.Complaints.Post_coidal_bleeding;
                cmd1.Parameters.AddWithValue("@Spotting", SqlDbType.Bit).Value = main.Complaints.Spotting;
                cmd1.Parameters.AddWithValue("@Abnormal_bleeding", SqlDbType.Bit).Value = main.Complaints.Abnormal_bleeding;
                cmd1.Parameters.AddWithValue("@Others", SqlDbType.Bit).Value = main.Complaints.Others;
                cmd1.Parameters.AddWithValue("@Other_specify",  main.Complaints.Others_specify ?? (object)DBNull.Value);
                con.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                con.Close();
                return ("Data save Successfully");
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
        
       


        public string addtest1(test test)
        {
            string constr = ConfigurationManager.ConnectionStrings["DbEntity"].ConnectionString;
           // string insertStatement = "INSERT INTO REGLIB.SCR_DEMO (P_ID, FNAME, EDU_ID, AGE, REC_DATE) VALUES ('P_ID', 'FNAME', 'EDU_ID', 'AGE', 'REC_DATE')";
            string queryString = "INSERT INTO REGLIB.SCR_DEMO (P_ID, FNAME, EDU_ID, AGE,REC_DATE) Values('" + test.P_ID + "','" + test.FNAME + "','" + test.EDU_ID + "','" + test.AGE + "','" + test.REC_DATE + "')";
            
            OdbcCommand cmd = new OdbcCommand(queryString);
             
            using (OdbcConnection connection = new OdbcConnection(constr))
            {
                cmd.Connection = connection;
                connection.Open();
                
                cmd.Parameters.AddWithValue("P_ID", test.P_ID != null ? test.P_ID: (object)DBNull.Value);
              
                cmd.Parameters.AddWithValue("FNAME", test.FNAME != null ? test.FNAME : (object)DBNull.Value);
                if (test.EDU_ID.HasValue)
                {
                    cmd.Parameters.AddWithValue("EDU_ID", test.EDU_ID);
                }
                else
                {
                    cmd.Parameters.AddWithValue("EDU_ID", DBNull.Value);
                }

                if(test.AGE.HasValue)
                {
                    cmd.Parameters.AddWithValue("AGE", test.AGE);
                }
                else
                {
                    cmd.Parameters.AddWithValue("AGE", DBNull.Value);
                }
               
                // cmd.Parameters.AddWithValue("AGE", test.AGE ?? (object)DBNull.Value);

                cmd.Parameters.AddWithValue("REC_DATE", test.REC_DATE ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Data save Successfully");

            }
        }

        public string EditRecord(Main main)
        {

            string query = q.updatetest();
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramId = new SqlParameter();
                paramId.ParameterName = "@P_ID";
                paramId.Value = main.Demos.P_ID;
                cmd.Parameters.Add(paramId);

                SqlParameter paramFNAME = new SqlParameter();
                paramFNAME.ParameterName = "@FNAME";
                paramFNAME.Value = main.Demos.FNAME;
                cmd.Parameters.Add(paramFNAME);

                SqlParameter paramMname = new SqlParameter();
                paramMname.ParameterName = "@Mname";
                paramMname.Value = main.Demos.MNAME;
                cmd.Parameters.Add(paramMname);

                SqlParameter paramLname = new SqlParameter();
                paramLname.ParameterName = "@Lname";
                paramLname.Value = main.Demos.LNAME;
                cmd.Parameters.Add(paramLname);

                //SqlParameter paramAge = new SqlParameter();
                //paramAge.ParameterName = "@Age";
                //paramAge.Value = main.Demos.Age;
                //cmd.Parameters.Add(paramAge);

                SqlParameter paramSex = new SqlParameter();
                paramSex.ParameterName = "@Sex";
                paramSex.Value = main.Demos.SEX;
                cmd.Parameters.Add(paramSex);

                SqlParameter paramEdu = new SqlParameter();
                paramEdu.ParameterName = "@Education_id";
                paramEdu.Value = main.Demos.EDU_ID;
                cmd.Parameters.Add(paramEdu);

                SqlParameter paramMarital = new SqlParameter();
                paramMarital.ParameterName = "@Marital_id";
                paramMarital.Value = main.Demos.MAR_ID;
                cmd.Parameters.Add(paramMarital);

                SqlParameter paramReli = new SqlParameter();
                paramReli.ParameterName = "@Religion_id";
                paramReli.Value = main.Demos.REL_ID;
                cmd.Parameters.Add(paramReli);

                SqlParameter paramOccup = new SqlParameter();
                paramOccup.ParameterName = "@Occupation_id";
                paramOccup.Value = main.Demos.OCC_ID;
                cmd.Parameters.Add(paramOccup);

                SqlParameter paramAddress = new SqlParameter();
                paramAddress.ParameterName = "@Address";
                paramAddress.Value = main.Demos.ADDRESS;
                cmd.Parameters.Add(paramAddress);

                SqlParameter paramPin = new SqlParameter();
                paramPin.ParameterName = "@Pincode";
                paramPin.Value = main.Demos.PINCODE;
                cmd.Parameters.Add(paramPin);


                SqlParameter paramAge = new SqlParameter();
                paramAge.ParameterName = "@Age";
                paramAge.Value = main.Demos.AGE;
                cmd.Parameters.Add(paramAge);

                SqlParameter paramCId = new SqlParameter();
                paramCId.ParameterName = "@C_id";
                paramCId.Value = main.Complaints.P_ID;
                cmd.Parameters.Add(paramCId);

                SqlParameter paramRPM = new SqlParameter();
                paramRPM.ParameterName = "@Red_patch_mouth";
                paramRPM.Value = main.Complaints.Red_patch_mouth;
                cmd.Parameters.Add(paramRPM);

                SqlParameter paramWPM = new SqlParameter();
                paramWPM.ParameterName = "@White_patch_mouth";
                paramWPM.Value = main.Complaints.White_patch_mouth;
                cmd.Parameters.Add(paramWPM);

                SqlParameter paramulcr = new SqlParameter();
                paramulcr.ParameterName = "@Ulcer";
                paramulcr.Value = main.Complaints.Ulcer;
                cmd.Parameters.Add(paramulcr);

                SqlParameter paramLeu = new SqlParameter();
                paramLeu.ParameterName = "@Leukoplakia";
                paramLeu.Value = main.Complaints.Leukoplakia;
                cmd.Parameters.Add(paramLeu);

                SqlParameter paramEry = new SqlParameter();
                paramEry.ParameterName = "@Erythroplakia";
                paramEry.Value = main.Complaints.Erythroplakia;
                cmd.Parameters.Add(paramEry);

                SqlParameter paramExtr = new SqlParameter();
                paramExtr.ParameterName = "@Extract_socket";
                paramExtr.Value = main.Complaints.Extract_socket;
                cmd.Parameters.Add(paramExtr);

                SqlParameter paramDiffChe = new SqlParameter();
                paramDiffChe.ParameterName = "@Diff_chewing";
                paramDiffChe.Value = main.Complaints.Diff_chewing;
                cmd.Parameters.Add(paramDiffChe);

                SqlParameter paramDiffSwall = new SqlParameter();
                paramDiffSwall.ParameterName = "@Diff_swallowing";
                paramDiffSwall.Value = main.Complaints.Diff_swallowing;
                cmd.Parameters.Add(paramDiffSwall);

                SqlParameter paramDiffSpeak = new SqlParameter();
                paramDiffSpeak.ParameterName = "@Diff_speaking";
                paramDiffSpeak.Value = main.Complaints.Diff_speaking;
                cmd.Parameters.Add(paramDiffSpeak);

                SqlParameter paramDiffMovTon = new SqlParameter();
                paramDiffMovTon.ParameterName = "@Diff_moving_tongue";
                paramDiffMovTon.Value = main.Complaints.Diff_moving_tongue;
                cmd.Parameters.Add(paramDiffMovTon);

                SqlParameter paramDiffSpifod = new SqlParameter();
                paramDiffSpifod.ParameterName = "@Diff_spicy_food";
                paramDiffSpifod.Value = main.Complaints.Diff_spicy_food;
                cmd.Parameters.Add(paramDiffSpifod);

                SqlParameter paramChgVoice = new SqlParameter();
                paramChgVoice.ParameterName = "@Change_voice";
                paramChgVoice.Value = main.Complaints.Change_voice;
                cmd.Parameters.Add(paramChgVoice);

                SqlParameter paramBrLup = new SqlParameter();
                paramBrLup.ParameterName = "@Breast_Lump";
                paramBrLup.Value = main.Complaints.Breast_Lump;
                cmd.Parameters.Add(paramBrLup);

                SqlParameter paramNipDis = new SqlParameter();
                paramNipDis.ParameterName = "@Nipple_discharge";
                paramNipDis.Value = main.Complaints.Nipple_discharge;
                cmd.Parameters.Add(paramNipDis);

                SqlParameter paramFolsmell = new SqlParameter();
                paramFolsmell.ParameterName = "@Foul_smelling";
                paramFolsmell.Value = main.Complaints.Foul_smelling;
                cmd.Parameters.Add(paramFolsmell);

                SqlParameter paramPocoBled = new SqlParameter();
                paramPocoBled.ParameterName = "@Post_coidal_bleeding";
                paramPocoBled.Value = main.Complaints.Post_coidal_bleeding;
                cmd.Parameters.Add(paramPocoBled);

                SqlParameter paramSpot = new SqlParameter();
                paramSpot.ParameterName = "@Spotting";
                paramSpot.Value = main.Complaints.Spotting;
                cmd.Parameters.Add(paramSpot);

                SqlParameter paramAbBleed = new SqlParameter();
                paramAbBleed.ParameterName = "@Abnormal_bleeding";
                paramAbBleed.Value = main.Complaints.Abnormal_bleeding;
                cmd.Parameters.Add(paramAbBleed);

                SqlParameter paramOther = new SqlParameter();
                paramOther.ParameterName = "@Others";
                paramOther.Value = main.Complaints.Others;
                cmd.Parameters.Add(paramOther);

                SqlParameter paramOthrSpec = new SqlParameter();
                paramOthrSpec.ParameterName = "@Other_specify";
                paramOthrSpec.Value = main.Complaints.Others_specify;
                cmd.Parameters.Add(paramOthrSpec);


                con.Open();
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



        public List<test> gettest()
        {
            List<test> test = new List<test>();
            string constr = ConfigurationManager.ConnectionStrings["DbEntity"].ConnectionString;
            using (OdbcConnection con=new OdbcConnection(constr))
            {

                string query = q.gettest();
                using (OdbcCommand cmd=new OdbcCommand(query,con))
                {
                    con.Open();

                    using (OdbcDataReader sdr= cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            test.Add(new test
                            {
                                P_ID = Convert.ToString(sdr["P_ID"]).Trim(),
                                FNAME = Convert.ToString(sdr["FNAME"]),
                                EDU_ID = ((Convert.IsDBNull(sdr["EDU_ID"])) ? 0 : Convert.ToInt32(sdr["EDU_ID"])),
                                AGE = ((Convert.IsDBNull(sdr["AGE"])) ? 0 : Convert.ToInt32(sdr["AGE"])),
                                REC_DATE = Convert.ToString(sdr["REC_DATE"])

                            });




                        }
                        
                        return test;
                    }
                }
            }
        }

        public List<Main> GetRecords()
        {
            List<Main> main = new List<Main>();
            string constr = ConfigurationManager.ConnectionStrings["DbEntity"].ConnectionString;

            using (SqlConnection con=new SqlConnection(constr))
            {
                string query = q.Getallrecords();
                using (SqlCommand cmd=new SqlCommand(query,con))
                {
                    con.Open();
                    using (SqlDataReader sdr=cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            main.Add(new Main
                            {
                                Demos = new Demo
                                {
                                    P_ID = Convert.ToString(sdr["P_ID"]),
                                    FNAME = Convert.ToString(sdr["FNAME"]),
                                    MNAME = Convert.ToString(sdr["Mname"]),
                                    LNAME = Convert.ToString(sdr["Lname"]),
                                    SEX = Convert.ToString(sdr["Sex"]),
                                    
                                    EDU_ID = ((Convert.IsDBNull(sdr["Education_id"])) ? 0 : Convert.ToInt32(sdr["Education_id"])),
                                    MAR_ID =   ((Convert.IsDBNull(sdr["Marital_id"  ])) ? 0 : Convert.ToInt32(sdr["Marital_id"  ])),
                                    // Marital_id = int.Parse(sdr["Marital_id"].ToString()),
                                    REL_ID = ((Convert.IsDBNull(sdr["Religion_id"])) ? 0 : Convert.ToInt32(sdr["Religion_id"])),
                                    //  Religion_id = int.Parse(sdr["Religion_id"].ToString()),
                                    // Occupation_id = int.Parse(sdr["Occupation_id"].ToString()),
                                    OCC_ID = ((Convert.IsDBNull(sdr["Occupation_id"])) ? 0 : Convert.ToInt32(sdr["Occupation_id"])),
                                    ADDRESS = sdr["Address"].ToString(),
                                    // Pincode = int.Parse(sdr["Pincode"].ToString()),
                                    PINCODE = ((Convert.IsDBNull(sdr["Pincode"])) ? 0 : Convert.ToInt32(sdr["Pincode"])),
                                  //  Age = int.Parse(sdr["Age"].ToString()),
                                    AGE = ((Convert.IsDBNull(sdr["Age"])) ? 0 : Convert.ToInt32(sdr["Age"])),


                                },
                                Complaints = new complaints
                                {

                                    P_ID = Convert.ToString(sdr["P_ID"]),
                                    Red_patch_mouth = Convert.ToBoolean(sdr["Red_patch_mouth"]),
                                    White_patch_mouth = Convert.ToBoolean(sdr["White_patch_mouth"]),
                                    Ulcer = Convert.ToBoolean(sdr["Ulcer"]),
                                    Leukoplakia = Convert.ToBoolean(sdr["Leukoplakia"]),
                                    Erythroplakia = Convert.ToBoolean(sdr["Erythroplakia"]),
                                    Extract_socket = Convert.ToBoolean(sdr["Extract_socket"]),
                                    Diff_chewing = Convert.ToBoolean(sdr["Diff_chewing"]),
                                    Diff_swallowing = Convert.ToBoolean(sdr["Diff_swallowing"]),
                                    Diff_speaking = Convert.ToBoolean(sdr["Diff_speaking"]),
                                    Diff_moving_tongue = Convert.ToBoolean(sdr["Diff_moving_tongue"]),
                                    Diff_spicy_food = Convert.ToBoolean(sdr["Diff_spicy_food"]),
                                    Change_voice = Convert.ToBoolean(sdr["Change_voice"]),
                                    Breast_Lump = Convert.ToBoolean(sdr["Breast_Lump"]),
                                    Nipple_discharge = Convert.ToBoolean(sdr["Nipple_discharge"]),
                                    Foul_smelling = Convert.ToBoolean(sdr["Foul_smelling"]),
                                    Post_coidal_bleeding = Convert.ToBoolean(sdr["Post_coidal_bleeding"]),
                                    Spotting = Convert.ToBoolean(sdr["Spotting"]),
                                    Abnormal_bleeding = Convert.ToBoolean(sdr["Abnormal_bleeding"]),
                                    Others = Convert.ToBoolean(sdr["Others"]),
                                    Others_specify = sdr["Others_specify"].ToString(),

                                }

                            });
                        }
                        return main;
                    }
                }
            }
        }


        public string edittest(test t)
        {
            string query = "UPDATE REGLIB.SCR_DEMO SET P_ID='"+t.P_ID+ "', FNAME='" + t.FNAME + "', EDU_ID='" + t.EDU_ID + "', AGE='" + t.AGE + "',REC_DATE='" + t.REC_DATE + "' WHERE P_ID='" + t.P_ID + "'";
            try
            {
                
               // string constr = ConfigurationManager.ConnectionStrings["DbEntity"].ConnectionString;
                OdbcCommand cmd = new OdbcCommand(query,con1);
                cmd.Connection = con1;

                OdbcParameter paramId = new OdbcParameter();
                paramId.ParameterName = t.P_ID;
                paramId.Value = t.P_ID;
                cmd.Parameters.Add(paramId);

                OdbcParameter paramname = new OdbcParameter();
                paramname.ParameterName = t.FNAME;
                paramname.Value = t.FNAME;
                cmd.Parameters.Add(paramname);

                OdbcParameter parameduid = new OdbcParameter();
                parameduid.ParameterName = t.EDU_ID.ToString();
                parameduid.Value = t.EDU_ID;
                cmd.Parameters.Add(parameduid);

                OdbcParameter parameage = new OdbcParameter();
                parameage.ParameterName = t.AGE.ToString();
                parameage.Value = t.AGE;
                cmd.Parameters.Add(parameage);

                OdbcParameter paramedate = new OdbcParameter();
                paramedate.ParameterName = t.REC_DATE;
                paramedate.Value = t.REC_DATE;
                cmd.Parameters.Add(paramedate);

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


    }
}
