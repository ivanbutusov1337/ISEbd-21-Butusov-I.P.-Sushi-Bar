using AbstractSushiBarContracts.BindingModels;
using AbstractSushiBarContracts.ViewModels;
using System.Collections.Generic;

namespace AbstractSushiBarContracts.BusinessLogicsContracts
{
    public interface IProductLogic
    {
        List<ProductViewModel> Read(ProductBindingModel model);
        void CreateOrUpdate(ProductBindingModel model);
        void Delete(ProductBindingModel model);
    }
}
