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
using Logic;
using DAL;

namespace Hub
{
    public partial class Tafeloverzicht : Form
    {
        public Tafeloverzicht()
        {
            InitializeComponent();
            ChangeColor();
            FillListView();
        }

        private static Tafeloverzicht _uniqueTafeloverzicht;
        public static Tafeloverzicht GetTafeloverzichtScreen()
        {
            if (_uniqueTafeloverzicht == null)
            {
                _uniqueTafeloverzicht = new Tafeloverzicht();
            }
            return _uniqueTafeloverzicht;
        }

        public void ChangeColor()
        {
            int count = 0;
            Table_Service tableservice = new Table_Service();
            List<Table> tables = tableservice.GetAllTables();

            Reservation_Service service = Reservation_Service.GetReservationService();
            foreach (var groupBox in Controls.OfType<GroupBox>())
            {
                foreach (var button in groupBox.Controls.OfType<Button>())
                {
                    Table t = tables[count];
                    if (t.TableStatus == 0)
                    {
                        button.BackColor = Color.Green;
                        button.Enabled = false;
                    }
                    else
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = true;
                    }
                    count++;
                }
            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Hub hub = Hub.GetHubScreen();
            hub.Show();
            this.Hide();
        }

        private void FillListView()
        {
            PendingOrder_Service service = new PendingOrder_Service();
            List<PendingOrder> pendingorder = service.GetAllPendingOrders();

            lvOverzicht.Items.Clear();
            foreach (Model.PendingOrder po in pendingorder)
            {
<<<<<<< HEAD
                ListViewItem li = new ListViewItem(po.OrderStatusName);
                li.SubItems.Add(po.TableID.ToString());
=======
                ListViewItem li = new ListViewItem(po.TableID.ToString());
                li.SubItems.Add(po.OrderStatusName);
>>>>>>> origin/Lars-v2
                lvOverzicht.Items.Add(li);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            PendingOrder_Service service = new PendingOrder_Service();
            List<PendingOrder> pendingorder = service.GetAllPendingOrders();

            lvOverzicht.Items.Clear();
            foreach (Model.PendingOrder po in pendingorder)
            {
<<<<<<< HEAD
                ListViewItem li = new ListViewItem(po.OrderStatusName);
                li.SubItems.Add(po.TableID.ToString());
=======
                ListViewItem li = new ListViewItem(po.TableID.ToString());
                li.SubItems.Add(po.OrderStatusName);
>>>>>>> origin/Lars-v2
                lvOverzicht.Items.Add(li);
            }
        }

        private void tafel3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            Table currentTable = Table.GetTable();
            currentTable.currentTable = new Table(3, 1);
>>>>>>> origin/Lars-v2
            if (tafel3.BackColor == Color.Red)
            {
                BestellingOpnemen bestellingopnemen = BestellingOpnemen.GetOrderScreen();
                bestellingopnemen.Show();
                this.Hide();
            }
        }

        private void tafel4_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            Table currentTable = Table.GetTable();
            currentTable.currentTable = new Table(4, 1);
>>>>>>> origin/Lars-v2
            if (tafel4.BackColor == Color.Red)
            {
                BestellingOpnemen bestellingopnemen = BestellingOpnemen.GetOrderScreen();
                bestellingopnemen.Show();
                this.Hide();
            }
        }
<<<<<<< HEAD
=======

        private void btn_Afrekenen_Click(object sender, EventArgs e)
        {
            if (lvOverzicht.FocusedItem == null)
            {
                MessageBox.Show("Selecteer eerst een tafel uit bovenstaande lijst.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Table currentTable = Table.GetTable();
                currentTable.currentTable = new Table(int.Parse(lvOverzicht.FocusedItem.Text), 0);
                Afreken afreken = Afreken.GetAfrekenScreen();
                afreken.Show();
                this.Hide();
            }
        }
>>>>>>> origin/Lars-v2
    }
}
