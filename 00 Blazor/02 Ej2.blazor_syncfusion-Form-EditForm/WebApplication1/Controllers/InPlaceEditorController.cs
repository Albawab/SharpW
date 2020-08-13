// <copyright file="InPlaceEditorController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_Application.Controllers
{
    using HenE_Application.Container;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// De controller van De editor Blazor.
    /// Maak een contact met de client.
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class InPlaceEditorController : ControllerBase
    {

        private InPlaceEditor placeEditor = new InPlaceEditor()
        {
            Title = "Title",
            Comments = "Comments",
            Tags = new string[] { "Android", "JavaScript", "jQuery", "TypeScript", "Angular", "React", "Vue", "Ionic" },
        };

        public InPlaceEditor PlaceEditor { get => this.placeEditor; set => this.placeEditor = value; }

        /// <summary>
        /// Geeft de data terug aan de client.
        /// </summary>
        /// <returns>De action result.</returns>
        [HttpGet]
        public InPlaceEditor GetData()
        {
            return this.PlaceEditor;
        }

        /// <summary>
        /// Creëert een nieuwe items.
        /// Die vanuit de client komt.
        /// </summary>
        /// <returns>De action result.</returns>
        [HttpPost]
        public IActionResult CreateEenItem([FromBody]InPlaceEditor laceEditor)
        {
            return this.Ok();
        }

        /// <summary>
        /// Update de data die de client hem wil updaten.
        /// </summary>
        /// <returns>De action result.</returns>
        [HttpPut]
        public IActionResult Update([FromBody]InPlaceEditor value)
        {
            this.PlaceEditor = value;
            return this.Ok();
        }
    }
}