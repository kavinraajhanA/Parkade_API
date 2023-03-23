using System.Configuration;
using System.Data.SqlClient;

namespace Parkade_DAL.DAL
{
    public class ConnectionIntializer
    {
        public SqlConnection dbConnection;
        public ConnectionIntializer()
        {
            try
            {
                if (dbConnection == null)
                {
                    dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ToString());
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
