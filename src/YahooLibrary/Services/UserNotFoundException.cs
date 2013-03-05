﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yahoo.Services
{
    public class UserNotFoundException : ApplicationException
    {
        public UserNotFoundException()
            : base("User cannot be found in database.")
        {
        }
    }
}