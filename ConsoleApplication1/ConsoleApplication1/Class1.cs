using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Diagnostics;


namespace ConsoleApplication1
{
    class Table
    {
        static void Main()
        {
            XElement table = new XElement("table");
            table.Add(new XAttribute("border", "1"));
            table.Add(new XAttribute("style", "width:600px"));

            // in practice values would be loaded from database


            var values = new List
        {
          "Software Development",
          "IT Enabled Services(20)",
          "IT - Training Institute(10)",
          "IT - Hardware(20)",
          "Call Center(14)",
          "BPO",
          "ISP",
          "IT-HR Consultancy",
          "Bio Technology",
          "Web Hosting",
          "Web Services",
          "Telecom",
          "Software Re-seller",
          "Dot Com",
          "Networking",          
          "Animation",
          "STPI"
        };

            AddRows(table, values);
            File.WriteAllText("mytable.html", table.ToString());
            Process.Start("mytable.html"); // display in browser
        }

        static void AddRows(XElement table, List values)
        {
            int numRows = values.Count / 3;
            int remCols = values.Count % 3;
            if (remCols > 0) numRows++;
            for (int i = 0; i < numRows; i++)
            {
                XElement tr = new XElement("tr");
                if (i < numRows - 1 || remCols == 0)
                {
                    tr.Add(new XElement("td", values[i * 3]),
                           new XElement("td", values[i * 3 + 1]),
                           new XElement("td", values[i * 3 + 2]));
                }
                else if (remCols == 1)
                {
                    tr.Add(new XElement("td", values[i * 3]),
                           new XElement("td", ""),
                           new XElement("td", ""));
                }
                else if (remCols == 2)
                {
                    tr.Add(new XElement("td", values[i * 3]),
                           new XElement("td", values[i * 3 + 1]),
                           new XElement("td", ""));
                }
                table.Add(tr);
            }
        }
    }
}
