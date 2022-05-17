﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Domain.Models;

namespace MyMovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        private readonly IUnitOfWork db;

        public FilmsController(IUnitOfWork db)
        {
            this.db = db;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var films = db.Films.GetAll();
            var results = new List<Film>();
            foreach(var film in films)
            {
                var casts = db.Casts.GetAllBasicActorCastByFilmId(film.Id);
                var _film = film;                
                _film.Casts.AddRange(casts);
                results.Add(_film);
            }
            return Ok(results);
        }
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var film = db.Films.GetById(id);
            if(film == null)
                return NotFound();
            var casts = db.Casts.GetAllBasicActorCastByFilmId(film.Id);
            film.Casts.AddRange(casts);
            return Ok(film);
        }
        [HttpGet("search")]
        public IActionResult Search(string q)
        {
            var films = db.Films.GetAll().Where(x => x.Name.Contains(q, StringComparison.InvariantCultureIgnoreCase) || x.Director.Name.Contains(q, StringComparison.InvariantCultureIgnoreCase) || x.Synopsis.Contains(q, StringComparison.InvariantCultureIgnoreCase)).ToList();
            //var films = db.Films.Find(x=>x.Name.Contains(q));

            return Ok(films);
        }
    }
}
