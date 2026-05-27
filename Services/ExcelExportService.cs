using ClosedXML.Excel;
using InventoryManager.Models;

namespace InventoryManager.Services
{
    public class ExcelExportService
    {
        public void ExportProducts(
            List<Product> products,
            string path)
        {
            using var workbook = new XLWorkbook();

            var worksheet =
                workbook.Worksheets.Add("Products");

            // HEADERS
            worksheet.Cell(1, 1).Value = "Id";
            worksheet.Cell(1, 2).Value = "Name";
            worksheet.Cell(1, 3).Value = "Quantity";
            worksheet.Cell(1, 4).Value = "Price";
            worksheet.Cell(1, 5).Value = "Category";

            int row = 2;

            foreach(var product in products)
            {
                worksheet.Cell(row, 1).Value = product.Id;
                worksheet.Cell(row, 2).Value = product.Name;
                worksheet.Cell(row, 3).Value = product.Quantity;
                worksheet.Cell(row, 4).Value = product.Price;
                worksheet.Cell(row, 5).Value = product.Category;

                row++;
            }

            worksheet.Columns().AdjustToContents();

            workbook.SaveAs(path);
        }
    }
}