using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{

    public class DynamicHtmlTable
    {


  
        //table tag constants

        private const string HtmlTableStart = "<table cellspacing=0 cellpadding=0 style=\"border-collapse:collapse; text-align:center;\">";

        private const string HtmlTableEnd = "</table>";

        private const string HtmlTrStart = "<tr>";

        private const string HtmlTrEnd = "</tr>";

        private const string HtmlThStart = "<th style=\" border-color:#5c87b2; border-style:solid;text-align:center;border-width:thin;\">";

        private const string HtmlThEnd = "</th>";

        private const string HtmlTdStart = "<td style=\" border-color:#5c87b2; border-style:solid;border-width:thin;\">";

        private const string HtmlTdEnd = "</td>";


      
        //This method creates dynamic table
                //This method create table header row with columns names
        private static void CreateTableHeaderRow(StringBuilder DynamicTable)
        {

            DynamicTable.AppendLine(HtmlTrStart);

            DynamicTable.AppendLine(HtmlThStart + "Name" + HtmlThEnd);

            DynamicTable.AppendLine(HtmlThStart + "Category" + HtmlThEnd);

            DynamicTable.AppendLine(HtmlThStart + "Price" + HtmlThEnd);

            DynamicTable.AppendLine(HtmlThStart + "Image URL" + HtmlThEnd);

            DynamicTable.AppendLine(HtmlTrEnd);

        }


        //This method create new table row with data
        private static void CreateTableRow(Product Product,

           StringBuilder emailDynamicTable)
        {

           
        }



        static void Main()
        {



            Console.WriteLine(DynamicTable);
        }



}







    }

  

