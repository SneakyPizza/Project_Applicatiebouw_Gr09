using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hub
{
    public partial class KeukenBar : Form
    {
        private static KeukenBar _uniqueKeukenBar;
        public KeukenBar()
        {
            InitializeComponent();

            Login_Service login_Service = Login_Service.GetLoginService();
            lbl_User.Text = "Ingelogd: " + login_Service.CurrentEmployee.Firstname + " " + login_Service.CurrentEmployee.Lastname;
            tlp_OrderGrid.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            MakeBarOrders();
        }

        public static KeukenBar GetKeukenBar()
        {
            if (_uniqueKeukenBar == null)
            {
                _uniqueKeukenBar = new KeukenBar();
            }
            return _uniqueKeukenBar;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Hub h = Hub.GetHubScreen();
            h.Show();
            this.Hide();
        }

        //replace with bar or kitchen
        private void CreateOrders()
        {
            KitchenBar_Service service = KitchenBar_Service.GetBarService();
            List<KitchenBarOrder> orders = service.GetKitchenBarOrders();

            for(int i = 0; i < orders.Count; i++)
            {
                CustomOrderControl card = new CustomOrderControl(orders[i].TableID, orders[i].OrderItems, "Test orders", orders[i].OrderID);
                tlp_OrderGrid.Controls.Add(card);
                card.Show();
            }
        }

        public void ReloadPage(string OrderType)
        {
            Login_Service service = Login_Service.GetLoginService();
            lbl_User.Text = "Ingelogd: " + service.CurrentEmployee.Firstname + " " + service.CurrentEmployee.Lastname;

            switch (OrderType)
            {
                case "Keuken":
                    MakeKitchenOrders();
                    break;
                case "Bar":
                    MakeKitchenOrders();
                    break;
                default:
                    break;
            }
            this.Refresh();
        }

        private void MakeBarOrders()
        {
            KitchenBar_Service service = KitchenBar_Service.GetBarService();
            List<KitchenBarOrder> orders = service.GetKitchenBarOrders();

            foreach(KitchenBarOrder order in orders)
            {
                if(order.Orderstatus == "Besteld" || order.Orderstatus == "Wordt bereid")
                {
                    List<Model.MenuItem> newitems = new List<Model.MenuItem>();
                    List<Model.MenuItem> items = order.OrderItems;
                    foreach (Model.MenuItem item in items)
                    {
                        //Menutype 1 = drinks, Menutype 2 = Alcoholic drinks
                        if (item.MenuTypeID == 1 || item.MenuTypeID == 2)
                        {
                            //add to list
                            newitems.Add(item);
                        }
                    }
                    if (newitems.Count != 0)
                    {
                        CustomOrderControl card = new CustomOrderControl(order.TableID, newitems, "Dranken", order.OrderID);
                        tlp_OrderGrid.Controls.Add(card);
                        card.Show();
                        newitems = null;
                    }
                }
            }
        }

        private void MakeKitchenOrders()
        {
            KitchenBar_Service service = KitchenBar_Service.GetBarService();
            List<KitchenBarOrder> orders = service.GetKitchenBarOrders();

            foreach (KitchenBarOrder order in orders)
            {
                List<Model.MenuItem> newitems = new List<Model.MenuItem>();
                List<Model.MenuItem> items = order.OrderItems;
                foreach (Model.MenuItem item in items)
                {
                    
                    if (item.MenuTypeID == 1 || item.MenuTypeID == 2)
                    {
                        //add to list
                        newitems.Add(item);
                    }
                }
                if (newitems.Count != 0)
                {
                    CustomOrderControl card = new CustomOrderControl(order.TableID, newitems,"", order.OrderID);
                    tlp_OrderGrid.Controls.Add(card);
                    card.Show();
                    newitems = null;
                }
            }
        }
    }
}
