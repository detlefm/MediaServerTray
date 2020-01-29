using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MediaServerTray {
    public class MS_Status {

        public static string Endpoint = "status2.html";

        XDocument doc;

        public bool Waiting => !ActiveRecordings;
        public bool ActiveTimers => TimerCount > 0;
        public bool ActiveRecordings => RecCount > 0;

        public int RecCount => GetFirstInt("reccount");
        public int TimerCount => GetFirstInt("timercount");

        public int NextTimer => GetFirstInt("nexttimer");


        private int GetFirstInt(string name) {
            var recCount = doc.Descendants(name).Select(p => p).FirstOrDefault();
            if (recCount != null) {
                if (int.TryParse(recCount.Value, out int nr)) {
                    return nr;
                }
            }
            return -1;
        }

        public bool Parse(string xmlString) {
            if (xmlString.StartsWith("<?xml")) {
                doc = XDocument.Parse(xmlString);
                return true;
            } else {
                return false;
            }
        }
 
    }
}
