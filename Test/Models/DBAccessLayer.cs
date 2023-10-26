using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace Test.Models
{
    public class DBAccessLayer
    {
        SqlConnection con = new SqlConnection("data source =.; initial catalog = Screening; integrated security = True;");

        public string AddRecord(Main main)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_demo_Add", con);
                //Demo properties
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@P_id", main.Demos.P_id);
                cmd.Parameters.AddWithValue("@Fname", main.Demos.Fname);
                cmd.Parameters.AddWithValue("@Mname", main.Demos.Mname);
                cmd.Parameters.AddWithValue("@Lname", main.Demos.Lname);
                //  cmd.Parameters.AddWithValue("@Age", main.Demos.Age);
                cmd.Parameters.AddWithValue("@Sex", main.Demos.Sex);
                cmd.Parameters.AddWithValue("@Education_id", main.Demos.Education_id);
                cmd.Parameters.AddWithValue("@Marital_id", main.Demos.Mariatal_id);
                cmd.Parameters.AddWithValue("@Religion_id", main.Demos.Religion_id);
                cmd.Parameters.AddWithValue("@Occupation_id", main.Demos.Occupation_id);
                cmd.Parameters.AddWithValue("@Address", main.Demos.Address);
                cmd.Parameters.AddWithValue("@Pincode", main.Demos.Pincode);
                // Complaints properties
                cmd.Parameters.AddWithValue("@C_id", main.Demos.P_id);
                cmd.Parameters.AddWithValue("@Red_patch_mouth", main.Complaints.Red_patch_mouth);
                cmd.Parameters.AddWithValue("@White_patch_mouth", main.Complaints.White_patch_mouth);
                cmd.Parameters.AddWithValue("@Ulcer", main.Complaints.Ulcer);
                cmd.Parameters.AddWithValue("@Leukoplakia", main.Complaints.Leukoplakia);
                cmd.Parameters.AddWithValue("@Erythroplakia", main.Complaints.Erythroplakia);
                cmd.Parameters.AddWithValue("@Extract_socket", main.Complaints.Extract_socket);
                cmd.Parameters.AddWithValue("@Diff_chewing", main.Complaints.Diff_chewing);
                cmd.Parameters.AddWithValue("@Diff_swallowing", main.Complaints.Diff_swallowing);
                cmd.Parameters.AddWithValue("@Diff_speaking", main.Complaints.Diff_speaking);
                cmd.Parameters.AddWithValue("@Diff_moving_tongue", main.Complaints.Diff_moving_tongue);
                cmd.Parameters.AddWithValue("@Diff_spicy_food", main.Complaints.Diff_spicy_food);
                cmd.Parameters.AddWithValue("@Change_voice", main.Complaints.Change_voice);
                cmd.Parameters.AddWithValue("@Breast_Lump", main.Complaints.Breast_Lump);
                cmd.Parameters.AddWithValue("@Nipple_discharge", main.Complaints.Nipple_discharge);
                cmd.Parameters.AddWithValue("@Foul_smelling", main.Complaints.Foul_smelling);
                cmd.Parameters.AddWithValue("@Post_coidal_bleeding", main.Complaints.Post_coidal_bleeding);
                cmd.Parameters.AddWithValue("@Spotting", main.Complaints.Spotting);
                cmd.Parameters.AddWithValue("@Abnormal_bleeding", main.Complaints.Abnormal_bleeding);
                cmd.Parameters.AddWithValue("@Others", main.Complaints.Others);
                cmd.Parameters.AddWithValue("@Other_specify", main.Complaints.Others_specify);
                con.Open();
                cmd.ExecuteNonQuery();
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

        public string EditRecord(Main main)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_demo_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramId = new SqlParameter();
                paramId.ParameterName = "@P_id";
                paramId.Value = main.Demos.P_id;
                cmd.Parameters.Add(paramId);

                SqlParameter paramFname = new SqlParameter();
                paramFname.ParameterName = "@Fname";
                paramFname.Value = main.Demos.Fname;
                cmd.Parameters.Add(paramFname);

                SqlParameter paramMname = new SqlParameter();
                paramMname.ParameterName = "@Mname";
                paramMname.Value = main.Demos.Mname;
                cmd.Parameters.Add(paramMname);

                SqlParameter paramLname = new SqlParameter();
                paramLname.ParameterName = "@Lname";
                paramLname.Value = main.Demos.Lname;
                cmd.Parameters.Add(paramLname);

                //SqlParameter paramAge = new SqlParameter();
                //paramAge.ParameterName = "@Age";
                //paramAge.Value = main.Demos.Age;
                //cmd.Parameters.Add(paramAge);

                SqlParameter paramSex = new SqlParameter();
                paramSex.ParameterName = "@Sex";
                paramSex.Value = main.Demos.Sex;
                cmd.Parameters.Add(paramSex);

                SqlParameter paramEdu = new SqlParameter();
                paramEdu.ParameterName = "@Education_id";
                paramEdu.Value = main.Demos.Education_id;
                cmd.Parameters.Add(paramEdu);

                SqlParameter paramMarital = new SqlParameter();
                paramMarital.ParameterName = "@Marital_id";
                paramMarital.Value = main.Demos.Mariatal_id;
                cmd.Parameters.Add(paramMarital);

                SqlParameter paramReli = new SqlParameter();
                paramReli.ParameterName = "@Religion_id";
                paramReli.Value = main.Demos.Religion_id;
                cmd.Parameters.Add(paramReli);

                SqlParameter paramOccup = new SqlParameter();
                paramOccup.ParameterName = "@Occupation_id";
                paramOccup.Value = main.Demos.Occupation_id;
                cmd.Parameters.Add(paramOccup);

                SqlParameter paramAddress = new SqlParameter();
                paramAddress.ParameterName = "@Address";
                paramAddress.Value = main.Demos.Address;
                cmd.Parameters.Add(paramAddress);

                SqlParameter paramPin = new SqlParameter();
                paramPin.ParameterName = "@Pincode";
                paramPin.Value = main.Demos.Pincode;
                cmd.Parameters.Add(paramPin);

                SqlParameter paramCId = new SqlParameter();
                paramCId.ParameterName = "@C_id";
                paramCId.Value = main.Complaints.P_id;
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


        public List<Main> GetRecords()
        {
            List<Main> main = new List<Main>();
            SqlCommand cmd = new SqlCommand("sp_GetAllRecords", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            sd.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                main.Add(new Main
                {
                    Demos = new Demo
                    {
                        P_id = Convert.ToString(dr["P_id"]),
                        Fname = Convert.ToString(dr["Fname"]),
                        Mname = Convert.ToString(dr["Mname"]),
                        Lname = Convert.ToString(dr["Lname"]),
                       
                        Sex = Convert.ToString(dr["Sex"]),
                        Education_id = Convert.ToInt32(dr["Education_id"]),
                        Mariatal_id = Convert.ToInt32(dr["Marital_id"]),
                        Religion_id = Convert.ToInt32(dr["Religion_id"]),
                        Occupation_id = Convert.ToInt32(dr["Occupation_id"]),
                        Address = Convert.ToString(dr["Address"]),
                        Pincode = Convert.ToInt32(dr["Pincode"]),
                        // Age=Convert.ToInt32(dr["Age"]),
                    },
                    Complaints = new complaints
                    {

                        P_id = Convert.ToString(dr["P_id"]),
                        Red_patch_mouth = Convert.ToBoolean(dr["Red_patch_mouth"]),
                        White_patch_mouth = Convert.ToBoolean(dr["White_patch_mouth"]),
                        Ulcer = Convert.ToBoolean(dr["Ulcer"]),
                        Leukoplakia = Convert.ToBoolean(dr["Leukoplakia"]),
                        Erythroplakia = Convert.ToBoolean(dr["Erythroplakia"]),
                        Extract_socket = Convert.ToBoolean(dr["Extract_socket"]),
                        Diff_chewing = Convert.ToBoolean(dr["Diff_chewing"]),
                        Diff_swallowing = Convert.ToBoolean(dr["Diff_swallowing"]),
                        Diff_speaking = Convert.ToBoolean(dr["Diff_speaking"]),
                        Diff_moving_tongue = Convert.ToBoolean(dr["Diff_moving_tongue"]),
                        Diff_spicy_food = Convert.ToBoolean(dr["Diff_spicy_food"]),
                        Change_voice = Convert.ToBoolean(dr["Change_voice"]),
                        Breast_Lump = Convert.ToBoolean(dr["Breast_Lump"]),
                        Nipple_discharge = Convert.ToBoolean(dr["Nipple_discharge"]),
                        Foul_smelling = Convert.ToBoolean(dr["Foul_smelling"]),
                        Post_coidal_bleeding = Convert.ToBoolean(dr["Post_coidal_bleeding"]),
                        Spotting = Convert.ToBoolean(dr["Spotting"]),
                        Abnormal_bleeding = Convert.ToBoolean(dr["Abnormal_bleeding"]),
                        Others = Convert.ToBoolean(dr["Others"]),
                        Others_specify = Convert.ToString(dr["Others_specify"])



                    }

                });
            }
            return main;


        }
    }
}
