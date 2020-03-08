using Kaveh.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kaveh.Application.Interfaces
{
    public interface IUserService
    {
        UserViewModel GetUserDetailsAll();
    }
}
