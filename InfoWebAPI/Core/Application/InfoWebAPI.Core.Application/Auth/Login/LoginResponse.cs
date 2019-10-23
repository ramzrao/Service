using InfoWebAPI.Application.Auth.Models;
using InfoWebAPI.Domain.Entities;
using System.Collections.Generic;

namespace InfoWebAPI.Application.Auth.Login
{
    public class LoginResponse
    {
        public AccessToken AccessToken { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsSuccessful { get; set; }
        public int UserId { get; set; }
        public List<Permission> UserPermissions { get; set; }
    }
}