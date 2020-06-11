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
                CustomOrderControl card = new CustomOrderControl(kbo.TableID, kbo.OrderItems);
                //listView1.Items.Add(card);
                listBox1.Items.Add(card);
                
            }
        }
    }
}
