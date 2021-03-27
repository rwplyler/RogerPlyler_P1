using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public interface IOrderDetail
    {
        List<AorderDetail> GetOrderDetails(int orderNum);

        AorderDetail AddOrderDetail(AorderDetail newOrderDetail);

        List<AorderDetail> GetAllOrderDetails();
    }
}
