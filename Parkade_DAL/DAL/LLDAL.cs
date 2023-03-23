using System;
using System.Data.SqlClient;
using System.Data;
using Parkade_DAL.BO;

namespace Parkade_DAL.DAL
{
    public class LLDAL:ConnectionIntializer 
    {
        public DataSet LandLordLogin(string username, string password)
        {
            DataSet dsRecords = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("PK_LANDLORD_LOGIN", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LLUSERNAME", username);
                cmd.Parameters.AddWithValue("@LLPASSWORD", password);
                cmd.Parameters.AddWithValue("@LLUSERISEXIST", false);
                cmd.Parameters.Add("@LLUSERISEXIST", SqlDbType.Bit, 50).Direction = ParameterDirection.Output;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                if (dbConnection.State == ConnectionState.Closed)
                {
                    dbConnection.Open();
                    cmd.ExecuteNonQuery();
                    bool userExist = (bool)cmd.Parameters["@LLUSERISEXIST"].Value;
                }
                da.Fill(dsRecords);
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dbConnection.Close();
            }
            return dsRecords;
        }

        public DataSet LandLordRegister(LLProfileBO lLProfileBO)
        {
            DataSet dsRecords = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("PK_LANDLORD_REGISTER", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LandLordName",lLProfileBO.LLName);
                cmd.Parameters.AddWithValue("@LandLordAddress", lLProfileBO.LLAddress);
                cmd.Parameters.AddWithValue("@LandLordDOB", lLProfileBO.LLDOB);
                cmd.Parameters.AddWithValue("@LandLordEmail", lLProfileBO.LLEmail);
                cmd.Parameters.AddWithValue("@LandLordPhone", lLProfileBO.LLPhone);
                cmd.Parameters.AddWithValue("@IsOTPVerified", lLProfileBO.IsOtpVerifed);
                cmd.Parameters.AddWithValue("@LandLordProfileImage", lLProfileBO.LLProfileImage);
                cmd.Parameters.AddWithValue("@LandLordPassword", lLProfileBO.LLPassword);
                //cmd.Parameters.AddWithValue("@IsLandLord", false);
                cmd.Parameters.Add("@IsUserExist", SqlDbType.Bit, 50).Direction = ParameterDirection.Output;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                if (dbConnection.State == ConnectionState.Closed)
                {
                    dbConnection.Open();
                    cmd.ExecuteNonQuery();
                    bool userExist = (bool)cmd.Parameters["@IsUserExist"].Value;
                }
                da.Fill(dsRecords);
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dbConnection.Close();
            }
            return dsRecords;
        }
        public DataSet AddLandDetails(LandDetailsBO landDetailsBO)
        {
            DataSet dsRecords = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("PK_LAND_DETAILS", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LandLordId",landDetailsBO.LandLordID);
                cmd.Parameters.AddWithValue("@LandName",landDetailsBO.LandName);
                //cmd.Parameters.AddWithValue("@DOB", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@LandCoverPhoto", landDetailsBO.LandCoverPhoto);
                cmd.Parameters.AddWithValue("@LandAddressLine1", landDetailsBO.LandAddLn1);
                cmd.Parameters.AddWithValue("@LandAddressLine2", landDetailsBO.LandAddLn2);
                cmd.Parameters.AddWithValue("@LandAddressCity", landDetailsBO.LandAddCity);
                cmd.Parameters.AddWithValue("@LandAddressState", landDetailsBO.LandAddState);
                cmd.Parameters.AddWithValue("@LandAddressCountry", landDetailsBO.LandAddCountry);
                cmd.Parameters.AddWithValue("@LandAddressPostalcode", landDetailsBO.LandAddPostalCode);
                cmd.Parameters.AddWithValue("@LandSize", landDetailsBO.LandSize);
                cmd.Parameters.AddWithValue("@AvailableSlots", landDetailsBO.AvailableSlots);
                cmd.Parameters.AddWithValue("@PriceForHour", landDetailsBO.PriceForHours);
                cmd.Parameters.AddWithValue("@PriceForDay",landDetailsBO.PriceForDays);
                cmd.Parameters.AddWithValue("@Features",landDetailsBO.Features);
                cmd.Parameters.AddWithValue("@Ratings",landDetailsBO.Ratings);
                cmd.Parameters.AddWithValue("@onemnth",landDetailsBO.onemnth);
                cmd.Parameters.AddWithValue("@threemnth",landDetailsBO.threemnth);
                cmd.Parameters.AddWithValue("@sixmnth",landDetailsBO.sixmnth);
                cmd.Parameters.AddWithValue("@CCTV",landDetailsBO.CCTV);
                cmd.Parameters.AddWithValue("@Security",landDetailsBO.Security);
                cmd.Parameters.AddWithValue("@Alarm",landDetailsBO.Alarm);
                cmd.Parameters.AddWithValue("@FireExtinguish",landDetailsBO.FireExtinguish);
                cmd.Parameters.AddWithValue("@fullDay",landDetailsBO.fullDay);
                //cmd.Parameters.Add("@IsUserExist", SqlDbType.Bit, 50).Direction = ParameterDirection.Output;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                if (dbConnection.State == ConnectionState.Closed)
                {
                    dbConnection.Open();
                    cmd.ExecuteNonQuery();
                    //bool userExist = (bool)cmd.Parameters["@IsUserExist"].Value;
                }
                da.Fill(dsRecords);
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dbConnection.Close();
            }
            return dsRecords;
        }

        public bool LLBankDetails(BankingDetailsBO bankingDetailsBO)
        {
            DataSet dsRecords = new DataSet();
            bool userExist = false;
            try
            {
                SqlCommand cmd = new SqlCommand("PK_LL_BANK_DETAILS", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LandLordId",bankingDetailsBO.LlId);
                cmd.Parameters.AddWithValue("@BankName",bankingDetailsBO.BankName);
                cmd.Parameters.AddWithValue("@AccountHolderName",bankingDetailsBO.AccountHolderName);
                cmd.Parameters.AddWithValue("@AccountNumber",bankingDetailsBO.AccountNumber);
                cmd.Parameters.AddWithValue("@IFSCCode",bankingDetailsBO.IFSCCode);
                cmd.Parameters.Add("@LLBankExist", SqlDbType.Bit, 50).Direction = ParameterDirection.Output;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                if (dbConnection.State == ConnectionState.Closed)
                {
                    dbConnection.Open();
                    cmd.ExecuteNonQuery();
                    userExist = (bool)cmd.Parameters["@LLBankExist"].Value;
                }
                da.Fill(dsRecords);
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dbConnection.Close();
            }
            return userExist;
        }

        public DataSet LLEdit(LLProfileBO llprofileBO)
        {
            DataSet dsRecords = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("PK_UPDATE_LANLORD_DETAILS", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LandLordId",llprofileBO.LLID);
                cmd.Parameters.AddWithValue("@LandLordName", llprofileBO.LLName);
                cmd.Parameters.AddWithValue("@LandLordDOB", llprofileBO.LLDOB);
                cmd.Parameters.AddWithValue("@LandLordEmail", llprofileBO.LLEmail);
                cmd.Parameters.AddWithValue("@LandLordAddress", llprofileBO.LLAddress);
                cmd.Parameters.AddWithValue("@LandLordProfileImage", llprofileBO.LLProfileImage);
                cmd.Parameters.AddWithValue("@IsOTPverified", llprofileBO.IsOtpVerifed);
                cmd.Parameters.AddWithValue("@IsLandLord", false);
                cmd.Parameters.Add("@LANDLORDEXIST", SqlDbType.Bit, 50).Direction = ParameterDirection.Output;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                if (dbConnection.State == ConnectionState.Closed)
                {
                    dbConnection.Open();
                    cmd.ExecuteNonQuery();
                    bool userExist = (bool)cmd.Parameters["@LANDLORDEXIST"].Value;
                }
                da.Fill(dsRecords);
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dbConnection.Close();
            }
            return dsRecords;
        }

        public DataSet LLProof(ProofDetailsBO proofDetailsBO)
        {
            DataSet dsRecords = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("PK_UPDATE_LANLORD_DETAILS", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LLTaxProof",proofDetailsBO.LLTaxProof );
                cmd.Parameters.AddWithValue("@LLAnotherProof", proofDetailsBO.LLAnotherproof);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                if (dbConnection.State == ConnectionState.Closed)
                {
                    dbConnection.Open();
                    cmd.ExecuteNonQuery();
                    //bool userExist = (bool)cmd.Parameters["@LANDLORDEXIST"].Value;
                }
                da.Fill(dsRecords);
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dbConnection.Close();
            }
            return dsRecords;
        }
    }
}
