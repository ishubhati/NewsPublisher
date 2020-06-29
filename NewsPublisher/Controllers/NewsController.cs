using Microsoft.AspNetCore.Mvc;
using NewsPublisher.Core.ResponseModel;
using NewsPublisher.Interfaces;
using NewsPublisher.Model;
using System;
using System.Collections.Generic;

namespace NewsPublisher.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly INewsPublisherModelService _newsPublisherModelService;
        public NewsController(INewsPublisherModelService newsPublisherModelService)
        {
            _newsPublisherModelService = newsPublisherModelService;
        }

        //GetNewsContents API
        // API returns data from all implemented news sources providers 
        [HttpGet]
        [ProducesResponseType(200)] //Success
        [ProducesResponseType(400)] //For bad request
        [ProducesResponseType(401)] // Unauthorized
        public IActionResult GetNewsContents([FromQuery] string PageId = "1")
        {
            SingleResponse<List<NewsContentResponse>> response = null;

            try
            {

                response = _newsPublisherModelService.GetNewsContents(Convert.ToInt32(PageId));

            }
            catch (Exception ex)
            {
                response = new SingleResponse<List<NewsContentResponse>>();
                response.HasError = true;
                response.ErrorMessage = ex.Message;
            }

            return StatusCode(Convert.ToInt32(response.StatusCode), response);
        }


        // API Add data into JSON file from and same file is being used to fetch data from implemented providers
        [HttpPost("RegisterNewsSource")]
        [ProducesResponseType(201)] //Success
        [ProducesResponseType(400)] //For bad request
        [ProducesResponseType(401)] // Unauthorized
        public IActionResult RegisterNewsSource([FromBody]NewsSourceProvider newsSourceProvider)
        {
            GenericResponse response = null;

            try
            {

                response = _newsPublisherModelService.RegisterNewsSource(newsSourceProvider);

            }
            catch (Exception ex)
            {
                response = new GenericResponse();
                response.HasError = true;
                response.ErrorMessage = ex.Message;
            }

            return StatusCode(Convert.ToInt32(response.StatusCode), response);
        }
    }
}
