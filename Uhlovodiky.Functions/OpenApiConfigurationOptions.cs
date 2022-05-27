using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Configurations;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using System;
using System.Linq;

namespace Uhlovodiky.Functions
{
    /// <summary>
    /// Class for setting the version of OpenAPI/Swagger version used - we need v3
    /// </summary>
    public class OpenApiConfigurationOptions : DefaultOpenApiConfigurationOptions
    {
        public override OpenApiVersionType OpenApiVersion { get; set; } = OpenApiVersionType.V3;
    }
}
