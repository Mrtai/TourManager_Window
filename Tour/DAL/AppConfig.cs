using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    class AppConfig
    {
        Configuration config;

        public AppConfig()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        //Get connection string from App.Config file
        public string GetConnectionString()
        {
            return config.ConnectionStrings.ConnectionStrings["DB_TOUREntities"].ConnectionString;
        }

        //Save connection string to App.config file
        public void SaveConnectionString(string pServerName,string pDataBase, string pUsername,string pPass)
        {
            string value = "metadata=res://*/TourModel.csdl|res://*/TourModel.ssdl|res://*/TourModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source="+pServerName+";initial catalog="+pDataBase+";user id="+pUsername+";password="+pPass+";MultipleActiveResultSets=True;App=EntityFramework&quot;";
            config.ConnectionStrings.ConnectionStrings["DB_TOUREntities"].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings["DB_TOUREntities"].ProviderName = "System.Data.EntityClient";
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
