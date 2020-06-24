using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using DAL;
using Logic;

namespace Hub
{
    public partial class Afreken : Form
    {
        public Afreken()
        {
            InitializeComponent();
            FillComboBox();
        }

        private static Afreken _uniqueAfreken;
        public static Afreken GetAfrekenScreen()
        {
            if (_uniqueAfreken == null)
            {
                _uniqueAfreken = new Afreken();
            }
            return _uniqueAfreken;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Hub hub = Hub.GetHubScreen();
            hub.Show();
            this.Hide();
        }

        private void FillComboBox() //combobox vullen met alle tafelnummers
        {
            Payment_Service payment_Service = Payment_Service.GetPaymentService();
            List<int> ids = payment_Service.GetAllReservationID(); ;

            foreach (int i in ids)
            {
                comboBoxGetReservation.Items.Add(i.ToString());
            }
        }

        private void FillListView(int ReservationID)
        {
            lvBestellingen.Items.Clear();
            Payment_Service payment_Service = Payment_Service.GetPaymentService();
            List<OrderDetails> orderDetails = payment_Service.GetOrderDetails(ReservationID);
            foreach (OrderDetails od in orderDetails)
            {
                ListViewItem li = new ListViewItem(od.MenuItemName);
                li.SubItems.Add(od.Amount.ToString());
                li.SubItems.Add(od.Price.ToString());
                lvBestellingen.Items.Add(li);
            }

            double totaalbedrag = 0;
            foreach (ListViewItem li in lvBestellingen.Items)
            {
                totaalbedrag += (double.Parse(li.SubItems[1].Text) * double.Parse(li.SubItems[2].Text));
            }
            lbl_Totaalbedrag.Text = totaalbedrag.ToString();
            totaalbedrag = totaalbedrag * 0.21;
            lbl_BTW.Text = totaalbedrag.ToString();
            lvBestellingen.Refresh();
        }

        private void comboBoxGetReservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillListView(int.Parse(comboBoxGetReservation.SelectedItem.ToString()));
        }

        private void comboBoxGetReservation_SelectedValueChanged(object sender, EventArgs e)
        {
            FillListView(int.Parse(comboBoxGetReservation.SelectedItem.ToString()));
        }

        private void btn_afreken_Click(object sender, EventArgs e)
        {
            Hub hub = Hub.GetHubScreen();
            hub.Show();
            this.Hide();
        }


    }
}
