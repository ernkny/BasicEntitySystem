using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess.Connection
{
    
    public class ProjectConStr
    {
        private string _connectionStr = @"Server=(localdb)\MSSQLLocalDB;Database=TechnologyStuff;Trusted_Connection=true";
           public string getConstr()
        {
            return _connectionStr;
        }
       
    }
}
