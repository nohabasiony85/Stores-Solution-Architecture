﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Stores.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        StoreEntities Init();
    }
}
