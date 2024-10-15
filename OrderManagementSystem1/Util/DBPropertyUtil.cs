using System.IO;

namespace util
{
    public static class DBPropertyUtil
    {
        public static string GetPropertyString(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            string connectionString = "Server=localhost;Database=OrderManagementDB;Integrated Security=True;";
";

            foreach (var line in lines)
            {
                if (line.StartsWith("ConnectionString"))
                {
                    connectionString = line.Split('=')[1].Trim();
                    break;
                }
            }
            return connectionString;
        }
    }
}
