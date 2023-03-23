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
    public class SlotController : ApiController
    {
        SlotsDAL slotsdal = new SlotsDAL();
        List<LandDetailsBO> landdetails = new List<LandDetailsBO>();  

        [HttpPost]
        [ActionName("VehicleDetails")]
        public void VehicleDetails(VehicleDetailsBO vehicleDetailsBO)
        {
            try
            {
                var LandDetailsBO = slotsdal.VehicleDetails(vehicleDetailsBO);
            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
        }

        [HttpGet]
        [ActionName("GetAllLandDetails")]
        public List<LandDetailsBO> GetAllLandDetails(string CityName)
        {
            try
            {
                var result = slotsdal.GetAllLandDetails(CityName);
                landdetails.Add(new LandDetailsBO { LandID = Convert.ToInt32(result.Tables[0].Rows[0][0]),
                                                    LandLordID = Convert.ToInt32(result.Tables[0].Rows[0][1]),
                                                    LandName= Convert.ToString(result.Tables[0].Rows[0][2]),
                                                    LandCoverPhoto=Convert.ToString(result.Tables[0].Rows[0][3]),
                    LandAddLn1 = Convert.ToString(result.Tables[0].Rows[0][4]),
                    LandAddLn2 = Convert.ToString(result.Tables[0].Rows[0][5]),
                    LandAddCity = Convert.ToString(result.Tables[0].Rows[0][6]),
                    LandAddState = Convert.ToString(result.Tables[0].Rows[0][7]),
                    LandAddCountry = Convert.ToString(result.Tables[0].Rows[0][8]),
                    LandAddPostalCode = Convert.ToInt64(result.Tables[0].Rows[0][9]),
                    LandSize = Convert.ToString(result.Tables[0].Rows[0][10]),
                    AvailableSlots = Convert.ToInt32(result.Tables[0].Rows[0][11]),
                    PriceForHours = Convert.ToDouble(result.Tables[0].Rows[0][12]),
                    PriceForDays = Convert.ToDouble(result.Tables[0].Rows[0][13]),
                    Features = Convert.ToString(result.Tables[0].Rows[0][14]),
                    Ratings = Convert.ToDouble(result.Tables[0].Rows[0][15]),
                });
                var test = landdetails;
            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
            return landdetails; 
        }

        [HttpGet]
        [ActionName("GetLandDetails")]
        public void GetLandDetails(LandDetailsBO landDetailsBO)
        {
            try
            {
                var LandDetailsBO = slotsdal.GetLandDetails(landDetailsBO);
            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
        }

        [HttpGet]
        [ActionName("LandPhotoDetails")]
        public void LandPhotoDetails(LandPhotoDetailsBO landPhotoDetailsBO)
        {
            try
            {
                var LandDetailsBO = slotsdal.LandPhotoDetails(landPhotoDetailsBO);
            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
        }

        [HttpGet]
        [ActionName("HomeSlotsDetails")]
        public void HomeSlotsDetails()
        {
            try
            {
                var LandDetailsBO = slotsdal.HomeSlotsDetails();
            }
            catch (Exception ex)
            {
                //writeExceptionDAL.WriteException("API", "LogInUser() : " + ex.ToString());
            }
        }
    }
}
