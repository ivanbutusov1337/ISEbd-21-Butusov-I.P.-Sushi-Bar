using System;
using System.Collections.Generic;
using System.Text;
using AbstractSushiBarContracts.BindingModels;
using AbstractSushiBarContracts.ViewModels;

namespace AbstractSushiBarContracts.BusinessLogicsContracts
{
    public interface IComponentLogic
    {
        List<ComponentViewModel> Read(ComponentBindingModel model);
        void CreateOrUpdate(ComponentBindingModel model);
        void Delete(ComponentBindingModel model);
    }
}
