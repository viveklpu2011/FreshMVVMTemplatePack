using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DuraDriveApp.Services.Interfaces
{
    public interface IUserService
    {
        bool LoggedIn { get; }
        Task SignOutUser();
    }
}
