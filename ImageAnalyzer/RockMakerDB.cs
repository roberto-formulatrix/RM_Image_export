using RockMakerModel;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace ImageAnalyzer
{
    internal class RockMakerDB
    {
        private static string _pathToRM;

        public static RockMakerEntities Instance { get; private set; }

        public static void Connect(string pathToRM)
        {
            RockMakerDB._pathToRM = pathToRM;
            RockMakerDB.Instance = new RockMakerEntities();
            RockMakerDB.Instance.Database.Connection.ConnectionString = RockMakerDB.BuildConnectionString(RockMakerDB._pathToRM);
        }

        private static string BuildConnectionString(string pathToRM)
        {
            pathToRM = Path.HasExtension(pathToRM) ? pathToRM : Path.Combine(pathToRM, "RockMaker.exe");
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder("MultipleActiveResultSets=True;App=AutoScoreInspection");
            KeyValueConfigurationCollection settings = ConfigurationManager.OpenExeConfiguration(pathToRM).AppSettings.Settings;
            connectionStringBuilder.DataSource = settings["RockMaker.Database.ServerName"].Value;
            connectionStringBuilder.InitialCatalog = settings["RockMaker.Database.Name"].Value;
            connectionStringBuilder.IntegratedSecurity = bool.Parse(settings["RockMaker.Database.UseWindowsAuthentication"].Value);
            if (!connectionStringBuilder.IntegratedSecurity)
            {
                connectionStringBuilder.UserID = settings["RockMaker.Database.UserID"].Value;
                connectionStringBuilder.Password = settings["RockMaker.Database.Password"].Value;
            }
            return connectionStringBuilder.ToString();
        }
    }
}