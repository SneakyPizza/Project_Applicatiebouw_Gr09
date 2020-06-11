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

            /* foreach (DataRow r in dt.Rows)
              {
                 if(orderid == r.Field<int>("OrderID"))
                 {
                     count++;
                     MenuItem item = new MenuItem(
                     r.Field<int>("MenuItemID"),
                     r.Field<string>("MenuItemName"),
                     r.Field<DateTime>("ShelfLife"),
                     r.Field<decimal>("PricePP")
                     );
                     orderitems.Add(item);

                    orderstatusname = r.Field<string>("OrderStatusName");
                     tableid = r.Field<int>("TableID");

                 } else
                 {
                     KitchenBarOrder order = new KitchenBarOrder(
                     orderid,
                     dt.Rows[count -1].Field<string>("OrderStatusName"),
                     dt.Rows[count-1].Field<int>("TableID"),
                     orderitems);
                     orders.Add(order);

                     orderid = r.Field<int>("OrderID");
                     orderitems.Clear();
                 }


                 if (orderid != r.Field<int>("OrderID"))
                  {
                      KitchenBarOrder order = new KitchenBarOrder(
                          orderid,
                          r.Field<string>("OrderStatusName"),
                          r.Field<int>("TableID"),
                          orderitems);
                      orders.Add(order);

                      orderid = r.Field<int>("OrderID");
                      orderitems.Clear();
                  } 

                  if(orderid == r.Field<int>("OrderID"))
                  {
                      MenuItem item = new MenuItem(
                      r.Field<int>("MenuItemID"),
                      r.Field<string>("MenuItemName"),
                      r.Field<DateTime>("ShelfLife"),
                      r.Field<decimal>("PricePP")
                      );
                      orderitems.Add(item);
                  }



              }*/
            List<KitchenBarOrder> orders = new List<KitchenBarOrder>();
            try
            {
                DataTable dt = _bar_DAO.GetOpenOrders();

                int orderid = 2;
                int count = 0;
                string orderstatusname = "";
                int tableid = 0;


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
                             1,
                             dt.Rows[i].Field<decimal>("PricePP")
                            );
                            orderitems.Add(mitem);
                        }

                        if (dt.Rows[i].Field<int>("OrderID") != dt.Rows[i - 1].Field<int>("OrderID") || (i +1) == dt.Rows.Count)
                        {
                            //List<MenuItem> it = orderitems;

                            KitchenBarOrder order = new KitchenBarOrder(
                            dt.Rows[i - 1].Field<int>("OrderID"),
                            dt.Rows[i - 1].Field<string>("OrderStatusName"),
                            dt.Rows[i - 1].Field<int>("TableID"),
                            new List<MenuItem>(orderitems));

                            orders.Add(order);
                            orderitems.Clear();
                            
                            orderid = dt.Rows[i].Field<int>("OrderID");
                        }
                    }

                    MenuItem item = new MenuItem(
                     dt.Rows[i].Field<int>("MenuItemID"),
                     dt.Rows[i].Field<string>("MenuItemName"),
                     dt.Rows[i].Field<DateTime>("ShelfLife"),
                     1,
                     dt.Rows[i].Field<decimal>("PricePP")
                    );
                     orderitems.Add(item);
                }
                 
            } catch(Exception e)
            {
                throw e;
            }
            return orders;
        }
    }
}
