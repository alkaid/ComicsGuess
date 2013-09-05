using System;
using System.Configuration;
namespace Maticsoft.DBUtility
{
    
    public class PubConstant
    {        
        private static string connStr=null;
        private static string dbPath = null;
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        public static string ConnectionString
        {           
            get 
            {
                //string _connectionString = ConfigurationManager.AppSettings["ConnectionString"];       
                //string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
                //if (ConStringEncrypt == "true")
                //{
                //    _connectionString = DESEncrypt.Decrypt(_connectionString);
                //}
                //return _connectionString; 
                if (null == connStr)
                {
                    throw new Exception("The connection string is null!Plese set DbPath before use ConnectionString");
                }
                else
                {
                    return connStr;
                }
            }
            set
            {
                connStr = value;
            }
        }

        public static string DbPath
        {
            get
            {
                return dbPath;
            }
            set
            {
                dbPath = value;
                connStr="Data Source="+dbPath+";Version=3;";
            }
        }



        /// <summary>
        /// 得到web.config里配置项的数据库连接字符串。
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string configName)
        {
            string connectionString = ConfigurationManager.AppSettings[configName];
            string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
            if (ConStringEncrypt == "true")
            {
                connectionString = DESEncrypt.Decrypt(connectionString);
            }
            return connectionString;
        }


    }
}
