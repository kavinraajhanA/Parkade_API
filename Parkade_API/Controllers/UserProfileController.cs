using Parkade_DAL.BO;
using Parkade_DAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Parkade_API.Controllers
{
    public class UserProfileController : ApiController
    {
        UserProfileBO profileBO=new UserProfileBO();
        UserProfileDAL userProfileDAL = new UserProfileDAL();
        List<LandDetailsBO> landDetailsBO=new List<LandDetailsBO>();

        [HttpGet]
        [ActionName("LogInUser")]
        public UserProfileBO LogInUser(string EmailID, string Password)
        {
            try
            {
                var res = userProfileDAL.UserLogin(EmailID,Password);
                profileBO.UserID = Convert.IsDBNull(res.Tables[0].Rows[0]["User_ID"]) ? 0 : Convert.ToInt32(res.Tables[0].Rows[0]["User_ID"]);
                profileBO.UserName = Convert.IsDBNull(res.Tables[0].Rows[0]["User_Name"]) ? "" : Convert.ToString(res.Tables[0].Rows[0]["User_Name"]);
                profileBO.UserEmail = Convert.IsDBNull(res.Tables[0].Rows[0]["User_Email"]) ? "" : Convert.ToString(res.Tables[0].Rows[0]["User_Email"]);
                profileBO.UserPhone = Convert.IsDBNull(res.Tables[0].Rows[0]["User_Phone"]) ? 0 : Convert.ToInt64(res.Tables[0].Rows[0]["User_Phone"]);
                profileBO.UserDOB = Convert.IsDBNull(res.Tables[0].Rows[0]["User_DOB"]) ? DateTime.MinValue : Convert.ToDateTime(res.Tables[0].Rows[0]["User_DOB"]);
                profileBO.UserAddress = Convert.IsDBNull(res.Tables[0].Rows[0]["User_Address"]) ? "" : Convert.ToString(res.Tables[0].Rows[0]["User_Address"]);

            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
            return profileBO;
        }

        [HttpPost]
        [ActionName("RegisterUser")]
        public void RegisterUser(UserProfileBO userProfileBO)
        {
            try
            {
                var profileBO = userProfileDAL.RegisterUser(userProfileBO);
            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
        }

        [HttpGet]
        [ActionName("SavePass")]
        public void SavePass(UserProfileBO userProfileBO)
        {
            try
            {
                var profileBO = userProfileDAL.SavePass(userProfileBO);
            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
        }

        [HttpGet]
        [ActionName("GetUserBookingHistory")]
        public void GetUserBookingHistory(UserBookingHistory userBookingHistory)
        {
            try
            {
                var profileBO = userProfileDAL.GetUserBookingHistory(userBookingHistory);
            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
        }

        [HttpPost]
        [ActionName("UserEdit")]
        public void UserEdit(UserProfileBO userProfileBO)
        {
            try
            {
                var profileBO = userProfileDAL.UserEdit(userProfileBO);
            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
        }

        [HttpPost]
        [ActionName("LicUpdate")]
        public void LicUpdate(ProofDetailsBO proofDetailsBO)
        {
            try
            {
                var profileBO = userProfileDAL.LicUpdate(proofDetailsBO);
            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
        }
    }
}
