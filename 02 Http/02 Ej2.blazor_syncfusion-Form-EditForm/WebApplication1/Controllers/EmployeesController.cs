namespace HenE_Application.Controllers
{
    using System.Collections.Generic;
    using HenE_Application.Container;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// De controller van de medewerkers.
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        /// <summary>
        /// De list van de medewerkers.
        /// </summary>
        private readonly List<Medewerker> medewerkers = new List<Medewerker>();

        /// <summary>
        /// Geeft de medewerkers als array terug.
        /// </summary>
        /// <returns>De list van de medewerkers.</returns>
        public IEnumerable<Medewerker> GetEmployees()
        {
            return this.medewerkers.ToArray();
        }

        /// <summary>
        /// Voegt een medewerker in de list in.
        /// </summary>
        /// <param name="employee">Een nieuwe medewerker.</param>
        [HttpPost]
        public void PostEmployee(Medewerker employee)
        {
            this.medewerkers.Add(employee);
        }
    }
}