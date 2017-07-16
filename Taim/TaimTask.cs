using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Taim
{
    public class TaimTask
    {
        public string Title
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }

        public string Estimation
        {
            get; set;
        }

        [XmlIgnore]
        public TimeSpan ElapsedTime
        {
            get; set;
        }
        
        public string ElapsedTimeString
        {
            get { return ElapsedTime.ToString(); }
            set { ElapsedTime = TimeSpan.Parse(value); }
        }

        public TaimTask()
        {
            ElapsedTime = new TimeSpan();
        }

        public TaimTask(string title, string description, string estimation)
        {
            Title = title;
            Description = description;
            Estimation = estimation;
            ElapsedTime = new TimeSpan();
        }

        public void Work(TimeSpan duration)
        {
            ElapsedTime = ElapsedTime.Add(duration);
        }
    }
}
