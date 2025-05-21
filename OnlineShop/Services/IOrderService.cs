using OnlineShopModels.Dto;
using System.Collections.Generic;

namespace OnlineShop.Services
{
    public interface IOrderService
    {
        IEnumerable<FilteredOrderResultDto> GetFiltered();

    }
}
