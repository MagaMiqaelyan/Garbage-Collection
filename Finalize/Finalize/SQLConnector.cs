using System;
using System.Data;
using System.Data.SqlClient;

namespace Finalize
{
    public class SQLConnector : IDisposable
    {
        string connectionString = "Data Source=(local);" +
                     "Initial Catalog=AdventureWorks_Final;" +
                     "Integrated Security=true";
        private SqlConnection sqlConn = null;

        /// <summary>
        /// Constructor
        /// </summary>
        public SQLConnector()
        {
            sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
        }

        public DataSet GetData()
        {
            //Add the code to retireve some data from the DataBase
            return new DataSet();
        }

        public void PutData()
        {
            //Add the code to update the data base
        }

        ~SQLConnector()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                GC.SuppressFinalize(this);
            }
            ReleaseNativeResource();
        }

        private void ReleaseNativeResource()
        {
            sqlConn.Dispose();
        }
    }
}
