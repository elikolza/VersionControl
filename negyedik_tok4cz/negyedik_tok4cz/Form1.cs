using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace negyedik_tok4cz
{
    public partial class Form1 : Form
    {
        List<Flat> Flats;
        RealEstateEntities context = new RealEstateEntities();

        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;

        private void CreateExcel()
        {
            try
            {
                // Excel elindítása és az applikáció objektum betöltése
                xlApp = new Excel.Application();

                // Új munkafüzet
                xlWB = xlApp.Workbooks.Add(Missing.Value);

                // Új munkalap
                xlSheet = xlWB.ActiveSheet;

                // Tábla létrehozása
                CreateTable(); // Ennek megírása a következő feladatrészben következik

                // Control átadása a felhasználónak
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex) // Hibakezelés a beépített hibaüzenettel
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                // Hiba esetén az Excel applikáció bezárása automatikusan
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }
          

        private void CreateTable()
        {
            string[] headers = new string[]
            {
                 "Kód",
                 "Eladó",
                 "Oldal",
                 "Kerület",
                 "Lift",
                 "Szobák száma",
                 "Alapterület (m2)",
                 "Ár (mFt)",
                 "Négyzetméter ár (Ft/m2)"
            };

            for (int tömb = 1; tömb <= headers.Length; tömb++)
            {
                xlSheet.Cells[1, 1] = headers[tömb-1];
            }

            /*Két dimenziós tömb*/

            object[,] values = new object[Flats.Count, headers.Length];

            int counter = 0;
            foreach (Flat f in Flats)
            {
                values[counter, 0] = f.Code;
                values[counter, 1] = f.Vendor;
                values[counter, 2] = f.Side;
                values[counter, 3] = f.District;

                if (f.Elevator == false)
                {
                    values[counter, 4] = "Nincs";
                }
                else
                {
                    values[counter, 4] = "Van";
                }

                values[counter, 5] = f.NumberOfRooms;
                values[counter, 5] = f.FloorArea;
                values[counter, 6] = f.Price;
                values[counter, 7] = f.Code;
                values[counter, 8] = "=" + (GetCell(counter + 2, values.GetLength(1) - 2)).ToString() + "*" + (GetCell(counter + 2, values.GetLength(1) - 1)).ToString(); ;
                counter++;
            }

         xlSheet.get_Range(
         GetCell(2, 1),
         GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;

        }

    private string GetCell(int x, int y)
    {
        string ExcelCoordinate = "";
        int dividend = y;
        int modulo;

        while (dividend > 0)
        {
            modulo = (dividend - 1) % 26;
            ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
            dividend = (int)((dividend - modulo) / 26);
        }
        ExcelCoordinate += x.ToString();

        return ExcelCoordinate;
    }

    public Form1()
        {
            InitializeComponent();
            LoadData();
            CreateExcel();
        }

        private void LoadData()
        {
            Flats = context.Flats.ToList();
        }

    }
}
