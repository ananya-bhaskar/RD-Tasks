using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{
    class DataStore : IDisposable
    {
        private bool isDisposed = false;
        private SqlConnection sqlConn;
        private String sql;
        private SqlCommand command;
        private string[] UserNames;
        private string[] UserEmailIds;
        public DataStore(string[] name,string[] email)
        {
            UserNames = name;
            UserEmailIds = email;
        }
        public void StoreData()
        {
            sqlConn = new SqlConnection(@"Data Source=EPINHYDW1424\MSSQLSERVER1;Initial Catalog=UserDetails;Integrated Security=True");
            using (sqlConn)
            {                
                sqlConn.Open();
                Console.WriteLine("connection made!!");
                int len = UserNames.Length;
                for (int i = 0; i < len; i++)
                {
                    sql = "insert into userData(firstname,email) values('" + UserNames[i] + "','" + UserEmailIds[i] + "')";
                    using (command = new SqlCommand(sql, sqlConn))
                    {
                        command.ExecuteNonQuery();
                    }                        
                }
            }            
            Console.WriteLine("Records successfully inserted into database!!");                      
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public virtual void Dispose(bool isDisposing)
        {
            if (isDisposed)
                return;
            if(isDisposing)
            {
                sql = null;                
                UserNames = null;
                UserEmailIds = null;                
            }            
            isDisposed = true;
            Console.WriteLine("Disposed Resources Successfully!!");
            Console.Read();
        }
    }
}
