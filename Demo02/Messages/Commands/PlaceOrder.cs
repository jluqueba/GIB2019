using NServiceBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo02.Messages.Commands
{
    public class PlaceOrder : ICommand
    {
        public string OrderId { get; set; }
    }
}
