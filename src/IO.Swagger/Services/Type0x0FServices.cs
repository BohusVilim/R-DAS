using IO.Swagger.Models;
using System.Globalization;
using System;
using Microsoft.EntityFrameworkCore;
using static IO.Swagger.Enums;

namespace IO.Swagger.Services
{
    public class Type0x0FServices
    {
        /// <summary>
        /// method is used to create a Type0x0F object from the hexadecimal string
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public Type0x0F Type0x0FCreator(string body)
        {
            try
            {
                Type0x0F type0x0F = new Type0x0F();

                type0x0F.Type = "0x0F";

                var batteryInt = int.Parse(body.Substring(5, 3), NumberStyles.HexNumber);
                type0x0F.Battery = Convert.ToDecimal(batteryInt) / 100;

                type0x0F.Flags = int.Parse(body.Substring(8, 2), NumberStyles.HexNumber);

                int asciiValue = Convert.ToInt32(body.Substring(18, 2), 16);
                type0x0F.Char = Convert.ToChar(asciiValue).ToString();

                string? x = null;
                switch (type0x0F.Char)
                {
                    case "A":
                        x = "*10";
                        break;

                    case "B":
                        x = "-100";
                        break;

                    case "C":
                        x = "+25";
                        break;
                }

                var y = body.Substring(13, 1);
                var z = y + body.Substring(10, 2);

                type0x0F.Axis1 = int.Parse(z, NumberStyles.HexNumber).ToString() + x;
                type0x0F.Axis2 = int.Parse(body.Substring(14, 4), NumberStyles.HexNumber).ToString() + x;

                return type0x0F;
            }

            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
