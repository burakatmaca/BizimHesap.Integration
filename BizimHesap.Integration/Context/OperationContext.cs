using BizimHesap.Integration.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace BizimHesap.Integration
{
    public class OperationContext : IOperationContext
    {
        readonly IIntegrationContext _integrationContext;

        public OperationContext([NotNull] IIntegrationContext integrationContext)
        {
            this._integrationContext = integrationContext;
        }

        public Voucher AddVoucher(AddVoucher data)
        {
            throw new NotImplementedException();
        }
        public IList<Product> Products()
        {
            throw new NotImplementedException();
        }
        public IList<Warehouse> Warehouses()
        {
            throw new NotImplementedException();
        }
        public IList<Inventory> Inventories(Guid warehouseId)
        {
            throw new NotImplementedException();
        }
    }
}
