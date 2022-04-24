using System;
using System.Collections.Generic;

namespace BizimHesap.Integration
{
    public interface IOperationContext
    {
        Model.Voucher AddVoucher(Model.AddVoucher data);
        IList<Model.Product> Products();
        IList<Model.Warehouse> Warehouses();
        IList<Model.Inventory> Inventories(Guid warehouseId);
    }
}
