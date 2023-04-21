using Azure;
using System.Text.Json;
using System.Linq;
using IO.Swagger.Models;
using System.Globalization;
using System;
using System.Collections.Generic;

namespace IO.Swagger.Services
{
    public class ApiApiServices
    {
        private readonly AppDbContext _context;
        public ApiApiServices(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// method is used to get a list of objects of type Type0x0A from the database
        /// </summary>
        public List<Type0x0A> DataGet()
        {
            return _context.Type0x0AEntities.ToList();
        }
    }
}
