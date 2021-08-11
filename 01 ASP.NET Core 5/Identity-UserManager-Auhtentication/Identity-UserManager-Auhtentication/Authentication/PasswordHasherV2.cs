namespace Identity_UserManager_Auhtentication.Authentication
{
    using System;
    using System.Security.Cryptography;
    using System.Text;
    using Identity_UserManager_Auhtentication.Model;
    using Microsoft.AspNetCore.Identity;

    public class PasswordHasherV2 : PasswordHasher<GebruikerUserModel>
    {
        public override PasswordVerificationResult VerifyHashedPassword(
            GebruikerUserModel user,
            string hashedPassword,
            string providedPassword)
        {
            string[] passwordProperties = hashedPassword.Split('|');
            if (passwordProperties.Length != 3)
            {
                return base.VerifyHashedPassword(user, hashedPassword, providedPassword);
            }
            else
            {
                string passwordHash = passwordProperties[0];
                int passwordFormat = 1;
                string salt = passwordProperties[2];
                if (string.Equals(
                    this.EncryptPassword(providedPassword, passwordFormat, salt),
                    passwordHash,
                    StringComparison.CurrentCultureIgnoreCase))
                {
                    return PasswordVerificationResult.SuccessRehashNeeded;
                }
                else
                {
                    return PasswordVerificationResult.Failed;
                }
            }
        }


        public override string HashPassword(GebruikerUserModel user, string password)
        {
            return base.HashPassword(user, password);
        }

        private string EncryptPassword(string pass, int passwordFormat, string salt)
        {
            if (passwordFormat == 0)
            {
                return pass;
            }

            byte[] inArray = Encoding.Unicode.GetBytes(pass);
            byte[] saltArray = Convert.FromBase64String(salt);
            byte[] returnArray = null;

            if (passwordFormat == 1)
            {
                // MembershipPasswordFormat.Hashed
                HashAlgorithm hm = SHA1.Create();

                byte[] allArray = new byte[saltArray.Length + inArray.Length];
                Buffer.BlockCopy(saltArray, 0, allArray, 0, saltArray.Length);
                Buffer.BlockCopy(inArray, 0, allArray, saltArray.Length, inArray.Length);
                returnArray = hm.ComputeHash(allArray);
            }

            return Convert.ToBase64String(returnArray);
        }
    }
}