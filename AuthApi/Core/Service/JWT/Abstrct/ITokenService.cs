﻿using Core.Model.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service.JWT.Abstrct
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}
