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
    public  class SlotsDAL:ConnectionIntializer
    {
        public DataSet VehicleDetails(VehicleDetailsBO vehicleDetailsBO)
        {
            DataSet dsRecords = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("PK_VEHICLE_DETAILS", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId",vehicleDetailsBO.UserID);
                cmd.Parameters.AddWithValue("@VehicleNumber",vehicleDetailsBO.VehicleNumber);
                //cmd.Parameters.AddWithValue("@DOB", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@VehiclePhoto", vehicleDetailsBO.Vehiclephoto);
                cmd.Parameters.AddWithValue("@BrandName", vehicleDetailsBO.BrandName);
                cmd.Parameters.AddWithValue("@ModelType", vehicleDetailsBO.Model);
                //cmd.Parameters.AddWithValue("@ProfileImage", "Image");
                cmd.Parameters.AddWithValue("@Colour", vehicleDetailsBO.colour);
                //cmd.Parameters.AddWithValue("@IsLandLord", false);
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

        public DataSet GetAllLandDetails(String CityName)
        {
            DataSet dsRecords = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("PK_GET_ALL_LAND_DETAILS", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CITYNAME", CityName);
                
                //cmd.Parameters.AddWithValue("@IsLandLord", false);
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

        public DataSet GetLandDetails(LandDetailsBO landDetailsBO)
        {
            DataSet dsRecords = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("PK_GET_LAND_DETAILS", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LANDID", landDetailsBO.LandID);

                //cmd.Parameters.AddWithValue("@IsLandLord", false);
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

        public DataSet LandPhotoDetails(LandPhotoDetailsBO landPhotoDetailsBO)
        {
            DataSet dsRecords = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("PK_LAND_PHOTO_DETAILS", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LandId",landPhotoDetailsBO.LandId);
                cmd.Parameters.AddWithValue("@PhotoPath",landPhotoDetailsBO.PhotoPath);

                //cmd.Parameters.AddWithValue("@IsLandLord", false);
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

        public DataSet HomeSlotsDetails()
        {
            DataSet dsRecords = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("PA_SEARCH_SLOT_DETAILS", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchKeyword", "hello");
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
