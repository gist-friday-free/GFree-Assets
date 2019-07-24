using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectMaker {
    class ClassData {

        public static string YEAR = "year";
        public static string SEMESTER = "semester";
        public static string CODE = "code";
        public static string NAME = "name";
        public static string PROFESSOR = "professor";
        public static string PLACE = "place";
        public static string SIZE = "size";
        public static string TIME = "time";
        public static string GRADE = "grade";

        public int year { get; set; }
        public int semester { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string professor { get; set; }
        public string place { get; set; }
        public int size { get; set; }
        public List<TimeSlot> time { get; set; }
        public int grade { get; set; }



        public override string ToString() {
            return $"코드 : {code}, 교수 : {professor}, 과목 : {name}, 장소 : {place}";
        }



        public static string GetCodeFromFullCode(string fullCode) {
            if (!fullCode.Contains("-"))
                return fullCode;
            else {
                return fullCode.Split('-')[0];
            }
        }
        public static int GetClassFromFullCode(string fullCode) {
            if (!fullCode.Contains("-")) {
                return -1;
            } else {
                return int.Parse(fullCode.Split('-')[1]);
            }
        }
    }

    class TimeSlot {
        public string week { get; set; }
        public HourMin startTime { get; set; }
        public HourMin endTime { get; set; }

        override public string ToString() {
            
            return String.Format("{0} {1:00}:{2:00} ~ {3:00}:{4:00}" ,week,
                startTime.hour,startTime.min,endTime.hour,endTime.min);
        }
    }
    class HourMin {
        public int hour { get; set; }
        public int min { get; set; }

        public HourMin(int hour , int min) {
            this.hour = hour;
            this.min = min;
        }
    }
}
