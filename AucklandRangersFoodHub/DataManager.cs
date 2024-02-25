using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AucklandRangersFoodHub.Models;
using AucklandRangersFoodHub.Resources.model;
using SQLite;



namespace AucklandRangersFoodHub
{
    public class DataManager
    {
        readonly SQLiteConnection connection;

        public DataManager()
        {
            string directorypath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);
            if (Directory.Exists(directorypath))
            {
                Directory.CreateDirectory(directorypath);
            }
            string combinepath = Path.Combine(directorypath, "AucklandRangers_data.db");

            connection = new SQLiteConnection(combinepath);

            connection.CreateTable<SignUp>();
            connection.CreateTable<ReservationsPage>();
        }
        public void InsertUser(SignUp new_user)//create a new user
        {
            connection.Insert(new_user);
        }
        public List<SignUp> GetUsers()// fetch the users
        {
            return connection.Table<SignUp>().ToList();
        }
        public void DeleteRow(int row)//delete a user
        {
            connection.Delete<SignUp>(row);
        }
        public void DeleteReservation(int row)//delete a reservation
        {
            connection.Delete<ReservationsPage>(row);
        }
        public List<ReservationsPage>GetReservations()//fetch the reservations
        {
            return connection.Table<ReservationsPage>().ToList();
        }
        public void InsertReservation(ReservationsPage newReservation)//create a reservation
        {
            connection.Insert(newReservation);
        }
    }
}
