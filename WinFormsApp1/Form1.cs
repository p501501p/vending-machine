namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Incraingredient coffee = new Incraingredient();
        Incraingredient water = new Incraingredient();
        Incraingredient Chocolate = new Incraingredient();
        Incraingredient MIke = new Incraingredient();
        BuyDrink1 Use2 = new BuyDrink1();
        BuyDrink02 Use3 = new BuyDrink02();
        StockUp Stock1 = new StockUp();
        INStock INcresincrease = new INStock();
        ConInt1 Convert = new ConInt1();
        BlackCoffee BlackCoffee = new BlackCoffee();
        Mocca Mocca = new Mocca();
        Latte Latte = new Latte();
        Chocolate Chocolate1 = new Chocolate();
        public Form1()
        {
            InitializeComponent();
            coffee.amount = 0;
            water.amount = 0;
            Chocolate.amount = 0;
            MIke.amount = 0;





        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var AllInt = Convert.convert(Twater, TCoffee, TMilk, TChocolate);
            BlackCoffee.Water = AllInt.INwater;
            BlackCoffee.Coffee = AllInt.INCof;
            var B = Use2.BuyDrink(Twater, TCoffee);
            double resultwater = B.OutWater;
            double resultCoffee = B.OutCof;

            if (BlackCoffee.Water >= 300 && BlackCoffee.Coffee >= 20)
            {

                Twater.Text = resultwater.ToString();
                TCoffee.Text = resultCoffee.ToString();

                if (resultwater < 300 || resultCoffee < 20)
                {

                    BBCoffee.Text = "BlackCoffee \n (Out of Stock)";
                    BBCoffee.Enabled = false;

                }

            }
            else
            {
                BBCoffee.Text = "BlackCoffee \n (Out of Stock)";
                BBCoffee.Enabled = false;
                MessageBox.Show("Not enough  Incraingredient ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var AllInt = Convert.convert(Twater, TCoffee, TMilk, TChocolate);
            Mocca.Water = AllInt.INwater;
            Mocca.Coffee = AllInt.INCof;
            Mocca.Choco = AllInt.INChocolate;
            var B = Use3.BuyDrink2(Twater, TCoffee, TChocolate);
            double resultwater = B.OutWater;
            double resultCoffee = B.OutCof;
            double resultChocolate = B.OutChocolate;
            if (Mocca.Water >= 300 && Mocca.Coffee >= 20 && Mocca.Choco >= 10)
            {
                Twater.Text = resultwater.ToString();
                TCoffee.Text = resultCoffee.ToString();
                TChocolate.Text = resultChocolate.ToString();

                if (resultwater < 300 || resultCoffee < 20 || resultChocolate < 10)
                {

                    BMocca.Text = "Mocca \n(Out of Stock)";
                    BMocca.Enabled = false;

                }

            }
            else
            {
                BMocca.Text = "Mocca \n(Out of Stock)";
                BMocca.Enabled = false;
                MessageBox.Show("Not enough  Incraingredient ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var AllInt = Convert.convert(Twater, TCoffee, TMilk, TChocolate);
            var B = Use3.BuyDrink2(Twater, TCoffee, TMilk);
            Latte.Water = AllInt.INwater;
            Latte.Coffee = AllInt.INCof;
            Latte.Milk = AllInt.INMilk;
            double resultwater = B.OutWater;
            double resultCoffee = B.OutCof;
            double resultMilk = B.OutMike;
            if (Latte.Water >= 300 && Latte.Coffee >= 20 && Latte.Milk >= 10)
            {
                Twater.Text = resultwater.ToString();
                TCoffee.Text = resultCoffee.ToString();
                TMilk.Text = resultMilk.ToString();

                if (resultwater < 300 || resultCoffee < 20 || resultMilk < 10)
                {

                    BLatte.Text = "Latte \n(Out of Stock)";
                    BLatte.Enabled = false;

                }
            }

            else
            {
                BLatte.Text = "Latte \n(Out of Stock)";
                BLatte.Enabled = false;
                MessageBox.Show("Not enough  Incraingredient ");

            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            var AllInt = Convert.convert(Twater, TCoffee, TMilk, TChocolate);
            var B = Use2.BuyDrink(Twater, TChocolate);
            double resultwater = B.OutWater;
            double resultCoffee = B.OutChocolate;
            Chocolate1.Water = AllInt.INwater;
            Chocolate1.Choco = AllInt.INChocolate;
            if (Chocolate1.Water >= 300 && Chocolate1.Choco >= 20)
            {
                Twater.Text = resultwater.ToString();
                TChocolate.Text = resultCoffee.ToString();
                if (resultwater < 300 || resultCoffee < 20)
                {

                    BChocolate.Text = "Chocolate \n (Out of Stock)";
                    BChocolate.Enabled = false;

                }

            }
            else
            {

                BChocolate.Text = "Chocolate \n (Out of Stock)";
                BChocolate.Enabled = false;
                MessageBox.Show("Not enough  Incraingredient ");

            }
        }

        private void BStockUp_Click(object sender, EventArgs e)
        {

            var AllInt = Convert.convert(Swater, Scoffee, Smilk, SChoco);
            INcresincrease.INwater = AllInt.INwater;
            INcresincrease.INCof = AllInt.INCof;
            INcresincrease.INMilk = AllInt.INMilk;
            INcresincrease.INChocolate = AllInt.INChocolate;
            var W = Stock1.StockUp1(INcresincrease, Twater, TCoffee, TMilk, TChocolate);
            double I1 = W.StockWater;
            double I2 = W.StockCof;
            double I3 = W.StockMilk;
            double I4 = W.StockChocolate;
            Twater.Text = I1.ToString();
            TCoffee.Text = I2.ToString();
            TMilk.Text = I3.ToString();
            TChocolate.Text = I4.ToString();
            if (I1 >= 300 && I2 >= 20)
            {
                BBCoffee.Text = "BlackCoffee";
                BBCoffee.Enabled = true;
            }
            if (I1 >= 300 && I2 >= 20 && I4 >= 10)
            {
                BMocca.Text = "Mocca";
                BMocca.Enabled = true;
            }
            if (I1 >= 300&& I2 >= 20 && I3 >= 10)
            {
                BLatte.Text = "Latte";
                BLatte.Enabled = true;
            }
            if (I1 >= 300 && I4 >= 10)
            {
                BChocolate.Text = "Chocolate";
                BChocolate.Enabled = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Twater_TextChanged(object sender, EventArgs e)
        {

        }

        private void Swater_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Pic2_Click(object sender, EventArgs e)
        {

        }
    }
}
