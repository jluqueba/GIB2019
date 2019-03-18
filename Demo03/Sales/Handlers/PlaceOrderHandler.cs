﻿using Demo03.Messages.Commands;
using Demo03.Messages.Events;
using NServiceBus;
using NServiceBus.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Sales.Handlers
{
    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        // It´s an expensive call so implent it as static
        static ILog log = LogManager.GetLogger<PlaceOrderHandler>();

        public Task Handle(PlaceOrder message, IMessageHandlerContext context)
        {
            log.Info($"Received PlaceOrder, OrderId = {message.OrderId}");

            var orderPlaced = new OrderPlaced() { OrderId = message.OrderId };

            //Thisnis teh way to publich an event inside a handler
            return context.Publish(orderPlaced);
        }
    }
}
