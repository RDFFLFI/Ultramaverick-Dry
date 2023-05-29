﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.ORDERING_MODEL;

namespace ELIXIR.DATA.CORE.INTERFACES.CANCELLED_INTERFACE
{
    public interface ICancelledOrders
    {
        Task<bool> VoidOrder(CancelledOrders cancelledOrder);
        Task<IEnumerable<CancelledOrders>> GetCancelledOrdersAsync();
    }
}