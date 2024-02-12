using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Data.Odbc;
using System.Configuration;

namespace Test.Models
{
    public class DBAccessLayer
    {
        Query q = new Query();
        OdbcConnection con1 = new OdbcConnection("Dsn=crreg; uid=tmh;pwd=tmh; initial catalog = EC_TMH; Trusted_Connection=Yes;");
        SqlConnection con = new SqlConnection("data source =.; initial catalog = Screening; integrated security = True;");


        //public string AddRecord(Main main)
        //{
        //    try
        //    {
        //        string query = q.InsertDemo();
        //        string query1 = q.InsertComplaint();


        //        SqlCommand cmd = new SqlCommand(query, con);
        //        SqlCommand cmd1 = new SqlCommand(query1, con);
        //        //Demo properties
        //        //  cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@P_ID", main.Demos.P_ID ?? (object)DBNull.Value);

        //        cmd.Parameters.AddWithValue("@Fname", main.Demos.Fname ?? (object)DBNull.Value);
        //        cmd.Parameters.AddWithValue("@Mname", main.Demos.Mname ?? (object)DBNull.Value);
        //        cmd.Parameters.AddWithValue("@Lname", main.Demos.Lname ?? (object)DBNull.Value);
        //        //  cmd.Parameters.AddWithValue("@Age", main.Demos.Age);
        //        cmd.Parameters.AddWithValue("@Sex", main.Demos.Sex ?? (object)DBNull.Value);
        //        cmd.Parameters.AddWithValue("@Education_id", main.Demos.Education_id ?? (object)DBNull.Value);
        //        cmd.Parameters.AddWithValue("@Marital_id", main.Demos.Mariatal_id ?? (object)DBNull.Value);
        //        cmd.Parameters.AddWithValue("@Religion_id", main.Demos.Religion_id ?? (object)DBNull.Value);
        //        cmd.Parameters.AddWithValue("@Occupation_id", main.Demos.Occupation_id ?? (object)DBNull.Value);
        //        cmd.Parameters.AddWithValue("@Address", main.Demos.Address ?? (object)DBNull.Value);
        //        cmd.Parameters.AddWithValue("@Pincode", main.Demos.Pincode ?? (object)DBNull.Value);

        //        cmd.Parameters.AddWithValue("@Age", main.Demos.Age ?? (object)DBNull.Value);
        //        // Complaints properties
        //        cmd1.Parameters.AddWithValue("@C_id", main.Demos.P_ID ?? (object)DBNull.Value);
        //        cmd1.Parameters.AddWithValue("@Red_patch_mouth", SqlDbType.Bit).Value = main.Complaints.Red_patch_mouth;
        //        cmd1.Parameters.AddWithValue("@White_patch_mouth", SqlDbType.Bit).Value = main.Complaints.White_patch_mouth;
        //        cmd1.Parameters.AddWithValue("@Ulcer", SqlDbType.Bit).Value = main.Complaints.Ulcer;
        //        cmd1.Parameters.AddWithValue("@Leukoplakia", SqlDbType.Bit).Value = main.Complaints.Leukoplakia;
        //        cmd1.Parameters.AddWithValue("@Erythroplakia", SqlDbType.Bit).Value = main.Complaints.Erythroplakia;
        //        cmd1.Parameters.AddWithValue("@Extract_socket", SqlDbType.Bit).Value = main.Complaints.Extract_socket;
        //        cmd1.Parameters.AddWithValue("@Diff_chewing", SqlDbType.Bit).Value = main.Complaints.Diff_chewing;
        //        cmd1.Parameters.AddWithValue("@Diff_swallowing", SqlDbType.Bit).Value = main.Complaints.Diff_swallowing;
        //        cmd1.Parameters.AddWithValue("@Diff_speaking", SqlDbType.Bit).Value = main.Complaints.Diff_speaking;
        //        cmd1.Parameters.AddWithValue("@Diff_moving_tongue", SqlDbType.Bit).Value = main.Complaints.Diff_moving_tongue;
        //        cmd1.Parameters.AddWithValue("@Diff_spicy_food", SqlDbType.Bit).Value = main.Complaints.Diff_spicy_food;
        //        cmd1.Parameters.AddWithValue("@Change_voice", SqlDbType.Bit).Value = main.Complaints.Change_voice;
        //        cmd1.Parameters.AddWithValue("@Breast_Lump", SqlDbType.Bit).Value = main.Complaints.Breast_Lump;
        //        cmd1.Parameters.AddWithValue("@Nipple_discharge", SqlDbType.Bit).Value = main.Complaints.Nipple_discharge;
        //        cmd1.Parameters.AddWithValue("@Foul_smelling", SqlDbType.Bit).Value = main.Complaints.Foul_smelling;
        //        cmd1.Parameters.AddWithValue("@Post_coidal_bleeding", SqlDbType.Bit).Value = main.Complaints.Post_coidal_bleeding;
        //        cmd1.Parameters.AddWithValue("@Spotting", SqlDbType.Bit).Value = main.Complaints.Spotting;
        //        cmd1.Parameters.AddWithValue("@Abnormal_bleeding", SqlDbType.Bit).Value = main.Complaints.Abnormal_bleeding;
        //        cmd1.Parameters.AddWithValue("@Others", SqlDbType.Bit).Value = main.Complaints.Others;
        //        cmd1.Parameters.AddWithValue("@Other_specify", main.Complaints.Others_specify ?? (object)DBNull.Value);
        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //        cmd1.ExecuteNonQuery();
        //        con.Close();
        //        return ("Data save Successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        if (con.State == ConnectionState.Open)
        //        {
        //            con.Close();
        //        }
        //        return (ex.Message.ToString());
        //    }
        //}

        //public string EditRecord(Main main)
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("sp_demo_Update", con);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter paramId = new SqlParameter();
        //        paramId.ParameterName = "@P_ID";
        //        paramId.Value = main.Demos.P_ID;
        //        cmd.Parameters.Add(paramId);

        //        SqlParameter paramFname = new SqlParameter();
        //        paramFname.ParameterName = "@Fname";
        //        paramFname.Value = main.Demos.Fname;
        //        cmd.Parameters.Add(paramFname);

        //        SqlParameter paramMname = new SqlParameter();
        //        paramMname.ParameterName = "@Mname";
        //        paramMname.Value = main.Demos.Mname;
        //        cmd.Parameters.Add(paramMname);

        //        SqlParameter paramLname = new SqlParameter();
        //        paramLname.ParameterName = "@Lname";
        //        paramLname.Value = main.Demos.Lname;
        //        cmd.Parameters.Add(paramLname);

        //        //SqlParameter paramAge = new SqlParameter();
        //        //paramAge.ParameterName = "@Age";
        //        //paramAge.Value = main.Demos.Age;
        //        //cmd.Parameters.Add(paramAge);

        //        SqlParameter paramSex = new SqlParameter();
        //        paramSex.ParameterName = "@Sex";
        //        paramSex.Value = main.Demos.Sex;
        //        cmd.Parameters.Add(paramSex);

        //        SqlParameter paramEdu = new SqlParameter();
        //        paramEdu.ParameterName = "@Education_id";
        //        paramEdu.Value = main.Demos.Education_id;
        //        cmd.Parameters.Add(paramEdu);

        //        SqlParameter paramMarital = new SqlParameter();
        //        paramMarital.ParameterName = "@Marital_id";
        //        paramMarital.Value = main.Demos.Mariatal_id;
        //        cmd.Parameters.Add(paramMarital);

        //        SqlParameter paramReli = new SqlParameter();
        //        paramReli.ParameterName = "@Religion_id";
        //        paramReli.Value = main.Demos.Religion_id;
        //        cmd.Parameters.Add(paramReli);

        //        SqlParameter paramOccup = new SqlParameter();
        //        paramOccup.ParameterName = "@Occupation_id";
        //        paramOccup.Value = main.Demos.Occupation_id;
        //        cmd.Parameters.Add(paramOccup);

        //        SqlParameter paramAddress = new SqlParameter();
        //        paramAddress.ParameterName = "@Address";
        //        paramAddress.Value = main.Demos.Address;
        //        cmd.Parameters.Add(paramAddress);

        //        SqlParameter paramPin = new SqlParameter();
        //        paramPin.ParameterName = "@Pincode";
        //        paramPin.Value = main.Demos.Pincode;
        //        cmd.Parameters.Add(paramPin);


        //        SqlParameter paramAge = new SqlParameter();
        //        paramAge.ParameterName = "@Age";
        //        paramAge.Value = main.Demos.Age;
        //        cmd.Parameters.Add(paramAge);

        //        SqlParameter paramCId = new SqlParameter();
        //        paramCId.ParameterName = "@C_id";
        //        paramCId.Value = main.Complaints.P_ID;
        //        cmd.Parameters.Add(paramCId);

        //        SqlParameter paramRPM = new SqlParameter();
        //        paramRPM.ParameterName = "@Red_patch_mouth";
        //        paramRPM.Value = main.Complaints.Red_patch_mouth;
        //        cmd.Parameters.Add(paramRPM);

        //        SqlParameter paramWPM = new SqlParameter();
        //        paramWPM.ParameterName = "@White_patch_mouth";
        //        paramWPM.Value = main.Complaints.White_patch_mouth;
        //        cmd.Parameters.Add(paramWPM);

        //        SqlParameter paramulcr = new SqlParameter();
        //        paramulcr.ParameterName = "@Ulcer";
        //        paramulcr.Value = main.Complaints.Ulcer;
        //        cmd.Parameters.Add(paramulcr);

        //        SqlParameter paramLeu = new SqlParameter();
        //        paramLeu.ParameterName = "@Leukoplakia";
        //        paramLeu.Value = main.Complaints.Leukoplakia;
        //        cmd.Parameters.Add(paramLeu);

        //        SqlParameter paramEry = new SqlParameter();
        //        paramEry.ParameterName = "@Erythroplakia";
        //        paramEry.Value = main.Complaints.Erythroplakia;
        //        cmd.Parameters.Add(paramEry);

        //        SqlParameter paramExtr = new SqlParameter();
        //        paramExtr.ParameterName = "@Extract_socket";
        //        paramExtr.Value = main.Complaints.Extract_socket;
        //        cmd.Parameters.Add(paramExtr);

        //        SqlParameter paramDiffChe = new SqlParameter();
        //        paramDiffChe.ParameterName = "@Diff_chewing";
        //        paramDiffChe.Value = main.Complaints.Diff_chewing;
        //        cmd.Parameters.Add(paramDiffChe);

        //        SqlParameter paramDiffSwall = new SqlParameter();
        //        paramDiffSwall.ParameterName = "@Diff_swallowing";
        //        paramDiffSwall.Value = main.Complaints.Diff_swallowing;
        //        cmd.Parameters.Add(paramDiffSwall);

        //        SqlParameter paramDiffSpeak = new SqlParameter();
        //        paramDiffSpeak.ParameterName = "@Diff_speaking";
        //        paramDiffSpeak.Value = main.Complaints.Diff_speaking;
        //        cmd.Parameters.Add(paramDiffSpeak);

        //        SqlParameter paramDiffMovTon = new SqlParameter();
        //        paramDiffMovTon.ParameterName = "@Diff_moving_tongue";
        //        paramDiffMovTon.Value = main.Complaints.Diff_moving_tongue;
        //        cmd.Parameters.Add(paramDiffMovTon);

        //        SqlParameter paramDiffSpifod = new SqlParameter();
        //        paramDiffSpifod.ParameterName = "@Diff_spicy_food";
        //        paramDiffSpifod.Value = main.Complaints.Diff_spicy_food;
        //        cmd.Parameters.Add(paramDiffSpifod);

        //        SqlParameter paramChgVoice = new SqlParameter();
        //        paramChgVoice.ParameterName = "@Change_voice";
        //        paramChgVoice.Value = main.Complaints.Change_voice;
        //        cmd.Parameters.Add(paramChgVoice);

        //        SqlParameter paramBrLup = new SqlParameter();
        //        paramBrLup.ParameterName = "@Breast_Lump";
        //        paramBrLup.Value = main.Complaints.Breast_Lump;
        //        cmd.Parameters.Add(paramBrLup);

        //        SqlParameter paramNipDis = new SqlParameter();
        //        paramNipDis.ParameterName = "@Nipple_discharge";
        //        paramNipDis.Value = main.Complaints.Nipple_discharge;
        //        cmd.Parameters.Add(paramNipDis);

        //        SqlParameter paramFolsmell = new SqlParameter();
        //        paramFolsmell.ParameterName = "@Foul_smelling";
        //        paramFolsmell.Value = main.Complaints.Foul_smelling;
        //        cmd.Parameters.Add(paramFolsmell);

        //        SqlParameter paramPocoBled = new SqlParameter();
        //        paramPocoBled.ParameterName = "@Post_coidal_bleeding";
        //        paramPocoBled.Value = main.Complaints.Post_coidal_bleeding;
        //        cmd.Parameters.Add(paramPocoBled);

        //        SqlParameter paramSpot = new SqlParameter();
        //        paramSpot.ParameterName = "@Spotting";
        //        paramSpot.Value = main.Complaints.Spotting;
        //        cmd.Parameters.Add(paramSpot);

        //        SqlParameter paramAbBleed = new SqlParameter();
        //        paramAbBleed.ParameterName = "@Abnormal_bleeding";
        //        paramAbBleed.Value = main.Complaints.Abnormal_bleeding;
        //        cmd.Parameters.Add(paramAbBleed);

        //        SqlParameter paramOther = new SqlParameter();
        //        paramOther.ParameterName = "@Others";
        //        paramOther.Value = main.Complaints.Others;
        //        cmd.Parameters.Add(paramOther);

        //        SqlParameter paramOthrSpec = new SqlParameter();
        //        paramOthrSpec.ParameterName = "@Other_specify";
        //        paramOthrSpec.Value = main.Complaints.Others_specify;
        //        cmd.Parameters.Add(paramOthrSpec);


        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //        return ("Data Update Successfully");

        //    }
        //    catch (Exception ex)
        //    {

        //        if (con.State == ConnectionState.Open)
        //        {
        //            con.Close();
        //        }
        //        return (ex.Message.ToString());
        //    }

        //}

        //public List<Main> GetRecords()
        //{
        //    List<Main> main = new List<Main>();
        //    string constr = ConfigurationManager.ConnectionStrings["DbEntity"].ConnectionString;

        //    using (SqlConnection con = new SqlConnection(constr))
        //    {
        //        string query = q.Getallrecords();
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            con.Open();
        //            using (SqlDataReader sdr = cmd.ExecuteReader())
        //            {
        //                while (sdr.Read())
        //                {
        //                    main.Add(new Main
        //                    {
        //                        Demos = new Demo
        //                        {
        //                            P_ID = Convert.ToString(sdr["P_ID"]),
        //                            Fname = Convert.ToString(sdr["Fname"]),
        //                            Mname = Convert.ToString(sdr["Mname"]),
        //                            Lname = Convert.ToString(sdr["Lname"]),
        //                            Sex = Convert.ToString(sdr["Sex"]),

        //                            Education_id = ((Convert.IsDBNull(sdr["Education_id"])) ? 0 : Convert.ToInt32(sdr["Education_id"])),
        //                            Mariatal_id = ((Convert.IsDBNull(sdr["Marital_id"])) ? 0 : Convert.ToInt32(sdr["Marital_id"])),
        //                            // Marital_id = int.Parse(sdr["Marital_id"].ToString()),
        //                            Religion_id = ((Convert.IsDBNull(sdr["Religion_id"])) ? 0 : Convert.ToInt32(sdr["Religion_id"])),
        //                            //  Religion_id = int.Parse(sdr["Religion_id"].ToString()),
        //                            // Occupation_id = int.Parse(sdr["Occupation_id"].ToString()),
        //                            Occupation_id = ((Convert.IsDBNull(sdr["Occupation_id"])) ? 0 : Convert.ToInt32(sdr["Occupation_id"])),
        //                            Address = sdr["Address"].ToString(),
        //                            // Pincode = int.Parse(sdr["Pincode"].ToString()),
        //                            Pincode = ((Convert.IsDBNull(sdr["Pincode"])) ? 0 : Convert.ToInt32(sdr["Pincode"])),
        //                            //  Age = int.Parse(sdr["Age"].ToString()),
        //                            Age = ((Convert.IsDBNull(sdr["Age"])) ? 0 : Convert.ToInt32(sdr["Age"])),


        //                        },
        //                        Complaints = new complaints
        //                        {

        //                            P_ID = Convert.ToString(sdr["P_ID"]),
        //                            Red_patch_mouth = Convert.ToBoolean(sdr["Red_patch_mouth"]),
        //                            White_patch_mouth = Convert.ToBoolean(sdr["White_patch_mouth"]),
        //                            Ulcer = Convert.ToBoolean(sdr["Ulcer"]),
        //                            Leukoplakia = Convert.ToBoolean(sdr["Leukoplakia"]),
        //                            Erythroplakia = Convert.ToBoolean(sdr["Erythroplakia"]),
        //                            Extract_socket = Convert.ToBoolean(sdr["Extract_socket"]),
        //                            Diff_chewing = Convert.ToBoolean(sdr["Diff_chewing"]),
        //                            Diff_swallowing = Convert.ToBoolean(sdr["Diff_swallowing"]),
        //                            Diff_speaking = Convert.ToBoolean(sdr["Diff_speaking"]),
        //                            Diff_moving_tongue = Convert.ToBoolean(sdr["Diff_moving_tongue"]),
        //                            Diff_spicy_food = Convert.ToBoolean(sdr["Diff_spicy_food"]),
        //                            Change_voice = Convert.ToBoolean(sdr["Change_voice"]),
        //                            Breast_Lump = Convert.ToBoolean(sdr["Breast_Lump"]),
        //                            Nipple_discharge = Convert.ToBoolean(sdr["Nipple_discharge"]),
        //                            Foul_smelling = Convert.ToBoolean(sdr["Foul_smelling"]),
        //                            Post_coidal_bleeding = Convert.ToBoolean(sdr["Post_coidal_bleeding"]),
        //                            Spotting = Convert.ToBoolean(sdr["Spotting"]),
        //                            Abnormal_bleeding = Convert.ToBoolean(sdr["Abnormal_bleeding"]),
        //                            Others = Convert.ToBoolean(sdr["Others"]),
        //                            Others_specify = sdr["Others_specify"].ToString(),

        //                        }

        //                    });
        //                }
        //                return main;
        //            }
        //        }
        //    }
        //}





        public void addtest1(Demo demo)
        {
            string constr = ConfigurationManager.ConnectionStrings["DbEntity"].ConnectionString;
            // string insertStatement = "INSERT INTO REGLIB.SCR_DEMO (P_ID, FNAME, EDU_ID, AGE, REC_DATE) VALUES ('P_ID', 'FNAME', 'EDU_ID', 'AGE', 'REC_DATE')";
            string queryString = "INSERT INTO REGLIB.SCR_DEMO (P_ID, FNAME, EDU_ID, AGE, REC_DATE) Values('" + demo .P_ID + "','" + demo.FNAME + "','" + demo.EDU_ID + "','" + demo.AGE + "','" + demo.REC_DATE?.ToString("dd/MM/yyyy") + "')";

            OdbcCommand command = new OdbcCommand(queryString);

            using (OdbcConnection connection = new OdbcConnection(constr))
            {
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public List<Demo> gettest()
        {
            List<Demo> demo = new List<Demo>();
            string constr = ConfigurationManager.ConnectionStrings["DbEntity"].ConnectionString;
            using (OdbcConnection con = new OdbcConnection(constr))
            {
                string query = q.gettest();
                using (OdbcCommand cmd = new OdbcCommand(query, con))
                {
                    con.Open();
                    using (OdbcDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            demo.Add(new Demo
                            {
                                P_ID = Convert.ToString(sdr["P_ID"]),
                                AGE = ((Convert.IsDBNull(sdr["AGE"])) ? 0 : Convert.ToInt32(sdr["AGE"])),
                                EDU_ID = ((Convert.IsDBNull(sdr["EDU_ID"])) ? 0 : Convert.ToInt32(sdr["EDU_ID"])),
                                FNAME = Convert.ToString(sdr["FNAME"]),
                                MNAME = Convert.ToString(sdr["MNAME"]),
                                LNAME = Convert.ToString(sdr["LNAME"]),

                                //SEX = ((Convert.IsDBNull(sdr["SEX"])) ? 0 : Convert.ToInt32(sdr["SEX"])),
                                MAR_ID = ((Convert.IsDBNull(sdr["MAR_ID"])) ? 0 : Convert.ToInt32(sdr["MAR_ID"])),
                                REL_ID = ((Convert.IsDBNull(sdr["REL_ID"])) ? 0 : Convert.ToInt32(sdr["REL_ID"])),

                                OCC_ID = ((Convert.IsDBNull(sdr["OCC_ID"])) ? 0 : Convert.ToInt32(sdr["OCC_ID"])),

                                ADDRESS = Convert.ToString(sdr["ADDRESS"]),

                                PINCODE = ((Convert.IsDBNull(sdr["PINCODE"])) ? 0 : Convert.ToInt32(sdr["PINCODE"])), 

                            });
                        }
                        return demo;
                    }
                }
            }
        }

    }
}
