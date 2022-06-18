﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeDotsV2.Contracts.Authentication
{
    public record LoginRequest(
        string FirstName,
        string LastName,
        string Email,
        string Password);

}
