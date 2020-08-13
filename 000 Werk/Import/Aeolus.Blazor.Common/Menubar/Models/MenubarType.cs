// <copyright file="MenubarType.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.Menubar.Models
{
    /// <summary>
    /// Een enumeratie waar de types van de tool items staat in.
    /// </summary>
    public enum MenubarType
    {
        /// <summary>
        /// De item is een knop.
        /// </summary>
        Button,

        /// <summary>
        /// De item is een group.
        /// </summary>
        Group,

        /// <summary>
        /// De item is een link.
        /// </summary>
        Link,

        /// <summary>
        /// De item is een search box.
        /// </summary>
        Search,

        /// <summary>
        /// De item die gaat een file uploaden.
        /// </summary>
        UploadFile,

        /// <summary>
        /// De item die dialg is.
        /// </summary>
        Dialog,

        /// <summary>
        /// De button van dialog.
        /// </summary>
        DialogButton,
    }
}
