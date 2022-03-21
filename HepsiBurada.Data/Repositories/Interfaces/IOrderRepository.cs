using System.Collections.Generic;
using HepsiBurada.Domain;

namespace HepsiBurada.Data.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        OrderRequestDto AddOrder(OrderRequestDto order);
        int OrderCountByProductCode(string productCode);
        IList<double> OrderPricesByProductCode(string productCode);
        int FindSoldProductCount(string orderProductCode);
    }
}