/*
 * R-DAS | C# interview task
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * Contact: develop@r-das.sk.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;
using IO.Swagger.Services;

namespace IO.Swagger.Controllers
{
    /// <summary>
    /// definition of class ApiApiController
    /// </summary>
    [ApiController]
    public class ApiApiController : ControllerBase
    {
        private readonly ApiApiServices _apiApiServices;
        public ApiApiController(ApiApiServices apiApiServices)
        {
            _apiApiServices = apiApiServices;
        }

        /// <summary>
        /// method gets data from _apiApiServices.DataGet() and returns a response with this data.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/data")]
        public IActionResult ApiDataGet()
        {
            try
            {
                return Ok(_apiApiServices.DataGet());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
