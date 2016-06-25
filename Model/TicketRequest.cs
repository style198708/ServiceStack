using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 创建票据 请求实体
    /// </summary>
    public class TicketRequest : IReturn<TicketResponse>
    {
        public int TicketId { get; set; }
        public int TableNumber { get; set; }
        public int ServerId { get; set; }
    }
    public class TicketDeleteRequest
    {
        public int TicketId { get; set; }
    }
    public class TicketUpdateRequest
    {
        public int TicketId { get; set; }
    }
}
