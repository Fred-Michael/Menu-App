using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Menu_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanelIndicator.Height = deals.Height;
            SidePanelIndicator.Top = deals.Top;
            veganDish1.BringToFront();
        }

        private void deals_Click(object sender, EventArgs e)
        {
            SidePanelIndicator.Height = deals.Height;
            SidePanelIndicator.Top = deals.Top;
            veganDish1.BringToFront();
        }

        private void specials_Click(object sender, EventArgs e)
        {
            SidePanelIndicator.Height = specials.Height;
            SidePanelIndicator.Top = specials.Top;
            menu_Gallery1.BringToFront();
        }
    }
}
