using PMS.Core.Models;
using PMS.Core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<LoginDto> FindUserByUsernameAndPasswordAsync(LoginDto loginDto);
        Task<User> GetUserByUsername(string username);
    
}
}
