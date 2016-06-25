using Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TicketService : ServiceStack.Service, ITicketService
    {
        /// <summary>
        /// 方法请求模式和路由规则 后面再说
        /// 请求票据列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<TicketResponse> Any(TicketRequest request)
        {
            List<TicketResponse> result = new List<TicketResponse>();
            List<OrderResponse> orderlist = new List<OrderResponse>();
            orderlist.Add(new OrderResponse() { OrderId = 1 });
            result.Add(new TicketResponse()
            {
                Orders = orderlist,
                ServerId = 1,
                TableNumber = 1,
                TicketId = 1,
                Timestamp = DateTime.Now
            });
            result.Add(new TicketResponse()
            {
                Orders = orderlist,
                ServerId = 2,
                TableNumber = 2,
                TicketId = 2,
                Timestamp = DateTime.Now
            });

            return result;
        }
        /// <summary>
        /// 删除指定票据（POST）
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public bool POST(TicketDeleteRequest deleteid)
        {
            return true;
        }

        /// <summary>
        /// 删除指定票据(GET)
        /// </summary>
        /// <param name="deleteid"></param>
        /// <returns></returns>
        public bool Get(TicketDeleteRequest deleteid)
        {
            return false;
        }

        public int POST(TicketUpdateRequest id)
        {
            return id.TicketId;
        }
    }
}
