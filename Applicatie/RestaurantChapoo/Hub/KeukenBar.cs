using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            CreateOrders();
        }

        public static KeukenBar GetKeukenBar()
        {
            if(_uniqueKeukenBar == null)
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
            foreach(KitchenBarOrder kbo in orders)
            {

                //listView1.Items.Add(card);
                //listBox1.Items.Add(card);
                
            }

            for(int i = 0; i < orders.Count; i++)
            {
               /* CustomOrderControl card = new CustomOrderControl(orders[i].TableID, orders[i].OrderItems);
                dgv_UserControl.Controls.Add(card);
                card.Location = dgv_UserControl.GetCellDisplayRectangle(0, i, false).Location;
                card.Size = dgv_UserControl.GetCellDisplayRectangle(0, i, false).Size; */
            }
        }
    }
}
