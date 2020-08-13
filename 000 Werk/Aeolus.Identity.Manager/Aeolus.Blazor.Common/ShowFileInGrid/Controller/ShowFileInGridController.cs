// <copyright file="ShowFileInGridController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE.Aeolus.Blazor.Common.ShowFileInGrid.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.IO;
    using HenE.Aeolus.Blazor.Common.ShowFileInGrid.Interfaces;
    using HenE.Aeolus.Blazor.Common.ShowFileInGrid.Model;
    using Syncfusion.XlsIO;

    /// <summary>
    /// De controller van de grid om de data van een bestand op he halen.
    /// </summary>
    public class ShowExcelFileInGridController : IShowFileInGrid
    {
        /// <summary>
        /// Geeft de data van de exel bestand terug.
        /// </summary>
        /// <param name="fileName">De naam van het bestand.</param>
        /// <returns>Een nieuwe list met data van Excel bestand.</returns>
        public List<ExcelCelModel> GetExcelItems(string fileName)
        {
            return new List<ExcelCelModel>()
            {
                new ExcelCelModel() { Value = this.ReadExcel(fileName) },
            };
        }

        /// <summary>
        /// Leest de data van een Excel bestand.
        /// </summary>
        /// <returns>De date van het bestand.</returns>
        private string ReadExcel(string fileName)
        {
            try
            {
                if (fileName != null && fileName != string.Empty)
                {
                    string name;
                    ExcelEngine excelEngine = new ExcelEngine();

                    // Instantiate the Excel application object
                    IApplication application = excelEngine.Excel;

                    // Set the default application version
                    application.DefaultVersion = ExcelVersion.Excel2016;

                    // Load the existing Excel workbook into IWorkbook
                    FileStream inputStream = File.Open($@"..\\Files\\{fileName}", FileMode.Open);
                    IWorkbook workbook = application.Workbooks.Open(inputStream);

                    // Get the first worksheet in the workbook into IWorksheet
                    IWorksheet worksheet = workbook.Worksheets[0];
                    DataTable customersTable = worksheet.ExportDataTable(worksheet.UsedRange, ExcelExportDataTableOptions.ColumnNames);
                    dynamic a = customersTable.Columns;
                    dynamic b = customersTable.Rows;
                    name = worksheet.Range["A2"].Value;

                    inputStream.Dispose();
                    inputStream.Close();

                    return name;
                }
                else
                {
                    return "";
                }
            }
            catch (Exception)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
