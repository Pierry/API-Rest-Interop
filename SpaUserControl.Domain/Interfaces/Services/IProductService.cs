﻿using SpaUserControl.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SpaUserControl.Domain.Interfaces.Services
{
    public interface IProductService
    {
        IEnumerable<Product> Get(int page);
        Product GetByGuid(Guid id);
        void Create(string title, string description, decimal price);
        void ChangeData(Guid id, string description, decimal price);
        void Remove(Guid id);
        void Dispose();
    }
}
