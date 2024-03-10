using Android.Content;
using Android.Graphics;
using Android.Widget;
using AucklandRangersFoodHub.Models;
using Newtonsoft.Json;
using AucklandRangersFoodHub.Resources.model;
using System.Data;
using System.Text.Json.Nodes;
using System.Text;
using Android.Views;
using Android.Graphics.Drawables;
using Java.Util;
namespace AucklandRangersFoodHub
{
    [Activity(Label = "Auckland Rangers Food Hub", MainLauncher = false)]
    public class MainActivity : Activity
    {
        string username;
        bool isSignedIn;
        EditText EditTextSearchBar;
        int number = 0;
        ImageButton ButtonProfileIcon;
        TextView TextBurger;
        Button ButtonMenu, ButtonCart, ButtonContactUs, ButtonProfile, ButtonSearch;
        ImageButton btnPrev, btnNext, ButtonVegeterianPage, ButtonBurgers;
        ImageView ImageViewMain;
        TextView recom1;
        ImageButton seafood, Vegeterian, krabbypattyicon, dualfeasticon, USTicon;
        View view;
        ImageButton searchButton;

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            //Searchbar PopUp Alert Dialog
            searchButton = FindViewById<ImageButton>(Resource.Id.searchButton);
            username = Intent.GetStringExtra("username");
            searchButton.Click += (sender, e) =>
            {
                AlertDialog.Builder builder = new AlertDialog.Builder(this);
                view = LayoutInflater.Inflate(Resource.Layout.SearchDialogLayout, null);

                EditTextSearchBar = view.FindViewById<EditText>(Resource.Id.SearchEditText);
                AlertDialog dialog = null;

                builder.SetView(view)
                       .SetPositiveButton("Search", (dialogInterface, which) =>
                       {
                           string searchData = EditTextSearchBar.Text;

                           if (string.IsNullOrEmpty(searchData))
                           {
                               Toast.MakeText(this, "You need to enter something first", ToastLength.Long).Show();
                           }
                           else
                           {

                               Intent intent = new Intent(this, typeof(SearchActivity));
                               intent.PutExtra("username", username);
                               intent.PutExtra("searchData", searchData);
                               StartActivity(intent);
                           }


                           dialog.Dismiss();
                       })
                       .SetNegativeButton("Cancel", (dialogInterface, which) =>
                       {
                           dialog.Dismiss();
                       });

                dialog = builder.Create();
                dialog.Show();
            };



            Vegeterian = FindViewById<ImageButton>(Resource.Id.vegeterian);
            Vegeterian.Click += OnButtonVegeterianClick;

            seafood = FindViewById<ImageButton>(Resource.Id.seafood);
            seafood.Click += OnseafoodClicked;

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

            krabbypattyicon = FindViewById<ImageButton>(Resource.Id.krabbypattyicon);
            krabbypattyicon.Click += OnkrabbypattyiconClicked;

            dualfeasticon = FindViewById<ImageButton>(Resource.Id.dualfeasticon);
            dualfeasticon.Click += OndualfeasticonClicked;

            USTicon = FindViewById<ImageButton>(Resource.Id.USTicon);
            USTicon.Click += OnUSTiconClicked;


            TextBurger = FindViewById<TextView>(Resource.Id.TextBurger);
            TextBurger.Click += OnButtonBurgersClicked;

            ButtonProfileIcon = FindViewById<ImageButton>(Resource.Id.ButtonProfileIcon);
            ButtonProfileIcon.Click += OnButtonProfileClicked;
            //ButtonProfileIcon.SetImageResource(Resource.Drawable.sadfasdfadsf);
            btnPrev = FindViewById<ImageButton>(Resource.Id.btnPrev);
            btnPrev.Click += OnButtonPrevClick;

            btnNext = FindViewById<ImageButton>(Resource.Id.btnNext);
            btnNext.Click += OnButtonNextClick;
            btnNext.RotationY = 180;

            //imageSwitcher = FindViewById<ImageSwitcher>(Resource.Id.btn_switch);
            NumberCheck();


        }

        //Vegerterian Image Button
        void OnButtonVegeterianClick(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Vegeterian catergory is still undergoing updates!", ToastLength.Short).Show();
        }
        void NumberCheck() //Image switches in ImageView
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
        void OnButtonBurgersClicked(Object sender, EventArgs e)//shows a pop up text for burger page
        {
            Toast.MakeText(this, "Already in the burger category.", ToastLength.Short).Show();
        }

        void OnseafoodClicked(object sender, EventArgs e) //pop up text for seafood page
        {
            Toast.MakeText(this, "Seafood category is still undergoing updates!.", ToastLength.Short).Show();
        }


        void OnkrabbypattyiconClicked(object sender, EventArgs e) //goes to krabby  page
        {
            Intent intent = new Intent(this, typeof(BurgersActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }

        void OndualfeasticonClicked(object sender, EventArgs e) //goes to dual feast  page
        {
            Intent intent = new Intent(this, typeof(DoubleBurgerActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }

        void OnUSTiconClicked(object sender, EventArgs e) //goes to Ultimate stack towers page
        {
            Intent intent = new Intent(this, typeof(UltimateTowerStackActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }

        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            //already on main page
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)//Goes to the profile page
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));

            intent.PutExtra("username", username);

            StartActivity(intent);
        }
    }
    [Activity(Label = "Cart Page")]
    public class CartActivity : Activity
    {
        string username;
        bool isSignedIn;
        double totalPriceGST;
        ImageButton ButtonProfileIcon;
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonProfile;
        Button ButtonContactUs;
        TextView itemCountTextView, TextViewTotalPrice;
        TextView totalPriceTextView;
        Button ProceedButton;
        TextView hiddenKPtxt;
        TextView DishNameText;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.CartPage);

            username = Intent.GetStringExtra("username");


            hiddenKPtxt = FindViewById<TextView>(Resource.Id.DishNameText);
            itemCountTextView = FindViewById<TextView>(Resource.Id.itemCountTextView);
            totalPriceTextView = FindViewById<TextView>(Resource.Id.totalPriceTextViewGST);
            TextViewTotalPrice = FindViewById<TextView>(Resource.Id.totalPriceTextView);

            string DishNameText = Intent.GetStringExtra("Krabby Patty");
            int itemCount = Intent.GetIntExtra("ItemCount", 0);
            double totalPrice = Intent.GetDoubleExtra("TotalPrice", 0);
            totalPriceGST = totalPrice * 1.15;

            hiddenKPtxt.Text = DishNameText;
            totalPriceTextView.Text = "Total price: $" + totalPrice.ToString();
            TextViewTotalPrice.Text = "Total price (including GST): $" + totalPriceGST.ToString();
            itemCountTextView.Text = "Qty: " + itemCount.ToString();


            // Android.Util.Log.Debug("CartActivity", $"Received ItemCount: {itemCount}, TotalPrice: {totalPrice}");

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

            ProceedButton = FindViewById<Button>(Resource.Id.ProceedButton);
            ProceedButton.Click += OnProceedButtonClicked;

            GenerateAndDisplayOrderNumber();
        }

        private void GenerateAndDisplayOrderNumber()
        {
            int customerId = 1;
            int orderCounter = 1;
            string orderNumber = GenerateOrderNumber(customerId);
            TextView orderNumberTextView = FindViewById<TextView>(Resource.Id.OrderNumID);
            orderNumberTextView.Text = "Order Number: " + orderNumber;


        }

        private static int orderCounter = 1;
        private string GenerateOrderNumber(int customerId)
        {
            
            return $"O{customerId}-{orderCounter++}";
        }

        void OnProceedButtonClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(PaymentActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)//Goes to the profile page
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
    }
    [Activity(Label = "Contact Us page")]
    public class ContactUsActivity : Activity
    {
        string username;
        ImageButton ButtonProfileIcon;
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonProfile;
        Button ButtonContactUs;
        bool isSignedIn;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.ContactUsPage);

            username = Intent.GetStringExtra("username");
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
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity));//Goes to the main page
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)//Goes to the profile page
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
    }
    [Activity(Label = "Payment page")]
    public class PaymentActivity : Activity
    {
        string username;
        bool isSignedIn;
        ImageButton ButtonProfileIcon;
        Button cardPayment;
        Button cashPayment;
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonContactUs;
        Button ButtonProfile;

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Payment);
            username = Intent.GetStringExtra("username");
            cardPayment = FindViewById<Button>(Resource.Id.cardPayment);
            cardPayment.Click += OncardPaymentClicked;

            cashPayment = FindViewById<Button>(Resource.Id.cashPayment);
            cashPayment.Click += OncashPaymentClicked;

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

            ShowReviewPopup();
        }

        private void ShowReviewPopup()
        {
            Dialog reviewDialog = new Dialog(this);
            reviewDialog.SetContentView(Resource.Layout.reviewPopup);


            TextView reviewTitle = reviewDialog.FindViewById<TextView>(Resource.Id.reviewTitle);
            RatingBar customerRatingBar = reviewDialog.FindViewById<RatingBar>(Resource.Id.customerRatingBar);
            EditText reviewEditText = reviewDialog.FindViewById<EditText>(Resource.Id.reviewEditText);
            Button submitReviewButton = reviewDialog.FindViewById<Button>(Resource.Id.submitReviewButton);


            reviewTitle.Text = "Give Us A Review!";


            submitReviewButton.Click += (sender, e) =>
            {
                string reviewText = reviewEditText.Text;
                float rating = customerRatingBar.Rating;


                reviewDialog.Dismiss();
                Toast.MakeText(this, "Thank you for your review!", ToastLength.Short).Show();
            };


            reviewDialog.Show();
        }


        void OncardPaymentClicked(object sender, EventArgs e)
        {
            var dialogView = LayoutInflater.Inflate(Resource.Layout.CardDetailsPopup, null);

            EditText cardNumberEditText = dialogView.FindViewById<EditText>(Resource.Id.cardNumberEditText);
            EditText expiryDateEditText = dialogView.FindViewById<EditText>(Resource.Id.expiryDateEditText);
            EditText cvvEditText = dialogView.FindViewById<EditText>(Resource.Id.cvvEditText);
            EditText cardNameEditText = dialogView.FindViewById<EditText>(Resource.Id.cardNameEditText);
            Button submitButton = dialogView.FindViewById<Button>(Resource.Id.submitButton);

            var dialog = new Dialog(this);
            dialog.SetContentView(dialogView);

            submitButton.Click += (dialogSender, dialogArgs) =>
            {
                // Retrieve card details from the dialog

                string cardNumber = cardNumberEditText.Text;
                string cardName = cardNameEditText.Text;
                string expiryDate = expiryDateEditText.Text;
                string cvv = cvvEditText.Text;
                dialog.Dismiss();

                Intent intent = new Intent(this, typeof(ReservationsAddActivity));
                intent.PutExtra("username", username);
                StartActivity(intent);

                Toast.MakeText(this, "Payment Succesful. ", ToastLength.Short).Show();

            };

            // Show the dialog
            dialog.Show();




        }

        void OncashPaymentClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ReservationsAddActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
            Toast.MakeText(this, "Payment will be recived at the restraunts counter. ", ToastLength.Short).Show();
        }

        void OnAddtoCartClicked(object sender, EventArgs e) // Adds items into cart
        {

        }

        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)//Goes to the profile page
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonViewDescriptionClicked(object sender, EventArgs e)//goes to the food description page
        {
            Intent intent = new Intent(this, typeof(FoodDescriptionActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
    }

    [Activity(Label = "Food description page")]
    public class FoodDescriptionActivity : Activity
    {
        string username;
        bool isSignedIn;
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonContactUs;
        ImageButton ButtonProfileIcon;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.FoodDescriptionPage);
            username = Intent.GetStringExtra("username");
            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfileIcon = FindViewById<ImageButton>(Resource.Id.ButtonProfileIcon);
            ButtonProfileIcon.Click += OnButtonProfileIconClicked;

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonProfileIconClicked(object sender, EventArgs e)//Goes to the profile page
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
    }
    [Activity(Label = "Profile page")]
    public class ProfileActivity : Activity
    {
        string username;

        TextView EditTextUserName, EditTextPassword, EditTextMobile, EditTextEmail;
        Button ButtonDeleteAccount;
        ImageButton ButtonSignOut;
        Button ButtonViewReservation, ButtonUpdate;
        Button ButtonMenu;
        Button ButtonCart;
        //ImageButton ButtonProfileIcon;
        Button ButtonContactUs;
        DataManager dataManager;
        SignUp user;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.ProfilePage);

            EditTextUserName = FindViewById<TextView>(Resource.Id.username);
            EditTextPassword = FindViewById<TextView>(Resource.Id.password);
            ButtonUpdate = FindViewById<Button>(Resource.Id.toupdatebuttonpage);
            ButtonUpdate.Click += OnButtonUpdateClick;
            EditTextMobile = FindViewById<TextView>(Resource.Id.mobile);
            EditTextEmail = FindViewById<TextView>(Resource.Id.email);
            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;
            dataManager = new DataManager();
            username = Intent.GetStringExtra("username");
            user = dataManager.GetUserName(username);
            if (user != null)
            {

                EditTextUserName.Text = user.UserName;
                EditTextPassword.Text = user.Password;
                EditTextMobile.Text = user.Mobile;
                EditTextEmail.Text = user.Email;
            }

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;

            ButtonViewReservation = FindViewById<Button>(Resource.Id.ButtonViewReservation);
            ButtonViewReservation.Click += OnButtonViewReservationClicked;

            ButtonSignOut = FindViewById<ImageButton>(Resource.Id.ButtonSignOut);
            ButtonSignOut.Click += OnButtonSignOutClicked;

            ButtonDeleteAccount = FindViewById<Button>(Resource.Id.ButtonDeleteAccount);
            ButtonDeleteAccount.Click += OnButtonDeleteAccountClicked;
        }
        protected override void OnResume()
        {
            base.OnResume();
            username = Intent.GetStringExtra("username");
            user = dataManager.GetUserName(username);
            if (user != null)
            {

                EditTextUserName.Text = user.UserName;
                EditTextPassword.Text = user.Password;
                EditTextMobile.Text = user.Mobile;
                EditTextEmail.Text = user.Email;
            }
        }
        void OnButtonUpdateClick(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(UpdateUsersActivity));
            intent.PutExtra("UserId", user.Id);
            intent.PutExtra("username", username);
            StartActivity(intent);
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
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)//Goes to the profile page
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
    }
    [Activity(Label = "Reservations page")]
    public class ReservationsScreenActivity : Activity
    {
        string username;
        bool isSignedIn;
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
            username = Intent.GetStringExtra("username");
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
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void ButtonMyReservationsClick(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ReserveEditActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)//Goes to the profile page
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
    }
    [Activity(Label = "Reserve edit page")]
    public class ReserveEditActivity : Activity
    {
        string username;
        bool isSignedIn;
        bool UpdateModeEnabled = false;
        bool DeleteMode = false;
        List<ReservationsPage> ReservationsDetails;
        ListView ListViewReservations;
        DataManager dataManager;
        Button ButtonMenu, ButtonEdit, ButtonUpdate;
        Button ButtonCart;
        Button ButtonContactUs;

        ImageButton ButtonProfileIcon, ButtonBackButton;
        Button ButtonAdd;
        Button ButtonProfile;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ReserveEditPage);
            username = Intent.GetStringExtra("username");
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

            ButtonUpdate = FindViewById<Button>(Resource.Id.reservationsUpdateButton);
            ButtonUpdate.Click += UpdateModeOn;

            ListViewReservations = FindViewById<ListView>(Resource.Id.listViewReservations);
            dataManager = new DataManager();
            Display();
            ListViewReservations.ItemClick += ListViewReservationItemClick;
            ListViewReservations.ItemClick += UpdateMode;

            ButtonAdd = FindViewById<Button>(Resource.Id.reservationsAddButton);
            ButtonAdd.Click += ButtonAddClick;
        }
        void Display()
        {
            ReservationsDetails = dataManager.GetReservations();
            ArrayAdapter arrayAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1);
            foreach (var item in ReservationsDetails)
            {
                arrayAdapter.Add($"{item.ReservationName}/{item.Table_Number}/{item.Time}");
            }
            ListViewReservations.Adapter = arrayAdapter;
        }
        protected override void OnResume()
        {
            base.OnResume();
            Display();
        }
        void UpdateModeOn(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Tap on a reservation to Update it", ToastLength.Long).Show();
            UpdateModeEnabled = true;
        }
        void ButtonEditClick(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Tap on a reservation to remove it", ToastLength.Long).Show();
            DeleteMode = true;
            UpdateModeEnabled = false;
        }
        void ButtonBackButtonClick(object sender, EventArgs e)
        {
            UpdateModeEnabled = false;
            DeleteMode = false;
            Intent intent = new Intent(this, typeof(ReservationsScreenActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void ButtonAddClick(object sender, EventArgs e)
        {
            UpdateModeEnabled = false;
            DeleteMode = false;
            Intent intent = new Intent(this, typeof(ReservationsAddActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void ListViewReservationItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            if (DeleteMode == true)
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
            DeleteMode = false;
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
            DeleteMode = false;
        }
        void UpdateMode(object sender, AdapterView.ItemClickEventArgs e)
        {
            if (UpdateModeEnabled == true)
            {

                DeleteMode = false;
                ReservationsPage currentRow = ReservationsDetails[e.Position];
                UpdateReservation(currentRow);
            }
        }
        void UpdateReservation(ReservationsPage reservationsPage)
        {
            UpdateModeEnabled = false;
            Intent intent = new Intent(this, typeof(UpdateReservations));
            intent.PutExtra("UserId", reservationsPage.Id);
            StartActivity(intent);
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            UpdateModeEnabled = false;
            DeleteMode = false;
            Intent intent = new Intent(this, typeof(CartActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            UpdateModeEnabled = false;
            DeleteMode = false;
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            UpdateModeEnabled = false;
            DeleteMode = false;
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)//Goes to the profile page
        {
            UpdateModeEnabled = false;
            DeleteMode = false;
            Intent intent = new Intent(this, typeof(ProfileActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
    }
    [Activity(Label = "Reservation add")]
    public class ReservationsAddActivity : Activity
    {
        string username;
        bool isSignedIn;
        EditText EditTextTableName, EditTextTableNumber, EditTextTime, editNumofPeople;
        ImageButton ButtonProfileIcon, ButtonBackButton;
        Button? ButtonMenu, ButtonCart, ButtonContactUs, ButtonProfile, ButtonCreateReservation;
        DataManager dataManager;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ReservationsAddPage);
            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;
            username = Intent.GetStringExtra("username");
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

            editNumofPeople = FindViewById<EditText>(Resource.Id.editNumofPeople);

            dataManager = new DataManager();
        }
        void ButtonBackButtonClick(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ReservationsScreenActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void ButtonCreateReservationClick(object sender, EventArgs e)//Inserts the details into the database
        {
            ReservationsPage reservationsInfo = new ReservationsPage()
            {
                Table_Number = EditTextTableNumber.Text,
                ReservationName = EditTextTableName.Text,
                Time = EditTextTime.Text,
               
            };
            dataManager.InsertReservation(reservationsInfo);

            Toast.MakeText(this, "Reservation has been created", ToastLength.Short).Show();

            Intent intent = new Intent(this, typeof(ReserveEditActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)//Goes to the profile page
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
    }
    [Activity(Label = "Sign in page", MainLauncher = true)]
    public class SignInActivity : Activity
    {
        string username;
        EditText Password, UserName;
        Button? ButtonSignUp, ButtonSignIn;
        DataManager dataManager;
        bool isSignedIn;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SignInPage);
            Password = FindViewById<EditText>(Resource.Id.Password);
            UserName = FindViewById<EditText>(Resource.Id.userName);
            ButtonSignUp = FindViewById<Button>(Resource.Id.ButtonSignUp);
            ButtonSignUp.Click += OnButtonSignUpClicked;
            isSignedIn = Intent.GetBooleanExtra("isSignedIn", false);
            ButtonSignIn = FindViewById<Button>(Resource.Id.ButtonSignIn);
            ButtonSignIn.Click += OnButtonSignInClicked;
            dataManager = new DataManager();
        }
        void OnButtonSignInClicked(object sender, EventArgs e)
        {
            username = UserName.Text;
            string password = Password.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Toast.MakeText(this, "You must fill out all the fields", ToastLength.Long).Show();
                return;
            }
            else
            {
                SignUp user = dataManager.GetUserName(username);
                if (user != null && user.Password == password)
                {
                    Intent intent = new Intent(this, typeof(MainActivity));
                    intent.PutExtra("username", username);
                    StartActivity(intent);
                }
                else
                {
                    Toast.MakeText(this, "Incorrect username or password", ToastLength.Long).Show();
                }
            }
        }
        void OnButtonSignUpClicked(object send, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(SignUpActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
    }
    [Activity(Label = "Sign up page")]
    public class SignUpActivity : Activity
    {
        string username;
        EditText? EditTextUserName, EditTextPassword, EditTextMobile, EditTextEmail;
        Button ButtonSubmit;
        Button ButtonAlreadyHaveAnAccount;
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonContactUs;
        bool isSignedIn;
        DataManager dataManager;
        //ImageButton ButtonProfileIcon;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SignUpPage);

            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;
            username = Intent.GetStringExtra("username");
            //ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            // ButtonCart.Click += OnButtonCartClicked;

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

            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonAlreadyHaveAnAccount(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(SignInActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            intent.PutExtra("username", username);
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
        string username;
        float Price = 30;//price for a burger
        float TotalPrice;
        int Count;
        double TotalPriceGST;
        bool isSignedIn;
        TextView TextViewQuantity;
        TextView totalPriceTextView;
        TextView DishNameText;
        Button AddtoCart;
        Button BackButton; //leads back to main page.xml
        Button ButtonViewDescription;
        ImageButton ButtonPlus;
        ImageButton ButtonMinus;
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonContactUs;
        ImageButton ButtonProfileIcon;
        TextView hiddenKPtxt;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.BurgersPage);

            hiddenKPtxt = FindViewById<TextView>(Resource.Id.hiddenKPtxt);

            AddtoCart = FindViewById<Button>(Resource.Id.AddtoCart);
            AddtoCart.Click += OnAddtoCartClicked;
            username = Intent.GetStringExtra("username");
            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfileIcon = FindViewById<ImageButton>(Resource.Id.ButtonProfileIcon);
            ButtonProfileIcon.Click += OnButtonProfileClicked;

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;

            ButtonPlus = FindViewById<ImageButton>(Resource.Id.ButtonPlus);
            ButtonPlus.Click += OnButtonPlusClicked;

            ButtonMinus = FindViewById<ImageButton>(Resource.Id.ButtonMinus);
            ButtonMinus.Click += OnButtonMinusClicked;

            TextViewQuantity = FindViewById<TextView>(Resource.Id.TextViewQuantity);

            totalPriceTextView = FindViewById<TextView>(Resource.Id.totalPriceTextView);

            ButtonViewDescription = FindViewById<Button>(Resource.Id.ButtonViewDescription);
            ButtonViewDescription.Click += OnButtonViewDescription;

            //BackButton = FindViewById<Button>(Resource.Id.BackButton);
            //BackButton.Click += OnBackButtonClicked;
        }
        void OnBackButtonClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonViewDescription(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(BurgerDescriptionActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonMinusClicked(object sender, EventArgs e)
        {
            Count--;

            TextViewQuantity.Text = "Qty: " + Count.ToString();
            TotalPrice = Count * Price;
            totalPriceTextView.Text = "Total Cost: $" + TotalPrice.ToString();
        }
        void OnButtonPlusClicked(object sender, EventArgs e)
        {
            Count++;

            hiddenKPtxt.Text = "Krabby Patty";

            TextViewQuantity.Text = "Qty: " + Count.ToString();
            TotalPrice = Count * Price;

            TotalPriceGST = TotalPrice;

            totalPriceTextView.Text = "Total Cost: $" + TotalPriceGST.ToString();

        }
        void OnAddtoCartClicked(object sender, EventArgs e)
        {

            Intent intent = new Intent(this, typeof(CartActivity));
            intent.PutExtra("username", username);
            intent.PutExtra("ItemCount", Count);
            intent.PutExtra("TotalPrice", TotalPriceGST);
            intent.PutExtra("Krabby Patty", "Krabby Patty");


            StartActivity(intent);
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            intent.PutExtra("ItemCount", Count);
            intent.PutExtra("username", username);
            intent.PutExtra("TotalPrice", TotalPriceGST);
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));//Goes to the profile page
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
    }
    [Activity(Label = "Dual Feast")]
    public class DoubleBurgerActivity : Activity
    {
        float Price = 20;//price for a burger
        float TotalPrice;
        int Count;
        string username;
        bool isSignedIn;
        TextView TextViewQuantity;
        TextView TextViewTotalPrice;

        ImageButton BackButton;//leads back to main page.xml
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
            SetContentView(Resource.Layout.DoubleBurger);
            username = Intent.GetStringExtra("username");
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

            BackButton = FindViewById<ImageButton>(Resource.Id.BackButton);
            BackButton.Click += OnBackButtonClicked;
        }
        void OnBackButtonClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonViewDescription(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(FoodDescriptionActivity));
            intent.PutExtra("username", username);
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
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));//Goes to the profile page
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
    }

    [Activity(Label = "Ultimate Stack Tower")]
    public class UltimateTowerStackActivity : Activity
    {
        float Price = 40;//price for a burger
        float TotalPrice;
        int Count;
        string username;
        bool isSignedIn;
        TextView TextViewQuantity;
        TextView TextViewTotalPrice;

        ImageButton BackButton;//leads back to main page.xml
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
            SetContentView(Resource.Layout.DoubleBurger);

            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;
            username = Intent.GetStringExtra("username");
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

            BackButton = FindViewById<ImageButton>(Resource.Id.BackButton);
            BackButton.Click += OnBackButtonClicked;
        }
        void OnBackButtonClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonViewDescription(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(UltimateBurgerStackActivity));

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
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));//Goes to the profile page
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
    }

    [Activity(Label = "Burger description activity")]
    public class BurgerDescriptionActivity : Activity
    {
        string username;
        bool isSignedIn;
        //ImageButton BackButton;
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonContactUs;
        ImageButton ButtonProfileIcon;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.BurgersDescriptionPage);
            username = Intent.GetStringExtra("username");
            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfileIcon = FindViewById<ImageButton>(Resource.Id.ButtonProfileIcon);
            ButtonProfileIcon.Click += OnButtonProfileClicked;

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;

            //BackButton = FindViewById<ImageButton>(Resource.Id.BackButton);
            // BackButton.Click += OnBackButtonClicked;
        }
        void OnBackButtonClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(BurgersActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            intent.PutExtra("username", username);
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
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));//Goes to the profile page
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
    }

    [Activity(Label = "Ultimate Tower Stack description activity")]
    public class UltimateBurgerStackActivity : Activity
    {
        string username;
        bool isSignedIn;
        ImageButton BackButton;
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonContactUs;
        ImageButton ButtonProfileIcon;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.UltimateBurgerStackDesc);
            username = Intent.GetStringExtra("username");
            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfileIcon = FindViewById<ImageButton>(Resource.Id.ButtonProfileIcon);
            ButtonProfileIcon.Click += OnButtonProfileClicked;

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;

            //BackButton = FindViewById<ImageButton>(Resource.Id.BackButton);
            //BackButton.Click += OnBackButtonClicked;
        }
        void OnBackButtonClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(UltimateTowerStackActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));//Goes to the profile page
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
    }
    [Activity(Label = "Dual Feast activity")]
    public class FoodDecriptionActivity : Activity
    {
        string username;
        //ImageButton BackButton;
        bool isSignedIn;
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonContactUs;
        ImageButton ButtonProfileIcon;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.FoodDescriptionPage);
            username = Intent.GetStringExtra("username");
            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfileIcon = FindViewById<ImageButton>(Resource.Id.ButtonProfileIcon);
            ButtonProfileIcon.Click += OnButtonProfileClicked;

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;

            //BackButton = FindViewById<ImageButton>(Resource.Id.BackButton);
            //BackButton.Click += OnBackButtonClicked;
        }
        void OnBackButtonClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(DoubleBurgerActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));//Goes to the profile page
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
    }
    [Activity(Label = "Update Users")]
    public class UpdateUsersActivity : Activity
    {
        string username;
        bool isSignedIn;
        Button ButtonUpdate;
        EditText EditTextUser, EditTextPassword, EditTextMobile, EditTextEmail;
        private int UserId;
        DataManager dataManager;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.UpdateUsersPage);
            ButtonUpdate = FindViewById<Button>(Resource.Id.ButtonUserUpdate);
            ButtonUpdate.Click += ButtonUpdateClick;
            EditTextUser = FindViewById<EditText>(Resource.Id.UpdateTextUserName);
            EditTextPassword = FindViewById<EditText>(Resource.Id.UpdateTextPassword);
            EditTextMobile = FindViewById<EditText>(Resource.Id.UpdateTextMobile);
            EditTextEmail = FindViewById<EditText>(Resource.Id.UpdateTextEmail);
            dataManager = new DataManager();
            username = Intent.GetStringExtra("username");
            UserId = Intent.GetIntExtra("UserId", 0);
            SignUp signUp = dataManager.GetUserId(UserId);
            if (signUp != null)
            {
                EditTextUser.Text = signUp.UserName;
                EditTextPassword.Text = signUp.Password;
                EditTextMobile.Text = signUp.Mobile;
                EditTextEmail.Text = signUp.Email;
            }
            else
            {
                Toast.MakeText(this, "Persons Data Not Found", ToastLength.Long).Show();
            }
        }
        void ButtonUpdateClick(object sender, EventArgs e)
        {
            SignUp update = new SignUp()
            {
                Id = UserId,
                UserName = EditTextUser.Text,
                Password = EditTextPassword.Text,
                Email = EditTextEmail.Text,
                Mobile = EditTextMobile.Text
            };
            dataManager.UpdateUser(update);

            Toast.MakeText(this, "Changes have been made", ToastLength.Long).Show();
            username = EditTextUser.Text;
            Intent intent = new Intent(this, typeof(ProfileActivity));

            intent.PutExtra("username", username);
            StartActivity(intent);
        }
    }
    [Activity(Label = "Vegetrerian page")]
    public class VegeterianActivity : Activity
    {
        string username;
        bool isSignedIn;
        float Price = 10;
        float TotalPrice;
        int Count;

        TextView TextViewQuantity;
        TextView TextViewTotalPrice;

        ImageButton ImageButtonBackButton;
        Button ButtonMenu, ButtonCart, ButtonContactUs, ButtonProfile, ButtonMinus, ButtonPlus, ButtonViewDescription;
        ImageButton ButtonProfileIcon;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            username = Intent.GetStringExtra("username");
            SetContentView(Resource.Layout.Vegeterian);
            ButtonProfile = FindViewById<Button>(Resource.Id.ButtonProfile);
            ButtonProfile.Click += OnButtonProfileClicked;
            ImageButtonBackButton = FindViewById<ImageButton>(Resource.Id.arrowicon);
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
        }
        void OnButtonViewDescription(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(BurgerDescriptionActivity));
            intent.PutExtra("username", username);
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

            Intent intent = new Intent(this, typeof(CartActivity));
            intent.PutExtra("ItemCount", Count);
            intent.PutExtra("username", username);
            intent.PutExtra("TotalPrice", TotalPrice);
            StartActivity(intent);

        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)
        {
            //already on profile page
        }
    }
    [Activity(Label = "Seafood Activity")]
    public class SeafoodActivity : Activity
    {
        string username;
        bool isSignedIn;
        float Price = 10;
        float TotalPrice;
        int Count;

        TextView TextViewQuantity;
        TextView TextViewTotalPrice;

        ImageButton ImageButtonBackButton;
        Button ButtonMenu, ButtonCart, ButtonContactUs, ButtonProfile, ButtonMinus, ButtonPlus, ButtonViewDescription;
        ImageButton ButtonProfileIcon;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Seafood);
            username = Intent.GetStringExtra("username");
            ButtonProfile = FindViewById<Button>(Resource.Id.ButtonProfile);
            ButtonProfile.Click += OnButtonProfileClicked;
            ImageButtonBackButton = FindViewById<ImageButton>(Resource.Id.arrowicon);
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
        }
        void OnButtonViewDescription(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(BurgerDescriptionActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonMinusClicked(object sender, EventArgs e)
        {
            Count--;
            TextViewQuantity.Text = "Qty: " + Count.ToString();
            double TotalPrice = Count * Price;
            double TotalPriceGST = TotalPrice * 3 / 23;
            TextViewTotalPrice.Text = "Total price (inc GST): " + TotalPriceGST.ToString();
        }
        void OnButtonPlusClicked(object sender, EventArgs e)
        {
            Count++;
            TextViewQuantity.Text = "Qty: " + Count.ToString();
            TotalPrice = Count * Price;

            double TotalPriceGST = TotalPrice * 1.15;

            TextViewTotalPrice.Text = "Total price: " + TotalPrice.ToString();

            TextViewTotalPrice.Text = "Total price (GST inc): " + TotalPriceGST.ToString();

            Intent intent = new Intent(this, typeof(CartActivity));
            intent.PutExtra("username", username);
            intent.PutExtra("ItemCount", Count);
            intent.PutExtra("TotalPrice", TotalPrice);
            StartActivity(intent);

        }
        void OnButtonCartClicked(object sender, EventArgs e)//Goes to the cart page
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)//Goes to the main page
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)//Goes to the contact us page
        {
            Intent intent = new Intent(this, typeof(ContactUsActivity));
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
        void OnButtonProfileClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));//Goes to the profile page
            intent.PutExtra("username", username);
            StartActivity(intent);
        }
    }
    [Activity(Label = "searchpage")]
    public class SearchActivity : Activity
    {
        string username;
        bool isSignedIn;
        TextView TextViewDisplay;
        private const string ApiKey = "2250c37f83084e18ae9707ea15352a30";
        private const string ApiUrl = "https://api.spoonacular.com/recipes/complexSearch";

        // Override the OnCreate method
        protected override async void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Get username from intent
            username = Intent.GetStringExtra("username");

           // Set the content view to the SearchPage layout
            SetContentView(Resource.Layout.SearchPage);

            // Find TextView by its id
            TextViewDisplay = FindViewById<TextView>(Resource.Id.textViewdisplay);

            // Get search data from intent
            string searchData = Intent.GetStringExtra("searchData");

            // Build the search query with the API key and search data
            string searchQuery = $"{ApiUrl}?apiKey={ApiKey}&query={searchData}";

            // Display search results in the TextView
            TextViewDisplay.Text = await SearchRecipes(searchQuery);
        }

        // Method to perform recipe search
        private async Task<string> SearchRecipes(string api)
        {
            // Send a GET request to the API
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage httpResponseMessage = await client.GetAsync(api);
                try
                {
                    // Check if the response is successful
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {   // Read and deserialize the content into recipe objects
                        string content = await httpResponseMessage.Content.ReadAsStringAsync();
                        var recipes = JsonConvert.DeserializeObject<Root>(content);
                        // Build a string with recipe information
                        StringBuilder stringBuilder = new StringBuilder();
                        foreach (var recipe in recipes.results)
                        {
                            stringBuilder.AppendLine($"Recipe Id : {recipe.id} \n Recipe Name : {recipe.title}\n");
                        }
                        return stringBuilder.ToString(); // Return the formatted recipe information
                    }
                    else
                    {    // Return an error message if the response is not successful
                        return $"Error:{httpResponseMessage.StatusCode} - {httpResponseMessage.ReasonPhrase}";
                    }
                }
                catch (Exception ex)
                {   // Return an error message if an exception occurs
                    return $"Error:{ex.Message}";
                }
            }
        }
    }
    public class Result
    {
        public int id { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string imageType { get; set; }
    }

    public class Root
    {
        public List<Result> results { get; set; }
        public int offset { get; set; }
        public int number { get; set; }
        public int totalResults { get; set; }
    }
}