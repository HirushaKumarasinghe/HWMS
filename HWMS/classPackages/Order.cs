using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWMS.classPackages
{
    class Order
    {
        protected int orderId;
        protected DateTime orderDate;
        protected DateTime orderTime;
        protected String orderdestination;
        protected int ItemId;
        protected double qunatity;
        protected double weight;
        void addOrder(Order order) { }
        void removeOrder(int orederID) { }
        void updateOrder(int orederID) { }
        void searchOrder(int orederID) { }
        Order getOrderById(int orederID) {
            return null;
        }
        void generateOrderReport(int orederID) { }
    }
}
