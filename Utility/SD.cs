using System;
using vscode_spice.Models;

namespace vscode_spice.Utility
{
    public static class SD
    {
        // better use a static detail file instead of magic strings
        public const string DefaultFoodImage = "default_food.png";

        public const string ManagerUser = "Manager";
        public const string KitchenUser = "Kitchen";
        public const string FrontDeskUser = "FrondDesk";
        public const string CustomerEndUser = "Customer";
        public const string ssShoppingCartCount = "ssCartCount";
        public const string ssCouponCode = "ssCouponCode";


        public static string ConvertToRawHtml(string source)
        {
            char[] array = new char[source.Length];
            int arrayIndex = 0;
            bool inside = false;

            for (int i = 0; i < source.Length; i++)
            {
                char let = source[i];
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }
            }
            return new string(array, 0, arrayIndex);
        }

        public static double DiscountedPrice(Coupon couponFromDb, double originalOrderTotal)
        {
            if (couponFromDb == null)
            {
                return originalOrderTotal;
            }
            else
            {
                if (couponFromDb.MinimumAmount > originalOrderTotal)
                {
                    return originalOrderTotal;
                }
                else
                {
                    // everything is valid
                    if (Convert.ToInt32(couponFromDb.CouponType) == (int)Coupon.ECouponType.Dollar)
                    {
                        return Math.Round(originalOrderTotal - couponFromDb.Discount, 2);
                    }

                    if (Convert.ToInt32(couponFromDb.CouponType) == (int)Coupon.ECouponType.Percent)
                    {
                        return Math.Round(originalOrderTotal - (originalOrderTotal * couponFromDb.Discount / 100), 2);
                    }
                }
                return originalOrderTotal;
            }
        }
    }
}