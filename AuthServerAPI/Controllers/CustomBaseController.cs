﻿using AuthServer.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace AuthServerAPI.Controllers
{
    public class CustomBaseController : ControllerBase
    {
        public IActionResult ActionResulInstance<T>(Response<T> response) where T : class
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}