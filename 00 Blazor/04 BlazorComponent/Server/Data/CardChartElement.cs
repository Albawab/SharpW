// <copyright file="CardChartElement.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HenE_Server.Data
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// De chart element.
    /// </summary>
    public class CardChartElement : CardElement
    {
        /// <summary>
        /// Gets or sets Data van de chart.
        /// </summary>
        public List<CardChartDateElement> ChartData { get; set; } = new List<CardChartDateElement>
        {
            new CardChartDateElement
            {
                XValueDate = new DateTime(2001, 01, 01),
                YValueData = 4,
                YValueData1 = 1,
            },
            new CardChartDateElement
            {
                XValueDate = new DateTime(2002, 01, 01),
                YValueData = 2,
                YValueData1 = 3,
            },
            new CardChartDateElement
            {
                XValueDate = new DateTime(2003, 01, 01),
                YValueData = 4,
                YValueData1 = 3,
            },
            new CardChartDateElement
            {
                XValueDate = new DateTime(2004, 01, 01),
                YValueData = 0,
                YValueData1 = 2,
            },
            new CardChartDateElement
            {
                XValueDate = new DateTime(2005, 01, 01),
                YValueData = 0,
                YValueData1 = 3,
            },
            new CardChartDateElement
            {
                XValueDate = new DateTime(2006, 01, 01),
                YValueData = 1,
                YValueData1 = 2,
            },
            new CardChartDateElement
            {
                XValueDate = new DateTime(2007, 01, 01),
                YValueData = 2,
                YValueData1 = 5,
            },
            new CardChartDateElement
            {
                XValueDate = new DateTime(2008, 01, 01),
                YValueData = 5,
                YValueData1 = 4,
            },
            new CardChartDateElement
            {
                XValueDate = new DateTime(2009, 01, 01),
                YValueData = 4,
                YValueData1 = 3,
            },
            new CardChartDateElement
            {
                XValueDate = new DateTime(2010, 01, 01),
                YValueData = 1.4,
                YValueData1 = 2,
            },
        };
    }
}
