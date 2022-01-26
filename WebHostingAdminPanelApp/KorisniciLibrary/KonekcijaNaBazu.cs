using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Linq;

namespace KorisniciLibrary
{
    public class KonekcijaNaBazu
    {
        private readonly IConfiguration _config;

        public string ConnectionStringName { get; set; } = "Default";

        public KonekcijaNaBazu(IConfiguration config)
        {
            _config = config;
        }

        public List<PeopleModel> GetAllPeople()
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);
            
            using(IDbConnection connection= new SqlConnection(connectionString))
            {
                var output = connection.Query<PeopleModel>("select * from Customer", new DynamicParameters()).ToList();

                return output;
            }
        }

        public List<CustomerPacketsModel> GetCustomerPacketsById(int id)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var output = connection.Query<CustomerPacketsModel>("Select * from CustomersPackets where CustomerId=" + id, new DynamicParameters()).ToList();
                return output;
            }
        }

        public int GetNumberOfCustomers()
        {   
                var output = GetAllPeople();
                return output.Count();
        }

        public int GetNumberOfAllActivePackets()
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var output = connection.Query<CustomerPacketsModel>("select * from CustomersPackets", new DynamicParameters()).ToList();

                return output.Count();
            }
        }
          
        public int GetCustomersPacketNumberByPacketId(int id)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var output = connection.Query<CustomerPacketsModel>("select * from CustomersPackets where PacketId=" + id, new DynamicParameters()).ToList();
                return output.Count();
            }

        }
    }
}
