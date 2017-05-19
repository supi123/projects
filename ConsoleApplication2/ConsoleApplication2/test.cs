using ConsoleApplication2;
using System;
using System.Xml;
using System.Linq;

public class GenerateXml
{
    public void Mains()
    {
        XmlDocument doc = new XmlDocument();
        doc.LoadXml("<book genre='novel' ISBN='1-861001-57-5'>" +
                    "<title>Pride And Prejudice</title>" +
                    "</book>");
        angularEntities db = new angularEntities();




        XmlNode root = doc.DocumentElement;


        var ds = (db.xml_table.GroupBy(s => s.WorkerID).Select(d => new { workid = d.Key })).ToList();

        

        foreach (var item in ds)
        {



            XmlElement elem = doc.CreateElement("staffHours");
            root.InsertAfter(elem, root.FirstChild);
            XmlElement elemS = doc.CreateElement("employeeId");
            elemS.InnerText = Convert.ToString(item.workid);
            elem.AppendChild(elemS);
            XmlElement child2 = doc.CreateElement("workDays");
            elem.AppendChild(child2);
            XmlElement child3 = doc.CreateElement("workDay");
            child2.AppendChild(child3);
            var date = (from s in db.xml_table where (s.WorkerID == item.workid) select s.WorkDate).Distinct().ToList();
            foreach (var items in date)
            {
                XmlElement child4 = doc.CreateElement("date");
                child4.InnerText = items;
                child3.AppendChild(child4);

                XmlElement child5 = doc.CreateElement("hourEntries");
                child3.AppendChild(child5);
                XmlElement child6 = doc.CreateElement("hourEntry");
                child5.AppendChild(child6);
                var hour = (from s in db.xml_table where (s.WorkerID == item.workid && s.WorkDate == items) select s).ToList();

                foreach (var item2 in hour)
                {


                    XmlElement child7 = doc.CreateElement("hours");
                    child7.InnerText = item2.Hours;
                    child6.AppendChild(child7);
                    XmlElement child8 = doc.CreateElement("jobTitleCode");
                    child8.InnerText = item2.JobTitleCode;
                    child6.AppendChild(child8);
                    XmlElement child9 = doc.CreateElement("payTypeCode");
                    child9.InnerText = item2.PayCode;
                    child6.AppendChild(child9);
                }
            }
        }


        XmlElement mainchild = doc.CreateElement("employees");
        root.InsertAfter(mainchild, root.FirstChild);
        foreach (var employee in ds)
        {
            XmlElement child21 = doc.CreateElement("employee");
            child21.InnerText = Convert.ToString(employee.workid);
            mainchild.AppendChild(child21);


        }
        Console.WriteLine("Display the modified XML...");
        doc.Save(@"f:\d.xml");
    }
}