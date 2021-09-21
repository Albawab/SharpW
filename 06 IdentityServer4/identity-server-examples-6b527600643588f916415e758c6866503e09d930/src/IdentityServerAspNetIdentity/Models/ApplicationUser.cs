using System;
using Microsoft.AspNetCore.Identity;

/// <summary>
/// This subclass of IdentityUser is used in the different parts of the 
/// application that refer to a user in the Identity System. This class
/// has three added properties, which have been added into the database.
/// On reflection, the Forename and Surname properties are better handled
/// as claims. See the comments for the two properties.
/// </summary>
namespace IdentityServerAspNetIdentity.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        // This property is currently in the data schema for 
        // the AspNetUsers table. After consideration, it is not needed. 
        // It is better to have the forename stored as the given name 
        // in the claims. In that way, it is automatically picked up 
        // by the OpenID Connect process. 
        //
        // There is no Drop Column operation for sqlite3, so the 
        // migrations cannot easily make this change. Therefore, this 
        // is a legacy field. With a littlle bit of work, this could be
        // undone in the tables, but it is left here for now.
         [PersonalData]
        public string Forename { get; set; }

        // This property is currently in the data schema for 
        // the AspNetUsers table. After consideration, it is not needed. 
        // It is better to have the forename stored as the family name 
        // in the claims. In that way, it is automatically picked up 
        // by the OpenID Connect process. 
        //
        // There is no Drop Column operation for sqlite3, so the 
        // migrations cannot easily make this change. Therefore, this 
        // is a legacy field. With a littlle bit of work, this could be
        // undone in the tables, but it is left here for now.
        [PersonalData]
        public string Surname { get; set; }

        /// <value>Holds the date that the registration was made.</value>
        [PersonalData]
        public DateTime RegisteredOn { get; set; }

    }
}
