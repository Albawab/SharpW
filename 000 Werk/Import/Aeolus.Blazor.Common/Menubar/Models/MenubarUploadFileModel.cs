// <copyright file="MenubarUploadFileModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.Menubar.Models
{
    /// <summary>
    /// Klas waar in de properties van een upload file staan.
    /// </summary>
    public class MenubarUploadFileModel : MenubarItemModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenubarUploadFileModel"/> class.
        /// </summary>
        /// <param name="id">De id van een item.</param>
        /// <param name="titel">De titel van uploadfile item.</param>
        public MenubarUploadFileModel(int id, string titel)
            : base(id, titel, MenubarType.UploadFile)
        {
        }
    }
}
