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
    public class MenuController : ApiController
    {
        MenuDAL menuDAL=new MenuDAL();
        [HttpGet]
        [ActionName("Notification")]
        public void Notification(NotificationBO notificationBO)
        {
            try
            {
                var profileBO = menuDAL.Notification(notificationBO);  
            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
        }
    }
}
