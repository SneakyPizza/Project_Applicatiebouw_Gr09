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
            tlp_OrderGrid.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            CreateOrders();
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

        private void CreateOrders()
        {
            KitchenBar_Service service = KitchenBar_Service.GetBarService();
            List<KitchenBarOrder> orders = service.GetKitchenBarOrders();

            for(int i = 0; i < orders.Count; i++)
            {

                CustomOrderControl card = new CustomOrderControl(orders[i].TableID, orders[i].OrderItems);
                tlp_OrderGrid.Controls.Add(card);
                card.Show();
            }
        }

        private DataTable CreateField(int rows)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Order"));

            for(int i = 0; i < rows; i++)
            {
                dt.Rows.Add(new object[] { "" });
            }
            return dt;
        }
    }
}
