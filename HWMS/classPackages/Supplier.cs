using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWMS.classPackages
{
    class Supplier
    {
        private int supplierId;
        private String supplierFName;
        private String supplierMName;
        private String supplierLName;
        private String addressLine1;
        private String addressLine2;
        private String itemNo;
        private String contact;
        void addSupplier(Supplier s) { }
        void removeSupplier(int supplierId) { }
        void updateSupplier(int supplierId) { }
        void searchSupplier(int supplierId) { }
        Order getSupplierById(int supplierId)
        {
            return null;
        }
        void generateSupplierReport(int supplierId) { }
    }
}
