﻿using BLL.DTO;
using DAL.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Abstract
{
    public interface IChatService
    {
        Task<ResponceWithData<List<MessageReadDTO>>> ReadAsync(string reciverID);
        Task<Responce> WriteAsync(MessageWriteDTO messageDTO);
    }
}
