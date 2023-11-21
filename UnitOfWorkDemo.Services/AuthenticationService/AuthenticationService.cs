using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using PMS.Core.Models;
using PMS.Core.Models.DTO;
using PMS.Endpoints;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Interfaces;
using UnitOfWorkDemo.Infrastructure.Repositories;

namespace PMS.Services.AuthenticationService
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly TokenService _tokenService;
        private readonly IMapper _mapper;


        public AuthenticationService(IUnitOfWork unitOfWork, TokenService tokenService, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _tokenService = tokenService;
            _mapper = mapper;
        }
        public async Task<LoginDto> LoginUser(LoginDto loginDto)
        {
            if (string.IsNullOrEmpty(loginDto.Username) || string.IsNullOrEmpty(loginDto.Password))
            {
                throw new ArgumentException("Invalid username or password");
            }

            var user = await _unitOfWork.UserRepository.FindUserByUsernameAndPasswordAsync(loginDto);

            if (user == null)
            {
                throw new UnauthorizedAccessException("Invalid username or password");
            }

            var token = _tokenService.GenerateToken(TokenGenerate.SecretKey, _tokenService.DefaultIssuer, _tokenService.DefaultAudience, loginDto.Username);

            await _unitOfWork.CompleteAsync();

            var mappedLoginDto = _mapper.Map<LoginDto>(user);

            mappedLoginDto.Token = token;

            return mappedLoginDto;
        }
    }
}
      
    




