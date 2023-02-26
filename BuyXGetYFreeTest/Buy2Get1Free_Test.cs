using Buy2Get1Free.Dto;
using Buy2Get1Free.Inheritance;
using Buy2Get1Free.Processor;
using System;
using Xunit;

namespace BuyXGetYFreeTest
{
    public class Buy2Get1Free_Test
    {
        [Fact]
        public void Promoyional_test_false()
        {
            IPromotional promotional = new Promotional();
            Apples apple = new Apples();
            Oranges orange = new Oranges();
            apple.quantity = 0;

            orange.quantity = 0;
            apple.isPromisionEnable = true;
            orange.isPromisionEnable = true;
            PromotionRole promosionRole = new PromotionRole();
            promosionRole.amountOfItemsElegible4Discount = 3;
            promosionRole.pay4 = 2;
            promosionRole.price = 0;
            decimal result = promotional.CalculateTotalPrice(apple, orange, promosionRole);
            bool expected = result > 0 ? true : false;
            Assert.False(expected, "Total Price:" + result);

        }
        [Fact]
        public void Promoyional_test_True()
        {
            Promotional promotional = new Promotional();
            Apples apple = new Apples();
            Oranges orange = new Oranges();
            apple.isPromisionEnable = true;
            orange.isPromisionEnable = true;
            apple.quantity = 5;
            orange.quantity = 7;
            PromotionRole promosionRole = new PromotionRole();
            promosionRole.amountOfItemsElegible4Discount = 3;
            promosionRole.pay4 = 2;
            promosionRole.price = 5;
            decimal result = promotional.CalculateTotalPrice(apple, orange, promosionRole);
            bool expected = result > 0 ? true : false;
            Assert.True(expected, "Total Price:" + result);

        }

        [Fact]
        public void Promoyional_test_True_Without_promotion()
        {
            Promotional promotional = new Promotional();
            Apples apple = new Apples();
            Oranges orange = new Oranges();
            apple.isPromisionEnable = false;
            orange.isPromisionEnable = false;
            apple.quantity = 5;
            orange.quantity = 7;
            PromotionRole promosionRole = new PromotionRole();
            promosionRole.amountOfItemsElegible4Discount = 3;
            promosionRole.pay4 = 2;
            promosionRole.price = 5;
            decimal result = promotional.CalculateTotalPrice(apple, orange, promosionRole);
            bool expected = result > 0 ? true : false;
            Assert.True(expected, "Total Price:" + result);

        }

    }
}
