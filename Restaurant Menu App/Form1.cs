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
            //menu_Gallery1.BringToFront();
        }

        private void eat_in_Click(object sender, EventArgs e)
        {
            SidePanelIndicator.Height = eat_in.Height;
            SidePanelIndicator.Top = eat_in.Top;
        }

        private void collections_Click(object sender, EventArgs e)
        {
            SidePanelIndicator.Height = collections.Height;
            SidePanelIndicator.Top = collections.Top;
        }

        private void delivery_Click(object sender, EventArgs e)
        {
            SidePanelIndicator.Height = delivery.Height;
            SidePanelIndicator.Top = delivery.Top;
        }

        private void map_location_Click(object sender, EventArgs e)
        {
            SidePanelIndicator.Height = map_location.Height;
            SidePanelIndicator.Top = map_location.Top;
        }
    }
}
