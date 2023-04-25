using FluentValidation.AspNetCore;
using iTicketAz.BLL.DTOs.Validators.User;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Threading.RateLimiting;

namespace iTicketAz.BLL
{
    public static class ServiceRegistration
    {
        public static void AddFluentValidation(this IServiceCollection services)
        {
            services.AddFluentValidation(conf =>
            {
                conf.RegisterValidatorsFromAssemblyContaining<AddValidator>();
            });
        }
        public static void AddBLLServices(this IServiceCollection services)
        {
            #region Rate Limit
            services.AddRateLimiter(options =>
                {
                    options.RejectionStatusCode = 429;
                    options.AddFixedWindowLimiter("Fixed", _options =>
                    {
                        _options.Window = TimeSpan.FromSeconds(30);
                        _options.PermitLimit = 4;
                        _options.QueueLimit = 2;
                        _options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
                    });
                });
            #endregion

            #region AutoMapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            #endregion

            #region Scrutor
            services.Scan(scan =>
               {
                   scan.FromCallingAssembly()
                   .AddClasses()
                   .AsMatchingInterface()
                   .WithScopedLifetime();
               });
            #endregion
        }
    }
}
