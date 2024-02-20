using Android.Net.Wifi.Aware;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AucklandRangersFoodHub.Resources.model
{
    public class SignUp //AUTOINCREMENT is only allowed on an INTEGER PRIMARY KEY
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Mobile { get; set; }
        public string Email { get; set; }
    }
}
