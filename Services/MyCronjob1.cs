using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using DVN.Data;
using DVN.Models;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DVN.Services
{
    public class MyCronJob1 : CronJobService
    {
        private readonly ILogger<MyCronJob1> _logger;
        private IServiceScopeFactory serviceProvider;
        private IConfiguration configuration;
        public MyCronJob1(IScheduleConfig<MyCronJob1> config, ILogger<MyCronJob1> logger, IServiceScopeFactory serviceProvider, IConfiguration configuration)
            : base(config.CronExpression, config.TimeZoneInfo)
        {
            _logger = logger;
            this.configuration = configuration;
            this.serviceProvider = serviceProvider;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("START.");
            return base.StartAsync(cancellationToken);
        }

        public override Task DoWork(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{DateTime.Now:hh:mm:ss} DOWROK RUN.");

            // THEM DON HANG O DAY 

            // GET ALL CUSTOMER ACTIVE ----------------


            // CREATE ORDER TEMP
            using (var scope = serviceProvider.CreateScope()) // this will use `IServiceScopeFactory` internally
            {
                var db = scope.ServiceProvider.GetService<ApplicationDbContext>();
                var customerActives = db.Customers.Where(item => item.Status == true).ToList();
                var option = db.Options.Where(item => item.Type == "Unitprice").FirstOrDefault();

                float unitPrice = 0;
                if (option != null)
                {
                    unitPrice = float.Parse(option.Value);
                }

                foreach (var item in customerActives)
                {
                    var orderTemp = new Order
                    {
                        CustomerId = item.Id,
                        Status = OrderStatus.NoProcess,
                        CreatTime = DateTime.Now,
                        UnitPrice = unitPrice
                    };

                    db.Orders.Add(orderTemp);
                }

                db.SaveChanges();
            }


            return Task.CompletedTask;
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("CronJob STOPPPPPPPPPPP.");
            return base.StopAsync(cancellationToken);
        }
    }
}