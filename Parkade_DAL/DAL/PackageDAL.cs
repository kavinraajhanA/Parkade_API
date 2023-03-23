using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parkade_DAL.BO;

namespace Parkade_DAL.DAL
{
    public class PackageDAL : ConnectionIntializer
    {
        public DataSet Subscription(UserSubscriptionDetailsBO userSubscriptionDetailsBO)
        {
            DataSet dsRecords = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("PK_SUBSCRRIPTION_DETAILS", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId",userSubscriptionDetailsBO.UserID);
                cmd.Parameters.AddWithValue("@MembershipId",userSubscriptionDetailsBO.MembershipID);
                cmd.Parameters.AddWithValue("@PlanId",userSubscriptionDetailsBO.PlanID);
                cmd.Parameters.AddWithValue("@PlanActivationDate",userSubscriptionDetailsBO.PlanActivationDate);
                cmd.Parameters.AddWithValue("@PlanActiveState",userSubscriptionDetailsBO.PlanActiveStatus);
                cmd.Parameters.AddWithValue("@PlanExpiryDate",userSubscriptionDetailsBO.PlanExpiryDate);
                cmd.Parameters.AddWithValue("@ActualPrice",userSubscriptionDetailsBO.ActualPrice);
                cmd.Parameters.AddWithValue("@CommissionAmount",userSubscriptionDetailsBO.CommissionAmount);
                cmd.Parameters.AddWithValue("@CompanyPrice",userSubscriptionDetailsBO.CompanyPrice);
                cmd.Parameters.AddWithValue("@TranscationId",userSubscriptionDetailsBO.TranscationID);
                cmd.Parameters.AddWithValue("@TranscationDateTime",userSubscriptionDetailsBO.TranscationDateTime);
                cmd.Parameters.AddWithValue("@TranscationType",userSubscriptionDetailsBO.TranscationType);
                cmd.Parameters.AddWithValue("@OfferCode",userSubscriptionDetailsBO.Offercode);
                cmd.Parameters.AddWithValue("@OfferPrice", userSubscriptionDetailsBO.Offerprice);
                cmd.Parameters.AddWithValue("@TotalPrice",userSubscriptionDetailsBO.TotalPrice);
                /*cmd.Parameters.AddWithValue("@CreatedBy", false);
                cmd.Parameters.AddWithValue("@CreatedDateTime", false);
                cmd.Parameters.AddWithValue("@ModifiedBy", false);
                cmd.Parameters.AddWithValue("@ModifiedDateTime", false);
                cmd.Parameters.AddWithValue("@DeleteFlag", false);
                cmd.Parameters.AddWithValue("@SUBSCRIPTIONEXIST", false);*/
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

        public DataSet Membership(MembershipDetailsBO membershipDetailsBO)
        {
            DataSet dsRecords = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("PK_MEMBERSHIP", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId",membershipDetailsBO.UserId);
                cmd.Parameters.AddWithValue("@MembershipActivationDate",membershipDetailsBO.MembershipActivationDate);
                cmd.Parameters.AddWithValue("@MembershipStatus",membershipDetailsBO.MembershipStatus);
                cmd.Parameters.AddWithValue("@MembershipExpiryDate",membershipDetailsBO.MembershipExpiryDate);
                cmd.Parameters.AddWithValue("@MembershipFee",membershipDetailsBO.MembershipFee);
                
                
                cmd.Parameters.AddWithValue("@LastExpiryDate",membershipDetailsBO.LastExpiryDate);
               
                cmd.Parameters.AddWithValue("@TranscationId",membershipDetailsBO.TransactionId);
                cmd.Parameters.AddWithValue("@TranscationDateTime",membershipDetailsBO.TransactionDate);
                cmd.Parameters.AddWithValue("@TranscationType",membershipDetailsBO.TransactionType);
             
               /*cmd.Parameters.AddWithValue("@CreatedBy", false);
                cmd.Parameters.AddWithValue("@CreatedDateTime", false);
                cmd.Parameters.AddWithValue("@ModifiedBy", false);
                cmd.Parameters.AddWithValue("@ModifiedDateTime", false);
                cmd.Parameters.AddWithValue("@DeleteFlag", false);
                cmd.Parameters.AddWithValue("@MemberExist", false);*/
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

        public DataSet Plan(PlanDetailsBO planDetailsBO)
        {
            DataSet dsRecords = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("PK_PLAN_DETAILS", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LandLordId",planDetailsBO.LLId);
                cmd.Parameters.AddWithValue("@LandId",planDetailsBO.LandId);
                cmd.Parameters.AddWithValue("@PlanName",planDetailsBO.PlanName);
                cmd.Parameters.AddWithValue("@NoOfMonths",planDetailsBO.NoOfMonths);
                cmd.Parameters.AddWithValue("@ExtraOffer",planDetailsBO.Extraoffer);


                cmd.Parameters.AddWithValue("@PlanAmount",planDetailsBO.PlanAmount);

                cmd.Parameters.AddWithValue("@CommissionAmount",planDetailsBO.CommissionAmount);
                cmd.Parameters.AddWithValue("@CompanyPrice",planDetailsBO.CompanyPrice);
                

                /*cmd.Parameters.AddWithValue("@CreatedBy", false);
                cmd.Parameters.AddWithValue("@CreatedDateTime", false);
                cmd.Parameters.AddWithValue("@ModifiedBy", false);
                cmd.Parameters.AddWithValue("@ModifiedDateTime", false);
                cmd.Parameters.AddWithValue("@DeleteFlag", false);
                cmd.Parameters.AddWithValue("@PLANEXIST", false);*/
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
