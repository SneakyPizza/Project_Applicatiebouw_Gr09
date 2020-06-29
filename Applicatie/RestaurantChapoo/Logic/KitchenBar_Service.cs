using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class KitchenBar_Service
    {
        private Bar_DAO _bar_DAO = new Bar_DAO();
        private static KitchenBar_Service _uniqueBarService;

        public static KitchenBar_Service GetBarService()
        {
            if(_uniqueBarService == null)
            {
                _uniqueBarService = new KitchenBar_Service();
                
            }
            return _uniqueBarService;
        }

        public List<KitchenBarOrder> GetKitchenBarOrders()
        {
            List<KitchenBarOrder> orders = new List<KitchenBarOrder>();
            try
            {
                DataTable dt = _bar_DAO.GetOpenOrders();

                int orderid = 2;
                List<MenuItem> orderitems = new List<MenuItem>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if(i > 1)
                    {
                        if ((i +1) == dt.Rows.Count)
                        {
                            MenuItem mitem = new MenuItem(
                             dt.Rows[i].Field<int>("MenuItemID"),
                             dt.Rows[i].Field<string>("MenuItemName"),
                             dt.Rows[i].Field<DateTime>("ShelfLife"),
                             dt.Rows[i].Field<int>("Amount"),
                             dt.Rows[i].Field<decimal>("PricePP"),
                             dt.Rows[i].Field<int>("MenuTypeID")
                            );
                            orderitems.Add(mitem);
                        }

                        if (dt.Rows[i].Field<int>("OrderID") != dt.Rows[i - 1].Field<int>("OrderID") || (i + 1) == dt.Rows.Count)
                        {
                            //List<MenuItem> it = orderitems;

                            KitchenBarOrder order = new KitchenBarOrder(
                            dt.Rows[i - 1].Field<int>("OrderID"),
                            dt.Rows[i - 1].Field<string>("OrderStatusName"),
                            dt.Rows[i - 1].Field<int>("TableID"),
                            new List<MenuItem>(orderitems),
                            dt.Rows[i - 1].Field<DateTime>("OrderTime"));

                            orders.Add(order);
                            orderitems.Clear();
                            
                            orderid = dt.Rows[i].Field<int>("OrderID");
                        }
                    }

                    MenuItem item = new MenuItem(
                             dt.Rows[i].Field<int>("MenuItemID"),
                             dt.Rows[i].Field<string>("MenuItemName"),
                             dt.Rows[i].Field<DateTime>("ShelfLife"),
                             dt.Rows[i].Field<int>("Amount"),
                             dt.Rows[i].Field<decimal>("PricePP"),
                             dt.Rows[i].Field<int>("MenuTypeID")
                    );
                     orderitems.Add(item);
                }
                 
            } catch(Exception e)
            {
                throw e;
            }
            return orders;
        }

        public void UpdatebarOrder(int ordernr, string status)
        {
            int statID = 0;
            switch (status)
            {
                case "Gereed":
                    statID = 3;
                    break;
                case "Annuleren":
                    statID = 4;
                    break;
                case "Afrekenen":
                    statID = 5;
                    break;
                default:
                    break;
            }

            if(statID != 0)
            {
                _bar_DAO.UpdateOrder(ordernr, statID);
            }
        }
    }
}
