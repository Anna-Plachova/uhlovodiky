using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Net;

namespace Uhlovodiky.Functions
{
    public static class Function
    {
        [FunctionName("NazevZeVzorce")]
        [Route("nazevzevzorce/{druh}/{vzorec}")]
        [OpenApiOperation(
            operationId: "nazevzevzorce",
            tags: new[] { "nazevzevzorce/{druh}/{vzorec}" },
            Description = "Vr�t� n�zev dan�ho druhu uhlovod�ku odvozen� z dan�ho vzorce",
            Visibility = OpenApiVisibilityType.Advanced)]
        [OpenApiParameter(name: "druh",
            In = ParameterLocation.Path,
            Required = true,
            Type = typeof(string),
            Description = "Druh uhlovod�ku, m��e nab�t jedn� z hodnot alkan|alken|alkyn")]
        [OpenApiParameter(name: "vzorec",
            In = ParameterLocation.Path,
            Required = true,
            Type = typeof(string),
            Description = "Sum�rn� vzorec uhlovod�ku ve form� CxHy")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK,
            contentType: "text/html",
            bodyType: typeof(string),
            Summary = "N�zev uhlovod�ku nebo v�sledek zpracov�n�")]
        public static IActionResult NazevZeVzorce(
            [HttpTrigger(
                AuthorizationLevel.Anonymous, 
                "get", 
                Route = "nazevzevzorce/{druh}/{vzorec}"
            )] HttpRequest req,
            string druh,
            string vzorec,
            ILogger log)
        {
            log.LogInformation($"Nazev ze vzorce - druh: {druh}, vzorec: {vzorec}");

            // kontrola parametr�
            if (string.IsNullOrEmpty(druh))
                return new BadRequestObjectResult("Hodnota parametru 'druh' je pr�zdn�");
            if (string.IsNullOrEmpty(vzorec))
                return new BadRequestObjectResult("Hodnota parametru 'vzorec' je pr�zdn�");
            if(!druh.Equals("alkan", StringComparison.OrdinalIgnoreCase) && !druh.Equals("alken", StringComparison.OrdinalIgnoreCase) && !druh.Equals("alkyn", StringComparison.OrdinalIgnoreCase))
                return new BadRequestObjectResult("Nezn�m� hodnota parametru 'druh'. Pou�ijte jednu z hodnot alkan|alken|alkyn");

            var uhlovodik = VyberUhlovodik(druh);
            string vysledek;

            try
            {
                var nazev = uhlovodik.NazevZeVzorce(vzorec);
                vysledek = nazev;
            }
            catch(Exception ex)
            {
                vysledek = ex.Message;
            }

            return new OkObjectResult(vysledek);
        }

        [FunctionName("VzorecZNazvu")]
        [Route("vzorecznazvu/{druh}/{nazev}")]
        [OpenApiOperation(
            operationId: "vzorecznazvu",
            tags: new[] { "vzorecznazvu/{druh}/{nazev}" },
            Description = "Vr�t� vzorec dan�ho druhu uhlovod�ku odvozen� z dan�ho n�zvu",
            Visibility = OpenApiVisibilityType.Advanced)]
        [OpenApiParameter(name: "druh",
            In = ParameterLocation.Path,
            Required = true,
            Type = typeof(string),
            Description = "Druh uhlovod�ku, m��e nab�t jedn� z hodnot alkan|alken|alkyn")]
        [OpenApiParameter(name: "nazev",
            In = ParameterLocation.Path,
            Required = true,
            Type = typeof(string),
            Description = "N�zev uhlovod�ku")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK,
            contentType: "text/html",
            bodyType: typeof(string),
            Summary = "Vzorec uhlovod�ku nebo v�sledek zpracov�n�")]
        public static IActionResult VzorecZNazvu(
            [HttpTrigger(
                AuthorizationLevel.Anonymous,
                "get",
                Route = "vzorecznazvu/{druh}/{nazev}"
            )] HttpRequest req,
            string druh,
            string nazev,
            ILogger log)
        {
            log.LogInformation($"Vzorec z nazvu - druh: {druh}, n�zev: {nazev}");

            // kontrola parametr�
            if (string.IsNullOrEmpty(druh))
                return new BadRequestObjectResult("Hodnota parametru 'druh' je pr�zdn�");
            if (string.IsNullOrEmpty(nazev))
                return new BadRequestObjectResult("Hodnota parametru 'nazev' je pr�zdn�");
            if (!druh.Equals("alkan", StringComparison.OrdinalIgnoreCase) && !druh.Equals("alken", StringComparison.OrdinalIgnoreCase) && !druh.Equals("alkyn", StringComparison.OrdinalIgnoreCase))
                return new BadRequestObjectResult("Nezn�m� hodnota parametru 'druh'. Pou�ijte jednu z hodnot alkan|alken|alkyn");

            var uhlovodik = VyberUhlovodik(druh);
            string vysledek;

            try
            {
                var vzorec = uhlovodik.VzorecZNazvu(nazev);
                vysledek = vzorec;
            }
            catch (Exception ex)
            {
                vysledek = ex.Message;
            }

            return new OkObjectResult(vysledek);
        }

        private static IUhlovodik VyberUhlovodik(string druh)
        {
            IUhlovodik uhlovodik;

            if (druh.Equals("alkan", StringComparison.OrdinalIgnoreCase))
                uhlovodik = new Alkan();
            else if (druh.Equals("alken", StringComparison.OrdinalIgnoreCase))
                uhlovodik = new Alken();
            else
                uhlovodik = new Alkyn();

            return uhlovodik;
        }
    }
}
