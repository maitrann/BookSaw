﻿using RestAPI_BookSaw.Entities;
using RestAPI_BookSaw.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI_BookSaw.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DownBookController : ControllerBase
    {
        private readonly IDownBookRepository _downbookRepository;
        public DownBookController(IDownBookRepository downbookRepository)
        {
            _downbookRepository = downbookRepository;
        }
        [HttpPost]
        public bool DownBookToLib(DownBook model)
        {
            return _downbookRepository.DownBookToLib(model);
        }
        [HttpGet("{idClient}", Name = "IdClient")]
        public IActionResult GetDownBookViews(int idClient)
        {
            try
            {
                var books = _downbookRepository.GetDownBookViews(idClient);
                if (books == null)
                {
                    return NotFound();
                }
                return Ok(books);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
