﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 项目经理信息接口
/// </summary>
namespace ChinaBank.IService
{
    using ChinaBank.Model;
    public interface  IManagessageServices
    {
        int Add(Managemessage message);

        List<Managemessage> GetManagemessage();
  
    }
}
