﻿using AutoMapper;
using SocialNetwork.Core.Application.Dtos.Account;
using SocialNetwork.Core.Application.Interfaces.Services;
using SocialNetwork.Core.Application.ViewModels.User;

namespace SocialNetwork.Core.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public UserService(IAccountService accountService, IMapper mapper)
        {
            _accountService = accountService;
            _mapper = mapper;
        }

        public async Task<AuthenticationResponse> LoginAsync(LoginViewModel vm)
        {
            AuthenticationRequest loginRequest = _mapper.Map<AuthenticationRequest>(vm);
            AuthenticationResponse userResponse = await _accountService.AuthenticateAsync(loginRequest);
            return userResponse;
        }

        public async Task SignOutAsync()
        {
            await _accountService.SignOutAsync();
        }

        public async Task<RegisterResponse> RegisterAsync(SaveUserViewModel vm, string origin)
        {
            RegisterRequest registerRequest = _mapper.Map<RegisterRequest>(vm);
            return await _accountService.RegisterUserAsync(registerRequest, origin);
        }

        public async Task UpdateAsync(SaveUserViewModel vm, string id)
        {
            RegisterRequest registerRequest = _mapper.Map<RegisterRequest>(vm);
            await _accountService.UpdateUserAsync(registerRequest, id);
        }

        public async Task<string> ConfirmEmailAsync(string userId, string token)
        {
            return await _accountService.ConfirmAccountAsync(userId, token);
        }

        public async Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordViewModel vm, string origin)
        {
            ForgotPasswordRequest forgotRequest = _mapper.Map<ForgotPasswordRequest>(vm);
            return await _accountService.ForgotPasswordAsync(forgotRequest, origin);
        }

        public async Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordViewModel vm)
        {
            ResetPasswordRequest resetRequest = _mapper.Map<ResetPasswordRequest>(vm);
            return await _accountService.ResetPasswordAsync(resetRequest);
        }

        public async Task<SaveUserViewModel> GetByIdAsync(string id)
        {
            AuthenticationResponse userResponse = await _accountService.GetUserByIdAsync(id);
            SaveUserViewModel vm = _mapper.Map<SaveUserViewModel>(userResponse);
            return vm;
        }
        
        public async Task<UserViewModel> GetByUsernameAsync(string username)
        {
            AuthenticationResponse userResponse = await _accountService.GetUserByUsernameAsync(username);
            UserViewModel vm = _mapper.Map<UserViewModel>(userResponse);
            return vm;
        }
    }
}
