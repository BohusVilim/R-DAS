using IO.Swagger.Models;
using IO.Swagger.Services;
using System;
using System.Text.Json;

namespace IO.Swagger
{
    public class Parser
    {
        private readonly Type0x0EServices _type0X0EServices;
        private readonly Type0x0AServices _type0X0AServices;
        private readonly Type0x0FServices _type0X0FServices;
        public Parser(Type0x0EServices type0X0EServices, Type0x0AServices type0X0AServices, Type0x0FServices type0X0FServices)
        {
            _type0X0AServices = type0X0AServices;
            _type0X0EServices = type0X0EServices;
            _type0X0FServices = type0X0FServices;
        }

        /// <summary>
        /// method is used to parse the data passed as a string and return the corresponding object based on the data type (Type0x0E, Type0x0A or Type0x0F)
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public object Parse(string body)
        {
            try
            {
                string type = body.Substring(2, 2);
                object ret;

                switch (type)
                {
                    case "0E":
                        ret = _type0X0EServices.Type0x0ECreator(body);
                        Console.WriteLine(JsonSerializer.Serialize(ret));
                        return ret;

                    case "0A":
                        ret = _type0X0AServices.Type0x0ACreator(body);
                        Console.WriteLine(JsonSerializer.Serialize(ret));
                        return ret;

                    case "0F":
                        ret = _type0X0FServices.Type0x0FCreator(body);
                        Console.WriteLine(JsonSerializer.Serialize(ret));
                        return ret;

                    default:
                        throw new ArgumentException("Unsupported parameter");
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
