using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using PycApi.Base;
using PycApi.Data;
using PycApi.Dto;
using PycApi.Service;
using System;
using System.Linq;
using System.Security.Cryptography;
using ISession = NHibernate.ISession;


namespace PycApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser_Service userService;
        private readonly ITokenService tokenService;
        public UserController(IUser_Service userService, ITokenService tokenService)
        {
            this.userService = userService;
            this.tokenService = tokenService;
        }
        private static string Cryptograf(string text, HashAlgorithm alg)

        {

            byte[] byteDegeri = System.Text.Encoding.UTF8.GetBytes(text);


            byte[] sifreliByte = alg.ComputeHash(byteDegeri);


            return Convert.ToBase64String(sifreliByte);


        }
        public static string MD5Converter(string text)
        {
            MD5CryptoServiceProvider pwd = new MD5CryptoServiceProvider();
            return Cryptograf(text, pwd);
        }



        [HttpPost ("Login")]
        public BaseResponse<TokenResponse> Login([FromBody] TokenRequest request)
        {

            var response = tokenService.GenerateToken(request);
            return response;
        }

        [HttpPost("Sign Up")]
        public BaseResponse<UserDto> Sign_Up([FromBody] UserDto request)
        {
            request.password = MD5Converter(request.password);
            var response = userService.Insert(request);
            return response;
        }

    }
}

