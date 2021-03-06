﻿using System;
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
        public CustomOrderControl(int tablenr, List<Model.MenuItem> menuItems, int orderid, DateTime orderTime)
        {
            InitializeComponent();

            TableNumber = tablenr;
            MenuItems = menuItems;
            OrderID = orderid;
            lbl_OrderTime.Text = orderTime.ToString("t");
            lbl_tableNumber.Text = tablenr.ToString();
            

            foreach(Model.MenuItem mi in menuItems)
            {
                ListViewItem i = new ListViewItem();
                ListViewItem ii = new ListViewItem(new[] { mi.MenuTypeName, mi.Stock.ToString() }); ;
                i.Text = mi.MenuTypeName;
                i.SubItems.Add(mi.PricePP.ToString());

                lv_menuItems.Items.Add(ii);
            }
        }

        public int TableNumber
        {
            get; set;
        }

        public int OrderID
        {
            get; private set;
        }

        public List<Model.MenuItem> MenuItems
        {
            get; private set;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            //Set this order to done
            KitchenBar_Service service = KitchenBar_Service.GetBarService();
            service.UpdatebarOrder(OrderID, btn_Confirm.Text);
            if (this.MenuItems[0].MenuTypeID == 3 || this.MenuItems[0].MenuTypeID == 4)
            {
                KeukenBar kb = KeukenBar.GetKeukenBar();
                kb.ReloadPage("Keuken");
            }
            if (MenuItems[0].MenuTypeID == 1 || MenuItems[0].MenuTypeID == 2)
            {
                KeukenBar kb = KeukenBar.GetKeukenBar();
                kb.ReloadPage("Bar");
            }
            MessageBox.Show("Bestelling gereed gemeld.", "Gelukt!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
