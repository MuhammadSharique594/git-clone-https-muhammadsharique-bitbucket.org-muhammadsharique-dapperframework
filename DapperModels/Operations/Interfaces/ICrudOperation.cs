﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperModels.Operations.Interfaces
{
    public interface ICrudOperation
    {
        void Insert();
        void Update();
        void Delete();
        void Select();
    }
}
