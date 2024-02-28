using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Content;
using AucklandRangersFoodHub.Models;

namespace AucklandRangersFoodHub
{
    [Activity(Label = "UpdateReservationActivity")]
    public class UpdateReservations : Activity
    {
        EditText TableName, TableNumber, TableTime;
        Button ButtonUpdate;
        DataManager dataManager;
        private int ReservationId;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.UpdateReservationsLayout);

            TableName = FindViewById<EditText>(Resource.Id.editTextTableName);
            TableNumber = FindViewById<EditText>(Resource.Id.editTextTableNumber);
            TableTime = FindViewById<EditText>(Resource.Id.editTextTime);
            ButtonUpdate = FindViewById<Button>(Resource.Id.ButtonUpdate);
            ButtonUpdate.Click += ButtonUpdate_Click;
            dataManager = new DataManager();
            ReservationId = Intent.GetIntExtra("UserId",0);
            ReservationsPage objectname = dataManager.GetReservationId(ReservationId);
            if (objectname != null)
            {
                TableName.Text = objectname.ReservationName;
                TableNumber.Text = objectname.Table_Number;
                TableTime.Text = objectname.Time;
            }
            else
            {
                Toast.MakeText(this, "Data not found", ToastLength.Long).Show();
            }
        }

        private void ButtonUpdate_Click(object? sender, EventArgs e)
        {
            ReservationsPage reservationsPage = new ReservationsPage()
            {
                Id = ReservationId,
                Table_Number = TableNumber.Text,
                ReservationName = TableName.Text,
                Time = TableTime.Text
            };
            dataManager.UpdateResrvation(reservationsPage);
            Finish();
        }
    }
}
