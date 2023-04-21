using IO.Swagger.Models;
using System.Globalization;
using System;
using Microsoft.EntityFrameworkCore;
using static IO.Swagger.Enums;

namespace IO.Swagger.Services
{
    public class Type0x0EServices
    {
        /// <summary>
        /// method is used to create a Type0x0E object from the hexadecimal string
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public Type0x0E Type0x0ECreator(string body)
        {
            try
            {
                Type0x0E type0x0E = new Type0x0E();

                type0x0E.Type = "0x0E";
                type0x0E.Battery = int.Parse(body.Substring(4, 2), NumberStyles.HexNumber);
                type0x0E.Tempereature = int.Parse(body.Substring(6, 4), NumberStyles.HexNumber);

                int asciiValue1 = Convert.ToInt32(body.Substring(10, 2), 16);
                var char1 = Convert.ToChar(asciiValue1).ToString();

                int asciiValue2 = Convert.ToInt32(body.Substring(12, 2), 16);
                string char2 = Convert.ToChar(asciiValue2).ToString();

                int asciiValue3 = Convert.ToInt32(body.Substring(14, 2), 16);
                string char3 = Convert.ToChar(asciiValue3).ToString();

                int asciiValue4 = Convert.ToInt32(body.Substring(16, 2), 16);
                string char4 = Convert.ToChar(asciiValue4).ToString();

                type0x0E.Chars = char1 + char2 + char3 + char4;

                return type0x0E;
            }

            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
