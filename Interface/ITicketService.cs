﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Interface
{
    public interface ITicketService
    {
        /// <summary>
        /// 方法请求模式和路由规则 后面再说
        /// 请求票据列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        List<TicketResponse> Any(TicketRequest request);
        /// <summary>
        /// 删除指定票据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        bool POST(TicketDeleteRequest deleteid);

        /// <summary>
        /// 删除指定票据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        bool Get(TicketDeleteRequest deleteid);

        int POST(TicketUpdateRequest id);
    }
}
