namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        void changeBackroundColor(Color color)
        {
            this.BackColor = color;
        }



        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            decimal price = Convert.ToDecimal(textBoxPrice.Text);

            ProductService productService = new ProductService();
            var lastProducttId = productService.CreateNewProductToDatabase(name, price);
            string message = lastProducttId > 0 ? "Success" : "Failes";
            MessageBox.Show(message);
        }
    }
}