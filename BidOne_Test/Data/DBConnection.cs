namespace BidOne_Test.Data
{
    public class DBConnection : IDBConnection
    {
        string path; 
        private IConfiguration _configuration;

        public DBConnection(IConfiguration configuration)
        {
            path = AppDomain.CurrentDomain.BaseDirectory;
            _configuration = configuration;
        }        

        public bool WriteJson(string jsonData)
        {
            try
            {
                File.WriteAllText(path + "\\" + _configuration.GetSection("filepath").GetSection("path").Value, jsonData);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                
            }

        }

    }
}
