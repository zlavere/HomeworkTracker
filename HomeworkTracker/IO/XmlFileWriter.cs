using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using HomeworkTracker.Model;

namespace HomeworkTracker.IO
{
    public class XmlFileWriter
    {
        private const string TasksFile = @"../../Assets/tasks.xml";
        public CourseCollection Courses { get;}
        private XmlSerializer Serializer { get;}

        public XmlFileWriter(CourseCollection courses)
        {
            this.Serializer = new XmlSerializer(typeof(CourseCollection));
            this.Courses = courses;
        }

        public void WriteToXmlFile()
        {

                using (TextWriter textWriter = new StreamWriter(TasksFile))
                {
                    using (var xmlWriter = new XmlTextWriter(textWriter)
                    {
                        Formatting = Formatting.Indented
                    })
                    {
                        this.Serializer.Serialize(xmlWriter, this.Courses);
                    }
                }
            }
        
    }
}
