﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStarApplication.Services.Interfaces
{
    public interface IMailService
    {
        void SendMail(string to, string from, string subject, string body);
    }
}
