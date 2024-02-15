using Android.Content;
namespace AucklandRangersFoodHub
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {

        Button ButtonProfileIcon;
        TextView TextBurger;
        Button ButtonBurgers;
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonContactUs;
        Button ButtonProfile;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfile = FindViewById<Button>(Resource.Id.ButtonProfile);
            ButtonProfile.Click += OnButtonProfileClicked;

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;

            ButtonBurgers = FindViewById<Button>(Resource.Id.ButtonBurgers);
            ButtonBurgers.Click += OnButtonBurgersClicked;

            TextBurger = FindViewById<TextView>(Resource.Id.TextBurger);
            TextBurger.Click += OnButtonBurgersClicked;

            ButtonProfileIcon = FindViewById<Button>(Resource.Id.ButtonProfileIcon);
            ButtonProfileIcon.Click += OnButtonProfileClicked;
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
        Button ButtonProfileIcon;
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

            ButtonProfileIcon = FindViewById<Button>(Resource.Id.ButtonProfileIcon);
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
        Button ButtonProfileIcon;
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

            ButtonProfileIcon = FindViewById<Button>(Resource.Id.ButtonProfileIcon);
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
        Button ButtonProfileIcon;
        Button ButtonViewDescription; //Goes to FoodDescription
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonContactUs;
        Button ButtonProfile;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

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

            ButtonProfileIcon = FindViewById<Button>(Resource.Id.ButtonProfileIcon);
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
        Button ButtonProfile;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.FoodDescriptionPage);

            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfile = FindViewById<Button>(Resource.Id.ButtonProfile);
            ButtonProfile.Click += OnButtonProfileClicked;

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
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonProfile;
        Button ButtonContactUs;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.ProfilePage);



            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfile = FindViewById<Button>(Resource.Id.ButtonProfile);
            ButtonProfile.Click += OnButtonProfileClicked;

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
    [Activity(Label = "Reservations page")]
    public class ReservationsScreenActivity : Activity
    {
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonContactUs;
        Button ButtonProfile;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfile = FindViewById<Button>(Resource.Id.ButtonProfile);
            ButtonProfile.Click += OnButtonProfileClicked;

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
    [Activity(Label = "Reserve edit page")]
    public class ReserveEditActivity : Activity
    {
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonContactUs;
        Button ButtonProfile;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfile = FindViewById<Button>(Resource.Id.ButtonProfile);
            ButtonProfile.Click += OnButtonProfileClicked;

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
    [Activity(Label = "Sign in page")]
    public class SignInActivity : Activity
    {
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonContactUs;
        Button ButtonProfile;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfile = FindViewById<Button>(Resource.Id.ButtonProfile);
            ButtonProfile.Click += OnButtonProfileClicked;

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
    [Activity(Label = "Sign up page")]
    public class SignUpActivity : Activity
    {
        Button ButtonMenu;
        Button ButtonCart;
        Button ButtonContactUs;
        Button ButtonProfile;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfile = FindViewById<Button>(Resource.Id.ButtonProfile);
            ButtonProfile.Click += OnButtonProfileClicked;

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
        void OnButtonProfileClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ProfileActivity));//Goes to the profile page
            StartActivity(intent);
        }
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
        Button ButtonProfile;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.BurgersPage);

            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfile = FindViewById<Button>(Resource.Id.ButtonProfile);
            ButtonProfile.Click += OnButtonProfileClicked;

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

            ButtonBackButton = FindViewById<Button>(Resource.Id.ButtonBackButton);
            ButtonBackButton.Click += OnButtonBackButtonClicked;
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
        Button ButtonProfile;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.BurgersDescriptionPage);

            ButtonMenu = FindViewById<Button>(Resource.Id.ButtonMenu);
            ButtonMenu.Click += OnButtonMenuClicked;

            ButtonCart = FindViewById<Button>(Resource.Id.ButtonCart);
            ButtonCart.Click += OnButtonCartClicked;

            ButtonProfile = FindViewById<Button>(Resource.Id.ButtonProfile);
            ButtonProfile.Click += OnButtonProfileClicked;

            ButtonContactUs = FindViewById<Button>(Resource.Id.ButtonContactUs);
            ButtonContactUs.Click += OnButtonContactUsClicked;

            ButtonBackButton = FindViewById<Button>(Resource.Id.ButtonBackButton);
            ButtonBackButton.Click += OnButtonBackButtonClicked;
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