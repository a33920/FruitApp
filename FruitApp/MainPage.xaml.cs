namespace FruitApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            List<Fruit> list = new List<Fruit>()
            {
                new Fruit(){Name="Apple",Image="apple.png",Description="This is an apple"},
                new Fruit(){Name="Orange",Image="Orange.png",Description="This is an Orange"},
                new Fruit(){Name="Banana",Image="Banana.png",Description="This is an Banana"},
                new Fruit(){Name="Kiwi",Image="Kiwi.png",Description="This is an Kiwi"},
                new Fruit(){Name="Strawberry",Image="Strawberry.png",Description="This is an Strawberry"},
                new Fruit(){Name="Pineapple",Image="Pineapple.png",Description="This is an Pineapple"},
                new Fruit(){Name="WaterMelon",Image="WaterMelon.png",Description="This is an WaterMelon"},
                new Fruit(){Name="Grapes",Image="Grape.png",Description="This is an Grapes"},
            };

            InitializeComponent();
            FruitListView.ItemsSource= list;
        }

        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var selectedItem = e.SelectedItem as Fruit;
            Navigation.PushAsync(new FruitDetailed(selectedItem.Name,selectedItem.Image,selectedItem.Description));
        }
    }
}