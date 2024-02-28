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
        }
        public void UpdateUser(SignUp user)
        {
            connection.Update(user);
        }
        public void InsertUser(SignUp new_user)
        {
            connection.Insert(new_user);
        }
        public List<SignUp> GetUsers()
        {
            return connection.Table<SignUp>().ToList();
        }
        public void DeleteRow(int row)
        {
            connection.Delete<SignUp>(row);
        }
        public void DeleteReservation(int row)
        {
            connection.Delete<ReservationsPage>(row);
        }
        public List<ReservationsPage>GetReservations()
        {
            return connection.Table<ReservationsPage>().ToList();
        }

        public void InsertReservation(ReservationsPage reservationsInfo)
        {
            connection.Insert(reservationsInfo);
        }
        public void UpdateResrvation(ReservationsPage reservationsPage)
        {
            connection.Update(reservationsPage);
        }
        public ReservationsPage GetReservationId(int reservationId)
        {
            return connection.Table<ReservationsPage>().FirstOrDefault(u => u.Id ==  reservationId);
        }
        public SignUp GetUserId(int userId)
        {
            return connection.Table<SignUp>().FirstOrDefault(u => u.Id == userId);
        }
    }   
}
