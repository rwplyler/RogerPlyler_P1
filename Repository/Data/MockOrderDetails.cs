using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class MockOrderDetails : IOrderDetail
    {

        List<AorderDetail> orderDetails = new List<AorderDetail>() { 
            new AorderDetail(){
                OrderId = 1,
                ItemId = 1,
                Total = 500
            },
            new AorderDetail(){
                OrderId = 1,
                ItemId = 2,
                Total = 400
            },
            new AorderDetail(){
                OrderId = 2,
                ItemId = 1,
                Total = 300
            },
            new AorderDetail(){
                OrderId = 3,
                ItemId = 2,
                Total = 200
            }



        };

        public AorderDetail AddOrderDetail(AorderDetail newOrderDetail)
        {
            orderDetails.Add(newOrderDetail);
            return newOrderDetail;
        }

        public List<AorderDetail> GetAllOrderDetails()
        {
            return orderDetails;
        }

        public List<AorderDetail> GetOrderDetails(int OrderNum)
        {
            return orderDetails.FindAll(o => o.OrderId == OrderNum);
        }

        
        
    }
}
