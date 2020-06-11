using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logic;

namespace Hub
{
    public partial class CustomOrderControl : UserControl
    {
        public CustomOrderControl(int tablenr, List<Model.MenuItem> menuItems)
        {
            InitializeComponent();

            TableNumber = tablenr;
            MenuItems = menuItems;

            foreach(Model.MenuItem mi in menuItems)
            {
                ListViewItem i = new ListViewItem();
                i.Text = mi.MenuTypeName;
                i.SubItems.Add(mi.PricePP.ToString());

                lv_menuItems.Items.Add(i);
            }
        }

        public int TableNumber
        {
            get; set;
        }

        public List<Model.MenuItem> MenuItems
        {
            get; private set;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            //Set this order to done.
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //Set this order to cancelled

        }
    }
}
