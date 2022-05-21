﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Interfaces
{
    public interface IMainView
    {
        void OpenRegisterForm();

        void OpenLoginForm();

        void OpenUserForm();

        void NotifyLogoutUser();

    }
}
