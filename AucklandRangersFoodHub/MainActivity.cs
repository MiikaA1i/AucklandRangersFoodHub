using Android.Content;
namespace AucklandRangersFoodHub
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
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
        void OnButtonCartClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)
        {

        }
        void OnButtonContactUsClicked(object sender, EventArgs e)
        {

        }
        void OnButtonProfileClicked(object sender, EventArgs e)
        {

        }
    }
    [Activity(Label = "Cart Page")]
    public class CartActivity : Activity
    {
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

        }
        void OnButtonCartClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(CartActivity));
            StartActivity(intent);
        }
        void OnButtonMenuClicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
        void OnButtonContactUsClicked(object sender, EventArgs e)
        {

        }
        void OnButtonProfileClicked(object sender, EventArgs e)
        {

        }
    }
    [Activity(Label = "Contact Us page")]
    public class ContactUsActivity : Activity
    {

    }
    [Activity(Label = "Food page")]
    public class FoodActivity : Activity
    {

    }
    [Activity(Label = "Menu page")]
    public class MenuActivity : Activity
    {

    }
    [Activity(Label = "Profile page")]
    public class ProfileActivity : Activity
    {

    }
    [Activity(Label = "Reservations page")]
    public class ReservationsScreenActivity : Activity
    {

    }
    [Activity(Label = "Reserve edit page")]
    public class ReserveEditActivity : Activity
    {

    }
    [Activity(Label = "Sign in page")]
    public class SignInActivity : Activity
    {

    }
    [Activity(Label = "Sign up page")]
    public class SignUpActivity : Activity
    {

    }
}