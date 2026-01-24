using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSaleSystem
{
    public class Coupon
    {
        public double Discount { get; set; }
        public bool IsValid { get; set; }

        public Coupon(double discount, bool isValid) 
        {
            Discount = discount;
            IsValid = isValid;
        }
    }
}
