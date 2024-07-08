namespace PerlaMonahElias_projectCSC323
{
    public partial class Form1 : Form
    {
        public Restaurant restaurant;

        public Form1()
        {
            InitializeComponent();
            restaurant = new Restaurant();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        FoodBuilder foodBuilder;
        public decimal price { get;set; }
        public int temperature { get; set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                price = Convert.ToDecimal(textBox1.Text);

            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                temperature = Convert.ToInt32(textBox2.Text);
            }
            catch { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(temperature < 10)
            {
                foodBuilder = new DessertBuilder();
            }
            else if(temperature > 10 && temperature < 20)
            {
                foodBuilder = new AppetizersBuilder();
            }
            else if(temperature >20 && temperature < 25)
            {
                foodBuilder = new SandwichesBuilder();
            }
            else if (temperature > 25)
            {
                foodBuilder = new PlatesBuilder();
            }
            restaurant.BuildFood(foodBuilder, this);
            label5.Text = restaurant.GetReceipt();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = restaurant.GetMenu();
        }
    }
}