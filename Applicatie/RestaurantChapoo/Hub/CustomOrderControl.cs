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

            lbl_tableNumber.Text = tablenr.ToString();
            lv_menuItems.Columns.Add("Gerecht");
            lv_menuItems.Columns.Add("Aantal");
            

            foreach(Model.MenuItem mi in menuItems)
            {
                ListViewItem i = new ListViewItem();
                ListViewItem ii = new ListViewItem(new[] { mi.MenuTypeName, mi.Stock.ToString() }); ;
                i.Text = mi.MenuTypeName;
                i.SubItems.Add(mi.PricePP.ToString());

                lv_menuItems.Items.Add(ii);
            }
            //lv_menuItems.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv_menuItems.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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
