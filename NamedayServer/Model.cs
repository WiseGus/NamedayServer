using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NamedayServer {
    public enum AnniversaryType { Nameday, International, National }

    [DataContract]
    public class Anniversary {

        [DataMember]
        public string Date {
            get {
                string monthDescription;
                switch (Month) {
                    case 1: monthDescription = "Ιανουαρίου"; break;
                    case 2: monthDescription = "Φεβρουαρίου"; break;
                    case 3: monthDescription = "Μαρτίου"; break;
                    case 4: monthDescription = "Απριλίου"; break;
                    case 5: monthDescription = "Μαϊου"; break;
                    case 6: monthDescription = "Ιουνίου"; break;
                    case 7: monthDescription = "Ιουλίου"; break;
                    case 8: monthDescription = "Αυγούστου"; break;
                    case 9: monthDescription = "Σεπτεμβρίου"; break;
                    case 10: monthDescription = "Οκτωβρίου"; break;
                    case 11: monthDescription = "Νοεμβρίου"; break;
                    case 12: monthDescription = "Δεκεμβρίου"; break;
                    default: monthDescription = null; break;
                }
                return Day.ToString() + " " + monthDescription;
            }
            protected set { }
        }

        [DataMember]
        public int Month { get; set; }

        [DataMember]
        public int Day { get; set; }

        [DataMember]
        public int IsHoliday { get; set; }

        [DataMember]
        public int IsNameday { get; set; }

        [DataMember]
        public int IsInternationalDay { get; set; }

        [DataMember]
        public int IsΝationalDay { get; set; }

        [DataMember]
        public string[] Names { get; set; }

        [DataMember]
        public int NonStatic { get; set; }
    }

    [DataContract]
    public class AnniversariesForMonth {

        [DataMember]
        public int Month { get; set; }

        [DataMember]
        public List<Anniversary> Anniversary { get; set; }
    }

    [DataContract]
    public class AnniversariesForYear {

        [DataMember]
        public string AnniversaryType { get; set; }

        [DataMember]
        public List<AnniversariesForMonth> Anniversaries { get; set; }
    }
}
