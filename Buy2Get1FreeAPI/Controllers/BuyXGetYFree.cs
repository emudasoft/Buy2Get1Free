using Buy2Get1Free.Dto;
using Buy2Get1Free.Inheritance;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buy2Get1FreeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyXGetYFree : ControllerBase
    {
        public readonly IPromotional _promotional;
        public BuyXGetYFree(IPromotional promotional)
        {
            _promotional = promotional;
        }


        [HttpPost]
        public ActionResult<decimal> GetPrice([FromForm] Basket basket)
        {

            return _promotional.CalculateTotalPrice(basket.apples, basket.oranges, basket.promosionRole);

        }
    }
}
