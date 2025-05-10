using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ITIDB_Form_in_NTiers
{
    class DBQuery
    {
        // 1. Define Conniction
        private readonly static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["iticon"].ConnectionString);

        // Select
        public static DataTable Select(string query)
        {
            // 2. Define Command
            SqlCommand cmd = new SqlCommand(query, conn);

            // 3. Define Adapter
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            // 4. Define Data Table
            DataTable DT = new DataTable();

            // 5. Fill Data Table
            adapter.Fill(DT);

            // 6. Bind Data
            return DT;
        }

        // DML
        public static int DML(string query)
        {
            // 2. Define Command
            SqlCommand cmd = new SqlCommand(query, conn);

            // 3. Open Connection
            conn.Open();
            int affectedRows;
            try
            {
                // 4. Execute Command
                affectedRows = cmd.ExecuteNonQuery();
            }
            finally
            {
                // 6. Close Connections
                conn.Close();
            }

            // 5. Bind Data
            return affectedRows;
        }
    }
}
