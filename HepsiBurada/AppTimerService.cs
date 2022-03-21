using System.Timers;
using HepsiBurada.Domain;
using HepsiBurada.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Timer = System.Timers.Timer;

namespace HepsiBurada
{
    public class AppTimerService
    {
        static Timer _timer;

        public static void Start(AppTime appTime)
        {
            var timer = new Timer(2000);
            timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
            timer.Enabled = true;
            _timer = timer;
        }

        static void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var orderService = Startup.ServiceProvider.GetService<IOrderService>();
            orderService.CreateOrder();
        }
    }
}