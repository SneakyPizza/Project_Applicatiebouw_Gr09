using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Model;
using Logic;
using System.IO;

namespace Hub
{
    public partial class BestellingOpnemen : Form
    {
        List<Model.MenuItem> winkelwagen = new List<Model.MenuItem>();
        private static BestellingOpnemen _uniqueOrderScreen;
        public BestellingOpnemen()
        {
            InitializeComponent();
            FillComboBox();
            Login_Service login_Service = Login_Service.GetLoginService();
            lbl_CurrentEmployee.Text = "Ingelogd: " + login_Service.CurrentEmployee.Firstname + " " + login_Service.CurrentEmployee.Lastname;
            lbl_Datum.Text = DateTime.Now.ToString("d");
            listViewMenuItems.View = View.Tile;
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(32, 32);
            //load images from resources

            try
            {
                imageList.Images.Add(Properties.Resources._18plusdranken);
                imageList.Images.Add(Properties.Resources.dranken);
                imageList.Images.Add(Properties.Resources.food);
            }
            catch (Exception e) //afbeeldingen kunnen niet worden gevonden/geladen
            {
                MessageBox.Show("De afbeeldingen kunnen niet worden geladen. De menukaarten worden zonder afbeeldingen getoond.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            listViewMenuItems.SmallImageList = imageList;
            listViewMenuItems.LargeImageList = imageList;
        }

        public static BestellingOpnemen GetOrderScreen()
        {
            if(_uniqueOrderScreen == null)
            {
                _uniqueOrderScreen = new BestellingOpnemen();
            }
            return _uniqueOrderScreen;
        }
        private void Btn_Dranken_Click(object sender, EventArgs e) //laad dranken items
        {
            MenuItem_Service menuItem_Service = new MenuItem_Service();
            List<Model.MenuItem> menuItems = menuItem_Service.GetMenuItems(1);
            listViewMenuItems.Items.Clear();
            listViewMenuItems.TileSize = new Size(200, 50);

            foreach (Model.MenuItem m in menuItems)
            {
                ListViewItem li = new ListViewItem(m.MenuTypeID.ToString(), 1);
                li.SubItems.Add(m.MenuTypeName + ", voorraad: " + m.Stock);
                listViewMenuItems.Items.Add(li);
            }
        }

        private void Btn_DrankenAlcoholisch_Click(object sender, EventArgs e) //laad alcohol items
        {
            MenuItem_Service menuItem_Service = new MenuItem_Service();
            List<Model.MenuItem> menuItems = menuItem_Service.GetMenuItems(2);
            listViewMenuItems.Items.Clear();
            listViewMenuItems.TileSize = new Size(200, 50);

            foreach (Model.MenuItem m in menuItems)
            {
                ListViewItem li = new ListViewItem(m.MenuTypeID.ToString(), 0);
                li.SubItems.Add(m.MenuTypeName + ", voorraad: " + m.Stock);
                listViewMenuItems.Items.Add(li);
            }
        }

        private void Btn_Lunch_Click(object sender, EventArgs e) //laad lunch items
        {
            MenuItem_Service menuItem_Service = new MenuItem_Service();
            List<Model.MenuItem> menuItems = menuItem_Service.GetMenuItems(3);
            listViewMenuItems.Items.Clear();
            listViewMenuItems.TileSize = new Size(450, 100);
            foreach (Model.MenuItem m in menuItems)
            {
                ListViewItem li = new ListViewItem(m.MenuTypeID.ToString(), 2);
                li.SubItems.Add(m.MenuTypeName + ", voorraad: " + m.Stock);
                listViewMenuItems.Items.Add(li);
            }
        }

        private void Btn_Diner_Click(object sender, EventArgs e) //laad diner items
        {
            MenuItem_Service menuItem_Service = new MenuItem_Service();
            List<Model.MenuItem> menuItems = menuItem_Service.GetMenuItems(4);
            listViewMenuItems.Items.Clear();
            listViewMenuItems.TileSize = new Size(450, 100);

            foreach (Model.MenuItem m in menuItems)
            {
                ListViewItem li = new ListViewItem(m.MenuTypeID.ToString(), 2);
                li.SubItems.Add(m.MenuTypeName + ", voorraad: " + m.Stock);
                listViewMenuItems.Items.Add(li);
            }
        }

        private void listViewMenuItems_Click(object sender, EventArgs e) //klik menu item aan -> stuur naar winkelwagen
        {
            int aantal = 1;
            int menuItemID = int.Parse(listViewMenuItems.FocusedItem.Text);
            MenuItem_Service menuItem_Service = new MenuItem_Service();
            List<Model.MenuItem> menuItems = menuItem_Service.GetMenuItemOnID(menuItemID);

            foreach (Model.MenuItem m in menuItems) 
            {
                if (m.Stock > 0)
                {
                    ListViewItem li = new ListViewItem(m.MenuTypeName);
                    li.SubItems.Add(aantal.ToString());
                    listViewWinkelwagen.Items.Add(li);
                }
                else
                {
                    MessageBox.Show("Dit item is niet op voorraad.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Btn_Plus_Click(object sender, EventArgs e) //winkelwagen item verhogen
        {
            if (listViewWinkelwagen.FocusedItem == null)
            {
                MessageBox.Show("Geef eerst aan van welk item je het aantal wilt verhogen.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int aantal = int.Parse(listViewWinkelwagen.FocusedItem.SubItems[1].Text);
                aantal++;
                listViewWinkelwagen.FocusedItem.SubItems[1].Text = aantal.ToString();
            }

        }

        private void Btn_Min_Click(object sender, EventArgs e) //winkelwagen item verlagen
        {
            if (listViewWinkelwagen.FocusedItem == null)
            {
                MessageBox.Show("Geef eerst aan van welk item je het aantal wilt verlagen.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int aantal = int.Parse(listViewWinkelwagen.FocusedItem.SubItems[1].Text);
                aantal--;
                if (aantal > 0)
                {
                    listViewWinkelwagen.FocusedItem.SubItems[1].Text = aantal.ToString();
                }
                else
                {
                    listViewWinkelwagen.Items.Remove(listViewWinkelwagen.FocusedItem);
                }
            }

        }

        private void Btn_BestellingPlaatsen_Click(object sender, EventArgs e) //bestellingen versturen naar db
        {
            int recentOrderID = 0;
            if (cmb_Tafelnr.SelectedItem == null || listViewWinkelwagen.Items.Count == 0) //check of alle velden zijn ingevuld
            {
                MessageBox.Show("Vul alle velden in.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MenuItem_Service menuItem_Service = new MenuItem_Service();
                Table_Service table_Service = new Table_Service();
                Login_Service s = Login_Service.GetLoginService();
                int reservationID = table_Service.GetReservationID(int.Parse(cmb_Tafelnr.SelectedItem.ToString())); //reservationID vinden van betreffende tafel
                if (reservationID == 0)
                {
                    MessageBox.Show("Er is geen reservering voor deze tafel.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Order_DAO order_DAO = new Order_DAO();
                    try //nieuwe order aanmaken voor betreffende tafel
                    {
                        order_DAO.PlaceOrder(1, reservationID, 1, s.CurrentEmployee.Id); //employeeID (2) nog aanpassen
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Order kan niet worden geplaatst. Neem contact op met de it-afdeling en laat de volgende foutmelding zien: " + ex.Message, "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    recentOrderID = GetMostRecentOrderID();
                    List<MenuOrder> menuOrders = new List<MenuOrder>();
                    MenuOrder_DAO menuOrder_DAO = new MenuOrder_DAO();
                    foreach (ListViewItem li in listViewWinkelwagen.Items) //Lijst met MenuOrders maken vanuit winkelwagen
                    {
                        Model.MenuOrder menuOrder = new MenuOrder(int.Parse(li.SubItems[1].Text), recentOrderID, menuItem_Service.GetMenuItemID(li.Text));
                        menuOrders.Add(menuOrder);
                    }
                    foreach(MenuOrder menuOrder in menuOrders) //lijst met menuOrders naar db sturen
                    {
                        menuOrder_DAO.PlaceMenuOrder(menuOrder.Amount, menuOrder.OrderID, menuOrder.MenuItemID);
                        menuOrder_DAO.UpdateStock(menuOrder.Amount, menuOrder.MenuItemID);
                    }
                    OrderPlaced(); 
                    this.Refresh(); //zet scherm weer op default
                }
            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Hub hub = Hub.GetHubScreen();
            hub.Show();
            this.Close();
        }
        private void FillComboBox() //combobox vullen met alle tafelnummers
        {
            Table_Service table_Service = new Table_Service();
            List<Table> tables = table_Service.GetAllTables();

            foreach(Table t in tables)
            {
                cmb_Tafelnr.Items.Add(t.TableID);
            }
        }
        private void OrderPlaced() //winkelwagen legen, tafelnr op default
        {
            MessageBox.Show("Bestelling geplaatst.", "Gelukt!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listViewWinkelwagen.Items.Clear();
            cmb_Tafelnr.SelectedItem = null;
        }
        private int GetMostRecentOrderID()
        {
            Order_Service order_Service = new Order_Service();
            return order_Service.GetMostRecentOrderID();
        }

    }
}
