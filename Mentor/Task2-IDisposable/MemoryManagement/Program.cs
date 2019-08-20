using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[] { "Ananya", "Bannu", "Snigdha" };
            string[] emails = new string[] { "ana@gmail.com", "buns@gmail.com", "snig@gmail.com" };
            using (DataStore ds = new DataStore(name, emails))
            {
                ds.StoreData();
            }                            
        }
    }
}
