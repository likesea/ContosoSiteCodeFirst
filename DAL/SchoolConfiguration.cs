using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.SqlServer;
using System.Data.Entity;
namespace ContosoSiteCodeFirst.DAL
{
    public class SchoolConfiguration :DbConfiguration
    {
        public SchoolConfiguration ()
        {
            SetExecutionStrategy("System.Data.SqlClient",()=>
                new   SqlAzureExecutionStrategy());
        }
    }
}