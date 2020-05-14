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

namespace Hub
{
    public partial class BestellingOpnemen : Form
    {
        int aantal = 1;
        public BestellingOpnemen()
        {
            InitializeComponent();

        }

        private void Btn_Dranken_Click(object sender, EventArgs e)
        {
            Logic.MenuItem_Service menuItem_Service = new Logic.MenuItem_Service();
            List<Model.MenuItem> menuItems = menuItem_Service.GetMenuItems(1);
            listViewMenuItems.Items.Clear();
            foreach (Model.MenuItem m in menuItems)
            {
                ListViewItem listViewItem = new ListViewItem(m.MenuTypeID.ToString());
                listViewItem.SubItems.Add(m.MenuTypeName);
                listViewItem.SubItems.Add(m.PricePP.ToString("0.00"));
                listViewMenuItems.Items.Add(listViewItem);
            }
        }

        private void Btn_DrankenAlcoholisch_Click(object sender, EventArgs e)
        {
            Logic.MenuItem_Service menuItem_Service = new Logic.MenuItem_Service();
            List<Model.MenuItem> menuItems = menuItem_Service.GetMenuItems(2);
            listViewMenuItems.Items.Clear();
            foreach (Model.MenuItem m in menuItems)
            {
                ListViewItem listViewItem = new ListViewItem(m.MenuTypeID.ToString());
                listViewItem.SubItems.Add(m.MenuTypeName);
                listViewItem.SubItems.Add(m.PricePP.ToString("0.00"));
                listViewMenuItems.Items.Add(listViewItem);
            }
        }

        private void Btn_Lunch_Click(object sender, EventArgs e)
        {
            Logic.MenuItem_Service menuItem_Service = new Logic.MenuItem_Service();
            List<Model.MenuItem> menuItems = menuItem_Service.GetMenuItems(3);
            listViewMenuItems.Items.Clear();
            foreach (Model.MenuItem m in menuItems)
            {
                ListViewItem listViewItem = new ListViewItem(m.MenuTypeID.ToString());
                listViewItem.SubItems.Add(m.MenuTypeName);
                listViewItem.SubItems.Add(m.PricePP.ToString("0.00"));
                listViewMenuItems.Items.Add(listViewItem);
            }
        }

        private void Btn_Diner_Click(object sender, EventArgs e)
        {
            Logic.MenuItem_Service menuItem_Service = new Logic.MenuItem_Service();
            List<Model.MenuItem> menuItems = menuItem_Service.GetMenuItems(4);
            listViewMenuItems.Items.Clear();
            foreach (Model.MenuItem m in menuItems)
            {
                ListViewItem listViewItem = new ListViewItem(m.MenuTypeID.ToString());
                listViewItem.SubItems.Add(m.MenuTypeName);
                listViewItem.SubItems.Add(m.PricePP.ToString("0.00"));
                listViewMenuItems.Items.Add(listViewItem);
            }
        }
    }
}
