﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5.Abstract
{
    interface IUserService
    {
        void Add(User user);
        void Delete(User user);
        void Update(User user);

    }
}
