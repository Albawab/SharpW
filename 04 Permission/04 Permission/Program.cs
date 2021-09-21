using HenE.Aeolus.Shared.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Permission
{
    static class Program
    {

        public static void Main(string[] args)
        {
            int nummer = 0;
            List<Permission> permissions = new List<Permission>() { Permission.Beveiliging_Beheer_AspNetUsers_Delete, Permission.Beveiliging_Beheer_Clients_Delete };
            Console.WriteLine("In Pack :"+permissions.PackPermissionsIntoString());

            foreach (var unpackPermission in permissions.PackPermissionsIntoString().UnpackPermissionsFromString())
            {
                Console.WriteLine($"Unpack {nummer++} :" + unpackPermission);
            }            
        }

        public static string PackPermissionsIntoString(this IEnumerable<Permission> permissions)
        {
            var packPermissionsIntoString = permissions.Aggregate("", (s, permission) => s + (char)permission);
            var a = "㈁";
            var b = "⇿";
            // packPermissionsIntoString = ℏ℔
            return packPermissionsIntoString;
        }


        public static IEnumerable<Permission> UnpackPermissionsFromString(this string packedPermissions)
        {
            if (packedPermissions == null)
                throw new ArgumentNullException(nameof(packedPermissions));
            foreach (var character in packedPermissions)
            {
                yield return ((Permission)character);
            }
        }
    }
}
