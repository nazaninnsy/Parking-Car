using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
     interface ICarRepository
    {
        DataTable SelectAll();
        DataTable SelectRow(int id);
        bool Insert(string StartTime, string EndTime, int cost, string CarTag);
        bool Update(int ID, string StartTime, string EndTime, int cost, string CarTag);
        bool Delete(int ID);
    }
}
