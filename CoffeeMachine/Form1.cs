namespace CoffeeMachine
{
    public partial class Form1 : Form
    {
        bool powerState = false;
        int coffeType = 0;
        double coffeSize = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            powerState = !powerState;

            Display.Text = powerState.ToString();
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }



        private void BlackCoffee_Click(object sender, EventArgs e)
        {
            if (powerState)
            {
                coffeType = 1;
                Display.Text = $"Rodzaj kawy: {coffeType} : Czarna";
            }

            else
            {
                Display.Text = "Brak zasilania!!!";
            }
        }

        private void CappuccinoCoffee_Click(object sender, EventArgs e)
        {
            if (powerState)
            {
                coffeType = 2;
                Display.Text = $"Rodzaj kawy: {coffeType} : Cappucchino";
            }

            else
            {
                Display.Text = "Brak zasilania!!!";
            }

        }

        private void EspressoCoffe_Click(object sender, EventArgs e)
        {
            if (powerState)
            {
                coffeType = 3;
                Display.Text = $"Rodzaj kawy: {coffeType} : Espresso";
            }


            else
            {
                Display.Text = "Brak zasilania!!!";
            }
        }


        private void HalfCupCoffe_Click(object sender, EventArgs e)
        {
            if (powerState)
            {
                if (coffeType != 0)
                {
                    coffeSize = 0.5;
                    Display.Text = $"Rozmiar kawy: {coffeSize} fili¿anki";
                }
                else
                {
                    Display.Text = "Podaj rozmiar kawy!!!";
                }

            }
            else
            {
                Display.Text = "Brak zasilania!!!";
            }

        }

        private void FullCupCoffee_Click(object sender, EventArgs e)
        {
            if (powerState)
            {
                if (coffeType != 0)
                {
                    if (coffeType != 3)
                    {
                        coffeSize = 1.0;
                        Display.Text = $"Rozmiar kawy: {coffeSize} fili¿anki";
                    }
                    else
                    {
                        Display.Text = "Espresso tylko w ma³ych fili¿ankach!!!";
                    }

                }
                else
                {
                    Display.Text = "Podaj rozmiar kawy!!!";
                }


            }
            else
            {
                Display.Text = "Brak zasilania!!!";
            }

        }

        private void AddSugar_Click(object sender, EventArgs e)
        {
            SugarLevel.Maximum = 6;
            SugarLevel.Minimum = 0;
            SugarLevel.Step = 1;
            SugarLevel.Value = SugarLevel.Value + 1;
        }

        private void SubSugar_Click(object sender, EventArgs e)
        {
            SugarLevel.Maximum = 6;
            SugarLevel.Minimum = 0;
            SugarLevel.Step = 1;
            SugarLevel.Value = SugarLevel.Value - 1;

        }

        private void RunCoffee_Click(object sender, EventArgs e)
        {
            if(powerState) 
            { 
                if (coffeSize != 0) 
                {
                    CoffeBox.Image = Image.FromFile(@"..\..\..\..\..\coffeecup.png");
                    Display.Text = coffeType.ToString();
                }
                else
                {
                    Display.Text = "Podaj rozmiar kawy!!!";
                }
            }
            else
            {
                Display.Text = "Brak zasilania!!!";
            }
            
        }
    }
}
