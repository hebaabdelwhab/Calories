using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calories
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public int Total_Cal = 0;
        Dictionary<int, vegetable> names = new Dictionary<int, vegetable> {
                { 0, new vegetable { name = "Broccoli", cal = 207, selected = "Not Selected" } },
                {1, new vegetable{name="Black Olives", cal=2, selected = "Not Selected"}},
                { 2, new vegetable{name="cabbage",cal= 227, selected = "Not Selected"}},
                { 3, new vegetable{name="Carrot",cal= 25, selected = "Not Selected"}},
                {4,new vegetable{name="Cherry Tomato",cal= 20, selected = "Not Selected"}},
                {5, new vegetable{name="Corn", cal=562, selected ="Not Selected"}},
                {6, new vegetable{name="Cucumber", cal=66, selected ="Not Selected"} },
                {7, new vegetable{name="Green onion", cal=5, selected ="Not Selected"} },
                {8, new vegetable{name="Mushrooms",cal=1, selected = "Not Selected"} },
                {9, new vegetable{name="Pepper",cal=20, selected = "Not Selected"}},
                {10,new vegetable{name="Potato",cal=164, selected = "Not Selected"} }
            };
        public MainPage()
        {

            InitializeComponent();

        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Total Calories", Total_Cal.ToString(), "OK");
        }

        private void Button_Clicked_1(object sender, System.EventArgs e)
        {
            Button thebutton = (Button)sender;
            int row = Grid.GetRow(thebutton);

            if (thebutton.Text == "Add")
            {
                Total_Cal += names[row].cal;
                thebutton.Text = "Remove";
                thebutton.BackgroundColor = Color.LightPink;

            }
            else
            {
                Total_Cal -= names[row].cal;
                thebutton.Text = "Add";
                thebutton.BackgroundColor = Color.LightGreen;
            }
        }
    }
}