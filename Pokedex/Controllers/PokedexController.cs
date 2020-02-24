using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Data.Dto;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Pokedex.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokedexController : ControllerBase
    {
        private readonly ILogger<PokedexController> _logger;
        private IPokedexRepository _repo;

        public PokedexController(ILogger<PokedexController> logger, IPokedexRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        /// <summary>
        /// Return a list of Pokemon
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("pokemon")]
        public IActionResult GetPokemonList()
        {
            try
            {
                var response = _repo.GetList();

                return response.Count == 0 ? StatusCode((int)HttpStatusCode.NoContent, null) : StatusCode((int)HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Returns a Pokemon
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("pokemon/{pokemonID}")]
        public IActionResult GetPokemon([Required][FromRoute]int pokemonID)
        {
            try
            {
                var response = _repo.Get(pokemonID);

                return StatusCode((int)HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Updates the specified Pokemon's Name or SpeciesID
        /// </summary>
        /// <param name="updateDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("pokemon")]
        public IActionResult UpdatePokemon([Required][FromBody]UpdatePokemonDto updateDto)
        {
            try
            {
                var response = _repo.Update(updateDto);

                return StatusCode((int)HttpStatusCode.OK, $"/Pokedex/pokemon/{response}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Creates a new Pokemon
        /// </summary>
        /// <param name="createPokemon"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("pokemon")]
        public IActionResult CreatePokemon([Required][FromBody] CreatePokemonDto createPokemon)
        {
            try
            {
                var response = _repo.Create(createPokemon);

                return StatusCode((int)HttpStatusCode.Created, $"/Pokedex/pokemon/{response}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Deletes a new Pokemon
        /// </summary>
        /// <param name="deleteDto"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("pokemon")]
        public IActionResult DeletePokemon([Required][FromBody] DeletePokemonDto deleteDto)
        {
            try
            {
                _repo.Delete(deleteDto);

                return StatusCode((int)HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Returns a list of PokemonSpecies with SpeciesID and SpeciesName
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("species")]
        public IActionResult GetSpeciesList()
        {
            try
            {
                var response = _repo.GetSpeciesList();

                return response.Count == 0 ? StatusCode((int)HttpStatusCode.NoContent, null) : StatusCode((int)HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
