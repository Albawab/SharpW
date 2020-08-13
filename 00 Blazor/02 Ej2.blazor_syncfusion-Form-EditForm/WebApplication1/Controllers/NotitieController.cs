// <copyright file="NotitieController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_Application.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Mime;
    using System.Threading.Tasks;
    using HenE_Application.Model;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.JsonPatch;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// De controller van De editor Blazor.
    /// Maak een contact met de client.
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class NotitieController : ControllerBase
    {
        private readonly List<Notitie> notities = new List<Notitie>();

        public NotitieController()
        {
            this.notities.Add(new Notitie()
            {
                Id = 2,

                Body = "d",
                Title = "T",
                Datum = DateTime.Now,
            }); ;
        }

        /// <summary>
        /// Geeft de data terug aan de client.
        /// </summary>
        /// <returns>De action result.</returns>
        [HttpGet]
        public IEnumerable<Notitie> Get()
        {
            return this.notities;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetById(int id)
        {
            var notitie = this.notities.FirstOrDefault(a => a.Id == id);

            if (notitie == null)
            {
                return this.BadRequest();
            }

            return this.Ok(notitie);
        }

        /// <summary>
        /// Creëert een nieuwe items.
        /// Die vanuit de client komt.
        /// </summary>
        /// <returns>De action result.</returns>
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create([FromBody]Notitie notitie)
        {
            this.notities.Add(notitie);

            return this.CreatedAtAction(nameof(this.GetById), new { id = notitie.Id }, notitie);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody]Notitie notitie)
        {
            this.notities[id] = notitie;
            return this.Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            this.notities.RemoveAt(id);
            return this.Ok();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> PartiallyUpdateNotitie(int id, [FromBody]JsonPatchDocument<Notitie> patchNotitie)
        {
            // If the received data is null
            if (patchNotitie == null)
            {
                return this.BadRequest();
            }

            var notitie = this.notities.SingleOrDefault(a => a.Id == id);

            // Check if is the book exist or not
            if (notitie == null)
            {
                return this.NotFound();
            }

            // Map retrieved book to BookModel with other properties (More or less with eexactly same name)
            //var bookToPatch = Mapper.Map<BookModel>(book);

            // Apply book to ModelState
            /*patchNotitie.ApplyTo(notitie, ModelState);

            // Use this method to validate your data
            TryValidateModel(notitie);

            // If model is not valid, return the problem
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            */

            // If everything was ok, return no content status code to users
            return this.NoContent();
        }
    }

}