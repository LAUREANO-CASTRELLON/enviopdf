using System.Configuration;
namespace PulsacionesGUI 
{
    public static class ConfigConnection
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    }

}


   