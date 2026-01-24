namespace PointOfSaleSystem
{
    public class PointOfSale
    {
        /// <summary>
        /// Subtracts the finalPrice from the amount the customer gives
        /// </summary>
        /// <param name="finalPrice">The amount due by the customer</param>
        /// <param name="customerAmount">The amount of cash the customer is paying</param>
        /// <returns>change if the customer pays more than what is due</returns>
        public double ProcessTransaction(double finalPrice, double customerAmount)
        {
            if (customerAmount < finalPrice)
                throw new ArgumentOutOfRangeException("Insufficient funds.");

            return customerAmount - finalPrice;
        }

        public double ApplyDiscount(string loyalty, double subtotal)
        {
            if (string.IsNullOrWhiteSpace(loyalty))
                throw new ArgumentNullException(nameof(loyalty), "loyalty cannot be empty");
            
            double finalPrice = subtotal;

            switch (loyalty)
            {
                case "Bronze":
                    finalPrice *= 0.9;
                    break;
                case "Silver":
                    finalPrice *= 0.8;
                    break;
                case "Gold":
                    finalPrice *= 0.7;
                    break;
            }

            return Math.Round(finalPrice, 2);
        }

        public double ApplyCoupon(double itemPrice, Coupon coupon)
        {
            if (!coupon.IsValid)
                throw new ArgumentException("Coupon is not valid.");

            return itemPrice - (itemPrice * coupon.Discount);
        }
    }
}
