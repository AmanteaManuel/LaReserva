using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaReserva.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Venta venta = new Venta();
            venta.Show();
        }
    }
}
