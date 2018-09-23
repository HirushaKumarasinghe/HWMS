using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWMS.classPackages
{
    class Property
    {
        private int propertyId;
        private DateTime dateAdded;
        private String description;
        private double price;
        private double val1;
        private double val2;
        void addProperty(Property pr) { }
        void removeProperty(int propertyId) { }
        void updateProperty(int propertyId) { }
        void searchProperty(int propertyId) { }
        Order getPropertyById(int propertyId)
        {
            return null;
        }
        void generatePropertyReport(int propertyId) { }
    }
}
