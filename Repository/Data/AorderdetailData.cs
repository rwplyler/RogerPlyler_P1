using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Data
{
    public class AorderdetailData : IOrderDetail
    {
        Project1Context context = new Project1Context();

        public AorderDetail AddOrderDetail(AorderDetail newOrderDetail)
        {
            context.AorderDetails.Add(newOrderDetail);
            return newOrderDetail;

        }

        public List<AorderDetail> GetAllOrderDetails()
        {
            return context.AorderDetails.ToList();
        }

        public List<AorderDetail> GetOrderDetails(int orderNum)
        {
            return context.AorderDetails.Where(o => o.OrderId == orderNum).ToList();
        }
    }
}
