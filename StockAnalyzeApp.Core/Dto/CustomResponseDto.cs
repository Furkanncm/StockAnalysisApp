using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Dto
{
    public class CustomResponseDto<T> where T : class
    {

        public T Data { get; set; }

        public List<string> Error { get; set; }

        [JsonIgnore]
        public int StatucCode { get; set; }

        public static CustomResponseDto<T> Success(T data, int statusCode)
        {
            return new CustomResponseDto<T>
            {
                Data = data,
                StatucCode = statusCode
            };
        }

        public static CustomResponseDto<T> Success(int statusCode)
        {
            return new CustomResponseDto<T>
            {
                StatucCode = statusCode
            };
        }

        public static CustomResponseDto<T> Fail(string error, int statusCode)
        {
            return new CustomResponseDto<T>
            {
                Error = new List<string> { error },
                StatucCode = statusCode
            };
        }

        public static CustomResponseDto<T> Fail(List<string> errors, int statusCode)
        {
            return new CustomResponseDto<T>
            {
                Error = errors,
                StatucCode = statusCode
            };
        }
        public static CustomResponseDto<T> Fail(int statusCode)
        {
            return new CustomResponseDto<T>
            {

                StatucCode = statusCode
            };
        }
    }
}