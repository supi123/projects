
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml;
    
//namespace ConsoleApplication2
//{
//    public class xml
//    {
//        public void d()
//        {
//            angularEntities db = new angularEntities();
//            var data = ((from s in db.xml_table select s).Distinct()).ToList();


//            XmlTextWriter writer = new XmlTextWriter(@"f:\d.xml", null);
//            XmlDocument doc = new XmlDocument();

//            writer.WriteStartDocument(true);

//            writer.Formatting = Formatting.Indented;

//            writer.Indentation = 2;

//            writer.WriteStartElement("employees");

//            foreach (var item in data)
//            {
//                //createNode(item.FacilityID, item.FacilityName, item.WorkerID, item.DateOfHire, item.TerminationDate, item.WorkDate, item.JobTitleCode, item.DepartmentCode, item.PayCode, item.PayType, item.Hours,writer);
//                createNode(item.WorkerID,item.DateOfHire,writer);
//            }

//            writer.WriteEndElement();

//            writer.WriteEndDocument();

          

//            writer.Close();
//            doc.Save(writer);   

//            //Console.Write(writer.WriteEndDocument());
//        }
//        //private void createNode(string FacilityID, string FacilityName, string WorkerID, dynamic DateOfHire, dynamic TerminationDate, dynamic WorkDate, dynamic JobTitleCode, dynamic DepartmentCode, dynamic PayCode, dynamic PayType, dynamic Hours, XmlTextWriter writer)
//        //{

//        //    writer.WriteStartElement("Product");

//        //    writer.WriteStartElement("FacilityID");

//        //    writer.WriteString(FacilityID);

//        //    writer.WriteEndElement();

//        //    writer.WriteStartElement("FacilityName");

//        //    writer.WriteString(FacilityName);

//        //    writer.WriteEndElement();

//        //    writer.WriteStartElement("WorkerID");

//        //    writer.WriteString(WorkerID);

//        //    writer.WriteEndElement();

//        //    writer.WriteEndElement();

//        //}

//        private void createNode( string WorkerID,string dataofhiring, XmlTextWriter writer)
//        {

//            writer.WriteStartElement("employee");

//            writer.WriteStartElement("WorkerID");

//            writer.WriteString(WorkerID);

//            writer.WriteEndElement();

//            writer.WriteStartElement("dataofhiring");

//            writer.WriteString(dataofhiring);

//            writer.WriteEndElement();

//            writer.WriteEndElement();
            

//        }

//    }
//}
