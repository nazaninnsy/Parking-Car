using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Car
{
    class CarRepository : ICarRepository
    {
        private string connectionstring = "DataSource = DESKTOP-G76TPQB; Initial Catalog = parking;Integrated Security = true";
        public bool Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(string StartTime, string EndTime, int cost, string CarTag)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectAll()
        {
            string query = "Select * From ParkingInfo";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectRow(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(int ID, string StartTime, string EndTime, int cost, string CarTag)
        {
            throw new NotImplementedException();
        }
    }
}
