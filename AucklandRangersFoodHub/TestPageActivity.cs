using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AucklandRangersFoodHub.Resources.model;
using Android.Content;

namespace AucklandRangersFoodHub
{
    [Activity(Label = "TestPage", MainLauncher = false)]
    public class TestPageActivity : Activity
    {
        Button backbutton;
        DataManager dataManager;
        ListView ListView;
        List<SignUp> userDetails;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.TestPageDataBase);

            backbutton = FindViewById<Button>(Resource.Id.button1);
            backbutton.Click += BackButtonClick;

            ListView = FindViewById<ListView>(Resource.Id.listView1);
            dataManager = new DataManager();
            userDetails = dataManager.GetUsers();
            ArrayAdapter<string> userDetailsAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1);
            foreach (var item in userDetails)
            {
                userDetailsAdapter.Add($"{item.UserName} / {item.Mobile} / {item.Email}");
            }
            ListView.Adapter = userDetailsAdapter;
            ListView.ItemClick += ListViewItemClick;
        }
        void BackButtonClick(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(SignUpActivity));
            StartActivity(intent);
        }
        void ListViewItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            SignUp selectedRow = userDetails[e.Position];
            AlertDialog.Builder builder = new AlertDialog.Builder(this);
            builder.SetTitle("Choose an option");
            builder.SetNegativeButton("Delete", (s,a) => DeleteRow(selectedRow));
            builder.SetPositiveButton("Cancel", (s,a) => CancelButton());
            builder.Show();
        }
        void CancelButton()
        {
            //does nothing
        }
        void DeleteRow(SignUp row)
        {
            dataManager.DeleteRow(row.Id);
            userDetails = dataManager.GetUsers();
            ArrayAdapter<string> userDetailsAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1);
            foreach (var item in userDetails)
            {
                userDetailsAdapter.Add($"{item.UserName} / {item.Mobile} / {item.Email}");
            }
            ListView.Adapter = userDetailsAdapter;
        }
    }
}
