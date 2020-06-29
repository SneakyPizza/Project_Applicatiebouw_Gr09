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
            Table table = Table.GetTable();
            Table_Service table_Service = Table_Service.GetTableService();
            FillListView(table_Service.GetReservationID(table.currentTable.TableID));
            FillCurrentTable();
        }

        private static Afreken _uniqueAfreken;
        public static Afreken GetAfrekenScreen()
        {
            if (_uniqueAfreken == null)
            {
                _uniqueAfreken = new Afreken();
            }
            _uniqueAfreken.FillCurrentTable();
            return _uniqueAfreken;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Hub hub = Hub.GetHubScreen();
            hub.Show();
            this.Hide();
        }


        private void FillListView(int ReservationID)
        {
            lvBestellingen.Items.Clear();
            Payment_Service payment_Service = Payment_Service.GetPaymentService();
            List<OrderDetails> orderDetails = payment_Service.GetOrderDetails(ReservationID);
            double btw = 0.09;
            double btw_total = 0;
            foreach (OrderDetails od in orderDetails)
            {
                if (od.MenuTypeID == 2)
                {
                    btw = 0.21;
                }

                double btw_price = double.Parse(od.Price.ToString()) * btw;
                btw_total += btw_price;
                ListViewItem li = new ListViewItem(od.MenuItemName);
                li.SubItems.Add(od.Amount.ToString());
                li.SubItems.Add(od.Price.ToString("0.00"));
                li.SubItems.Add(btw_price.ToString("0.00"));
                lvBestellingen.Items.Add(li);
            }

            double totaalbedrag = 0;
            foreach (ListViewItem li in lvBestellingen.Items)
            {
                totaalbedrag += (double.Parse(li.SubItems[1].Text) * double.Parse(li.SubItems[2].Text));
            }
            lbl_exBedrag.Text = (totaalbedrag - btw_total).ToString("0.00");
            lbl_BTW.Text = btw_total.ToString("0.00");
            lbl_inclBedrag.Text = totaalbedrag.ToString("0.00");
            lvBestellingen.Refresh();
        }

        private void btn_afreken_Click(object sender, EventArgs e)
        {
            Payment_Service payment_Service = Payment_Service.GetPaymentService();
            double Money;
            bool res = double.TryParse(textBoxFooi.Text, out Money);
            if (res == false)
            {
                Money = 0;
            }
            else
            {
                Money = double.Parse(textBoxFooi.Text);
            }
            
            int Payment;
            if (radioButtonPIN.Checked || radioButtonContant.Checked)
            {
                if (radioButtonPIN.Checked)
                {
                    Payment = 2;
                }
                else
                {
                    Payment = 3;
                }
                payment_Service.PlacePayment(Money, Payment);
            }

            MessageBox.Show("Bestelling afgerekend.", "Gelukt!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Tafeloverzicht tafeloverzicht = Tafeloverzicht.GetTafeloverzichtScreen();
            tafeloverzicht.Show();
            this.Hide();
        }

        public void FillCurrentTable()
        {
            Table table = Table.GetTable();
            lbl_currentTable.Text = "Huidige tafel: " + table.currentTable.TableID.ToString();
        }
    }
}
