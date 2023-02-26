using Buy2Get1Free.Dto;

namespace Buy2Get1Free.Inheritance
{
    public   interface IPromotional
    {
        public decimal CalculateTotalPrice(Apples apple, Oranges orange, PromotionRole promosionRole);
    }
}
