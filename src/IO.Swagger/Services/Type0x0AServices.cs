using IO.Swagger.Models;
using static IO.Swagger.Enums;
using System.Globalization;
using System;
using System.Linq.Expressions;

namespace IO.Swagger.Services
{
    public class Type0x0AServices
    {
        private AppDbContext _context;
        public Type0x0AServices (AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// method is used to create a Type0x0A object from the hexadecimal string
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public Type0x0A Type0x0ACreator(string body) 
        {
            try
            {
                Type0x0A type0X0A = new Type0x0A();
                type0X0A.Type = "0X0A";
                type0X0A.Id = int.Parse(body.Substring(4, 2), NumberStyles.HexNumber);

                int value = Convert.ToInt32(body.Substring(6, 2), 16);

                type0X0A.State = ((Type0x0AByte2Enum)value).ToString();

                string ipString = body.Substring(8, 8);

                type0X0A.IpAddr = string.Format("{0}.{1}.{2}.{3}",
                    Convert.ToByte(ipString.Substring(0, 2), 16),
                    Convert.ToByte(ipString.Substring(2, 2), 16),
                    Convert.ToByte(ipString.Substring(4, 2), 16),
                    Convert.ToByte(ipString.Substring(6, 2), 16));

                _context.Type0x0AEntities.Add(type0X0A);
                _context.SaveChanges();

                return type0X0A;
            }
            
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
