using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorksModel
{
    public class Offer
    {
        private int specialOfferId;
        private string description;
        private decimal discountPct;
        private DateTime startDate;
        private DateTime endDate;

        public int SpecialOfferId
        {
            get { return specialOfferId; }
            set { specialOfferId = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public decimal DiscountPct
        {
            get { return discountPct; }
            set { discountPct = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
    }
}
