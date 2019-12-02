using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL_TOUR
{
    public class Config
    {
        static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public Config()
        {
           
        }

        //Get connection string from App.Config file
        public static string GetConnectionString()
        {
            return config.ConnectionStrings.ConnectionStrings["DB_TOUREntities"].ConnectionString;
        }
        public int Check_Config()
        {
            string connectionString = GetConnectionString();
            string[] parts = connectionString.Split(';');
            string dataSourcestr = "";
            string database = "";
            string user = "";
            string password = "";
            bool c = false;
            for (int i = 0; i < parts.Length; i++)
            {
                string part = parts[i].Trim();
                if (part.StartsWith("provider connection string="))
                {
                    dataSourcestr = part.Replace("provider connection string=", "");
                }
                if (part.StartsWith("data source="))
                {
                    dataSourcestr = part.Replace("data source=", "");
                    c = true;
                }
                if (part.StartsWith("initial catalog="))
                {
                    database = part.Replace("initial catalog=", "");
                }
                if(part.StartsWith("user id="))
                {
                    user = part.Replace("user id=","");
                }
                if (part.StartsWith("password="))
                {
                    password = part.Replace("password=", "");
                }

            }
            string datasource = "";
            if (c)
            {
                datasource = dataSourcestr;
            }
            else
            {
                string[] partpass = dataSourcestr.Split('=');
                datasource = partpass[1].Trim();
            }
            

            string connect = "Data Source="+ datasource + ";Initial Catalog="+database+";User ID="+user+";Password="+password;
            SqlConnection _Sqlconn = new SqlConnection(connect);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;// Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2;// Chuỗi cấu hình không phù hợp.
            }
        }



        //Save connection string to App.config file
        public static void SaveConnectionString(string pServerName, string pDataBase, string pUsername, string pPass)
        {
            string c = GetConnectionString();
            string value = "metadata=res://*/TourModel.csdl|res://*/TourModel.ssdl|res://*/TourModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=" + pServerName + ";initial catalog=" + pDataBase + ";user id=" + pUsername + ";password=" + pPass + ";MultipleActiveResultSets=True;App=EntityFramework&quot;";
            config.ConnectionStrings.ConnectionStrings["DB_TOUREntities"].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings["DB_TOUREntities"].ProviderName = "System.Data.EntityClient";
            config.Save(ConfigurationSaveMode.Modified);
            //ConfigurationManager.RefreshSection(config.ConnectionStrings.SectionInformation.SectionName);
            ConfigurationManager.RefreshSection("ConnectionStrings");
            
            
        }
    }
}
