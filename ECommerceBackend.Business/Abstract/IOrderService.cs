﻿using ECommerceBackend.Core.Utilities.Results;
using ECommerceBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<Order> GetById(int orderId);
        IDataResult<List<Order>> GetList();
        IResult Add(Order order);
        IResult Delete(Order order);
        IResult Update(Order order);
    }
}
