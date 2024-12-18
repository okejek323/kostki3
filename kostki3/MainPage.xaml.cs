namespace kostki3
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BBQ(object sender, EventArgs e)
        {
            Random Rnd = new Random();

            int k1 = Rnd.Next(1, 6);
            int k2 = Rnd.Next(1, 6);
            int k3 = Rnd.Next(1, 6);
            int k4 = Rnd.Next(1, 6);
            int k5 = Rnd.Next(1, 6);

            // Wyświetlanie obrazów
            k1Image.Source = ImageSource.FromFile($"k{k1}.png");
            k2Image.Source = ImageSource.FromFile($"k{k2}.png");
            k3Image.Source = ImageSource.FromFile($"k{k3}.png");
            k4Image.Source = ImageSource.FromFile($"k{k4}.png");
            k5Image.Source = ImageSource.FromFile($"k{k5}.png");

            // Wynik
            int wynik = (k1 + k2 + k3 + k4 + k5) + 5;
            Display.FontSize = 25;
            Display.HorizontalTextAlignment = TextAlignment.Center;
            if (wynik > 22)
            {

                Display.TextColor = Colors.GreenYellow;
                Display.Text = $"WYNIK TWOICH PUNKTÓW {wynik}, WYGRAŁEŚ";
            }
            else
            {
                Display.TextColor = Colors.IndianRed;
                Display.Text = $"WYNIK TWOICH PUNKTÓW {wynik}, PRZEGRAŁEŚ ĄĆ (gambling)";
            }
        }
    }
}
