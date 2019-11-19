using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ItemImage : UserControl
    {
        public string labelName
        {
            get { return lb_name.Text; }
            set { lb_name.Text = value; }
        }
        public string labelGia
        {
            get { return lb_gia.Text; }
            set { lb_gia.Text = value; }
        }
        
        public ItemImage()
        {
            InitializeComponent();
        }

        private void jThinButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
