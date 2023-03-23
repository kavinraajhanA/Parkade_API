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
    public class MenuDAL:ConnectionIntializer
    {
        public DataSet Notification(NotificationBO notificationBO)
        {
            DataSet dsRecords = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("PK_NOTIFICATION", dbConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NotificationId",notificationBO.NotificationId);
                cmd.Parameters.AddWithValue("@Notification",notificationBO.NotificationContent);
                cmd.Parameters.AddWithValue("@IsRead", false);
                cmd.Parameters.AddWithValue("@IsUser", false);
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
