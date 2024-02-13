namespace AucklandRangersFoodHub
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
        void OnButtonCartClicked(object sender, EventArgs e)
        {

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