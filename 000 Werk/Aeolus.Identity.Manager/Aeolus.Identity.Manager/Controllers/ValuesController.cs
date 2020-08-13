// <copyright file="ValuesController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Identity.Manager.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http.Headers;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Http.Features;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Een controller waarmee het project met de server kan contact opnemen.
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// hosting.
        /// </summary>
        [Obsolete]
        private readonly IHostingEnvironment hostingEnv;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValuesController"/> class.
        /// </summary>
        /// <param name="env">env.</param>
        [Obsolete]
        public ValuesController(IHostingEnvironment env)
        {
            this.hostingEnv = env;
        }

        /// <summary>
        /// Get de items van de server.
        /// </summary>
        /// <returns>Is het gelukt.</returns>
        [HttpGet]
        public IActionResult GetItem()
        {
            return this.Ok();
        }

        /// <summary>
        /// slaat een list van de files in de server.
        /// </summary>
        /// <param name="uploadFiles">De lijst die wordt opsloeg.</param>
        [HttpPost("[action]")]
        public void Save(IList<IFormFile> uploadFiles)
        {
            long size = 0;
            try
            {
                foreach (var file in uploadFiles)
                {
                    var filename = ContentDispositionHeaderValue
                            .Parse(file.ContentDisposition)
                            .FileName
                            .Trim('"');
                    filename = @"C:\Users\albaw\Desktop\D" + $@"\{filename}";
                    size += (int)file.Length;
                    if (!System.IO.File.Exists(filename))
                    {
                        using (FileStream fs = System.IO.File.Create(filename))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                this.Response.Clear();
                this.Response.StatusCode = 204;
                this.Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "File failed to upload";
                this.Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = e.Message;
            }
        }
    }
}
