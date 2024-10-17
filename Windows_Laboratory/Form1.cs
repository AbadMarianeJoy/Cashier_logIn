using System;
using System.Windows.Forms;

namespace Windows_Laboratory
{
    public partial class Form2 : Form
    {
        private double totalPrice = 0;

        public Form2()
        {
            InitializeComponent();
          
        }
            
        private void button_COMPUTE_Click(object sender, EventArgs e)
        {
           
            string itemName = textName.Text;
            double price = Convert.ToDouble(textPrice.Text);
            int quantity = Convert.ToInt32(textBox4.Text);
            double discount = Convert.ToDouble(textDiscount.Text);

            DiscountedItem discountedItem = new DiscountedItem(itemName, price, quantity, discount);

            totalPrice = discountedItem.getTotalPrice();
            label_TOTAL.Text = "Total Price: " + totalPrice.ToString();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            double payment = Convert.ToDouble(textPayment.Text);
            double change = payment - totalPrice;
            label_CHANGE.Text = "Change: " + change.ToString();
        }
        private void ClearFields()
        {
            textName.Clear();
            textPrice.Clear();
            textBox4.Clear();
            textDiscount.Clear();
            textPayment.Clear();
            label_TOTAL.Text = "";
            label_CHANGE.Text = "";
            totalPrice = 0;
        }

 
        public class Item
        {
            protected string Name { get; set; }
            protected double Price { get; set; }
            protected int Quantity { get; set; }

            public Item(string name, double price, int quantity)
            {
                this.Name = name;
                this.Price = price;
                this.Quantity = quantity;
            }

            public virtual double getTotalPrice()
            {
                return Price * Quantity;
            }

            public void setPayment(double amount)
            {
                
            }
        }

        public class DiscountedItem : Item
        {
            private double Discount { get; set; }
            private double discountedPrice;

            public DiscountedItem(string name, double price, int quantity, double discount)
                : base(name, price, quantity)
            {
                this.Discount = discount;
            }

            public override double getTotalPrice()
            {
                double discountValue = Price * (Discount * 0.01);
                discountedPrice = Price - discountValue;
                return discountedPrice * Quantity;
            }
        }

       

        

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Log out logic: Hide Form2 and show Form1 (login form)
            this.Hide(); // Hides the current form (Form2)
            Form1 form1 = new Form1(); // Create a new instance of Form1
            form1.Show(); // Show the login form (Form1)
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Exit the application
            Application.Exit(); // Closes the entire application
        }
    }
    }

