namespace _4M04Kostki
{
    public partial class MainPage : ContentPage
    {

        int suma = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnRzutClicked(object sender, EventArgs e)
        {
            suma = 0;
            int rzut;
            Random r = new Random();

            Image[] kostki = new Image[] { k00, k01, k10, k11, k20, k21 };

            /*
            rzut = r.Next(1, 7);
            k00.Source = "kosc" + rzut.ToString() + ".png";
            suma += rzut;
            */

            
            foreach(var k in kostki)
            {
                rzut = r.Next(1, 7);
                k.Source = "kosc" + rzut.ToString() + ".png";
                suma += rzut;
            }


            lblSuma.Text = $"Suma: {suma}";
        }


    }

}
