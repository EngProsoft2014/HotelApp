using System;

namespace EngHotel.Pages.Orders.OrderDetails;

public partial class DiningSevicesDetailsPage : Controls.CustomControl
{
	public DiningSevicesDetailsPage()
	{
		InitializeComponent();
	}


    private void TapGestureRecognizer_Breakfast(object sender, TappedEventArgs e)
    {
        if (Breakfast.IsVisible == false)
        {
            Breakfast.IsVisible = true;
        }
        else
        {
            Breakfast.IsVisible = false;
        }
    }

    private void TapGestureRecognizer_Lunch(object sender, TappedEventArgs e)
    {
        if (Lunch.IsVisible == false)
        {
            Lunch.IsVisible = true;
        }
        else
        {
            Lunch.IsVisible = false;
        }
    }

    private void TapGestureRecognizer_Dinner(object sender, TappedEventArgs e)
    {
        if (Dinner.IsVisible == false)
        {
            Dinner.IsVisible = true;
        }
        else
        {
            Dinner.IsVisible = false;
        }
    }
}