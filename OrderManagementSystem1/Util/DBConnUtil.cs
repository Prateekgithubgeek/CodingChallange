using System.Data.SqlClient;

namespace util
{
    public static class DBConnUtil
    {
        public static SqlConnection GetDBConn()
        {
            string connectionString = DBPropertyUtil.GetPropertyString("dbConfig.properties");
            return new SqlConnection(connectionString);
        }
    }
}
