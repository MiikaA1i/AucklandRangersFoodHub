using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace AucklandRangersFoodHub.Models
{
    public class ReservationsPage
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Table_Number { get; set; }
        public string Time { get; set; }
        public string ReservationName { get; set; }
    }
}

