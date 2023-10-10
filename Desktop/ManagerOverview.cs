using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class ManagerOverview : Form
    {
        public ManagerOverview()
        {
            InitializeComponent();
        }

        private void btnAreaManagement_Click(object sender, EventArgs e)
        {
            Area_LocationManagement management = new Area_LocationManagement();
            management.Show();

        }
    }
}
