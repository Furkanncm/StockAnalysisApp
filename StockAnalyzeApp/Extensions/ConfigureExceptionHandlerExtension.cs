﻿using Microsoft.AspNetCore.Diagnostics;
using StockAnalyzeApp.Core.Dto.BaseResponseDtos;
using System.Net;
using System.Net.Mime;
using System.Text.Json;

namespace StockAnalyzeApp.Extensions
{
    public static class ConfigureExceptionHandlerExtension
    {
        public static void ConfigureExceptionHandler(this WebApplication application)
        {
            application.UseExceptionHandler(builder =>
            {
                builder.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = MediaTypeNames.Application.Json;

                    var contextFeature =  context.Features.Get<IExceptionHandlerFeature>();
                    var response = CustomResponseDto<NoContentDto>.Fail(contextFeature.Error.Message, 400);
                    if(contextFeature != null)
                    {
                        await context.Response.WriteAsync(JsonSerializer.Serialize(new
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = contextFeature.Error.Data.ToString(),
                            Title = "Beklenmeyen Hata",
                            response
                            
                        }));
                    }
                });
            });
        }

    }
}
