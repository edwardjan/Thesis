﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.XPath;
using System.Diagnostics;

using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;

namespace PRJCLUMS
{
    public class CreateInvoice
    {
        public Document document;
        public TextFrame addressFrame;
        public Table table;
        public System.Windows.Forms.ListView.ListViewItemCollection listViewItem;
        public string InvoidNo { get; set; }
        public string UserID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }


        public void PrintPDF(string filePath)
        {
            CreateDocument();   

            var renderer = new PdfDocumentRenderer();
            renderer.Document = this.document;
            renderer.RenderDocument();
            renderer.PdfDocument.Save(filePath);

            Process.Start(filePath);
        }

        void CreateDocument()
        {
            // Create a new MigraDoc document
            this.document = new Document();
            this.document.Info.Title = "Cyril's Garden Flower Shop Sales Management System";
            this.document.Info.Subject = "Billing Reports";
            this.document.Info.Author = "STI Developer";

            DefineStyles();

            CreatePage();

            FillContent();
        }

        void DefineStyles()
        {
            // Get the predefined style Normal.
            Style style = this.document.Styles["Normal"];
            // Because all styles are derived from Normal, the next line changes the 
            // font of the whole document. Or, more exactly, it changes the font of
            // all styles and paragraphs that do not redefine the font.
            style.Font.Name = "Verdana";

            style = this.document.Styles[StyleNames.Header];
            style.ParagraphFormat.AddTabStop("16cm", MigraDoc.DocumentObjectModel.TabAlignment.Right);

            style = this.document.Styles[StyleNames.Footer];
            style.ParagraphFormat.AddTabStop("8cm", MigraDoc.DocumentObjectModel.TabAlignment.Center);

            // Create a new style called Table based on style Normal
            style = this.document.Styles.AddStyle("Table", "Normal");
            style.Font.Name = "Verdana";
            style.Font.Name = "Times New Roman";
            style.Font.Size = 9;

            // Create a new style called Reference based on style Normal
            style = this.document.Styles.AddStyle("Reference", "Normal");
            style.ParagraphFormat.SpaceBefore = "5mm";
            style.ParagraphFormat.SpaceAfter = "5mm";
            style.ParagraphFormat.TabStops.AddTabStop("16cm", MigraDoc.DocumentObjectModel.TabAlignment.Right);
        }

        void CreatePage()
        {
            // Each MigraDoc document needs at least one section.
            Section section = this.document.AddSection();

            // Put a logo in the header
            Image image = section.Headers.Primary.AddImage ("");
            image.Height = "2.5cm";
            image.LockAspectRatio = true;
            image.RelativeVertical = RelativeVertical.Line;
            image.RelativeHorizontal = RelativeHorizontal.Margin;
            image.Top = ShapePosition.Top;
            image.Left = ShapePosition.Right;
            image.WrapFormat.Style = WrapStyle.Through;

            // Create footer
            Paragraph paragraph = section.Footers.Primary.AddParagraph();
            paragraph.AddText("Cyril's Garden Flower Shop Sales Management System");
            paragraph.Format.Font.Size = 9;
            paragraph.Format.Alignment = ParagraphAlignment.Center;

            // Create the text frame for the address
            this.addressFrame = section.AddTextFrame();
            this.addressFrame.Height = "3.0cm";
            this.addressFrame.Width = "7.0cm";
            this.addressFrame.Left = ShapePosition.Left;
            this.addressFrame.RelativeHorizontal = RelativeHorizontal.Margin;
            this.addressFrame.Top = "5.0cm";
            this.addressFrame.RelativeVertical = RelativeVertical.Page;

            // Put sender in address frame
            paragraph = this.addressFrame.AddParagraph("Cyril's Garden Flower Shop Sales Management System");
            paragraph.Format.Font.Name = "Times New Roman";
            paragraph.Format.Font.Size = 7;
            paragraph.Format.SpaceAfter = 3;

            // Add the print date field
            paragraph = section.AddParagraph();
            paragraph.Format.SpaceBefore = "8cm";
            paragraph.Style = "Reference";
            paragraph.AddFormattedText(string.Format("Invoice No: {0}", InvoidNo), TextFormat.Bold);
            paragraph.AddTab();
            paragraph.AddText("Date: ");
            paragraph.AddDateField("MM/dd/yyyy");

            // Create the item table
            this.table = section.AddTable();
            this.table.Style = "Table";
            this.table.Borders.Color = Colors.AliceBlue; //TableBorder;
            this.table.Borders.Width = 0.25;
            this.table.Borders.Left.Width = 0.5;
            this.table.Borders.Right.Width = 0.5;
            this.table.Rows.LeftIndent = 0;

            // Before you can add a row, you must define the columns
            Column column = this.table.AddColumn("1cm");
            column.Format.Alignment = ParagraphAlignment.Center;

            column = this.table.AddColumn("2.5cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = this.table.AddColumn("3cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = this.table.AddColumn("2cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = this.table.AddColumn("2cm");
            column.Format.Alignment = ParagraphAlignment.Center;

            column = this.table.AddColumn("3cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = this.table.AddColumn("2.5cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            // Create the header of the table
            Row row = table.AddRow();
            row.HeadingFormat = true;
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Format.Font.Bold = true;
            row.Shading.Color = Colors.Aqua; //TableBlue;
            row.Cells[0].AddParagraph("Line#");
            row.Cells[0].Format.Font.Bold = false;
            row.Cells[1].AddParagraph("Item Name");
            row.Cells[1].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[2].AddParagraph("Category");
            row.Cells[2].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[3].AddParagraph("Description");
            row.Cells[3].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[4].AddParagraph("Price");
            row.Cells[4].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[5].AddParagraph("Quantity");
            row.Cells[5].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[6].AddParagraph("Total");
            row.Cells[6].Format.Alignment = ParagraphAlignment.Left;
        }

        void FillContent()
        {
            // Fill address in address text frame
            Paragraph paragraph = this.addressFrame.AddParagraph();
            paragraph.AddText(CustomerName);
            paragraph.AddLineBreak();
            paragraph.AddText(CustomerAddress);


            // Iterate the invoice items
            double totalExtendedPrice = 0;
            int line = 1;
            foreach (ListViewItem listItems in listViewItem)
            {
                double quantity = Convert.ToDouble(listItems.SubItems[5].Text);
                double price = Convert.ToDouble(listItems.SubItems[4].Text);

                // Each item fills two rows
                Row row1 = this.table.AddRow();
                row1.TopPadding = 1.5;
                row1.Cells[0].Shading.Color = Colors.Gray; // TableGray;
                row1.Cells[0].VerticalAlignment = VerticalAlignment.Center;
                row1.Cells[1].Format.Alignment = ParagraphAlignment.Left;
                row1.Cells[2].Format.Alignment = ParagraphAlignment.Left;
                row1.Cells[3].Format.Alignment = ParagraphAlignment.Left;
                row1.Cells[4].Format.Alignment = ParagraphAlignment.Left;
                row1.Cells[5].Format.Alignment = ParagraphAlignment.Left;
                row1.Cells[6].Format.Alignment = ParagraphAlignment.Right;

                row1.Cells[0].AddParagraph(line.ToString()); 
                row1.Cells[1].AddParagraph(listItems.SubItems[1].Text); // ItemName
                row1.Cells[2].AddParagraph(listItems.SubItems[2].Text); // Category
                row1.Cells[3].AddParagraph(listItems.SubItems[3].Text); // Description
                row1.Cells[4].AddParagraph(listItems.SubItems[4].Text); // Price
                row1.Cells[5].AddParagraph(listItems.SubItems[5].Text); // Quantity
                row1.Cells[6].AddParagraph(listItems.SubItems[6].Text + " PHP"); // Total Price
                totalExtendedPrice += (Convert.ToDouble(listItems.SubItems[6].Text));
                line++;
            }

            // Add an invisible row as a space line to the table
            Row row = this.table.AddRow();
            row.Borders.Visible = false;
        
            // Add the total due row

            // Compute 12% TAX.
            string NetSales = (totalExtendedPrice / 1.12).ToString("###,##0.00");
            string TaxPayable = (totalExtendedPrice - (totalExtendedPrice / 1.12)).ToString("###,##0.00");
            string TotalSales = totalExtendedPrice.ToString("###,##0.00");

            row = this.table.AddRow();
            row.Cells[5].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[5].AddParagraph("Net Sales:");
            row.Cells[6].Format.Alignment = ParagraphAlignment.Right;
            row.Cells[6].AddParagraph(NetSales + " PHP");

            row = this.table.AddRow();
            row.Cells[5].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[5].AddParagraph("Tax Payable (12%):");
            row.Cells[6].Format.Alignment = ParagraphAlignment.Right;
            row.Cells[6].AddParagraph(TaxPayable + " PHP");

            row = this.table.AddRow();
            row.Cells[5].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[5].AddParagraph("Total Sales:");
            row.Cells[6].Format.Alignment = ParagraphAlignment.Right;
            row.Cells[6].AddParagraph(TotalSales + " PHP");

            // Set the borders of the specified cell range
            this.table.SetEdge(5, this.table.Rows.Count - 4, 1, 4, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 0.75);

            // Add the notes paragraph
            paragraph = this.document.LastSection.AddParagraph();
            paragraph.Format.SpaceBefore = "1cm";
            paragraph.Format.Borders.Width = 0.75;
            paragraph.Format.Borders.Distance = 3;
            paragraph.Format.Borders.Color = Colors.AliceBlue;
            paragraph.Format.Shading.Color = Colors.Gray;
            paragraph.AddText("We guarantee all items are in good condition!!!");
        }
    }
}