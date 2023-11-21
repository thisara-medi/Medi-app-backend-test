using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PMS.Core.Interfaces;
using PMS.Core.Models;
using PMS.Core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Interfaces;
using UnitOfWorkDemo.Infrastructure;
using UnitOfWorkDemo.Infrastructure.Repositories;

namespace PMS.Infrastructure.Repositories.UserRepository
{
    public class UserRepository :  IUserRepository
    {
        private readonly DbContextClass _context;
        private readonly IMapper _mapper;

        public UserRepository(DbContextClass context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<LoginDto> FindUserByUsernameAndPasswordAsync(LoginDto loginDto)
        {
            User user = _mapper.Map<User>(loginDto);

            User foundUser = await _context.Users
                .SingleOrDefaultAsync(u => u.Username == user.Username && u.Password == user.Password);

            // Assuming you have a method to map User to LoginDto in your mapping configuration
            LoginDto foundUserDto = _mapper.Map<LoginDto>(foundUser);

            return foundUserDto;
        }




            public async Task<User> GetUserByUsername(string username)
        {
            throw new NotImplementedException();
        }
    }
}
