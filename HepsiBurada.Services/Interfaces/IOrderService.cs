using HepsiBurada.Services.Service;

namespace HepsiBurada.Services.Interfaces
{
    public interface IOrderService
    {
        string CreateOrder(string[] commandArray);
        string CreateOrder();
    }
}