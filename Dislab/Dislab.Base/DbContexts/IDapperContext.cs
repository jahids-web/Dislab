﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dislab.Base.DbContexts
{
    public interface IDapperContext
    {
        IDbConnection CreateConnection();
    }
}
