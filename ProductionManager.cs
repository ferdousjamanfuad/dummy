using BakeryShopManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BakeryShopManagementSystem
{
    public partial class ProductionManager : Form
    {
        public ProductionManager()
        {
            InitializeComponent();
        }

        private void btnexitpm_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
