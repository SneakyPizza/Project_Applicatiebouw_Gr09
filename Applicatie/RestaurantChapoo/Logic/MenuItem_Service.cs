﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic
{
    public class MenuItem_Service
    {
        MenuItem_DAO MenuItem_DAO = new MenuItem_DAO();
        public List<MenuItem> GetMenuItems(int MenuTypeID)
        {
            try
            {
                return MenuItem_DAO.GetMenuItems(MenuTypeID);
            }
            catch(Exception e)
            {
                List<MenuItem> menuItems = new List<MenuItem>();
                MenuItem menuItem = new MenuItem(1, e.ToString(), DateTime.Now, 3);
                menuItems.Add(menuItem);
                return menuItems;
            }
        }
    }
}