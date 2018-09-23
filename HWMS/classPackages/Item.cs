using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWMS.classPackages
{
    class Item
    {
        private int itemId;
        private String manufacturer;
        private int supplierId;
        private double realPrice;
        private double sellingPrice;
        private int quantity;
        void addItem(Item itemId) { }
        void removeItem(int itemId) { }
        void updateItem(int itemId) { }
        void searchItem(int itemId) { }
        Order getItemById(int itemId)
        {
            return null;
        }
        void generateItemReport(int itemId) { }
    }
}
