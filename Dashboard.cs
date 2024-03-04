using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zakaria_Location
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Utils.AfficherImageAdmin(logo);
            Utils.NomApplication(lb_na);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormVoiture emp = new FormVoiture();
            this.Hide();
            emp.Show();
        }
    }
}
