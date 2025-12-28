using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakeryShopManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txturname.Text = "";
            txtpass.Text = "";
        }

        private void btnlgn_Click(object sender, EventArgs e)
        {
            if (txturname.Text == "")
              lblerrorurname.Visible = true;
            else
                lblerrorurname.Visible = false;

            if (txtpass.Text == "")
                  lblerrorpass.Visible = true;
              else
                  lblerrorpass.Visible = false;



            if (txturname.Text == "admin" && txtpass.Text == "admin")
            {
                this.Hide();
                Admin admin = new Admin();
                admin.Show();
            }
            else if (txturname.Text == "cashier" && txtpass.Text == "cashier")
            {
                this.Hide();
                Cashier cashier = new Cashier();
                cashier.Show();
            }
            else if (txturname.Text == "pm" && txtpass.Text == "pm")
            {
                this.Hide();
                ProductionManager pm = new ProductionManager();
                pm.Show();
            }
            else if (txturname.Text == "im" && txtpass.Text == "im")
            {
                this.Hide();
                InventoryManager im = new InventoryManager();
                im.Show();
            }
            else
            {
                if (txturname.Text != "" && txtpass.Text != "")
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txturname.Text = "";
                    txtpass.Text = "";
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblerrorurname.Visible = false;
            lblerrorpass.Visible = false;
        }

        private void linklblreg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }
    }
}