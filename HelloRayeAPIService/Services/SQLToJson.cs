using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace HelloRayeAPIService.Services
{
    public class SQLToJson
    {
        public static string Execute(string sqlConnection, string sqlQuery)
        {
            var dataTable = new DataTable();

            SqlConnection cnn = new SqlConnection(sqlConnection); // replace with your database connection
            

            SqlCommand cmd = new SqlCommand(sqlQuery, cnn);

            cnn.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dataTable);
            var json = DataTableToJSONWithJSONNet(dataTable);


            cnn.Close();

            return json;
        }
        public static string DataTableToJSONWithJSONNet(DataTable table)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(table);
            return JSONString;
        }
    }
}
