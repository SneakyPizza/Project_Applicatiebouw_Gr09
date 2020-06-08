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
        public BestellingOpnemen()
        {
            InitializeComponent();
            FillComboBox();
            listViewMenuItems.View = View.Tile;
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(32, 32);
            //load images from file
            String[] paths = { };
            paths = Directory.GetFiles("C:/Users/larsd/OneDrive/Documenten/GitHub/Project_Applicatiebouw_Gr09/Applicatie/img"); // path aanpassen
            try
            {
                foreach(String path in paths)
                {
                    imageList.Images.Add(Image.FromFile(path));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            listViewMenuItems.SmallImageList = imageList;
            listViewMenuItems.LargeImageList = imageList;
        }
        private void Btn_Dranken_Click(object sender, EventArgs e)
        {
            MenuItem_Service menuItem_Service = new MenuItem_Service();
            List<Model.MenuItem> menuItems = menuItem_Service.GetMenuItems(1);
            listViewMenuItems.Items.Clear();
            listViewMenuItems.TileSize = new Size(200, 50);

            foreach (Model.MenuItem m in menuItems)
            {
                ListViewItem li = new ListViewItem(m.MenuTypeID.ToString(), 1);
                li.SubItems.Add(m.MenuTypeName);
                listViewMenuItems.Items.Add(li);
            }
        }

        private void Btn_DrankenAlcoholisch_Click(object sender, EventArgs e)
        {
            MenuItem_Service menuItem_Service = new MenuItem_Service();
            List<Model.MenuItem> menuItems = menuItem_Service.GetMenuItems(2);
            listViewMenuItems.Items.Clear();
            listViewMenuItems.TileSize = new Size(200, 50);

            foreach (Model.MenuItem m in menuItems)
            {
                ListViewItem li = new ListViewItem(m.MenuTypeID.ToString(), 0);
                li.SubItems.Add(m.MenuTypeName);
                listViewMenuItems.Items.Add(li);
            }
        }

        private void Btn_Lunch_Click(object sender, EventArgs e)
        {
            MenuItem_Service menuItem_Service = new MenuItem_Service();
            List<Model.MenuItem> menuItems = menuItem_Service.GetMenuItems(3);
            listViewMenuItems.Items.Clear();
            listViewMenuItems.TileSize = new Size(330, 100);
            foreach (Model.MenuItem m in menuItems)
            {
                ListViewItem li = new ListViewItem(m.MenuTypeID.ToString(), 3);
                li.SubItems.Add(m.MenuTypeName);
                listViewMenuItems.Items.Add(li);
            }
        }

        private void Btn_Diner_Click(object sender, EventArgs e)
        {
            MenuItem_Service menuItem_Service = new MenuItem_Service();
            List<Model.MenuItem> menuItems = menuItem_Service.GetMenuItems(4);
            listViewMenuItems.Items.Clear();
            listViewMenuItems.TileSize = new Size(330, 100);

            foreach (Model.MenuItem m in menuItems)
            {
                ListViewItem li = new ListViewItem(m.MenuTypeID.ToString(), 3);
                li.SubItems.Add(m.MenuTypeName);
                listViewMenuItems.Items.Add(li);
            }
        }

        private void listViewMenuItems_Click(object sender, EventArgs e)
        {
            int aantal = 1;
            int menuItemID = int.Parse(listViewMenuItems.FocusedItem.Text);
            MenuItem_Service menuItem_Service = new MenuItem_Service();
            List<Model.MenuItem> menuItems = menuItem_Service.GetMenuItemOnID(menuItemID);

            foreach (Model.MenuItem m in menuItems) 
            {
                ListViewItem li = new ListViewItem(m.MenuTypeName);
                li.SubItems.Add(aantal.ToString());
                listViewWinkelwagen.Items.Add(li);
            }

        }

        private void Btn_Plus_Click(object sender, EventArgs e)
        {
            int aantal = int.Parse(listViewWinkelwagen.FocusedItem.SubItems[1].Text);
            aantal++;
            listViewWinkelwagen.FocusedItem.SubItems[1].Text = aantal.ToString();
        }

        private void Btn_Min_Click(object sender, EventArgs e)
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

        private void Btn_BestellingPlaatsen_Click(object sender, EventArgs e) //Lijst met MenuOrder aanmaken voor elk item in lijst. Al deze items versturen naar db én voor elke item Order aanmaken in db
        {
            if (cmb_Tafelnr.SelectedItem == null || listViewWinkelwagen.Items == null)
            {
                MessageBox.Show("Vul alle velden in.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MenuItem_Service menuItem_Service = new MenuItem_Service();
                Table_Service table_Service = new Table_Service();
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
                        order_DAO.PlaceOrder(0, reservationID, 1, 2); //employeeID (2) nog aanpassen
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error: {0}", error.Message);
                    }

                    List<MenuOrder> menuOrders = new List<MenuOrder>();
                    MenuOrder_DAO menuOrder_DAO = new MenuOrder_DAO();
                    foreach (ListViewItem li in listViewWinkelwagen.Items) //order vullen met MenuOrders
                    {
                        Model.MenuOrder menuOrder = new MenuOrder(int.Parse(li.SubItems[1].Text), 50, menuItem_Service.GetMenuItemID(li.Text)); //orderID nog aanpassen
                        menuOrders.Add(menuOrder);
                    }
                    foreach(MenuOrder menuOrder in menuOrders) //alle menuOrders naar db sturen
                    {
                        menuOrder_DAO.PlaceMenuOrder(menuOrder.Amount, menuOrder.OrderID, menuOrder.MenuItemID);
                    }
                    OrderPlaced();
                }


            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Hub hub = new Hub();
            hub.Show();
            this.Close();
        }
        private void FillComboBox()
        {
            Table_Service table_Service = new Table_Service();
            List<Table> tables = table_Service.GetAllTables();

            foreach(Table t in tables)
            {
                cmb_Tafelnr.Items.Add(t.TableID);
            }
        }
        private void OrderPlaced()
        {
            MessageBox.Show("Bestelling geplaatst.", "Gelukt!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listViewWinkelwagen.Items.Clear();
            cmb_Tafelnr.SelectedItem = null;
        }
    }
}
