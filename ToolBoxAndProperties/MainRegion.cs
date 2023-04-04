using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBoxAndProperties
{
    public partial class MainRegion : Form
    {
        public MainRegion()
        {
            InitializeComponent();
        }

        private void btn_toolBox_Click(object sender, EventArgs e)
        {
            ToolBox frm = new ToolBox();
            frm.Show();
        }

        private void btn_properties_Click(object sender, EventArgs e)
        {
            Propertiess frm = new Propertiess();
            frm.Show();
        }
    }
}
