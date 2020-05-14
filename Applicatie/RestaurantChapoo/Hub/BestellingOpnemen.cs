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
        public BestellingOpnemen()
        {
            InitializeComponent();
            listViewMenuItems.View = View.Tile;
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(32, 32);
            //load images from file
            String[] paths = { };
            paths = Directory.GetFiles("C:/Users/larsd/Documents/GitHub/Project_Applicatiebouw_Gr09/Applicatie/img");
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
            Logic.MenuItem_Service menuItem_Service = new Logic.MenuItem_Service();
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
            Logic.MenuItem_Service menuItem_Service = new Logic.MenuItem_Service();
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
            Logic.MenuItem_Service menuItem_Service = new Logic.MenuItem_Service();
            List<Model.MenuItem> menuItems = menuItem_Service.GetMenuItems(3);
            listViewMenuItems.Items.Clear();
            listViewMenuItems.TileSize = new Size(300, 100);
            foreach (Model.MenuItem m in menuItems)
            {
                ListViewItem li = new ListViewItem(m.MenuTypeID.ToString(), 3);
                li.SubItems.Add(m.MenuTypeName);
                listViewMenuItems.Items.Add(li);
            }
        }

        private void Btn_Diner_Click(object sender, EventArgs e)
        {
            Logic.MenuItem_Service menuItem_Service = new Logic.MenuItem_Service();
            List<Model.MenuItem> menuItems = menuItem_Service.GetMenuItems(4);
            listViewMenuItems.Items.Clear();
            listViewMenuItems.TileSize = new Size(300, 100);

            foreach (Model.MenuItem m in menuItems)
            {
                ListViewItem li = new ListViewItem(m.MenuTypeID.ToString(), 3);
                li.SubItems.Add(m.MenuTypeName);
                listViewMenuItems.Items.Add(li);
            }
        }
    }
}
