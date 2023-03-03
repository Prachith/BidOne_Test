using BidOne_Test.Data;
using BidOne_Test.Models;
using Newtonsoft.Json;

namespace BidOne_Test.Service
{
    public class CustomerBL : ICustomerBL
    {
        readonly IDBConnection _connection;

        public CustomerBL(IDBConnection dBConnection)
        {
            _connection = dBConnection;
        }

        public bool AddData(Customers customer)
        {
            bool result = false;

            var json = JsonConvert.SerializeObject(customer);

            result = _connection.WriteJson(json);

            return result;
        }
    }
}
