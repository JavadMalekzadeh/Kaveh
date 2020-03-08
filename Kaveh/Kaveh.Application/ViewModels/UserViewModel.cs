using Kaveh.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kaveh.Application.ViewModels
{
    public class UserViewModel
    {
        public IEnumerable<User> UserDetails { get; set; }
    }
}
