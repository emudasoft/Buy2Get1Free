using Buy2Get1Free.Dto;
using Buy2Get1Free.Inheritance;

namespace Buy2Get1Free.Processor
{
    public class Promotional : IPromotional
    {
        public decimal CalculateTotalPrice(Apples apple, Oranges orange, PromotionRole promosionRole)
        {
            int totalQuantity = apple.quantity + orange.quantity;
            var totalPrice = (totalQuantity * promosionRole.price);

            if (apple.isPromisionEnable && orange.isPromisionEnable)
            {
                int discountableBundles = totalQuantity / promosionRole.amountOfItemsElegible4Discount;
                var discount = discountableBundles * (promosionRole.amountOfItemsElegible4Discount - promosionRole.pay4) * promosionRole.price;
                totalPrice = totalPrice - discount;
            }
            return totalPrice;
        }
    }
}
