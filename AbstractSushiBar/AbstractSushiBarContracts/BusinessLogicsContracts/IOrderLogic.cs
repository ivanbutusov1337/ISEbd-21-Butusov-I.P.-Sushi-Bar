using System;
using System.Collections.Generic;
using System.Text;
using AbstractSushiBarContracts.BindingModels;
using AbstractSushiBarContracts.ViewModels;

namespace AbstractSushiBarContracts.BusinessLogicsContracts
{
    public interface IOrderLogic
    {
        List<OrderViewModel> Read(OrderBindingModel model);
        void CreateOrder(CreateOrderBindingModel model);
        void TakeOrderInWork(ChangeStatusBindingModel model);
        void FinishOrder(ChangeStatusBindingModel model);
        void DeliveryOrder(ChangeStatusBindingModel model);
    }
}
