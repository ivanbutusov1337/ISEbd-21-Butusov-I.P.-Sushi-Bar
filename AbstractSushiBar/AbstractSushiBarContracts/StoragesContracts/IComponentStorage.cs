﻿using System;
using System.Collections.Generic;
using System.Text;
using AbstractSushiBarContracts.BindingModels;
using AbstractSushiBarContracts.ViewModels;

namespace AbstractSushiBarContracts.StoragesContracts
{
    public interface IComponentStorage
    {
        List<ComponentViewModel> GetFullList();
        List<ComponentViewModel> GetFilteredList(ComponentBindingModel model);
        ComponentViewModel GetElement(ComponentBindingModel model);
        void Insert(ComponentBindingModel model);
        void Update(ComponentBindingModel model);
        void Delete(ComponentBindingModel model);
    }
}
