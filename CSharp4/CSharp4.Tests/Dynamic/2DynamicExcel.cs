﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excel = Microsoft.Office.Interop.Excel;


namespace CSharp4.Tests.Dynamic
{
	[TestClass]
	public class _2DynamicExcel
	{
		[TestMethod]
		public void TestExcelMethod001()
		{
			var excel = new Excel.Application();
			var workbook = excel.Workbooks.Add();
			var sheet = excel.ActiveSheet;

			excel.Visible = true;
			excel.Cells[1, 1] = "Hi, Avinash";
			excel.Columns[1].AutoFit();

			excel.Cells[2, 1] = 10;
			excel.Cells[3, 1] = 15;
			excel.Cells[4, 1] = 20;
			excel.Cells[5, 1] = 25;
			excel.Cells[6, 1] = 30;
			excel.Cells[7, 1] = 35;

			var chart = workbook.Charts.Add(After: sheet);
			chart.ChartWizard(Source: sheet.Range("A2", "A7"));
		}
	}
}
