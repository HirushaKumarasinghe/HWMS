using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWMS.classPackages
{
    class PermanentCustomer
    {
        private int customerId;
        private String customerFName;
        private String customerMName;
        private String customerLName;
        private String addressLine1;
        private String addressLine2;
        private String city;
        private double amountPayable;
        private double discount;
        private double creditLimit;
        private DateTime dateAdded;
        private String contact;


        public PermanentCustomer(int customerId, String customerFName, String customerMName, String customerLName, String addressLine1, String addressLine2, String city, double amountPayable, double discount, double creditLimit, DateTime dateAdded,String contact) {
            this.customerId = customerId;
            this.customerFName = customerFName;
            this.customerMName = customerMName;
            this.customerLName = customerLName;
            this.addressLine1 = addressLine1;
            this.addressLine2 = addressLine2;
            this.city = city;
            this.amountPayable = amountPayable;
            this.creditLimit = creditLimit;
            this.dateAdded = dateAdded;
            this.contact = contact;        
        }
        void addCutomer(int customerId, String customerFName, String customerMName, String custom) { }
        void removeCutomer(int customerId) { }
        void updateCutomer(int customerId) { }
        void searchCutomer(int customerId) { }
        Order getCutomerById(int customerId)
        {
            return null;
        }
        void generateCutomerReport(int customerId) { }
    }
}
