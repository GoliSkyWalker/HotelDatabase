using System;

namespace HotelDataBaseProj
{
    public class DateManagement
    {
        public DateTime enteranceDate, checkoutDate;
        public int ReservationDuration;

        public DateManagement(DateTime enteranceDate, DateTime checkoutDate)
        {
            this.enteranceDate = enteranceDate;
            this.checkoutDate = checkoutDate;
            CalculateNights(enteranceDate, checkoutDate);
        }

        public DateManagement()
        {
        }

        public void CalculateNights(DateTime enteranceDate, DateTime checkoutDate)
        {
            if (!enteranceDate.Equals(null) && !checkoutDate.Equals(null))
                ReservationDuration = (int) (enteranceDate - checkoutDate).TotalDays - 1;
        }
    }
}