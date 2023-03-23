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
    public class LLController : ApiController
    {
        LLDAL llDAL = new LLDAL();

        [HttpGet]
        [ActionName("LandLordLogin")]
        public void LandLordLogin(string EmailID, string Password)
        {
            try
            {
                var LandDetailsBO = llDAL.LandLordLogin(EmailID,Password);
            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
        }

        [HttpGet]
        [ActionName("LandLordRegister")]
        public void LandLordRegister(LLProfileBO lLProfileBO)
        {
            try
            {
                var LandDetailsBO = llDAL.LandLordRegister(lLProfileBO);
            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
        }


        [HttpGet]
        [ActionName("AddLandDetails")]
        public void AddLandDetails(LandDetailsBO landDetailsBO)
        {
            try
            {
                var LandDetailsBO = llDAL.AddLandDetails(landDetailsBO);
            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
        }


        [HttpPost]
        [ActionName("LLBankDetails")]
        public bool  LLBankDetails(BankingDetailsBO bankingDetailsBO)
        {
            bool bankExist = false;
            try
            {
                 bankExist = llDAL.LLBankDetails(bankingDetailsBO);
            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
            return bankExist;
        }

        [HttpPost]
        [ActionName("LLEdit")]
        public void LLEdit(LLProfileBO llprofileBO)
        {
            try
            {
                var profileBO = llDAL.LLEdit(llprofileBO);
            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
        }

        [HttpPost]
        [ActionName("LLProof")]
        public void LLProof(ProofDetailsBO proofDetailsBO)
        {
            try
            {
                var profileBO = llDAL.LLProof(proofDetailsBO);
            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
        }
    }
}
