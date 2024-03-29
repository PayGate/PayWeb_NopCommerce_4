﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework.Mvc.Routing;

namespace Nop.Plugin.Payments.PayGate
{
    public partial class RouteProvider : IRouteProvider
    {
        /// <summary>
        /// Register routes
        /// </summary>
        /// <param name="routeBuilder">Route builder</param>
        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
            //PayGateReturnHandler
            endpointRouteBuilder.MapControllerRoute("Plugin.Payments.PayGate.PayGateReturnHandler",
                "Plugins/PaymentPayGate/PayGateReturnHandler",
                new { controller = "PaymentPayGate", action = "PayGateReturnHandler" }
            );
            //PayGateNotifyHandler
            endpointRouteBuilder.MapControllerRoute("Plugin.Payments.PayGate.PayGateNotifyHandler",
                "Plugins/PaymentPayGate/PayGateNotifyHandler",
                new { controller = "PaymentPayGate", action = "PayGateNotifyHandler" }
            );
        }

        /// <summary>
        /// Gets a priority of route provider
        /// </summary>
        public int Priority
        {
            get { return 0; }
        }
    }
}
