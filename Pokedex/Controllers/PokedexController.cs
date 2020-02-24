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
        /// Returns a list of all pokemon  you have currently caught
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
        /// Returns a single pokemon that you have caught by its PokemonID
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
        /// Updates a caught pokemon by its PokemonID. You can update the PokemonName, SpeciesID, or both.
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
        /// Adds to your list of caught pokemon. Provide the Pokemon SpeciesID and PokemonName.
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
        /// Deletes a pokemon from your caught list by PokemonID.
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
        /// Returns a list of all PokemonSpecies with both SpeciesID and SpeciesName.
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
