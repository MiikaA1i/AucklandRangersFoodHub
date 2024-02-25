using Android.Content;
using AucklandRangersFoodHub.Models;
using AucklandRangersFoodHub.Resources.model;
using System.Data;
namespace AucklandRangersFoodHub
{
    [Activity(Label = "Auckland Rangers Food Hub", MainLauncher = true)]
    public class MainActivity : Activity
    {
        int number = 0;
        ImageButton ButtonProfileIcon;
        TextView TextBurger;
        ImageButton ButtonBurgers;
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonContactUs;
        Button ButtonProfile;
        ImageButton btnPrev, btnNext;
        ImageView ImageViewMain;


        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            ImageViewMain = FindViewById<ImageView>(Resource.Id.ImageViewMain);

            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfile = FindViewById<Button>(Resource.Id.ButtonProfile);
            ButtonProfile.Click += OnButtonProfileClicked;

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;

            ButtonBurgers = FindViewById<ImageButton>(Resource.Id.ButtonBurgers);
            ButtonBurgers.Click += OnButtonBurgersClicked;
            ButtonBurgers.SetImageResource(Resource.Drawable.burgerImage);
            

            TextBurger = FindViewById<TextView>(Resource.Id.TextBurger);
            TextBurger.Click += OnButtonBurgersClicked;

            ButtonProfileIcon = FindViewById<ImageButton>(Resource.Id.ButtonProfileIcon);
            ButtonProfileIcon.Click += OnButtonProfileClicked;
            //ButtonProfileIcon.SetImageResource(Resource.Drawable.sadfasdfadsf);
            btnPrev = FindViewById<ImageButton>(Resource.Id.btnPrev);
            btnPrev.Click += OnButtonPrevClick;

            btnNext = FindViewById<ImageButton>(Resource.Id.btnNext);
            btnNext.Click += OnButtonNextClick;

            //imageSwitcher = FindViewById<ImageSwitcher>(Resource.Id.btn_switch);
            NumberCheck();
        }
        void NumberCheck()
        {
            if (number >= 3)
            {
                number = 0;
            }
            if (number < 0)
            {
                number = 2;
            }
            switch (number)
            {
                case 0:
                    ImageViewMain.SetImageResource(Resource.Drawable.burgerImage);
                    break;
                case 1:
                    ImageViewMain.SetImageResource(Resource.Drawable.seafood);
                    break;
                case 2:
                    ImageViewMain.SetImageResource(Resource.Drawable.vegeterian);
                    break;
            }
        }
        void OnButtonPrevClick(object sender, EventArgs e)
        {
            number -= 1;
            NumberCheck();
        }
        void OnButtonNextClick(object sender, EventArgs e)
        {
            number += 1;
            NumberCheck();
        }
        void OnButtonBurgersClicked(Object sender, EventArgs e)//Goes to the burger page
        {
            Intent intent = new Intent(this, typeof(BurgersActivity));
            StartActivity(intent);
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)//Goes to the profile page
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));
            StartActivity(intent);
        }
    }
    [Activity(Label = "Cart Page")]
    public class CartActivity : Activity
    {
        ImageButton ButtonProfileIcon;
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonProfile;
        Button ButtonContactUs;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.CartPage);



            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfile = FindViewById<Button>(Resource.Id.ButtonProfile);
            ButtonProfile.Click += OnButtonProfileClicked;

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;

            ButtonProfileIcon = FindViewById<ImageButton>(Resource.Id.ButtonProfileIcon);
            ButtonProfileIcon.Click += OnButtonProfileClicked;
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)//Goes to the profile page
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));
            StartActivity(intent);
        }
    }
    [Activity(Label = "Contact Us page")]
    public class ContactUsActivity : Activity
    {
        ImageButton ButtonProfileIcon;
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonProfile;
        Button ButtonContactUs;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.ContactUsPage);



            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfile = FindViewById<Button>(Resource.Id.ButtonProfile);
            ButtonProfile.Click += OnButtonProfileClicked;

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;

            ButtonProfileIcon = FindViewById<ImageButton>(Resource.Id.ButtonProfileIcon);
            ButtonProfileIcon.Click += OnButtonProfileClicked;

        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity));//Goes to the main page
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)//Goes to the profile page
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));
            StartActivity(intent);
        }
    }
    [Activity(Label = "Food page")]
    public class FoodActivity : Activity
    {
        ImageButton ButtonProfileIcon;
        Button ButtonViewDescription; //Goes to FoodDescription
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonContactUs;
        Button ButtonProfile;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.FoodPage);

            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfile = FindViewById<Button>(Resource.Id.ButtonProfile);
            ButtonProfile.Click += OnButtonProfileClicked;

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;

            ButtonViewDescription = FindViewById<Button>(Resource.Id.ButtonViewDescription);
            ButtonViewDescription.Click += OnButtonViewDescriptionClicked;

            ButtonProfileIcon = FindViewById<ImageButton>(Resource.Id.ButtonProfileIcon);
            ButtonProfileIcon.Click += OnButtonProfileClicked;
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)//Goes to the profile page
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));
            StartActivity(intent);
        }
        void OnButtonViewDescriptionClicked(object sender, EventArgs e)//goes to the food description page
        {
            Intent intent = new Intent(this, typeof(FoodDescriptionActivity));
            StartActivity(intent);
        }
    }
    [Activity(Label = "Food description page")]
    public class FoodDescriptionActivity : Activity
    {
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonContactUs;
        ImageButton ButtonProfileIcon;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.FoodDescriptionPage);

            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfileIcon = FindViewById<ImageButton>(Resource.Id.ButtonProfile);
            ButtonProfileIcon.Click += OnButtonProfileClicked;

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)//Goes to the profile page
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));
            StartActivity(intent);
        }
    }
    [Activity(Label = "Profile page")]
    public class ProfileActivity : Activity
    {
        Button ButtonDeleteAccount;
        Button ButtonSignOut;
        Button ButtonViewReservation;
        Button ButtonMenu;
        Button ButtonCart;
        //ImageButton ButtonProfileIcon;
        Button ButtonContactUs;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.ProfilePage);

            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            //ButtonProfileIcon = FindViewById<ImageButton>(Resource.Id.ButtonProfile);
            //ButtonProfileIcon.Click += OnButtonProfileClicked;

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;

            ButtonViewReservation = FindViewById<Button>(Resource.Id.ButtonViewReservation);
            ButtonViewReservation.Click += OnButtonViewReservationClicked;

            ButtonSignOut = FindViewById<Button>(Resource.Id.ButtonSignOut);
            ButtonSignOut.Click += OnButtonSignOutClicked;

            ButtonDeleteAccount = FindViewById<Button>(Resource.Id.ButtonDeleteAccount);
            ButtonDeleteAccount.Click += OnButtonDeleteAccountClicked;
        }
        void OnButtonDeleteAccountClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
        void OnButtonSignOutClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(SignInActivity));
            StartActivity(intent);
        }
        void OnButtonViewReservationClicked(object sender, EventArgs args)
        {
            Intent intent = new Intent(this, typeof(ReservationsScreenActivity));
            StartActivity(intent);
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)//Goes to the profile page
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));
            StartActivity(intent);
        }
    }
    [Activity(Label = "Reservations page")]
    public class ReservationsScreenActivity : Activity
    {
        Button? ButtonMyReservations, ButtonBookAReservation;
        ImageButton ButtonProfileIcon;
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonContactUs;
        Button ButtonProfile;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ReservationScreenPage);

            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfile = FindViewById<Button>(Resource.Id.ButtonProfile);
            ButtonProfile.Click += OnButtonProfileClicked;

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;

            ButtonProfileIcon = FindViewById<ImageButton>(Resource.Id.ButtonProfileIcon);
            ButtonProfileIcon.Click += OnButtonProfileClicked;

            ButtonMyReservations = FindViewById<Button>(Resource.Id.ButtonMyReservations);
            ButtonMyReservations.Click += ButtonMyReservationsClick;

            ButtonBookAReservation = FindViewById<Button>(Resource.Id.ButtonBookAReservation);
            ButtonBookAReservation.Click += ButtonBookAReservationClick;
        }
        void ButtonBookAReservationClick(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ReservationsAddActivity));
            StartActivity(intent);
        }
        void ButtonMyReservationsClick(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ReserveEditActivity));
            StartActivity(intent);
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)//Goes to the profile page
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));
            StartActivity(intent);
        }
    }
    [Activity(Label = "Reserve edit page")]
    public class ReserveEditActivity : Activity
    {
        bool EditMode = false;
        List<ReservationsPage> ReservationsDetails;
        ListView ListViewReservations;
        DataManager dataManager;
        Button ButtonMenu, ButtonEdit;
        Button ButtonCart;
        Button ButtonContactUs;

        ImageButton ButtonProfileIcon, ButtonBackButton;
        Button ButtonAdd;
        Button ButtonProfile;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ReserveEditPage);

            ButtonBackButton = FindViewById<ImageButton>(Resource.Id.arrowicon);
            ButtonBackButton.Click += ButtonBackButtonClick;

            ButtonEdit = FindViewById<Button>(Resource.Id.buttonEdit);
            ButtonEdit.Click += ButtonEditClick;

            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfileIcon = FindViewById<ImageButton>(Resource.Id.ButtonProfileIcon);
            ButtonProfileIcon.Click += OnButtonProfileClicked;

            ButtonProfile = FindViewById<Button>(Resource.Id.ButtonProfile);
            ButtonProfile.Click += OnButtonProfileClicked;

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;

            ListViewReservations = FindViewById<ListView>(Resource.Id.listViewReservations);
            dataManager = new DataManager();
            ReservationsDetails = dataManager.GetReservations();
            ArrayAdapter arrayAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1);
            foreach (var item in ReservationsDetails)
            {
                arrayAdapter.Add($"{item.ReservationName}/{item.Table_Number}/{item.Time}");
            }
            ListViewReservations.Adapter = arrayAdapter;
            ListViewReservations.ItemClick += ListViewReservationItemClick;

            ButtonAdd = FindViewById<Button>(Resource.Id.reservationsAddButton);
            ButtonAdd.Click += ButtonAddClick;
        }
        void ButtonEditClick(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Tap on a reservation to remove it", ToastLength.Long).Show();
            EditMode = true;
        }
        void ButtonBackButtonClick(object sender, EventArgs e)
        {
            EditMode = false;
            Intent intent = new Intent(this, typeof(ReservationsScreenActivity));
            StartActivity(intent);
        }
        void ButtonAddClick(object sender, EventArgs e)
        {
            EditMode = false;
            Intent intent = new Intent(this, typeof(ReservationsAddActivity));
            StartActivity(intent);
        }
        void ListViewReservationItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            if (EditMode == true)
            {
                ReservationsPage currentRow = ReservationsDetails[e.Position];
                AlertDialog.Builder builder = new AlertDialog.Builder(this);
                builder.SetTitle("Do you want to delete this reservation?");
                builder.SetPositiveButton("Delete", (s, a) => DeleteReservation(currentRow));
                builder.SetNegativeButton("Cancel", (s, a) => CancelDelete());
                builder.Show();
            }
        }
        void CancelDelete()
        {
            EditMode = false;
        }
        void DeleteReservation(ReservationsPage rowtoremove)
        {
            dataManager.DeleteReservation(rowtoremove.Id);
            ReservationsDetails = dataManager.GetReservations();
            ArrayAdapter arrayAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1);
            foreach (var item in ReservationsDetails)
            {
                arrayAdapter.Add($"{item.ReservationName}/{item.Table_Number}/{item.Time}");
            }
            ListViewReservations.Adapter = arrayAdapter;
            EditMode = false;
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            EditMode = false;
            Intent intent = new Intent(this, typeof(CartActivity));
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            EditMode = false;
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            EditMode = false;
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)//Goes to the profile page
        {
            EditMode = false;
            Intent intent = new Intent(this, typeof(ProfileActivity));
            StartActivity(intent);
        }
    }
    [Activity(Label = "Reservation add")]
    public class ReservationsAddActivity : Activity
    {
        EditText EditTextTableName, EditTextTableNumber, EditTextTime;
        ImageButton ButtonProfileIcon, ButtonBackButton;
        Button? ButtonMenu, ButtonCart, ButtonContactUs, ButtonProfile, ButtonCreateReservation;
        DataManager dataManager;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ReservationsAddPage);
            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonBackButton = FindViewById<ImageButton>(Resource.Id.arrowicon);
            ButtonBackButton.Click += ButtonBackButtonClick;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfileIcon = FindViewById<ImageButton>(Resource.Id.ButtonProfileIcon);
            ButtonProfileIcon.Click += OnButtonProfileClicked;

            ButtonProfile = FindViewById<Button>(Resource.Id.ButtonProfile);
            ButtonProfile.Click += OnButtonProfileClicked;

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;

            ButtonCreateReservation = FindViewById<Button>(Resource.Id.ButtonCreateReservation);
            ButtonCreateReservation.Click += ButtonCreateReservationClick;

            EditTextTableNumber = FindViewById<EditText>(Resource.Id.editTextTableNumber);

            EditTextTableName = FindViewById<EditText>(Resource.Id.editTextTableName);

            EditTextTime = FindViewById<EditText>(Resource.Id.editTextTime);

            dataManager = new DataManager();
        }
        void ButtonBackButtonClick(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ReservationsScreenActivity));
            StartActivity(intent);
        }
        void ButtonCreateReservationClick(object sender, EventArgs e)//Inserts the details into the database
        {
            ReservationsPage reservationsInfo = new ReservationsPage()
            {
                Table_Number = EditTextTableNumber.Text,
                ReservationName = EditTextTableName.Text,
                Time = EditTextTime.Text
            };
            dataManager.InsertReservation(reservationsInfo);
            Toast.MakeText(this, "Reservation has been created", ToastLength.Short).Show();

            Intent intent = new Intent(this, typeof(ReserveEditActivity));
            StartActivity(intent);
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)//Goes to the profile page
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));
            StartActivity(intent);
        }
    }
    [Activity(Label = "Sign in page")]
    public class SignInActivity : Activity
    {
        Button? ButtonSignUp, ButtonMenu, ButtonCart, ButtonContactUs, ButtonSignIn;
        //ImageButton ButtonProfileIcon;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SignInPage);

            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            /*ButtonProfileIcon = FindViewById<ImageButton>(Resource.Id.ButtonProfile);
            ButtonProfileIcon.Click += OnButtonProfileClicked;*/

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;

            ButtonSignUp = FindViewById<Button>(Resource.Id.ButtonSignUp);
            ButtonSignUp.Click += OnButtonSignUpClicked;

            ButtonSignIn = FindViewById<Button>(Resource.Id.ButtonSignIn);
            ButtonSignIn.Click += OnButtonSignInClicked;
        }
        void OnButtonSignInClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
        void OnButtonSignUpClicked(object send, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(SignUpActivity));
            StartActivity(intent);
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)//Goes to the profile page
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));
            StartActivity(intent);
        }
    }
    [Activity(Label = "Sign up page")]
    public class SignUpActivity : Activity
    {
        EditText? EditTextUserName, EditTextPassword, EditTextMobile, EditTextEmail;
        Button ButtonSubmit;
        Button ButtonAlreadyHaveAnAccount;
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonContactUs;

        DataManager dataManager;
        //ImageButton ButtonProfileIcon;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SignUpPage);

            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            //ButtonProfileIcon = FindViewById<ImageButton>(Resource.Id.ButtonProfile);
            //ButtonProfileIcon.Click += OnButtonProfileClicked;

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;

            ButtonAlreadyHaveAnAccount = FindViewById<Button>(Resource.Id.ButtonAlreadyHaveAnAccount);
            ButtonAlreadyHaveAnAccount.Click += OnButtonAlreadyHaveAnAccount;

            ButtonSubmit = FindViewById<Button>(Resource.Id.ButtonSubmit);
            ButtonSubmit.Click += OnButtonSubmitClicked;

            EditTextUserName = FindViewById<EditText>(Resource.Id.editTextUserName);
            EditTextPassword = FindViewById<EditText>(Resource.Id.editTextPassword);
            EditTextMobile = FindViewById<EditText>(Resource.Id.editTextMobile);
            EditTextEmail = FindViewById<EditText>(Resource.Id.editTextEmail);

            dataManager = new DataManager();


        }
        void OnButtonSubmitClicked(object sender, EventArgs e)
        {


            //Puts information into the database
            SignUp signup = new SignUp()
            {
                UserName = EditTextUserName.Text,
                Password = EditTextPassword.Text,
                //Id = EditTextId.Text,
                Mobile = EditTextMobile.Text,
                Email = EditTextEmail.Text
            };
            dataManager.InsertUser(signup);
            Toast.MakeText(this, "Details have been saved", ToastLength.Short).Show();

            Intent intent = new Intent(this, typeof(TestPageActivity));
            StartActivity(intent);
        }
        void OnButtonAlreadyHaveAnAccount(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(SignInActivity));
            StartActivity(intent);
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            StartActivity(intent);
        }
        /*        void OnButtonProfileClicked(object sender, EventArgs e)
                {
                    Intent intent = new Intent(this, typeof(ProfileActivity));//Goes to the profile page
                    StartActivity(intent);
                }*/
    }
    [Activity(Label = "Burgers Page")]
    public class BurgersActivity : Activity
    {
        float Price = 10;//price for a burger
        float TotalPrice;
        int Count;


        TextView TextViewQuantity;
        TextView TextViewTotalPrice;

        Button ButtonBackButton;//leads back to main page.xml
        Button ButtonViewDescription;
        Button ButtonPlus;
        Button ButtonMinus;
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonContactUs;
        ImageButton ButtonProfileIcon;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.BurgersPage);

            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfileIcon = FindViewById<ImageButton>(Resource.Id.ButtonProfileIcon);
            ButtonProfileIcon.Click += OnButtonProfileClicked;

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;

            ButtonPlus = FindViewById<Button>(Resource.Id.ButtonPlus);
            ButtonPlus.Click += OnButtonPlusClicked;

            ButtonMinus = FindViewById<Button>(Resource.Id.ButtonMinus);
            ButtonMinus.Click += OnButtonMinusClicked;

            TextViewQuantity = FindViewById<TextView>(Resource.Id.TextViewQuantity);

            TextViewTotalPrice = FindViewById<TextView>(Resource.Id.TextViewTotalPrice);

            ButtonViewDescription = FindViewById<Button>(Resource.Id.ButtonViewDescription);
            ButtonViewDescription.Click += OnButtonViewDescription;

            //ButtonBackButton = FindViewById<Button>(Resource.Id.ButtonBackButton);
            //ButtonBackButton.Click += OnButtonBackButtonClicked;
        }
        void OnButtonBackButtonClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
        void OnButtonViewDescription(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(BurgerDescriptionActivity));
            StartActivity(intent);
        }
        void OnButtonMinusClicked(object sender, EventArgs e)
        {
            Count--;
            TextViewQuantity.Text = "Qty: " + Count.ToString();
            TotalPrice = Count * Price;
            TextViewTotalPrice.Text = "Total price: " + TotalPrice.ToString();
        }
        void OnButtonPlusClicked(object sender, EventArgs e)
        {
            Count++;
            TextViewQuantity.Text = "Qty: " + Count.ToString();
            TotalPrice = Count * Price;
            TextViewTotalPrice.Text = "Total price: " + TotalPrice.ToString();
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));//Goes to the profile page
            StartActivity(intent);
        }
    }
    [Activity(Label = "Burger description activity")]
    public class BurgerDescriptionActivity : Activity
    {
        Button ButtonBackButton;
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonContactUs;
        ImageButton ButtonProfileIcon;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.BurgersDescriptionPage);

            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfileIcon = FindViewById<ImageButton>(Resource.Id.ButtonProfileIcon);
            ButtonProfileIcon.Click += OnButtonProfileClicked;

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;

            //ButtonBackButton = FindViewById<Button>(Resource.Id.ButtonBackButton);
            //ButtonBackButton.Click += OnButtonBackButtonClicked;
        }
        void OnButtonBackButtonClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(BurgersActivity));
            StartActivity(intent);
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));//Goes to the profile page
            StartActivity(intent);
        }
    }
}