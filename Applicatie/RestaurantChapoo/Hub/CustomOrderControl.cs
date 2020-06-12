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
        public CustomOrderControl(int tablenr, List<Model.MenuItem> menuItems, string menutype, int orderid)
        {
            InitializeComponent();

            TableNumber = tablenr;
            MenuItems = menuItems;
            OrderID = orderid;
            lbl_DinerType.Text = OrderID.ToString();
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
            lv_menuItems.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv_menuItems.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
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
            KitchenBar_Service service = KitchenBar_Service.GetBarService();
            service.UpdatebarOrder(OrderID, btn_Confirm.Text);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //Set this order to cancelled
            KitchenBar_Service service = KitchenBar_Service.GetBarService();
            service.UpdatebarOrder(OrderID, btn_Cancel.Text);
        }
    }
}
