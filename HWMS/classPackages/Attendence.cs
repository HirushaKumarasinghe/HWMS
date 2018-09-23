using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWMS.classPackages
{
    class Attendence
    {
        private int empId;
        private DateTime date;
        private DateTime startTime;
        private DateTime endTime;

        public Attendence() { }
        public Attendence(int empId, DateTime date, DateTime startTime, DateTime endTime) {
            this.empId = empId;
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
        }
        void addAttendence(Bill bill) { }
        void removeAttendence(int billId) { }
        void updateAttendence(int billId) { }
        void searchAttendence(int billId) { }
        Bill getAttendenceById(int billId)
        {
            return null;
        }
        void generateAttendenceReport(int billId) { }
    }
}
