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
        private static MenuItem_Service _uniqueMenuItemService;

        public static MenuItem_Service GetMenuItemService()
        {
            if(_uniqueMenuItemService == null)
            {
                _uniqueMenuItemService = new MenuItem_Service();
            }
            return _uniqueMenuItemService;
        }
        public List<MenuItem> GetMenuItems(int MenuTypeID)
        {
            try
            {
                return MenuItem_DAO.GetMenuItems(MenuTypeID);
            }
            catch(Exception e)
            {
                List<MenuItem> menuItems = new List<MenuItem>();
                MenuItem menuItem = new MenuItem(1, e.ToString(), DateTime.Now, 5, 3, 4);
                menuItems.Add(menuItem);
                return menuItems;
            }
        }
        public List<MenuItem> GetMenuItemOnID(string MenuItemName)
        {
            try
            {
                return MenuItem_DAO.GetMenuItemOnName(MenuItemName);
            }
            catch(Exception e)
            {
                List<MenuItem> menuItems = new List<MenuItem>();
                MenuItem menuItem = new MenuItem(1, e.ToString(), DateTime.Now, 5, 3, 4);
                menuItems.Add(menuItem);
                return menuItems;
            }
        }
        public int GetMenuItemID(string MenuItemName)
        {
            try
            {
                return MenuItem_DAO.GetMenuItemID(MenuItemName);
            }
            catch (Exception e)
            {
                return 999;
            }
        }
    }
}
