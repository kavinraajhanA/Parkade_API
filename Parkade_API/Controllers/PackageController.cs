using Parkade_DAL.BO;
using Parkade_DAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;

namespace Parkade_API.Controllers
{
    public class PackageController : ApiController
    {
        PackageDAL packageDAL = new PackageDAL();

        [HttpGet]
        [ActionName("Subscription")]
        public void Subscription(UserSubscriptionDetailsBO userSubscriptionDetailsBO)
        {
            try
            {
                var profileBO = packageDAL.Subscription(userSubscriptionDetailsBO);
            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
        }

        [HttpGet]
        [ActionName("Membership")]
        public void Membership(MembershipDetailsBO membershipDetailsBO)
        {
            try
            {
                var profileBO = packageDAL.Membership(membershipDetailsBO);
            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
        }

        [HttpGet]
        [ActionName("Plan")]
        public void Plan(PlanDetailsBO planDetailsBO)
        {
            try
            {
                var profileBO = packageDAL.Plan(planDetailsBO);
            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
        }
    }
}