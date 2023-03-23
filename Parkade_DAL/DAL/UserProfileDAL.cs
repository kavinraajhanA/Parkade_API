using Parkade_DAL.BO;
using System.Data.SqlClient;
using System.Data;
using System;

namespace Parkade_DAL.DAL
{
    public class UserProfileDAL : ConnectionIntializer
    {
        public DataSet UserLogin(string username, string password)
        {
            DataSet dsRecords = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("PK_USER_LOGIN", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@USERNAME", username);
                cmd.Parameters.AddWithValue("@PASSWORD", password);
                cmd.Parameters.AddWithValue("@IsLandLord", false);
                cmd.Parameters.Add("@USERISEXIST", SqlDbType.Bit, 50).Direction = ParameterDirection.Output;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                if (dbConnection.State == ConnectionState.Closed)
                {
                    dbConnection.Open();
                    cmd.ExecuteNonQuery();
                    bool userExist = (bool)cmd.Parameters["@USERISEXIST"].Value;
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

        public DataSet RegisterUser(UserProfileBO userProfileBO)
        {
            DataSet dsRecords = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("PK_USER_REGISTER", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@USERNAME", userProfileBO.UserName);
                cmd.Parameters.AddWithValue("@ADDRESS", userProfileBO.UserAddress);
                cmd.Parameters.AddWithValue("@DOB", userProfileBO.UserDOB);
                cmd.Parameters.AddWithValue("@UserEmail", userProfileBO.UserEmail);
                cmd.Parameters.AddWithValue("@UserPhone", userProfileBO.UserPhone);
                cmd.Parameters.AddWithValue("@IsOTPVerified", false);
                cmd.Parameters.AddWithValue("@UserPassword", userProfileBO.UserPassword);
                cmd.Parameters.AddWithValue("@UserProfileImage", userProfileBO.UserProfileImage);
                cmd.Parameters.Add("@USERISEXIST", SqlDbType.Bit, 50).Direction = ParameterDirection.Output;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                if (dbConnection.State == ConnectionState.Closed)
                {
                    dbConnection.Open();
                    cmd.ExecuteNonQuery();
                    bool userExist = (bool)cmd.Parameters["@USERISEXIST"].Value;
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

        public DataSet SavePass(UserProfileBO userProfileBO)
        {
            DataSet dsRecords = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("PA_FORGOT_PASSWORD", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId",userProfileBO.UserID);
                cmd.Parameters.AddWithValue("@NewPassword",userProfileBO.UserPassword);
                cmd.Parameters.AddWithValue("@IsLandLord", false);
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

        public DataSet GetUserBookingHistory(UserBookingHistory userBookingHistory)
        {
            DataSet dsRecords = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("PK_GET_USER_BOOKING_HISTORY", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@USERID", userBookingHistory.UserID);
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

        public DataSet UserEdit(UserProfileBO userProfileBO)
        {
            DataSet dsRecords = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("PK_UPDATE_USER_DETAIL", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@USERID",userProfileBO.UserID);
                cmd.Parameters.AddWithValue("@USERNAME", userProfileBO.UserName);
                cmd.Parameters.AddWithValue("@DOB",userProfileBO.UserDOB);
                cmd.Parameters.AddWithValue("@UserEmail",userProfileBO.UserEmail);
                cmd.Parameters.AddWithValue("@UserMobile",userProfileBO.UserPhone);
                cmd.Parameters.AddWithValue("@ADDRESS", userProfileBO.UserAddress);
                cmd.Parameters.AddWithValue("@UserProfileImage",userProfileBO.UserProfileImage);
                cmd.Parameters.AddWithValue("@UserPassword", userProfileBO.UserPassword);
                cmd.Parameters.AddWithValue("@IsOTPVerified", userProfileBO.IsOtpVerifed);
                cmd.Parameters.AddWithValue("@IsLandLord", false);
                cmd.Parameters.Add("@USEREXIST", SqlDbType.Bit, 50).Direction = ParameterDirection.Output;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                if (dbConnection.State == ConnectionState.Closed)
                {
                    dbConnection.Open();
                    cmd.ExecuteNonQuery();
                    bool userExist = (bool)cmd.Parameters["@USEREXIST"].Value;
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

        public DataSet LicUpdate(ProofDetailsBO proofDetailsBO)
        {
            DataSet dsRecords = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("PK_PROOF_DETAILS", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID",proofDetailsBO.UserID);
                cmd.Parameters.AddWithValue("@LandLordID",proofDetailsBO.LLID);
                cmd.Parameters.AddWithValue("@UsrLicFrontImage",proofDetailsBO.UserLicFrontImage);
                cmd.Parameters.AddWithValue("@UsrLicBackImage",proofDetailsBO.UserLicBackImage);
                cmd.Parameters.AddWithValue("@UsrLicValidTillDate",proofDetailsBO.UserLicValidTillDate);
                cmd.Parameters.AddWithValue("@LLAnotherProof",proofDetailsBO.LLAnotherproof);
                cmd.Parameters.AddWithValue("@LLTaxProof", proofDetailsBO.LLTaxProof);
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
    }
}
