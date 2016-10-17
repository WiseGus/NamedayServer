using System;
using System.Collections.Generic;

namespace NamedayServer {

    public class Anniversaries {

        public IEnumerable<Anniversary> AnnivsData { get { return _AnnivsData; } }
        private List<Anniversary> _AnnivsData = new List<Anniversary>();

        public Anniversaries(int year) {
            AddAnnivsJanuary();
            AddAnnivsFebruary();
            AddAnnivsMarch();
            AddAnnivsApril();
            AddAnnivsMay();
            AddAnnivsJune();
            AddAnnivsJuly();
            AddAnnivsAugust();
            AddAnnivsSeptember();
            AddAnnivsOctober();
            AddAnnivsNovember();
            AddAnnivsDecember();

            DateTime easterDate = Easter.CalcEaster(year);
            AddAnnivsNonStatic(easterDate);

            AddAnnivsSpecial(year);

            AddAnnivsInternational();

            AddAnnivsNational();
        }

        private void AddAnnivsJanuary() {
            _AnnivsData.Add(new Anniversary { Day = 1, Month = 1, IsNameday = 1, Names = new[] { "Βασίλειος", "Βασίλης", "Βάσος", "Βασίλας", "Μπίλλης", "Μπίλης", "Βασιλεία", "Βασιλική", "Βάσω", "Βάσια", "Βιβή", "Βίκυ", "Βίβιαν", "Βασούλα", "Βασιλίνα", "Εμμέλεια", "Τηλέμαχος" } });
            _AnnivsData.Add(new Anniversary { Day = 2, Month = 1, IsNameday = 1, Names = new[] { "Σεραφείμ", "Σεραφειμία", "Σεραφείμα", "Σεραφίνα", "Σεραφειμή", "Σεραφειμούλα", "Σεραφειμίτσα", "Σίλβεστρος", "Σιλβέστρης", "Σίλβης", "Σιλβέστρα", "Σίλβα" } });
            _AnnivsData.Add(new Anniversary { Day = 3, Month = 1, IsNameday = 1, Names = new[] { "Γενοβέφα", "Γενεβιέβη" } });
            _AnnivsData.Add(new Anniversary { Day = 4, Month = 1, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 5, Month = 1, IsNameday = 1, Names = new[] { "Θεωνάς", "Θεώνη", "Θεόπεμπτος", "Θεόπεμπτη", "Συγκλητική" } });
            _AnnivsData.Add(new Anniversary { Day = 6, Month = 1, IsNameday = 1, Names = new[] { "Φώτιος", "Φώτης", "Φωτεινός", "Φώτις", "Φωτεινή", "Φανή", "Φένια", "Φώτω", "Φώφη", "Φωτούλα", "Φαίη", "Φωφώ", "Θεοφάνης", "Φάνης", "Θεοφανία", "Φάνια", "Φανή", "Φένια", "Φανούλα", "Ιορδάνης", "Ντάνης", "Δάνης", "Ιορδάνα", "Ντάνα", "Δάνα", "Ουρανία", "Ράνια", "Περιστέρα", "Θεοπούλα", "Θεόπη" } });
            _AnnivsData.Add(new Anniversary { Day = 7, Month = 1, IsNameday = 1, Names = new[] { "Γιάννης", "Τζαννής", "Τζανής", "Γιάγκος", "Ιωάννης", "Ζαννέτος", "Ζαννέττος", "Γιάννα", "Γιαννούλα", "Ιωάννα", "Ζαννέτα", "Ζαννέττα", "Ζανέτ", "Πρόδρομος", "Προδρομάκης", "Μάκης" } });
            _AnnivsData.Add(new Anniversary { Day = 8, Month = 1, IsNameday = 1, Names = new[] { "Αγάθων", "Βασίλισσα", "Κέλσιος", "Κέλσια", "Κέλσα", "Κέλση", "Δομινίκη", "Δομνίκα", "Δομνίκη", "Δομήνικος", "Παρθένα", "Έλσα", "Έλση", "Νένα" } });
            _AnnivsData.Add(new Anniversary { Day = 9, Month = 1, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 10, Month = 1, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 11, Month = 1, IsNameday = 1, Names = new[] { "Θεοδόσιος", "Θεοδόσης", "Δόσιος", "Δόσης" } });
            _AnnivsData.Add(new Anniversary { Day = 12, Month = 1, IsNameday = 1, Names = new[] { "Τατιανή", "Τατιάνα", "Τάτια", "Τίτη", "Τάνια", "Μέρτιος", "Μέρτος", "Μέρτης", "Μύρτος", "Μερτία", "Μέρτα", "Μέρτη", "Μερτούλα", "Μυρτιά", "Μυρτούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 13, Month = 1, IsNameday = 1, Names = new[] { "Ερμύλλος", "Ερμίλλος", "Ερμύλλη", "Ερμίλλη", "Ερμύλα" } });
            _AnnivsData.Add(new Anniversary { Day = 14, Month = 1, IsNameday = 1, Names = new[] { "Νίνας", "Νίνα" } });
            _AnnivsData.Add(new Anniversary { Day = 15, Month = 1, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 16, Month = 1, IsNameday = 1, Names = new[] { "Δαν", "Δανάη" } });
            _AnnivsData.Add(new Anniversary { Day = 17, Month = 1, IsNameday = 1, Names = new[] { "Αντώνιος", "Αντώνης", "Τόνης", "Νάκος", "Αντώνας", "Αντωνάκος", "Αντωνάκης", "Τόνυ", "Αντωνία", "Αντωνούλα", "Τόνια", "Θεοδόσιος", "Θεοδόσης", "Δόσιος", "Δόσης" } });
            _AnnivsData.Add(new Anniversary { Day = 18, Month = 1, IsNameday = 1, Names = new[] { "Αθανάσιος", "Θανάσης", "Νάσος", "Σάκης", "Θάνος", "Θανάσος", "Θανασάκης", "Σούλης", "Αθανασία", "Νάσια", "Νάνσυ", "Θανασία", "Θανασούλα", "Σούλα", "Νάσα", "Σούλη", "Κύριλλος", "Κυριλλία", "Κυρίλλα", "Κυρίλλη", "Θεόδουλος", "Θεοδούλιος", "Θεοδούλης", "Θεοδουλία", "Θεοδούλα", "Θεόδουλη" } });
            _AnnivsData.Add(new Anniversary { Day = 19, Month = 1, IsNameday = 1, Names = new[] { "Ευφρασία", "Ευφρασίτσα", "Μακάριος", "Μακάρης", "Μακαράς", "Μακαρία", "Μακάρω", "Μακαρίτσα", "Μακαρούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 20, Month = 1, IsNameday = 1, Names = new[] { "Ευθύμιος", "Ευθύμης", "Θύμιος", "Θέμης", "Ευθυμία", "Ευθυμούλα", "Θύρσος", "Θύρσης", "Θύρσα", "Θύρση", "Φαβιανός" } });
            _AnnivsData.Add(new Anniversary { Day = 21, Month = 1, IsNameday = 1, Names = new[] { "Αγνή", "Αγνούλα", "Ευγένιος", "Ευγένης", "Μάξιμος", "Μάξιμη", "Μάξιμα", "Νεόφυτος", "Νεοφυτία", "Νεοφύτη", "Πάτροκλος", "Πατρόκλειος", "Πατροκλέας", "Πατροκλής", "Πατρόκλεια", "Πατροκλά", "Πάτρα", "Πατρούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 22, Month = 1, IsNameday = 1, Names = new[] { "Τιμόθεος", "Τίμος", "Τιμάς", "Τίμης", "Θέος", "Τιμοθέη", "Τιμοθέα", "Τίμα", "Τίμη", "Θέα", "Θέη" } });
            _AnnivsData.Add(new Anniversary { Day = 23, Month = 1, IsNameday = 1, Names = new[] { "Αγαθάγγελος", "Αγαθαγγέλα", "Αγαθαγγέλη", "Διονύσιος", "Διονύσης", "Νιόνιος", "Νύσης", "Ντένης", "Διονυσία", "Διονυσούλα", "Νύσα", "Σίσσυ", "Ντενίζ" } });
            _AnnivsData.Add(new Anniversary { Day = 24, Month = 1, IsNameday = 1, Names = new[] { "Ζωσιμάς", "Ζωσιμίνα", "Ξένος", "Ξένιος", "Ξένη", "Ξένια", "Φίλωνας", "Φίλων" } });
            _AnnivsData.Add(new Anniversary { Day = 25, Month = 1, IsNameday = 1, Names = new[] { "Γρηγόρης", "Γρηγόριος", "Γόλης", "Γρηγορία", "Μαργαρίτα" } });
            _AnnivsData.Add(new Anniversary { Day = 26, Month = 1, IsNameday = 1, Names = new[] { "Ξενοφών", "Ξενοφώντας", "Φώντας", "Φόντας", "Φόνης", "Ξενοφωντία", "Ξενοφωντίνα", "Ξενοφούλα", "Ξενοφώντη", "Ξένια" } });
            _AnnivsData.Add(new Anniversary { Day = 27, Month = 1, IsNameday = 1, Names = new[] { "Χρυσόστομος", "Χρυσοστόμης", "Χρυσοστόμη", "Χρυσοστομία", "Χρυσοστομίτσα" } });
            _AnnivsData.Add(new Anniversary { Day = 28, Month = 1, IsNameday = 1, Names = new[] { "Παλλάδιος", "Παλάδιος", "Παλλάδης", "Παλάδης", "Χάρις" } });
            _AnnivsData.Add(new Anniversary { Day = 29, Month = 1, IsNameday = 1, Names = new[] { "Βαρσιμαίος", "Βαρσάμης", "Βαρσαμία", "Βαρσάμω", "Βαλσάμω", "Βαλσαμία" } });
            _AnnivsData.Add(new Anniversary { Day = 30, Month = 1, IsNameday = 1, Names = new[] { "Μαύρος", "Μαυρουδής", "Μαυροειδής", "Μαυρέτα", "Χρυσή", "Χρύσα", "Χρυσαλία", "Χρυσαυγή", "Χρυσούλα", "Σήλια", "Χρυστάλλα", "Χρυσταλλία", "Αύρα" } });
            _AnnivsData.Add(new Anniversary { Day = 30, Month = 1, IsNameday = 1, Names = new[] { "Κύρος", "Κύρης", "Ευδοξία", "Ευδοξούλα", "Δόξα", "Δοξούλα" } });
        }

        private void AddAnnivsFebruary() {
            _AnnivsData.Add(new Anniversary { Day = 1, Month = 2, IsNameday = 1, Names = new[] { "Τρύφων", "Τρύφωνας", "Τρυφωνία", "Φιλικητάτη", "Φιλικήτη", "Φιλικήτα" } });
            _AnnivsData.Add(new Anniversary { Day = 2, Month = 2, IsNameday = 1, Names = new[] { "Υπαπαντή", "Μαρουλία", "Μαρούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 3, Month = 2, IsNameday = 1, Names = new[] { "Σταμάτης", "Σταμάτιος", "Στάμος", "Σταμούλης", "Σταμέλος", "Σταμέλης", "Σταμελάς", "Σταματία", "Μάτα", "Ματούλα", "Ματίνα", "Σταματίνα", "Σταμάτα", "Σταμέλα", "Σταμούλα", "Σταματή", "Μάτω", "Σταματέλλα", "Συμεών", "Συμεώνης", "Σύμος", "Συμεωνή", "Συμεωνία", "Συμεώνα", "Σύμη" } });
            _AnnivsData.Add(new Anniversary { Day = 4, Month = 2, IsNameday = 1, Names = new[] { "Ιάσιμος", "Σίμος", "Ιασίμη", "Σίμη", "Ισίδωρος", "Σιδέρης", "Ισιδώρα", "Δώρα" } });
            _AnnivsData.Add(new Anniversary { Day = 5, Month = 2, IsNameday = 1, Names = new[] { "Αγαθή", "Αγαθούλα", "Αγαθώ", "Αγαθία", "Αγαθίτσα" } });
            _AnnivsData.Add(new Anniversary { Day = 6, Month = 2, IsNameday = 1, Names = new[] { "Φώτιος", "Φώτης", "Φωτεινός", "Φώτις", "Φωτεινή", "Φανή", "Φένια", "Φώτω", "Φώφη", "Φωτούλα", "Φαίη", "Φωφώ" } });
            _AnnivsData.Add(new Anniversary { Day = 7, Month = 2, IsNameday = 1, Names = new[] { "Παρθένιος", "Παρθένης", "Παρθενία", "Παρθενόπη" } });
            _AnnivsData.Add(new Anniversary { Day = 8, Month = 2, IsNameday = 1, Names = new[] { "Ζαχαρίας", "Ζάχαρης", "Ζάχαρος", "Ζάκι", "Ζάκης", "Ζαχαρένια", "Ζαχάρω", "Ζαχαρούλα", "Ζαχαρίτσα" } });
            _AnnivsData.Add(new Anniversary { Day = 9, Month = 2, IsNameday = 1, Names = new[] { "Μάρκελος", "Παγκράτιος", "Παγκρατία", "Νικηφόρος", "Νικηφορία", "Νικηφόρα" } });
            _AnnivsData.Add(new Anniversary { Day = 10, Month = 2, IsNameday = 1, Names = new[] { "Χαράλαμπος", "Χαρίλαος", "Χαραλάμπης", "Χάρης", "Χάμπος", "Λάμπης", "Λάμπος", "Λαμπίας", "Μπάμπης", "Μπάμπος", "Χαραλαμπία", "Χαραλαμπή", "Λαμπή", "Λάμπω", "Μπαμπίνα", "Μπήλιω", "Μπιλιώ", "Μπία", "Χάμπη", "Χαρίλαος", "Χάρης", "Χαρίκλεια", "Χαρά", "Χαρούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 11, Month = 2, IsNameday = 1, Names = new[] { "Βλάσιος", "Βλάσης", "Βλάσος", "Βλασία", "Βλασούλα", "Θεοδώρα", "Θοδώρα", "Δώρα", "Δωρούλα", "Ντόρα", "Αυγή", "Αυγούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 12, Month = 2, IsNameday = 1, Names = new[] { "Μελέτιος", "Μελέτης", "Μελετία", "Μελετούλα", "Μελετίνα", "Πλωτίνος", "Πλωτός", "Πλωτίνη", "Πλωτή", "Πλωτίνα" } });
            _AnnivsData.Add(new Anniversary { Day = 13, Month = 2, IsNameday = 1, Names = new[] { "Πρίσκιλλα", "Πρισίλλα" } });
            _AnnivsData.Add(new Anniversary { Day = 14, Month = 2, IsNameday = 1, Names = new[] { "Βαλεντίνος", "Βαλεντίων", "Βαλεντίνο", "Ντίνος", "Βαλεντίνη", "Βαλεντίνα", "Ντίνα" } });
            _AnnivsData.Add(new Anniversary { Day = 15, Month = 2, IsNameday = 1, Names = new[] { "Ευσέβιος", "Ευσεβής", "Ευσεβεία", "Σέβη", "Ευσεβούλα", "Σεβούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 16, Month = 2, IsNameday = 1, Names = new[] { "Πάμφιλος", "Παμφύλη", "Παμφίλη", "Σέλευκος", "Σελεύκα", "Σελεύκη", "Σελεύκεια" } });
            _AnnivsData.Add(new Anniversary { Day = 17, Month = 2, IsNameday = 1, Names = new[] { "Θεόδωρος", "Θοδωρής", "Θόδωρος", "Θεοδώρα", "Δώρα", "Θοδώρα", "Δωρούλα", "Ντόρα", "Πουλχερία", "Πουλχερίνα", "Πουλχερίτσα", "Πουλχέρω", "Πουλχέρη" } });
            _AnnivsData.Add(new Anniversary { Day = 18, Month = 2, IsNameday = 1, Names = new[] { "Αγαπητός", "Λέων", "Λέοντας", "Λεοντάριος", "Λεοντάρης", "Λεοντόκαρδος" } });
            _AnnivsData.Add(new Anniversary { Day = 19, Month = 2, IsNameday = 1, Names = new[] { "Φιλόθεος", "Φιλοθέη", "Φιλοθέα", "Φιλοθεούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 20, Month = 2, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 21, Month = 2, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 22, Month = 2, IsNameday = 1, Names = new[] { "Θαλάσσιος", "Θαλάσσης", "Θάλασσα", "Θαλασσινή", "Θαλασσιά", "Θαλασσία" } });
            _AnnivsData.Add(new Anniversary { Day = 23, Month = 2, IsNameday = 1, Names = new[] { "Πολύκαρπος", "Πολυκάρπης", "Πολυκαρπία", "Πολυκάρπη", "Πολυκαρπίτσα", "Πολυκαρπούλα", "Πολυχρόνης", "Πολυχρόνιος", "Χρόνης", "Πολυχρονία", "Πολυχρονούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 24, Month = 2, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 25, Month = 2, IsNameday = 1, Names = new[] { "Ρήγας", "Ρηγίνος", "Ρήγος", "Ρηγίνη", "Ρηγίνα", "Ρεγίνα", "Ρεγγίνα", "Ρήγισσα", "Ρηγούλα", "Ρηγίλη", "Ρήγω", "Ταράσιος", "Ταράσης", "Ταρσή", "Ταρσώ", "Ταρασία", "Ταρσίτσα" } });
            _AnnivsData.Add(new Anniversary { Day = 26, Month = 2, IsNameday = 1, Names = new[] { "Ανατολή", "Πορφύριος", "Πορφυρός", "Πορφύρης", "Πορφυρή", "Πορφυρία", "Πορφύρα", "Πορφυρώ", "Πορφυρούλα", "Σεβαστιανός", "Σεβαστίνος", "Σεβαστός", "Σέβος", "Σέβης", "Φώτιος", "Φώτης", "Φωτεινός", "Φώτις", "Φωτεινή", "Φανή", "Φένια", "Φώτω", "Φώφη", "Φωτούλα", "Φαίη", "Φωφώ" } });
            _AnnivsData.Add(new Anniversary { Day = 27, Month = 2, IsNameday = 1, Names = new[] { "Ασκληπιός", "Ασκληπιάς", "Ασκληπιάδα", "Νήσιος", "Νήσης" } });
            _AnnivsData.Add(new Anniversary { Day = 28, Month = 2, IsNameday = 1, Names = new[] { "Κύρα", "Κυρά", "Κυράτσα", "Κυράτσω", "Κυράτση", "Κυρατσούδα", "Μαριάννα" } });
            _AnnivsData.Add(new Anniversary { Day = 29, Month = 2, IsNameday = 1, Names = new[] { "Κασσιανός", "Κασιανός", "Κάσσιος", "Κάσιος", "Κάσσος", "Κάσος" } });
        }

        private void AddAnnivsMarch() {
            _AnnivsData.Add(new Anniversary { Day = 1, Month = 3, IsNameday = 1, Names = new[] { "Ευδοκία", "Ευδοκούλα", "Ευδοκίτσα", "Ευδοκή", "Εύη", "Παράσχος", "Πάρης", "Πάρις", "Χαρίσιος", "Χάρισος", "Χαρίσης", "Χαρίσα" } });
            _AnnivsData.Add(new Anniversary { Day = 2, Month = 3, IsNameday = 1, Names = new[] { "Ευθαλία", "Θάλια", "Θάλεια", "Ευθαλίτσα", "Ευθαλιώ", "Θαλίτσα", "Θαλιώ", "Τρωάδιος", "Τρωάδης", "Τρωάδος", "Τρωάς", "Τρωάδα", "Τρωαδία", "Τρωάδη", "Τρωαδίτσα" } });
            _AnnivsData.Add(new Anniversary { Day = 3, Month = 3, IsNameday = 1, Names = new[] { "Κλεόνικος", "Κλεονίκη", "Νίκη", "Κλεονίκω", "Θεοδώρητος" } });
            _AnnivsData.Add(new Anniversary { Day = 4, Month = 3, IsNameday = 1, Names = new[] { "Γεράσιμος", "Μάκης", "Μικές", "Μίκης", "Γερασιμούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 5, Month = 3, IsNameday = 1, Names = new[] { "Αρχέλαος", "Ευλόγιος", "Ευλογής", "Ευλογία", "Ευλογούλα", "Ευλογίτσα", "Κόνων" } });
            _AnnivsData.Add(new Anniversary { Day = 6, Month = 3, IsNameday = 1, Names = new[] { "Ησύχιος", "Ησύχης", "Ησυχία" } });
            _AnnivsData.Add(new Anniversary { Day = 7, Month = 3, IsNameday = 1, Names = new[] { "Ευγένιος", "Ευγένης" } });
            _AnnivsData.Add(new Anniversary { Day = 8, Month = 3, IsNameday = 1, Names = new[] { "Ερμής", "Θεοφύλακτος", "Φυλακτός", "Φυλαχτός", "Θεοφύλακτη", "Φυλακτή", "Φυλαχτή", "Φυλαχτούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 9, Month = 3, IsNameday = 1, Names = new[] { "Αέτιος", "Αετός", "Αέτης", "Αετίς", "Αετίων", "Αετίνα", "Βιβιανός", "Βιβιάνα", "Βιβιανή", "Βιβή", "Βίβιαν", "Ηλιανός", "Ιλιάς", "Ηλιανή", "Ηλιάνα", "Λιάνα", "Ιλιάνα", "Ηλιάννα", "Λυσίμαχος", "Λυσιμάχη", "Ξάνθος", "Ξάνθιος", "Ξανθιάς", "Ξανθούλιος", "Ξανθούλης", "Ξανθή", "Ξανθούλα", "Σεβηριανός", "Σεβηριανή", "Σμάραγδος", "Σμαράγδης", "Σμαραγδένιος", "Σμάρης", "Σμαράγδα", "Σμαραγδένια", "Σμαραγδή", "Σμαράγδω", "Σμαρούλα", "Σμαρώ", "Σμαραγδία", "Σμαραγδούλα", "Σμάρα", "Φιλοκτήμων", "Φιλοκτήμονας", "Σαράντης", "Σαράντος", "Σαραντούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 10, Month = 3, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 11, Month = 3, IsNameday = 1, Names = new[] { "Θαλής", "Θαλλός", "Θαλλής", "Θάλλεια", "Θάλεια", "Θάλλω", "Θεοδώρα", "Θοδώρα", "Δώρα", "Δωρούλα", "Ντόρα", "Σαβίνα", "Ζαμπίνα", "Ζαμπία", "Σωφρόνιος", "Σωφρόνης", "Σωφρονία", "Σωφρόνη" } });
            _AnnivsData.Add(new Anniversary { Day = 12, Month = 3, IsNameday = 1, Names = new[] { "Θεοφάνης", "Φάνης", "Θεοφανία", "Φάνια", "Φανή", "Φένια", "Φανούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 13, Month = 3, IsNameday = 1, Names = new[] { "Λέανδρος", "Μάριος" } });
            _AnnivsData.Add(new Anniversary { Day = 14, Month = 3, IsNameday = 1, Names = new[] { "Βενέδικτος", "Βενεδίκτη", "Βενεδικτίνη", "Βενεδικτίνα", "Ευφράσιος", "Ευφράσης", "Ευφράσας", "Φράσας", "Φράσιος", "Φράσης", "Ματθίλντη", "Ματίλντα", "Ματθίλδη", "Μαθίλδη", "Θίλδη", "Θίλδα", "Τίτα" } });
            _AnnivsData.Add(new Anniversary { Day = 15, Month = 3, IsNameday = 1, Names = new[] { "Αγάπιος" } });
            _AnnivsData.Add(new Anniversary { Day = 16, Month = 3, IsNameday = 1, Names = new[] { "Χριστόδουλος", "Ιουλιανός", "Γιουλιανός", "Γιολανός" } });
            _AnnivsData.Add(new Anniversary { Day = 17, Month = 3, IsNameday = 1, Names = new[] { "Αλέξιος", "Αλέξης", "Αλέκος", "Αλεξία", "Αλέξα", "Γερτρούδη" } });
            _AnnivsData.Add(new Anniversary { Day = 18, Month = 3, IsNameday = 1, Names = new[] { "Εδουάρδος", "Έντουαρντ", "Έντυ" } });
            _AnnivsData.Add(new Anniversary { Day = 19, Month = 3, IsNameday = 1, Names = new[] { "Χρύσανθος", "Χρυσανθίς", "Χρυσάνθη", "Δαρεία", "Δάρα", "Δάρω", "Θεόδωρος", "Θοδωρής", "Θόδωρος", "Θεοδώρα", "Δώρα", "Θοδώρα", "Δωρούλα", "Ντόρα" } });
            _AnnivsData.Add(new Anniversary { Day = 20, Month = 3, IsNameday = 1, Names = new[] { "Κλώντια", "Κλόντια", "Κλαύδια", "Κλό", "Ροδιανός", "Ροδινός", "Ροδίνης", "Ρόδης", "Ροδιανή", "Ροδιάνα", "Ροδή", "Ροδία", "Λωξάνδρα", "Λωξάντρα", "Ρωξάνη", "Ρωξάνα", "Ορθοδόξης", "Δόξης", "Δοξάκης", "Ορθοδοξία", "Δόξα", "Ορθούλα", "Άξιος", "Άξια" } });
            _AnnivsData.Add(new Anniversary { Day = 21, Month = 3, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 22, Month = 3, IsNameday = 1, Names = new[] { "Δρόσος", "Δροσίδα", "Δροσούλα", "Δροσία", "Δρόσω", "Δροσοσταλία", "Δροσοσταλίδα", "Δροσίς" } });
            _AnnivsData.Add(new Anniversary { Day = 23, Month = 3, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 24, Month = 3, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 25, Month = 3, IsNameday = 1, Names = new[] { "Ευάγγελος", "Βαγγέλης", "Βάγγος", "Αγγελής", "Ευαγγελία", "Βαγγελιώ", "Βαγγελίτσα", "Λίτσα", "Εύα", "Κέλλυ", "Λιλή", "Άγγελος", "Αγγελής", "Αγγελική", "Άντζελα", "Άτζελα", "Άντζυ", "Αγγέλα", "Αγγέλλω", "Αγγελίνα", "Εθνεγερσία" } });
            _AnnivsData.Add(new Anniversary { Day = 26, Month = 3, IsNameday = 1, Names = new[] { "Πούλιος", "Σύλας", "Σύλος", "Σύλα", "Σύλια", "Σύλη" } });
            _AnnivsData.Add(new Anniversary { Day = 27, Month = 3, IsNameday = 1, Names = new[] { "Φίλητος", "Φιλήτα", "Φιλήτη", "Λυδία", "Λήδα", "Λύδα", "Μακεδόνιος", "Μακεδόνας", "Μακεδόνης", "Μακεδών", "Μακεδονία", "Μακεδονούλα", "Μακεδονίτσα", "Ματρώνα", "Ματρόνα", "Γρηγόρης", "Γρηγόριος", "Γόλης", "Γρηγορία" } });
            _AnnivsData.Add(new Anniversary { Day = 28, Month = 3, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 29, Month = 3, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 30, Month = 3, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 31, Month = 3, IsNameday = 1, Names = new[] { "Υπάτιος", "Ύπατος", "Υπάτης" } });
        }

        private void AddAnnivsApril() {
            _AnnivsData.Add(new Anniversary { Day = 1, Month = 4, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 2, Month = 4, IsNameday = 1, Names = new[] { "Τίτος", "Τίτης", "Τίτα", "Τίτη" } });
            _AnnivsData.Add(new Anniversary { Day = 3, Month = 4, IsNameday = 1, Names = new[] { "Ιλλύριος", "Λύρος", "Ιλλυρία", "Λύρα" } });
            _AnnivsData.Add(new Anniversary { Day = 4, Month = 4, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 5, Month = 4, IsNameday = 1, Names = new[] { "Αργυρώ", "Αργυρή", "Αργυρούλα", "Ρούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 6, Month = 4, IsNameday = 1, Names = new[] { "Ευτύχιος", "Ευτύχης", "Ευτυχία", "Ευτυχούλα", "Ευτυχίτσα", "Έφη" } });
            _AnnivsData.Add(new Anniversary { Day = 7, Month = 4, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 8, Month = 4, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 9, Month = 4, IsNameday = 1, Names = new[] { "Ευψύχιος", "Εύψυχος", "Ευψύχης", "Ευψυχία", "Ευψυχούλα", "Ευψυχίτσα", "Ψυχούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 10, Month = 4, IsNameday = 1, Names = new[] { "Μάξιμος", "Μάξιμη", "Μάξιμα", "Αναξιμένης", "Μένης", "Δημοσθένης", "Δήμος", "Διονύσιος", "Διονύσης", "Νιόνιος", "Νύσης", "Ντένης", "Διονυσία", "Διονυσούλα", "Νύσα", "Σίσσυ", "Ντενίζ", "Επαμεινώνδας", "Νώντας", "Ετεοκλής", "Ζήνων", "Ηρακλής", "Ηρακλεία", "Ηρακλίτσα", "Ηφαιστίων", "Θεμιστοκλής", "Θέμης", "Θεμιστοκλεία", "Θέμιδα", "Θέμις", "Θεόφραστος", "Θησέας", "Θησεύς", "Ισοκράτης", "Μιλτιάδης", "Μίλτος", "Ξενοφών", "Ξενοφώντας", "Φώντας", "Φόντας", "Φόνης", "Ξενοφωντία", "Ξενοφωντίνα", "Ξενοφούλα", "Ξενοφώντη", "Ξένια", "Όμηρος", "Παρμενίων", "Πελοπίδας", "Περικλής", "Πίνδαρος", "Πολύβιος", "Προμηθεύς", "Σοφοκλής", "Σωκράτης", "Σωκρατίνα", "Σωκρατία", "Τιμόθεος", "Τίμος", "Τιμάς", "Τίμης", "Θέος", "Τιμοθέη", "Τιμοθέα", "Τίμα", "Τίμη", "Θέα", "Θέη", "Φιλοποίμην", "Φίλης", "Φωκίων", "Φώκος" } });
            _AnnivsData.Add(new Anniversary { Day = 11, Month = 4, IsNameday = 1, Names = new[] { "Αντίπας", "Αντύπας" } });
            _AnnivsData.Add(new Anniversary { Day = 12, Month = 4, IsNameday = 1, Names = new[] { "Ακάκιος", "Κάχι", "Κάκι", "Ανθούσα" } });
            _AnnivsData.Add(new Anniversary { Day = 13, Month = 4, IsNameday = 1, Names = new[] { "Γερόντιος", "Μαρτίνος", "Μαρτίνη" } });
            _AnnivsData.Add(new Anniversary { Day = 14, Month = 4, IsNameday = 1, Names = new[] { "Αρίσταρχος", "Θωμαΐς", "Θωμαΐδα", "Θωμαή" } });
            _AnnivsData.Add(new Anniversary { Day = 15, Month = 4, IsNameday = 1, Names = new[] { "Λεωνίδας", "Λεωνίδης", "Λεώ", "Λεωνιδία", "Κρήσκης" } });
            _AnnivsData.Add(new Anniversary { Day = 16, Month = 4, IsNameday = 1, Names = new[] { "Γαληνός", "Γαλήνη", "Νίκη", "Καλλίς", "Κάλλι", "Καλίς", "Κάλι", "Καλλίδα", "Καλλία", "Καλίδα", "Καλία", "Χιονία", "Χιονούλα", "Χιονίτσα", "Χιονάτη" } });
            _AnnivsData.Add(new Anniversary { Day = 17, Month = 4, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 18, Month = 4, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 19, Month = 4, IsNameday = 1, Names = new[] { "Φιλίππα", "Φιλιππία", "Φιλιώ" } });
            _AnnivsData.Add(new Anniversary { Day = 20, Month = 4, IsNameday = 1, Names = new[] { "Ζακχαίος", "Ζάκχος", "Ζάχος" } });
            _AnnivsData.Add(new Anniversary { Day = 21, Month = 4, IsNameday = 1, Names = new[] { "Αλεξάνδρα", "Αλεξία", "Αλεξάντρα", "Αλέκα", "Ιανουάριος", "Ιανός", "Ιανή", "Φαίστος", "Φαιστή", "Φαιστίνα" } });
            _AnnivsData.Add(new Anniversary { Day = 22, Month = 4, IsNameday = 1, Names = new[] { "Νέαρχος", "Νιάρχος", "Ναθαναήλ", "Ναθάνης", "Ναθαναήλος", "Ναθαναήλης", "Ναθαναηλία", "Ναθανηλία" } });
            _AnnivsData.Add(new Anniversary { Day = 23, Month = 4, IsNameday = 1, Names = new[] { "Λάζαρος", "Λάζος" } });
            _AnnivsData.Add(new Anniversary { Day = 24, Month = 4, IsNameday = 1, Names = new[] { "Αχιλλέας", "Αχιλλεύς", "Αχίλιος", "Αχίλλιος", "Αχίλειος", "Αχίλλειος", "Δούκας", "Δούκισσα", "Δουκίτσα", "Βαλεντίνη", "Βαλεντίνα", "Ντίνα", "Ελισάβετ", "Ελίζα", "Λίζα", "Ζέτα", "Ζέττα", "Έλλη", "Βέτα", "Ελισσάβετ", "Θαυμαστός", "Θαυμαστή", "Βάιος", "Βάια", "Βάγια", "Βαία", "Δάφνης", "Δάφνη" } });
            _AnnivsData.Add(new Anniversary { Day = 25, Month = 4, IsNameday = 1, Names = new[] { "Νίκη", "Πάγκαλος" } });
            _AnnivsData.Add(new Anniversary { Day = 26, Month = 4, IsNameday = 1, Names = new[] { "Γλαφυρός", "Γλαφύρα", "Γλαφυρή", "Γλαφυρούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 27, Month = 4, IsNameday = 1, Names = new[] { "Μάγνος", "Μαγνής", "Μάγνα" } });
            _AnnivsData.Add(new Anniversary { Day = 28, Month = 4, IsNameday = 1, Names = new[] { "Ιάσων", "Ιάσονας", "Ιάσωνας", "Σωσίπατρος", "Σώπατρος", "Σωπάτρα", "Σωπατρία", "Πάτρα", "Πατρούλα", "Πατρίτσα", "Κέρκυρα", "Κερκύρα" } });
            _AnnivsData.Add(new Anniversary { Day = 29, Month = 4, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 30, Month = 4, IsNameday = 1, Names = new[] { "Αργυρή", "Αργυρούλα", "Ρούλα", "Αργυρώ", "Ασημάκης", "Ασημίνα", "Μαλαματή", "Μάλα", "Μαλαματένια", "Ματίνα", "Δονάτος", "Δονάτα", "Ντονάτα", "Ντονατέλα", "Ιάκωβος", "Ιακωβίνα", "Ζακελίνα" } });
        }

        private void AddAnnivsMay() {
            _AnnivsData.Add(new Anniversary { Day = 1, Month = 5, IsNameday = 1, Names = new[] { "Ιερεμίας", "Ισιδώρα", "Δώρα", "Τάμαρα", "Ταμάρα", "Φιλόσοφος", "Σοφός", "Φιλοσοφία", "Φιλοσοφή", "Αναστάσιος", "Νατάσα", "Νατάσσα", "Τασία", "Σία", "Τατία", "Τάσα", "Τέσα" } });
            _AnnivsData.Add(new Anniversary { Day = 2, Month = 5, IsNameday = 1, Names = new[] { "Έσπερος", "Εσπέρα", "Εσπερία", "Αυγερινός", "Αυγέρης", "Αυγίτης", "Αυγέρας", "Αυγέρου", "Αυγερού", "Ματρώνα", "Ματρόνα" } });
            _AnnivsData.Add(new Anniversary { Day = 3, Month = 5, IsNameday = 1, Names = new[] { "Μαύρος", "Μαύρα", "Μαυρούλα", "Μαυρίτσα", "Ροδόπη", "Ροδώπη", "Λαμπροτρίτη", "Ραφαήλ", "Ραφαήλος", "Ραφαέλος", "Ραφαέλα", "Ραφαέλλα", "Ραφαήλα", "Ραφαηλία", "Νικόλαος", "Νικόλας", "Νίκος", "Νικολός", "Νικολής", "Νικολάκης", "Νικολέττα", "Νικολούδα", "Νικολίτσα", "Νικολίνα", "Νικολέτα", "Νικόλ", "Ειρήνη", "Ρένα", "Ρήνα", "Ρηνιώ", "Ρηνούλα", "Ειρήνα", "Ειρήνγκω", "Ρένια", "Μάρκος", "Μαρκούλης", "Μαρκία", "Μαρκούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 4, Month = 5, IsNameday = 1, Names = new[] { "Πελαγής", "Πελάγιος", "Πελαγία", "Πελαγούλα", "Πελαγίνα", "Πελαγίτσα", "Πελαγιώ", "Ιλάριος", "Μελής", "Μέλος", "Μέλιος", "Μέλας", "Μέλια", "Μελίτσα", "Θεοχάρης", "Θεοχαρούλα", "Χαρούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 5, Month = 5, IsNameday = 1, Names = new[] { "Ειρήνη", "Ρένα", "Ρήνα", "Ρηνιώ", "Ρηνούλα", "Ειρήνα", "Ειρήνγκω", "Ρένια", "Ειρηναίος", "Ρένος", "Ειρηναία", "Ευφραίμ", "Ευφραίμιος", "Ευφραίμης", "Εφραίμ", "Ευφραιμία", "Ευφραιμίτσα" } });
            _AnnivsData.Add(new Anniversary { Day = 6, Month = 5, IsNameday = 1, Names = new[] { "Σεραφείμ", "Σεραφειμία", "Σεραφείμα", "Σεραφίνα", "Σεραφειμή", "Σεραφειμούλα", "Σεραφειμίτσα", "Ιώβ", "Ιωβία", "Ιώβη", "Ζώης", "Ζήσης", "Ζήσιμος", "Ζωή", "Ζησούλα", "Ζωΐτσα", "Ζωζώ", "Πηγή", "Κρήνη", "Κρηνιώ" } });
            _AnnivsData.Add(new Anniversary { Day = 7, Month = 5, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 8, Month = 5, IsNameday = 1, Names = new[] { "Αρσένιος", "Αρσένης", "Αρσενία", "Αρσίνα", "Αρσινόη", "Θεολόγος", "Θεολόγης", "Θολόγος", "Θολόγης", "Θολόης", "Θεολογία", "Θολογία", "Μήλιος", "Μήλης", "Μηλιώ", "Μηλιά", "Μηλίτσα", "Θωμάς", "Θωμαή" } });
            _AnnivsData.Add(new Anniversary { Day = 9, Month = 5, IsNameday = 1, Names = new[] { "Χριστόφορος", "Χριστοφόρης", "Φόρης", "Χριστόφης", "Χριστοφία", "Χριστοφίνα", "Ησαΐας" } });
            _AnnivsData.Add(new Anniversary { Day = 10, Month = 5, IsNameday = 1, Names = new[] { "Σίμων" } });
            _AnnivsData.Add(new Anniversary { Day = 11, Month = 5, IsNameday = 1, Names = new[] { "Αρμόδιος", "Αρμόδης", "Μεθόδιος", "Αργύρης", "Αργύριος", "Αργυρή", "Αργυρούλα", "Ρούλα", "Αργυρώ", "Ασημίνα", "Ολυμπιάς", "Ολυμπία", "Ολυμπιάδα", "Ολύμπω", "Ολύμπη", "Όλια", "Ολυμπούλα", "Διοσκουρίδης", "Διοσκορίδης", "Διόσκορος" } });
            _AnnivsData.Add(new Anniversary { Day = 12, Month = 5, IsNameday = 1, Names = new[] { "Επιφάνειος", "Επιφάνιος", "Επιφανία", "Θεόδωρος", "Θοδωρής", "Θόδωρος", "Θεοδώρα", "Δώρα", "Θοδώρα", "Δωρούλα", "Ντόρα" } });
            _AnnivsData.Add(new Anniversary { Day = 13, Month = 5, IsNameday = 1, Names = new[] { "Γλυκερία", "Σέργιος", "Σεργία", "Σεργιανή", "Σεργιούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 14, Month = 5, IsNameday = 1, Names = new[] { "Αριστοτέλης", "Τέλης", "Θεράπων", "Ισίδωρος", "Σιδέρης", "Ισιδώρα", "Δώρα" } });
            _AnnivsData.Add(new Anniversary { Day = 15, Month = 5, IsNameday = 1, Names = new[] { "Αχίλλιος", "Αχιλλέας", "Αχίλιος", "Αχίλειος", "Αχίλλειος", "Παχώμιος", "Παχούμιος", "Πάχος", "Καλή", "Κάλη", "Μυροφόρα" } });
            _AnnivsData.Add(new Anniversary { Day = 16, Month = 5, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 17, Month = 5, IsNameday = 1, Names = new[] { "Ανδρόνικος", "Ανδρονίκη", "Ιουνία", "Γιουνία", "Σόλων", "Σόλωνας", "Σολόχων" } });
            _AnnivsData.Add(new Anniversary { Day = 18, Month = 5, IsNameday = 1, Names = new[] { "Ιούλιος", "Ιουλία", "Ιουλιανή", "Ιουλίτσα", "Γιουλία", "Γιούλα", "Γιουλίτσα", "Τζούλια", "Γιούλη", "Γαλάτεια", "Γαλατία", "Φαεινός", "Φαεινή" } });
            _AnnivsData.Add(new Anniversary { Day = 19, Month = 5, IsNameday = 1, Names = new[] { "Πατρίκιος", "Πάτρικ", "Πατρίκος", "Πατρίκης", "Πατρίτσιος", "Πατρίτσης", "Πατρικία", "Πατρίκα", "Πατριτσία", "Πατρίτσα", "Θεόγνωστος", "Θεογνώστης", "Θεογνώσιος", "Θεογνωσία", "Θεόκτιστος", "Μένανδρος" } });
            _AnnivsData.Add(new Anniversary { Day = 20, Month = 5, IsNameday = 1, Names = new[] { "Θαλλελαίος", "Θαλής", "Λυδία", "Λήδα", "Λύδα" } });
            _AnnivsData.Add(new Anniversary { Day = 21, Month = 5, IsNameday = 1, Names = new[] { "Κωνσταντίνος", "Κώστας", "Κωστής", "Κωσταντίνος", "Κωστάκης", "Κωνσταντίνα", "Κωνσταντία", "Κωσταντίνα", "Κωστούλα", "Ντίνα", "Νάντια", "Ελένη", "Έλενα", "Ελεάννα", "Ελεάνα", "Λένα", "Λενίτσα", "Λένγκω", "Λενιώ", "Ελεονόρα", "Ελεονώρα", "Νόρα", "Μαριλένα", "Ελενάκι", "Νίτσα" } });
            _AnnivsData.Add(new Anniversary { Day = 22, Month = 5, IsNameday = 1, Names = new[] { "Αιμίλιος", "Μίλιος", "Αιμιλία", "Έμυ", "Εμιλία", "Έμιλυ", "Έμμα", "Μίλια", "Κόδρος", "Κόδρα", "Βηθεσδά" } });
            _AnnivsData.Add(new Anniversary { Day = 23, Month = 5, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 24, Month = 5, IsNameday = 1, Names = new[] { "Παλλαδία", "Παλαδία", "Παλλάδα", "Παλάδα", "Μαρκιανή", "Μαρκιάνα", "Φωτεινή", "Φώτω", "Φώφη", "Φωτούλα", "Φαίη", "Φωφώ", "Χριστιανός", "Χριστιανή" } });
            _AnnivsData.Add(new Anniversary { Day = 25, Month = 5, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 26, Month = 5, IsNameday = 1, Names = new[] { "Αλφαίος", "Καρπός", "Συνέσιος", "Συνέσης", "Συνεσία" } });
            _AnnivsData.Add(new Anniversary { Day = 27, Month = 5, IsNameday = 1, Names = new[] { "Αλύπιος", "Αλυπία", "Θεράπων" } });
            _AnnivsData.Add(new Anniversary { Day = 28, Month = 5, IsNameday = 1, Names = new[] { "Διοσκουρίδης", "Διοσκορίδης", "Διόσκορος" } });
            _AnnivsData.Add(new Anniversary { Day = 29, Month = 5, IsNameday = 1, Names = new[] { "Θεοδοσία", "Θεοδόσω", "Ολιβιανός", "Ολβιανός", "Ολιβία", "Ολίβια", "Υπομονή" } });
            _AnnivsData.Add(new Anniversary { Day = 30, Month = 5, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 31, Month = 5, IsNameday = 1, Names = new[] { "Ερμείας", "Ερμειάς", "Ερμεία", "Μάγος", "Μάγια" } });
        }

        private void AddAnnivsJune() {
            _AnnivsData.Add(new Anniversary { Day = 1, Month = 6, IsNameday = 1, Names = new[] { "Ευέλπιστος", "Ευελπίστη", "Ιέραξ", "Ιέρακας", "Γέρακας", "Γεράκης", "Γερακίνα", "Πύρρος", "Πύρος", "Πύρρα", "Πύρα", "Θεσπέσιος", "Θεσπέσης", "Θεσπέσια", "Ιουστίνος" } });
            _AnnivsData.Add(new Anniversary { Day = 2, Month = 6, IsNameday = 1, Names = new[] { "Μαρίνος", "Νικηφόρος", "Νικηφορία", "Νικηφόρα" } });
            _AnnivsData.Add(new Anniversary { Day = 3, Month = 6, IsNameday = 1, Names = new[] { "Ιερία", "Ιέρεια", "Υπατία", "Υπατή", "Υπατούλα", "Πατούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 4, Month = 6, IsNameday = 1, Names = new[] { "Μάρθα" } });
            _AnnivsData.Add(new Anniversary { Day = 5, Month = 6, IsNameday = 1, Names = new[] { "Δωρόθεος", "Δωροθέα", "Πλούταρχος", "Κύνθια", "Κυνθία", "Απόλλωνας", "Απόλλων", "Νίκανδρος", "Νικανδρία", "Νίκη", "Σεληνιάς", "Σελήνος", "Σελήνιος", "Σεληνιάδα", "Σεληνία", "Σελήνη", "Σελήνα" } });
            _AnnivsData.Add(new Anniversary { Day = 6, Month = 6, IsNameday = 1, Names = new[] { "Ιλαρίων", "Ιλαρίωνας", "Ιλαρία", "Ιλαριάδα", "Λαριάδα" } });
            _AnnivsData.Add(new Anniversary { Day = 7, Month = 6, IsNameday = 1, Names = new[] { "Ζηναΐς", "Ζηναΐδα", "Παναγής", "Πανάγος", "Σεβαστιανή", "Σεβαστίνα", "Σεβαστιάνα", "Σεβαστή", "Σέβη", "Σεβούλα", "Σεβαστούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 8, Month = 6, IsNameday = 1, Names = new[] { "Καλλιόπη", "Καλλιοπία", "Πόπη", "Κάλια", "Πίτσα", "Ναυκράτιος", "Ναυκράτης" } });
            _AnnivsData.Add(new Anniversary { Day = 9, Month = 6, IsNameday = 1, Names = new[] { "Ροδάνθη", "Ροζάνθη", "Νεφέλη" } });
            _AnnivsData.Add(new Anniversary { Day = 10, Month = 6, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 11, Month = 6, IsNameday = 1, Names = new[] { "Βαρθολομαίος", "Βαρνάβας", "Λουκάς", "Λουκία", "Λουκίτσα", "Ζαφείριος", "Ζαφείρης", "Ζαφειρία", "Ζαφείρω" } });
            _AnnivsData.Add(new Anniversary { Day = 12, Month = 6, IsNameday = 1, Names = new[] { "Ονούφριος", "Ονούφρης", "Ονουφρία" } });
            _AnnivsData.Add(new Anniversary { Day = 13, Month = 6, IsNameday = 1, Names = new[] { "Τριφύλλιος", "Τριφύλιος" } });
            _AnnivsData.Add(new Anniversary { Day = 14, Month = 6, IsNameday = 1, Names = new[] { "Ελισσαίος", "Ελισσώ", "Ελισώ", "Νήφων" } });
            _AnnivsData.Add(new Anniversary { Day = 15, Month = 6, IsNameday = 1, Names = new[] { "Αυγουστίνος", "Αυγουστίνα", "Αύγουστος", "Αυγούστα", "Ιερώνυμος", "Γερώνυμος", "Ιερονύμη", "Μόνικα", "Μόνα", "Ορτίσιος", "Ορτίσης", "Ορτίσια", "Ορτανσία" } });
            _AnnivsData.Add(new Anniversary { Day = 16, Month = 6, IsNameday = 1, Names = new[] { "Τύχων", "Τίχων" } });
            _AnnivsData.Add(new Anniversary { Day = 17, Month = 6, IsNameday = 1, Names = new[] { "Ισμαήλ", "Ισμαήλης", "Ισμαήλος", "Σμαήλης", "Σμαήλος", "Μαήλης", "Μαήλος", "Φήλιξ", "Φίληξ", "Φίλιξ", "Φίληκας", "Φίληξα", "Φιλήκη", "Φηλικίτη" } });
            _AnnivsData.Add(new Anniversary { Day = 18, Month = 6, IsNameday = 1, Names = new[] { "Έρασμος", "Λεόντιος", "Λεοντία", "Λεοντίνα", "Λεοντίτσα" } });
            _AnnivsData.Add(new Anniversary { Day = 19, Month = 6, IsNameday = 1, Names = new[] { "Παΐσιος", "Παΐσης", "Παϊσία", "Ζώσιμος", "Ζώσης", "Ζήσιμος", "Ζήσης", "Ζωσιμαίος", "Ζώσα", "Ζωσιμαία" } });
            _AnnivsData.Add(new Anniversary { Day = 20, Month = 6, IsNameday = 1, Names = new[] { "Μεθόδιος", "Τριάδα", "Τριάς", "Κορίνος", "Κόρη", "Κορίνα" } });
            _AnnivsData.Add(new Anniversary { Day = 21, Month = 6, IsNameday = 1, Names = new[] { "Αφροδίσιος", "Αφροδισία" } });
            _AnnivsData.Add(new Anniversary { Day = 22, Month = 6, IsNameday = 1, Names = new[] { "Ζηνάς", "Ζένας", "Ζένος", "Ζήνα", "Ζένα", "Ζένια", "Ευσέβιος", "Ευσεβής", "Ευσεβεία", "Σέβη", "Ευσεβούλα", "Σεβούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 23, Month = 6, IsNameday = 1, Names = new[] { "Αριστοκλής", "Αριστοκλέας", "Αριστόκλεος", "Αγριππίνα", "Λούλης", "Λούλου", "Λούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 24, Month = 6, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 25, Month = 6, IsNameday = 1, Names = new[] { "Λίβιος", "Λίβας", "Λιβύη", "Έρως", "Έρωτας", "Φεβρωνία", "Φευρωνία", "Φεύρω", "Φέβρω", "Φέβρα", "Φεύρα", "Φεβρούλα", "Φευρούλα", "Φευρωνίτσα", "Φεβρωνίτσα" } });
            _AnnivsData.Add(new Anniversary { Day = 26, Month = 6, IsNameday = 1, Names = new[] { "Μακάριος", "Μακάρης", "Μακαράς", "Μακαρία", "Μακάρω", "Μακαρίτσα", "Μακαρούλα", "Αγαμέμνων", "Αγαμέμνονας", "Αγησίλαος", "Αγόρω", "Αγορίτσα", "Αίολος", "Άλκηστις", "Αλκμήνη", "Ανδρομέδα", "Αντιόπη", "Αριστομένης", "Αρθούρος", "Βελισάριος", "Βενέτιος", "Βενετία", "Βενιζέλος", "Βιολέτα", "Βρασίδας", "Διαγόρας", "Δίκαιος", "Εβελίνα", "Έκτορας", "Ελβίρα", "Εριφύλη", "Ερρίκος", "Ερωτόκριτος", "Ευαγόρας", "Ευριπίδης", "Ευρυδίκη", "Φαίδων", "Φαίδωνας", "Φειδίας", "Φραγκίσκος", "Φρατζέσκα", "Γιασεμή", "Γιασμίνα", "Γιολάντα", "Γλαύκος", "Ηλέκτρα", "Ιοκάστη", "Ισαβέλα", "Καλομοίρα", "Καλυψώ", "Κανέλος", "Κανέλα", "Κασσάνδρα", "Κίμων", "Κίμωνας", "Κίρκη", "Κλάρα", "Κλεάνθης", "Κλεάνθη", "Κλέαρχος", "Κλεομένης", "Κομνηνός", "Κρίτων", "Κυβέλη", "Λαέρτης", "Λογοθέτης", "Λυκούργος", "Λύσανδρος", "Μανταλένα", "Μάνθος", "Μίνωας", "Μιράντα", "Μιρέλα", "Μυρτώ", "Ναυσικά", "Νεοκλής", "Νεοπτόλεμος", "Νιόβη", "Οφηλία", "Ορφέας", "Όθων", "Όθωνας", "Παγώνα", "Πανωραία", "Περίανδρος", "Πραξιτέλης", "Πυθαγόρας", "Ροδοθέα", "Τερέζα", "Τερψιθέα", "Θέλξη", "Θρασύβουλος", "Θράσος", "Τιμολέων", "Άγις", "Αίσωπος", "Αλβέρτος", "Αλκίνοος", "Αμφιτρίτη", "Αναξίμανδρος", "Ανδροκλής", "Αρετή", "Αρετούσα", "Εριέττα", "Έρρικα", "Γοργίας", "Ήρα", "Ηρώ", "Ιόλη", "Ιπποκράτης", "Κάρολος", "Μαλβίνα", "Μέλισσα", "Ναπολέων", "Ναπολέωντας", "Σεμίνα" } });
            _AnnivsData.Add(new Anniversary { Day = 27, Month = 6, IsNameday = 1, Names = new[] { "Πιερής", "Πιέρος", "Πιέριος", "Πιέρης", "Πιερίων", "Πιερία", "Πιέρα" } });
            _AnnivsData.Add(new Anniversary { Day = 28, Month = 6, IsNameday = 1, Names = new[] { "Ανάργυρος", "Ανάργυρη", "Αναργυρούλα", "Γερμανός" } });
            _AnnivsData.Add(new Anniversary { Day = 29, Month = 6, IsNameday = 1, Names = new[] { "Πέτρος", "Πετρής", "Πετράς", "Πετράκης", "Πετρουλάς", "Πετρίνος", "Πέτρα", "Πετρούλα", "Πετρία", "Πετρίνα", "Παύλος", "Πώλ", "Παυλίνα", "Πωλίνα" } });
            _AnnivsData.Add(new Anniversary { Day = 30, Month = 6, IsNameday = 1, Names = new[] { "Απόστολος", "Τόλης", "Αποστόλης", "Αποστολία", "Λία", "Αποστολίνα", "Πολίνα", "Μελίτων", "Μελίτωνας", "Μελίτος", "Μελίτης" } });
        }

        private void AddAnnivsJuly() {
            _AnnivsData.Add(new Anniversary { Day = 1, Month = 7, IsNameday = 1, Names = new[] { "Ανάργυρος", "Ανάργυρη", "Αναργυρούλα", "Δαμιανός", "Δαμιανή", "Κοσμάς", "Μαυρίκιος", "Μαυρίκης", "Μωρίς", "Μαυρικία", "Μαυρίκα" } });
            _AnnivsData.Add(new Anniversary { Day = 2, Month = 7, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 3, Month = 7, IsNameday = 1, Names = new[] { "Ανατόλιος", "Ζουμπουλία", "Υάκινθος", "Υακίνθη", "Υάνθη", "Ιάνθη" } });
            _AnnivsData.Add(new Anniversary { Day = 4, Month = 7, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 5, Month = 7, IsNameday = 1, Names = new[] { "Λαμπαδός", "Λαμπαδία", "Λαμπαδίνα", "Λαμπαδή" } });
            _AnnivsData.Add(new Anniversary { Day = 6, Month = 7, IsNameday = 1, Names = new[] { "Λυκίας", "Λύκιος", "Λυκία", "Σάτυρος", "Σάτος" } });
            _AnnivsData.Add(new Anniversary { Day = 7, Month = 7, IsNameday = 1, Names = new[] { "Κυριακή", "Κυριακίτσα", "Κική", "Κίκα", "Κικίτσα", "Κίτσα", "Κορίνα", "Ντομένικα", "Σάντυ", "Οδυσσέας" } });
            _AnnivsData.Add(new Anniversary { Day = 8, Month = 7, IsNameday = 1, Names = new[] { "Θεόφιλος", "Προκόπιος", "Προκόπης", "Προκοπία" } });
            _AnnivsData.Add(new Anniversary { Day = 9, Month = 7, IsNameday = 1, Names = new[] { "Παγκράτιος", "Παγκρατία" } });
            _AnnivsData.Add(new Anniversary { Day = 10, Month = 7, IsNameday = 1, Names = new[] { "Αμαλία", "Αμελί" } });
            _AnnivsData.Add(new Anniversary { Day = 11, Month = 7, IsNameday = 1, Names = new[] { "Εύφημος", "Ευφημία", "Εύφημη", "Εύφη", "Ευφημούλα", "Ευφούλα", "Φούλα", "Όλγα" } });
            _AnnivsData.Add(new Anniversary { Day = 12, Month = 7, IsNameday = 1, Names = new[] { "Βερονίκη", "Βερόνικα", "Βέρα", "Βερενίκη", "Παΐσιος", "Παΐσης", "Παϊσία", "Ιλάριος" } });
            _AnnivsData.Add(new Anniversary { Day = 13, Month = 7, IsNameday = 1, Names = new[] { "Σάρα", "Σάρρα", "Ηλιόφωτος" } });
            _AnnivsData.Add(new Anniversary { Day = 14, Month = 7, IsNameday = 1, Names = new[] { "Νικόδημος", "Ακύλας" } });
            _AnnivsData.Add(new Anniversary { Day = 15, Month = 7, IsNameday = 1, Names = new[] { "Βλαδίμηρος", "Βλαντίμηρος", "Κήρυκος", "Ιουλίτα", "Ιουλίττα", "Ιουλίττη", "Ιουλίτη", "Γιουλίττα", "Γιουλίτα", "Γιουλίττη", "Γιουλίτη" } });
            _AnnivsData.Add(new Anniversary { Day = 16, Month = 7, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 17, Month = 7, IsNameday = 1, Names = new[] { "Μαρίνος", "Μαρίνα", "Αλίκη", "Αλεξάνδρα", "Αλεξία", "Αλεξάντρα", "Αλέκα" } });
            _AnnivsData.Add(new Anniversary { Day = 18, Month = 7, IsNameday = 1, Names = new[] { "Αιμιλιανός", "Αιμίλιος", "Αιμιλιανή", "Έμμυ", "Αιμιλία" } });
            _AnnivsData.Add(new Anniversary { Day = 19, Month = 7, IsNameday = 1, Names = new[] { "Γαρυφαλλιά", "Γαριφαλιά", "Διός", "Δίας", "Μακρίνα" } });
            _AnnivsData.Add(new Anniversary { Day = 20, Month = 7, IsNameday = 1, Names = new[] { "Ηλίας", "Λιάκος", "Λιάκουρας", "Λίας", "Ηλιάνα", "Λιάνα", "Ηλιάννα" } });
            _AnnivsData.Add(new Anniversary { Day = 21, Month = 7, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 22, Month = 7, IsNameday = 1, Names = new[] { "Μαγδαληνή", "Μάγδα", "Μαγδούλα", "Μαγδαλένα", "Μαγδαλένια", "Μαγδαλή", "Μαγδάλω", "Μαριλένα", "Μαριαλένα", "ΜαρίαΕλένη", "Μαρκέλλα", "Μαρκέλα", "Μαρκελλή", "Μαρκελή", "Μενέλαος" } });
            _AnnivsData.Add(new Anniversary { Day = 23, Month = 7, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 24, Month = 7, IsNameday = 1, Names = new[] { "Χριστίνα", "Χριστιάνα", "Κριστιάνα", "Χρίστα", "Κρίστα", "Χρίστη", "Κρίστη", "Χριστινάκι", "Αθηναγόρας" } });
            _AnnivsData.Add(new Anniversary { Day = 25, Month = 7, IsNameday = 1, Names = new[] { "Άννα", "Αννίτα", "Ανίτα", "Ανέτα", "Αννέτα", "Ανναμπέλλα", "Ανναμαρία", "Αννούλα", "Ανέζα", "Ανεζούλα", "Άννη", "ΆνναΜαρία", "Άννα-Μαρία", "Ευπράξιος", "Εύπραξος", "Ευπραξία", "Ευπραξούλα", "Πραξούλα", "Ολυμπιάς", "Ολυμπία", "Ολυμπιάδα", "Ολύμπω", "Ολύμπη", "Όλια", "Ολυμπούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 26, Month = 7, IsNameday = 1, Names = new[] { "Ερμόλαος", "Ερμολία", "Λία", "Παρασκευάς", "Πάρης", "Πάρις", "Παρασκευή", "Εύη", "Εβίτα", "Βούλα", "Βιβή", "Βέτη", "Βέττη", "Παρασκευούλα", "Πάρις", "Βίβιαν", "Έρση", "Ωραιοζήλη", "Ωραιοζηλία", "Ζήλια", "Ζήλη", "Ζέλια" } });
            _AnnivsData.Add(new Anniversary { Day = 27, Month = 7, IsNameday = 1, Names = new[] { "Παντελεήμων", "Παντελεήμωνας", "Παντελής", "Παντελεήμονας", "Παντελάκης", "Παντέλος", "Παντελίτσα", "Παντελίνα", "Παντελεούσα", "Σαμψών" } });
            _AnnivsData.Add(new Anniversary { Day = 28, Month = 7, IsNameday = 1, Names = new[] { "Ακάκιος", "Κάχι", "Κάκι", "Αυξέντιος", "Αυξέντης", "Αυξεντία", "Αυξεντούλα", "Δρόσος", "Δροσίδα", "Δροσούλα", "Δροσία", "Δρόσω", "Δροσοσταλία", "Δροσοσταλίδα", "Δροσίς", "Τίμων", "Τίμος", "Τιμόνα", "Τιμόνη", "Τίμα", "Ειρήνη", "Ρένα", "Ρήνα", "Ρηνιώ", "Ρηνούλα", "Ειρήνα", "Ειρήνγκω", "Ρένια", "Χρυσοβαλάντης", "Βαλάντης", "Βαλάντος", "Χρυσοβαλάντος", "Χρυσοβαλάντω", "Χρυσοβαλάντου", "Χρυσοβαλαντία", "Βαλάντα", "Βαλάντω" } });
            _AnnivsData.Add(new Anniversary { Day = 29, Month = 7, IsNameday = 1, Names = new[] { "Θεόδοτος", "Θεοδότης", "Θεοδότη", "Καλλίνικος", "Καλλινίκης" } });
            _AnnivsData.Add(new Anniversary { Day = 30, Month = 7, IsNameday = 1, Names = new[] { "Ανδρόνικος", "Ανδρονίκη", "Σιλουανός", "Σιλουανή", "Σιλουάνα", "Σιλουάνια", "Κρήσκης" } });
            _AnnivsData.Add(new Anniversary { Day = 31, Month = 7, IsNameday = 1, Names = new[] { "Ευδόκιμος", "Ευδόκιμη", "Ιωσήφ", "Σήφης", "Ιωσηφίνα", "Ζοζεφίνα", "Φρειδερίκος", "Φρειδερίκη" } });
        }

        private void AddAnnivsAugust() {
            _AnnivsData.Add(new Anniversary { Day = 1, Month = 8, IsNameday = 1, Names = new[] { "Ελέσα", "Ελέσσα", "Εύκλεος", "Ευκλεή", "Ευκλέα", "Μάρκελος", "Σολομονή" } });
            _AnnivsData.Add(new Anniversary { Day = 2, Month = 8, IsNameday = 1, Names = new[] { "Ιουστινιανός" } });
            _AnnivsData.Add(new Anniversary { Day = 3, Month = 8, IsNameday = 1, Names = new[] { "Ολύμπιος", "Σαλώμη", "Σαλώμα" } });
            _AnnivsData.Add(new Anniversary { Day = 4, Month = 8, IsNameday = 1, Names = new[] { "Μαξιμιλιανός", "Ξακουστός", "Εξακουστοδιανός", "Εξακουστωδιανός", "Εξακουστός", "Ξακουστή" } });
            _AnnivsData.Add(new Anniversary { Day = 5, Month = 8, IsNameday = 1, Names = new[] { "Νόννα", "Νόνα" } });
            _AnnivsData.Add(new Anniversary { Day = 6, Month = 8, IsNameday = 1, Names = new[] { "Σωτήριος", "Σωτήρης", "Σώτος", "Σωτηρία", "Σωτήρω", "Ευμορφία", "Μορφούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 7, Month = 8, IsNameday = 1, Names = new[] { "Αστέριος", "Αστέρης", "Αστρινός", "Αστερινός", "Αστρινή", "Αστέρω", "Αστερία", "Αστρούλα", "Αστερινή", "Νικάνωρ", "Νικάνορας" } });
            _AnnivsData.Add(new Anniversary { Day = 8, Month = 8, IsNameday = 1, Names = new[] { "Μύρων", "Μύρα", "Μίρκα", "Τριαντάφυλλος", "Τριανταφύλλης", "Φύλλης", "Φύλλιος", "Τριανταφυλλένιος", "Τριανταφυλλιά", "Φύλλη", "Φύλλια", "Φυλλιώ", "Φυλλίτσα", "Τριανταφυλλένια", "Ρόζα" } });
            _AnnivsData.Add(new Anniversary { Day = 9, Month = 8, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 10, Month = 8, IsNameday = 1, Names = new[] { "Ήρων", "Ηρωνία", "Ηρώ", "Λαυρέντιος", "Λαυρέντης", "Λαυρεντία", "Λώρα", "Λωραίνη", "Λάουρα", "Λαυρεντίνα", "Ιππόλυτος", "Ιππολύτη", "Ιππολύτα" } });
            _AnnivsData.Add(new Anniversary { Day = 11, Month = 8, IsNameday = 1, Names = new[] { "Εύπλους", "Εύπλος", "Εύπλοος" } });
            _AnnivsData.Add(new Anniversary { Day = 12, Month = 8, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 13, Month = 8, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 14, Month = 8, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 15, Month = 8, IsNameday = 1, Names = new[] { "Παναγιώτης", "Πάνος", "Πανούσος", "Παναγής", "Πανάγος", "Γιώτης", "Τάκης", "Πανίκος", "Παναγιώτα", "Γιώτα", "Παναγιούλα", "Γιούλα", "Παναγούλα", "Νάγια", "Δέσποινα", "Δέσπω", "Ντέπη", "Πέπη", "Ζέπω", "Μαρία", "Μαργέτα", "Μαριέττα", "Μαργετίνα", "Μάρω", "Μαριώ", "Μαριωρή", "Μαρίκα", "Μαριγώ", "Μαριγούλα", "Μαρούλα", "Μαρίτσα", "Μανιώ", "Μαίρη", "Μαρινίκη", "Μιρέλλα", "Μυρέλλα", "Μάνια", "Μάρα", "Μαράκι", "Μάριος", "Γεσθημανή", "Ιεσθημανή", "Θεοτόκης", "Θεοτοκία", "Μαριάντζελα", "Μαρινέλα", "Ελώνα", "Ελλώνα", "Ελόνα", "Ηλιοστάλακτη", "Καθολική", "Κρυστάλλω", "Κρουστάλλω", "Κρουστάλω", "Κρυσταλία", "Κρυσταλλία", "Κρουσταλένια", "Πρέσβεια", "Πρεσβεία", "Συμέλα", "Σιμέλα", "Σουμελά" } });
            _AnnivsData.Add(new Anniversary { Day = 16, Month = 8, IsNameday = 1, Names = new[] { "Αλκιβιάδης", "Άλκης", "Άλτσος", "Γεράσιμος", "Μάκης", "Μικές", "Μίκης", "Γερασιμούλα", "Διομήδης", "Σεραφείμ", "Σεραφειμία", "Σεραφείμα", "Σεραφίνα", "Σεραφειμή", "Σεραφειμούλα", "Σεραφειμίτσα", "Σαράντης", "Σαράντος", "Σαραντούλα", "Σταμάτης", "Σταμάτιος", "Στάμος", "Σταμούλης", "Σταμέλος", "Σταμέλης", "Σταμελάς", "Σταματία", "Μάτα", "Ματούλα", "Ματίνα", "Σταματίνα", "Σταμάτα", "Σταμέλα", "Σταμούλα", "Σταματή", "Μάτω", "Σταματέλλα" } });
            _AnnivsData.Add(new Anniversary { Day = 17, Month = 8, IsNameday = 1, Names = new[] { "Λευκοθέα", "Λευκοθέη", "Μύρων", "Μύρα", "Μίρκα", "Στράτος", "Στράτων", "Στράτης", "Στράτα", "Στρατία", "Στρατίνα", "Στρατούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 18, Month = 8, IsNameday = 1, Names = new[] { "Αρσένιος", "Αρσένης", "Αρσενία", "Αρσίνα", "Αρσινόη", "Λαύρος", "Λαύρης", "Λάουρος", "Λαύρα", "Λάουρα", "Φλώρος", "Φλώρης", "Φλώρα", "Φλωρή", "Φλωρίτσα" } });
            _AnnivsData.Add(new Anniversary { Day = 19, Month = 8, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 20, Month = 8, IsNameday = 1, Names = new[] { "Ηλιόδωρος", "Ηλιοδώρα", "Ελεοδώρα", "Έλντα", "Θεοχάρης", "Θεοχαρούλα", "Χαρούλα", "Σαμουήλ", "Σαμουήλος", "Σαμουήλης", "Σαμουέλος", "Σαμουηλία", "Σαμουήλα", "Σαμουέλα" } });
            _AnnivsData.Add(new Anniversary { Day = 21, Month = 8, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 22, Month = 8, IsNameday = 1, Names = new[] { "Αγαθόνικος", "Θεοπρέπιος", "Θεοπρεπής", "Θεοπρεπία", "Θεοπρεπή" } });
            _AnnivsData.Add(new Anniversary { Day = 23, Month = 8, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 24, Month = 8, IsNameday = 1, Names = new[] { "Αιτωλία", "Ευτύχιος", "Ευτύχης", "Ευτυχία", "Ευτυχούλα", "Ευτυχίτσα", "Έφη" } });
            _AnnivsData.Add(new Anniversary { Day = 25, Month = 8, IsNameday = 1, Names = new[] { "Βαρθολομαίος", "Τίτος", "Τίτης", "Τίτα", "Τίτη" } });
            _AnnivsData.Add(new Anniversary { Day = 26, Month = 8, IsNameday = 1, Names = new[] { "Αδριανός", "Αδριανή", "Αδριάνα", "Αντριάνα", "Ανδριάννα", "Ανδριαννή", "Ανδριάνα", "Ναταλία", "Ναταλίνα", "Ναταλή", "Νάταλι" } });
            _AnnivsData.Add(new Anniversary { Day = 27, Month = 8, IsNameday = 1, Names = new[] { "Αρκάδιος", "Αρκάδης", "Αρκαδία", "Αρκάδα", "Λυμπέρης", "Λιμπέρης", "Λιμπέριος", "Λιβέριος", "Λιβέρης", "Όσιος", "Οσία", "Φανούριος", "Φανούρης", "Φάνης", "Νούρης", "Φανουρία", "Φανή" } });
            _AnnivsData.Add(new Anniversary { Day = 28, Month = 8, IsNameday = 1, Names = new[] { "Δάμων", "Δάμωνας" } });
            _AnnivsData.Add(new Anniversary { Day = 29, Month = 8, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 30, Month = 8, IsNameday = 1, Names = new[] { "Αλέξανδρος", "Αλέξαντρος", "Αλέκος", "Αλέξης", "Άλεξ", "Αλεξάνδρα", "Αλεξία", "Αλέξα", "Αλεξάντρα", "Αλεξανδρα", "Ευλάλιος", "Ευλαλία", "Φύλακας" } });
            _AnnivsData.Add(new Anniversary { Day = 31, Month = 8, IsNameday = 1, Names = new[] { "" } });
        }

        private void AddAnnivsSeptember() {
            _AnnivsData.Add(new Anniversary { Day = 1, Month = 9, IsNameday = 1, Names = new[] { "Αδαμάντιος", "Αδάμος", "Αδάμης", "Αδάμας", "Διαμαντής", "Αδαμαντία", "Αμάντα", "Άντα", "Διαμαντούλα", "Διαμάντω", "Ρουμπίνη", "Μαντώ", "Αθηνά", "Ακριβή", "Αντιγόνη", "Γόνη", "Ασπασία", "Αφροδίτη", "Φρέγια", "Διώνη", "Διόνη", "Δωδώνη", "Ελπινίκη", "Ερασμία", "Ερατώ", "Τέτη", "Ευτέρπη", "Θάλεια", "Θεανώ", "Θεονύμφη", "Καλλιρόη", "Καλλιρρόη", "Καλλίστη", "Κλειώ", "Κλεονίκη", "Κλεοπάτρα", "Κλειώ", "Πάτρα", "Πατρούλα", "Πατρίτσα", "Κοραλία", "Ράλλης", "Ραλλία", "Ραλία", "Ραλλού", "Ραλού", "Μαργαρίτα", "Μαριάνθη", "Μελπομένη", "Μέλπω", "Μόσχω", "Μοσχούλα", "Ουρανία", "Ράνια", "Πανδώρα", "Πηνελόπη", "Μπηλιώ", "Μπιλιώ", "Πίτσα", "Πολύμνια", "Πολυνίκη", "Πολύνα", "Πόλυ", "Σαπφώ", "Τερψιχόρη", "Χαϊδευτός", "Χάιδω", "Χαρίκλεια", "Χαρά", "Χαρούλα", "Ιησούς", "Μελέτιος", "Μελέτης", "Μελετία", "Μελετούλα", "Μελετίνα", "Συμεών", "Συμεώνης", "Σύμος", "Συμεωνή", "Συμεωνία", "Συμεώνα", "Σύμη", "Ισμήνη", "Πολυτίμη" } });
            _AnnivsData.Add(new Anniversary { Day = 2, Month = 9, IsNameday = 1, Names = new[] { "Μάμας", "Μάμαντας", "Μάμα" } });
            _AnnivsData.Add(new Anniversary { Day = 3, Month = 9, IsNameday = 1, Names = new[] { "Άνθιμος", "Άνθιμη", "Αριστίων", "Αριστίωνας", "Αριστέας", "Αριστέα", "Αρίστη", "Αρχοντής", "Αρχοντίων", "Αρχοντίωνας", "Αρχοντία", "Αρχοντή", "Αρχοντούλα", "Αρχόντισσα", "Αρχόντω", "Πολύδωρος", "Πολύδωρας", "Πόλης", "Πολυδώρης", "Πόλη", "Πολυδώρα", "Πόλα", "Πολυδώρη", "Φοίβος", "Φοίβη" } });
            _AnnivsData.Add(new Anniversary { Day = 4, Month = 9, IsNameday = 1, Names = new[] { "Ερμιόνη", "Ερμίνα", "Μωυσής", "Μωσής", "Μωυσία", "Μωσία", "Ροζαλία", "Ρόζυ", "Ρόζα", "Ωκεανός", "Ωκεάνιος", "Ωκεάνης", "Ωκεανία", "Ωκεανή", "Ωκεανίς" } });
            _AnnivsData.Add(new Anniversary { Day = 5, Month = 9, IsNameday = 1, Names = new[] { "Ζαχαρίας", "Ζάχαρης", "Ζάχαρος", "Ζάκι", "Ζάκης", "Ζαχαρένια", "Ζαχάρω", "Ζαχαρούλα", "Ζαχαρίτσα" } });
            _AnnivsData.Add(new Anniversary { Day = 6, Month = 9, IsNameday = 1, Names = new[] { "Βίβος", "Βιβή", "Ευδόξιος", "Ευδόξης", "Δόξης" } });
            _AnnivsData.Add(new Anniversary { Day = 7, Month = 9, IsNameday = 1, Names = new[] { "Κασσιανός", "Κασιανός", "Κάσσιος", "Κάσιος", "Κάσσος", "Κάσος", "Κάσσης", "Κάσης", "Κασσιανή", "Κάσσυ", "Κασιανή", "Κασσία", "Κασία", "Σώζων", "Σώζος", "Σώζης", "Σώζη", "Σωζούσα", "Σώζα" } });
            _AnnivsData.Add(new Anniversary { Day = 8, Month = 9, IsNameday = 1, Names = new[] { "Δέσποινα", "Δέσπω", "Ντέπη", "Πέπη", "Ζέπω", "Γενέθλιος", "Σκιαδενή", "Τσαμπίκος", "Τσαμπίκα", "Μίκα" } });
            _AnnivsData.Add(new Anniversary { Day = 9, Month = 9, IsNameday = 1, Names = new[] { "Ιωακείμ", "Κιαράν", "Κιάρα" } });
            _AnnivsData.Add(new Anniversary { Day = 10, Month = 9, IsNameday = 1, Names = new[] { "Κλήμης", "Κλημεντίνη", "Κλημεντίνα", "Κλεμεντίνη", "Κλεμεντίνα", "Μηνοδώρα", "Μητροδώρα", "Πουλχερία", "Πουλχερίνα", "Πουλχερίτσα", "Πουλχέρω", "Πουλχέρη" } });
            _AnnivsData.Add(new Anniversary { Day = 11, Month = 9, IsNameday = 1, Names = new[] { "Ευάνθης", "Ευανθία", "Εύα", "Ευφρόσυνος", "Φρόσυνος" } });
            _AnnivsData.Add(new Anniversary { Day = 12, Month = 9, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 13, Month = 9, IsNameday = 1, Names = new[] { "Αριστείδης", "Αρίστος", "Άρης", "Αριστέα", "Αριστούλα", "Αριστίνα", "Κορνήλιος", "Κορνήλης", "Κορνήλος", "Κορνηλία", "Κορνήλα" } });
            _AnnivsData.Add(new Anniversary { Day = 14, Month = 9, IsNameday = 1, Names = new[] { "Θεοκλής", "Θεοκλέας", "Θεόκλεια", "Σταύρος", "Σταυριανός", "Σταύρακας", "Σταυράκιος", "Σταυρής", "Σταυράκης", "Σταυρούλα", "Σταυριανή", "Σταυρίνα", "Σταυρία" } });
            _AnnivsData.Add(new Anniversary { Day = 15, Month = 9, IsNameday = 1, Names = new[] { "Βησσαρίων", "Βησσαρίωνας", "Βησσαρία", "Νικήτας", "Νικήτη", "Νικήτα" } });
            _AnnivsData.Add(new Anniversary { Day = 16, Month = 9, IsNameday = 1, Names = new[] { "Εύφημος", "Ευφημία", "Εύφημη", "Εύφη", "Ευφημούλα", "Ευφούλα", "Φούλα", "Λουντμίλλα", "Λουντμίλα", "Μελιτίνος", "Μελίνα", "Μελιτίνη", "Μελιτίνα", "Μελίτη", "Μελίτα" } });
            _AnnivsData.Add(new Anniversary { Day = 17, Month = 9, IsNameday = 1, Names = new[] { "Σοφιανός", "Σοφούλης", "Σοφία", "Σόνια", "Σοφιανή", "Σόφη", "Σοφίνα", "Φιφή", "Σοφούλα", "Σοφίτσα", "Σοφάκι", "Πίστη", "Πίστις", "Ελπίδα", "Ελπίς", "Αγάπιος", "Αγάπη", "Σοφιάννα", "Αγαθοκλής", "Αγαθοκλέας", "Αγαθόκλεος", "Αγαθόκλεια", "Ολιβιανός", "Ολβιανός", "Ολιβία", "Ολίβια", "Παντολέων", "Παντολέοντας", "Παντολεοντής", "Παντολεοντία", "Παντολεοντή", "Πηλεύς", "Πηλέας" } });
            _AnnivsData.Add(new Anniversary { Day = 18, Month = 9, IsNameday = 1, Names = new[] { "Αριάδνη", "Αριάνα", "Ευμένιος", "Ευμένης", "Ευμενία", "Κάστωρ", "Κάστορας", "Κάστορης", "Ρωμύλος", "Ρωμύλιος", "Ρωμύλης", "Ρωμύλα", "Ρωμυλία", "Ρωμύλη", "Ρωμυλαία" } });
            _AnnivsData.Add(new Anniversary { Day = 19, Month = 9, IsNameday = 1, Names = new[] { "Σαββάτιος", "Σάββατος", "Σαββάτης", "Σαββατία", "Σαββατίνα", "Σαββάτα", "Σαββάτη", "Σαββάτω" } });
            _AnnivsData.Add(new Anniversary { Day = 20, Month = 9, IsNameday = 1, Names = new[] { "Ευστάθιος", "Στάθης", "Σταθάς", "Σταθάκος", "Ευσταθία", "Σταθούλα", "Σταθία", "Ευσταθούλα", "Θεοπίστη" } });
            _AnnivsData.Add(new Anniversary { Day = 21, Month = 9, IsNameday = 1, Names = new[] { "Ίωνας", "Ιωνάς", "Ίων", "Ιωνία" } });
            _AnnivsData.Add(new Anniversary { Day = 22, Month = 9, IsNameday = 1, Names = new[] { "Ζωγραφιά", "Λοΐζος", "Λουίζα", "Φωκάς", "Φώκιος", "Φώκης", "Φωκία", "Φωκίνα" } });
            _AnnivsData.Add(new Anniversary { Day = 23, Month = 9, IsNameday = 1, Names = new[] { "Ξάνθιππος", "Ξανθίππη", "Ξανθή", "Ξανθούλα", "Πολυξένη", "Ξένη", "Ξένια", "Ραΐς", "Ραΐδα", "Ίρις", "Ίριδα" } });
            _AnnivsData.Add(new Anniversary { Day = 24, Month = 9, IsNameday = 1, Names = new[] { "Θέκλα", "Κόπρος", "Κόπρις", "Μυρσίνη", "Μυρτώ", "Μυρτιά", "Μυρτιδιώτισσα", "Μύρτα", "Μυρσώ", "Μέρσα", "Αμερισούδα", "Αμερσούδα", "Αμέρσσα", "Αμέρσα", "Πέρσης", "Περσεφόνη", "Πέρσα", "Πέρση" } });
            _AnnivsData.Add(new Anniversary { Day = 25, Month = 9, IsNameday = 1, Names = new[] { "Ευφροσύνη", "Φροσύνη", "Φρόσω", "Ευφροσύνα", "Φροσούλα", "Φροσού", "Έφη" } });
            _AnnivsData.Add(new Anniversary { Day = 26, Month = 9, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 27, Month = 9, IsNameday = 1, Names = new[] { "Ακυλίνα", "Ακυλίνη", "Ακυλήνη", "Επίχαρις", "Επιχάρια", "Ζήνων", "Καλλίστρατος", "Καλλιστράτης", "Καλλιστράτη" } });
            _AnnivsData.Add(new Anniversary { Day = 28, Month = 9, IsNameday = 1, Names = new[] { "Χαρίτων", "Χαρίτωνας", "Χαρίτος" } });
            _AnnivsData.Add(new Anniversary { Day = 29, Month = 9, IsNameday = 1, Names = new[] { "Κυριάκος" } });
            _AnnivsData.Add(new Anniversary { Day = 30, Month = 9, IsNameday = 1, Names = new[] { "Στρατόνικος", "Στράτος", "Στρατής", "Στρατονίκης", "Στρατονίκιος" } });
        }

        private void AddAnnivsOctober() {
            _AnnivsData.Add(new Anniversary { Day = 1, Month = 10, IsNameday = 1, Names = new[] { "Ανανίας", "Νίνος", "Θηρεσία", "Ρωμανός", "Ρωμάνα", "Ρωμανή" } });
            _AnnivsData.Add(new Anniversary { Day = 2, Month = 10, IsNameday = 1, Names = new[] { "Κυπριανός", "Κυπριανή", "Ιουστίνη", "Ιούστα", "Γιούστα", "Ιουστίνα", "Γιουστίνα", "Γιουστίνη" } });
            _AnnivsData.Add(new Anniversary { Day = 3, Month = 10, IsNameday = 1, Names = new[] { "Διονύσιος", "Διονύσης", "Νιόνιος", "Νύσης", "Ντένης", "Διονυσία", "Διονυσούλα", "Νύσα", "Σίσσυ", "Ντενίζ" } });
            _AnnivsData.Add(new Anniversary { Day = 4, Month = 10, IsNameday = 1, Names = new[] { "Βερίνα", "Βερίνη", "Βέρα", "Βερούλα", "Βερούλη", "Ιερόθεος", "Καλλισθένης", "Καλλισθένη" } });
            _AnnivsData.Add(new Anniversary { Day = 5, Month = 10, IsNameday = 1, Names = new[] { "Χαριτίνη", "Χαριτίνα", "Χαρίτη", "Τίνα", "Χαρά" } });
            _AnnivsData.Add(new Anniversary { Day = 6, Month = 10, IsNameday = 1, Names = new[] { "Ερωτηίς", "Ερωτηίδα" } });
            _AnnivsData.Add(new Anniversary { Day = 7, Month = 10, IsNameday = 1, Names = new[] { "Σέργιος", "Σεργία", "Σεργιανή", "Σεργιούλα", "Βάκχος", "Βάκχη", "Βακχία", "Πολυχρόνης", "Πολυχρόνιος", "Χρόνης", "Πολυχρονία", "Πολυχρονούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 8, Month = 10, IsNameday = 1, Names = new[] { "Πελαγής", "Πελάγιος", "Πελαγία", "Πελαγούλα", "Πελαγίνα", "Πελαγίτσα", "Πελαγιώ" } });
            _AnnivsData.Add(new Anniversary { Day = 9, Month = 10, IsNameday = 1, Names = new[] { "Λωτ", "Λοτ" } });
            _AnnivsData.Add(new Anniversary { Day = 10, Month = 10, IsNameday = 1, Names = new[] { "Ευλάμπιος", "Λάμπης", "Ευλάμπης", "Ευλαμπία", "Ευλαμπή", "Λαμπή", "Λαμπία", "Λάμπω" } });
            _AnnivsData.Add(new Anniversary { Day = 11, Month = 10, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 12, Month = 10, IsNameday = 1, Names = new[] { "Ανδρόμαχος", "Μάχος", "Ανδρομάχη", "Μάχη", "Μαχούλα", "Βαλάντης", "Βαλάντιος" } });
            _AnnivsData.Add(new Anniversary { Day = 13, Month = 10, IsNameday = 1, Names = new[] { "Καρπός", "Αγαθονίκη", "Χρυσή", "Χρύσα", "Χρυσαλία", "Χρυσαυγή", "Χρυσούλα", "Σήλια", "Χρυστάλλα", "Χρυσταλλία", "Φλωρέντιος", "Φλωρέντης", "Φλωρέντος", "Φλορέντσος", "Φλωρεντία", "Φλωρέντα", "Φλωρένα", "Φλώρινα", "Φλωρένσα", "Φλωρέντζα", "Ντία" } });
            _AnnivsData.Add(new Anniversary { Day = 14, Month = 10, IsNameday = 1, Names = new[] { "Γερβάσιος", "Γερβασία", "Ναζάριος", "Ιγνάτιος", "Ιγνάτης", "Ιγνατία" } });
            _AnnivsData.Add(new Anniversary { Day = 15, Month = 10, IsNameday = 1, Names = new[] { "Λουκιανός", "Λουκιανή" } });
            _AnnivsData.Add(new Anniversary { Day = 16, Month = 10, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 17, Month = 10, IsNameday = 1, Names = new[] { "Αντίγονος", "Ευπρέπιος", "Ευπρέπειος", "Ευπρεπής", "Ευπρεπία" } });
            _AnnivsData.Add(new Anniversary { Day = 18, Month = 10, IsNameday = 1, Names = new[] { "Λουκάς", "Λουκία", "Λουκίτσα", "Μαρίνος" } });
            _AnnivsData.Add(new Anniversary { Day = 19, Month = 10, IsNameday = 1, Names = new[] { "Κλεοπάτρα", "Κλειώ", "Πάτρα", "Πατρούλα", "Πατρίτσα", "Φήλιξ", "Φίληξ", "Φίλιξ", "Φίληκας", "Φίληξα", "Φιλήκη", "Φηλικίτη" } });
            _AnnivsData.Add(new Anniversary { Day = 20, Month = 10, IsNameday = 1, Names = new[] { "Αρτέμιος", "Αρτέμης", "Άρτεμις", "Αρτέμη", "Αρτέμιδα", "Αρτεμία", "Αρτεμισία", "Γεράσιμος", "Μάκης", "Μικές", "Μίκης", "Γερασιμούλα", "Διάνα", "Ντιάνα", "Ενόη", "Ματρώνα", "Ματρόνα", "Κερασιά", "Κερασία" } });
            _AnnivsData.Add(new Anniversary { Day = 21, Month = 10, IsNameday = 1, Names = new[] { "Ευκράτης", "Εύκρατος", "Ευκρατάς", "Ευκρατία", "Ευκρατούλα", "Ούρσουλα", "Ορσαλία", "Σωκράτης", "Σωκρατίνα", "Σωκρατία", "Χριστόδουλος" } });
            _AnnivsData.Add(new Anniversary { Day = 22, Month = 10, IsNameday = 1, Names = new[] { "Αβέρκιος", "Αβερκία" } });
            _AnnivsData.Add(new Anniversary { Day = 23, Month = 10, IsNameday = 1, Names = new[] { "Ιάκωβος", "Ιακωβίνα", "Ζακελίνα" } });
            _AnnivsData.Add(new Anniversary { Day = 24, Month = 10, IsNameday = 1, Names = new[] { "Σεβαστιανή", "Σεβαστίνα", "Σεβαστιάνα", "Σεβαστή", "Σέβη", "Σεβούλα", "Σεβαστούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 25, Month = 10, IsNameday = 1, Names = new[] { "Χρυσάνθη", "Χρυσάφιος", "Χρυσάφης", "Χρυσαφένια" } });
            _AnnivsData.Add(new Anniversary { Day = 26, Month = 10, IsNameday = 1, Names = new[] { "Γλύκων", "Γλυκός", "Δημήτριος", "Δημήτρης", "Δημητρός", "Μίμης", "Τζίμης", "Μήτσος", "Δημητράκης", "Τζιμάκος", "Μητσάκος", "Μήτρος", "Δήμητρα", "Μιμή", "Μιμίκα", "Δημητρούλα", "Δημητρία", "Ντίμι", "Δήμος", "Λέπτινος", "Λεπτίνα", "Λούππος", "Λούππης", "Κυπαρισσία", "Παρεσίνα", "Παρεσσία", "Παρέσια", "Παρέσσα" } });
            _AnnivsData.Add(new Anniversary { Day = 27, Month = 10, IsNameday = 1, Names = new[] { "Νέστορας", "Νέστωρ", "Νεστορία" } });
            _AnnivsData.Add(new Anniversary { Day = 28, Month = 10, IsNameday = 1, Names = new[] { "Βήλη", "Βίλια", "Ευνίκη", "Ευνίκα" } });
            _AnnivsData.Add(new Anniversary { Day = 29, Month = 10, IsNameday = 1, Names = new[] { "Αβραάμ", "Αβραμία", "Μελιτίνος", "Μελιτίνη", "Μελιτίνα", "Μελίτη", "Μελίτα", "Μελίνα" } });
            _AnnivsData.Add(new Anniversary { Day = 30, Month = 10, IsNameday = 1, Names = new[] { "Απολλωνία", "Αστέριος", "Αστέρης", "Αστρινός", "Αστερινός", "Αστρινή", "Αστέρω", "Αστερία", "Αστρούλα", "Αστερινή", "Ζηνόβιος", "Ζηνοβής", "Ζήνος", "Τζήνος", "Ζηνοβία", "Ζήνα", "Τζήνα", "Τζίνα", "Ζελίνα", "Κλεόπας", "Πάκης", "Κλεόπιος", "Κλεοπάκης", "Κλεοπία", "Κρόνος", "Κρονίων", "Κρονίωνας", "Κρονίος", "Κρονία", "Μαρκιανός", "Μαρκίνος", "Τέρτιος", "Τέρτος", "Τέρτης", "Τερτίνος", "Τέρτια", "Τέρτα", "Τέρτη", "Τερτίνα" } });
            _AnnivsData.Add(new Anniversary { Day = 31, Month = 10, IsNameday = 1, Names = new[] { "Απελλής", "Απέλλης", "Αμπλίος", "Αμπλία", "Νάρκισος", "Νάρκισσος", "Αριστόβουλος", "Αριστοβούλη", "Στρατονίκη", "Στρατή", "Νίκη" } });
        }

        private void AddAnnivsNovember() {
            _AnnivsData.Add(new Anniversary { Day = 1, Month = 11, IsNameday = 1, Names = new[] { "Κοσμάς", "Δαμιανός", "Δαμιανή", "Ανάργυρος", "Ανάργυρη", "Αναργυρούλα", "Δαβίδ", "Δαυίδ", "Διόνυσος" } });
            _AnnivsData.Add(new Anniversary { Day = 2, Month = 11, IsNameday = 1, Names = new[] { "Ακίνδυνος", "Ακίνδυνη", "Ανεμπόδιστος", "Ανεμπόδιστη", "Αφθόνιος", "Αφθονία", "Ελπιδηφόρος", "Ελπιδοφόρος", "Ελπιδηφόρα", "Ελπιδοφόρα", "Πήγασος", "Πηγάσιος", "Πηγασία" } });
            _AnnivsData.Add(new Anniversary { Day = 3, Month = 11, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 4, Month = 11, IsNameday = 1, Names = new[] { "Ερμαίος", "Ερμαίας", "Ιωαννίκιος", "Ιωανίκιος" } });
            _AnnivsData.Add(new Anniversary { Day = 5, Month = 11, IsNameday = 1, Names = new[] { "Γαλακτίων", "Γαλακτίωνας", "Γαλάτιος", "Γαλάτης", "Γαλακτία", "Γαλατεία", "Γαλάτια", "Επιστήμη", "Λίνος", "Λίνα", "Σιλβανός", "Σιλβάνα", "Σιλβανή", "Σίλβια", "Σίλβα" } });
            _AnnivsData.Add(new Anniversary { Day = 6, Month = 11, IsNameday = 1, Names = new[] { "Λεονάρδος" } });
            _AnnivsData.Add(new Anniversary { Day = 7, Month = 11, IsNameday = 1, Names = new[] { "Αθηνόδωρος", "Αθηνόδωρας", "Αθηνοδωρής", "Δώρης", "Αθηνοδώρα", "Ερνέστος", "Ερνέστα", "Ερνεστίνη", "Ερνεστίνα", "Θεαγένης", "Θεαγένιος", "Θεαγενεία", "Θεαγενία", "Θεμέλιος", "Θεμέλη", "Θεμελίνα" } });
            _AnnivsData.Add(new Anniversary { Day = 8, Month = 11, IsNameday = 1, Names = new[] { "Άγγελος", "Αγγελής", "Αγγελική", "Άντζελα", "Άτζελα", "Άντζυ", "Αγγέλα", "Αγγέλλω", "Αγγελίνα", "Γαβριήλ", "Γαβρίλος", "Γαβρίλης", "Γαβριέλα", "Γαβρίλα", "Γαβριηλίτσα", "Γαβριλίτσα", "Αραβέλα", "Μιχαήλ", "Μισέλ", "Μιχάλης", "Μιχαλός", "Μιχελής", "Μιχαέλα", "Μιχαέλλα", "Μιχαήλα", "Μιχαηλίτσα", "Μιχαλίτσα", "Σεραφείμ", "Σεραφειμία", "Σεραφείμα", "Σεραφίνα", "Σεραφειμή", "Σεραφειμούλα", "Σεραφειμίτσα", "Ευστρατία", "Μεταξία", "Μεταξούλα", "Ταξούλα", "Ραφαήλ", "Ραφαήλος", "Ραφαέλος", "Ραφαέλα", "Ραφαέλλα", "Ραφαήλα", "Ραφαηλία", "Σταμάτης", "Σταμάτιος", "Στάμος", "Σταμούλης", "Σταμέλος", "Σταμέλης", "Σταμελάς", "Σταματία", "Μάτα", "Ματούλα", "Ματίνα", "Σταματίνα", "Σταμάτα", "Σταμέλα", "Σταμούλα", "Σταματή", "Μάτω", "Σταματέλλα", "Στρατηγός", "Στρατής", "Στρατηγούλα", "Ταξιάρχης", "Ταξιαρχούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 9, Month = 11, IsNameday = 1, Names = new[] { "Νεκτάριος", "Νεκτάρης", "Νεκταρία", "Νεκταρίνα", "Νεκταρούλα", "Ελλάδιος", "Ελλάδης", "Θεοκτίστη", "Μαύρος", "Μαύρα", "Μαυρούλα", "Μαυρίτσα" } });
            _AnnivsData.Add(new Anniversary { Day = 10, Month = 11, IsNameday = 1, Names = new[] { "Αρσένιος", "Αρσένης", "Αρσενία", "Αρσίνα", "Αρσινόη", "Εραστός", "Εράστη", "Εραστή", "Ηρωδίων", "Ροδίων", "Ηρωδιάς", "Ηρωδιάδα", "Ροδίων", "Ρόδιος", "Ροδής", "Ρόδος", "Ροδιά", "Ροδούλα", "Ροδίτα", "Ρόζα", "Ροζαλία", "Ροζίτα", "Ροζίνα", "Ροζάνα", "Σωσίπατρος", "Σώπατρος", "Σωπάτρα", "Σωπατρία", "Πάτρα", "Πατρούλα", "Πατρίτσα", "Μίλος", "Μίλης", "Μίλων", "Ορέστης", "Ορεστιάς", "Ορεστία", "Ορεστιάδα", "Ωρίων", "Ωρίωνας", "Ωριώνης", "Ωριώνη" } });
            _AnnivsData.Add(new Anniversary { Day = 11, Month = 11, IsNameday = 1, Names = new[] { "Μηνάς", "Βικέντιος", "Βικέντης", "Βικεντία", "Βίκτωρ", "Βίκτωρας", "Βίκτορας", "Βικτωρία", "Βικτορία", "Δράκων", "Δράκοντας", "Δράκος", "Δρακούλης", "Δρακούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 12, Month = 11, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 13, Month = 11, IsNameday = 1, Names = new[] { "Δαμασκηνός", "Δαμασκηνή", "Χρυσόστομος", "Χρυσοστόμης", "Χρυσοστόμη", "Χρυσοστομία", "Χρυσοστομίτσα" } });
            _AnnivsData.Add(new Anniversary { Day = 14, Month = 11, IsNameday = 1, Names = new[] { "Γρηγόρης", "Γρηγόριος", "Γόλης", "Γρηγορία", "Φίλιππος", "Φίλιππας", "Φιλιππής", "Φιλιππάκης" } });
            _AnnivsData.Add(new Anniversary { Day = 15, Month = 11, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 16, Month = 11, IsNameday = 1, Names = new[] { "Ιφιγένεια", "Ματθαίος", "Μαθιός", "Μαθαίος", "Ματθούλα", "Ματθίλδη", "Θίλδα", "Τίτα", "Μαθούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 17, Month = 11, IsNameday = 1, Names = new[] { "Γεννάδιος", "Γενάδιος" } });
            _AnnivsData.Add(new Anniversary { Day = 18, Month = 11, IsNameday = 1, Names = new[] { "Πλάτωνας", "Πλάτων", "Πλατωνία", "Πλατώνα" } });
            _AnnivsData.Add(new Anniversary { Day = 19, Month = 11, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 20, Month = 11, IsNameday = 1, Names = new[] { "Δεναχίς", "Δεναχίδα" } });
            _AnnivsData.Add(new Anniversary { Day = 21, Month = 11, IsNameday = 1, Names = new[] { "Μαρία", "Μαργέτα", "Μαριέττα", "Μαργετίνα", "Μάρω", "Μαριώ", "Μαριωρή", "Μαρίκα", "Μαριγώ", "Μαριγούλα", "Μαρούλα", "Μαρίτσα", "Μανιώ", "Μαίρη", "Μαρινίκη", "Μιρέλλα", "Μυρέλλα", "Μάνια", "Μάρα", "Μαράκι", "Μάριος", "Βιργινία", "Δέσποινα", "Δέσπω", "Ντέπη", "Πέπη", "Ζέπω", "Λεμονιά", "Σουλτάνης", "Σουλτάνα", "Σούζυ", "Σούζη", "Τάνια" } });
            _AnnivsData.Add(new Anniversary { Day = 22, Month = 11, IsNameday = 1, Names = new[] { "Βαλέριος", "Βαλεριανός", "Βάλιος", "Βαλέρια", "Βαλεριάνα", "Βάλια", "Σεσίλια", "Κεκίλια", "Κικίλια", "Φιλήμων", "Φιλήμονας", "Φιλημονή", "Φιλημόνα", "Φλημόνα" } });
            _AnnivsData.Add(new Anniversary { Day = 23, Month = 11, IsNameday = 1, Names = new[] { "Αμφιλόχιος", "Αμφιλοχία", "Έλενος", "Λένος" } });
            _AnnivsData.Add(new Anniversary { Day = 24, Month = 11, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 25, Month = 11, IsNameday = 1, Names = new[] { "Αικατερίνη", "Αικατερίνα", "Κατερίνα", "Κατίνα", "Κάτια", "Ρίνα", "Καλοτίνα", "Καίτη", "Κατερινάκι", "Μερκούριος", "Μερκούρης", "Μέρκουρας", "Μάρκορας", "Μερκουρία" } });
            _AnnivsData.Add(new Anniversary { Day = 26, Month = 11, IsNameday = 1, Names = new[] { "Στυλιανός", "Στέργιος", "Στέλιος", "Στελής", "Τέλης", "Τέλιος", "Στέλα", "Στεργιανή", "Στεργιούλα", "Στυλιανή", "Στέλλα", "Τέλα", "Τελία", "Τελίτσα", "Στελίνα", "Νίκων" } });
            _AnnivsData.Add(new Anniversary { Day = 27, Month = 11, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 28, Month = 11, IsNameday = 1, Names = new[] { "Ειρήναρχος" } });
            _AnnivsData.Add(new Anniversary { Day = 29, Month = 11, IsNameday = 1, Names = new[] { "Φαίδρα", "Φαιδρούλα", "Φαιδρίνα", "Φιλούμενος", "Φίλος", "Φιλουμένη", "Φιλομίνα", "Φιλομίλα", "Φιλομίλη", "Φίλη" } });
            _AnnivsData.Add(new Anniversary { Day = 30, Month = 11, IsNameday = 1, Names = new[] { "Ανδρέας", "Αντρέας", "Ανδρίκος", "Αντρίκος", "Ανδριάνα", "Ανδρούλα", "Ανδριανή", "Αντριάννα" } });
        }

        private void AddAnnivsDecember() {
            _AnnivsData.Add(new Anniversary { Day = 1, Month = 12, IsNameday = 1, Names = new[] { "Θεόκλητος", "Ναούμ", "Ναούμης", "Ναόμι", "Ναούμα", "Φιλάρετος", "Φιλαρέτης", "Φιλαρέτη" } });
            _AnnivsData.Add(new Anniversary { Day = 2, Month = 12, IsNameday = 1, Names = new[] { "Μερόπη", "Μυρόπη", "Σολομών", "Σολομώντας", "Σόλων", "Σόλωνας", "Σολομωντία" } });
            _AnnivsData.Add(new Anniversary { Day = 3, Month = 12, IsNameday = 1, Names = new[] { "Γλυκέριος", "Γλυκερός" } });
            _AnnivsData.Add(new Anniversary { Day = 4, Month = 12, IsNameday = 1, Names = new[] { "Βαρβάρα", "Ρούλα", "Ρίτσα", "Βαρβάρω", "Βαρβαρούλα", "Βαρβαρίτσα", "Σεραφείμ", "Σεραφειμία", "Σεραφείμα", "Σεραφίνα", "Σεραφειμή", "Σεραφειμούλα", "Σεραφειμίτσα" } });
            _AnnivsData.Add(new Anniversary { Day = 5, Month = 12, IsNameday = 1, Names = new[] { "Διογένης", "Σάββας", "Σάβας", "Σαββούλης", "Σαββούλα", "Σαβούλα", "Σαβούλη" } });
            _AnnivsData.Add(new Anniversary { Day = 6, Month = 12, IsNameday = 1, Names = new[] { "Νικόλαος", "Νικόλας", "Νίκος", "Νικολός", "Νικολής", "Νικολάκης", "Νικολέττα", "Νικολούδα", "Νικολίτσα", "Νικολίνα", "Νικολέτα", "Νικόλ" } });
            _AnnivsData.Add(new Anniversary { Day = 7, Month = 12, IsNameday = 1, Names = new[] { "Αμβρόσιος", "Αμβρόσης", "Αμβροσία" } });
            _AnnivsData.Add(new Anniversary { Day = 8, Month = 12, IsNameday = 1, Names = new[] { "Πατάπιος" } });
            _AnnivsData.Add(new Anniversary { Day = 9, Month = 12, IsNameday = 1, Names = new[] { "Άννα", "Αννίτα", "Ανίτα", "Ανέτα", "Αννέτα", "Ανναμπέλλα", "Ανναμαρία", "Αννούλα", "Ανέζα", "Ανεζούλα", "Άννη" } });
            _AnnivsData.Add(new Anniversary { Day = 10, Month = 12, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 11, Month = 12, IsNameday = 1, Names = new[] { "" } });
            _AnnivsData.Add(new Anniversary { Day = 12, Month = 12, IsNameday = 1, Names = new[] { "Σπυρίδων", "Σπυρίδωνας", "Σπύρος", "Σπυρέτος", "Σπυράκης", "Σπυράκος", "Σπήλιος", "Σπυριδούλα", "Σπυρούλα", "Σπυρέτα", "Σπυρίνα", "Σπυρίδινα", "Λούλα" } });
            _AnnivsData.Add(new Anniversary { Day = 13, Month = 12, IsNameday = 1, Names = new[] { "Άρης", "Ευστράτιος", "Ευστράτης", "Στρατής", "Στράτος", "Ευστρατάς", "Στρατάς", "Ευστρατία", "Στρατούλα", "Στράτα", "Ευστρατούλα", "Ιουβενάλιος", "Ιουβενάλης", "Γιουβενάλης", "Ιουβεναλία", "Λουκάς", "Λουκία", "Λουκίτσα" } });
            _AnnivsData.Add(new Anniversary { Day = 14, Month = 12, IsNameday = 1, Names = new[] { "Αρριανός", "Αριανός", "Αρρειανός", "Αρειανός", "Αρριανή", "Αριάνα", "Λεύκιος", "Λεύκης", "Λεύκος", "Λεύκας", "Λευκή", "Λευκούλα", "Λευκάδα" } });
            _AnnivsData.Add(new Anniversary { Day = 15, Month = 12, IsNameday = 1, Names = new[] { "Ελευθέριος", "Λευθέρης", "Λευτέρης", "Λεφτέρης", "Ελευθερία", "Ρία", "Λευθερία", "Λευτερία", "Ανθή", "Ανθούλα", "Άνθια", "Άνθεια", "Σύλβια", "Σωσσάνα", "Σωσάνα", "Σωσάννα" } });
            _AnnivsData.Add(new Anniversary { Day = 16, Month = 12, IsNameday = 1, Names = new[] { "Θεοφανώ", "Μόδεστος" } });
            _AnnivsData.Add(new Anniversary { Day = 17, Month = 12, IsNameday = 1, Names = new[] { "Δανιήλ", "Δανιήλος", "Δανιέλος", "Δανιήλα", "Δανιέλα", "Δανιηλίτσα", "Ανανίας", "Νίνος", "Αζαρίας", "Μισαήλ", "Διονύσιος", "Διονύσης", "Νιόνιος", "Νύσης", "Ντένης", "Διονυσία", "Διονυσούλα", "Νύσα", "Σίσσυ", "Ντενίζ", "Ίακχος", "Ίακχη" } });
            _AnnivsData.Add(new Anniversary { Day = 18, Month = 12, IsNameday = 1, Names = new[] { "Σεβαστιανός", "Σεβαστίνος", "Σεβαστός", "Σέβος", "Σέβης", "Φλώρος", "Φλώρης", "Φλώρα", "Φλωρή", "Φλωρίτσα", "Ιακώβ", "Ιωσήφ", "Σήφης", "Ιωσηφίνα", "Ζοζεφίνα" } });
            _AnnivsData.Add(new Anniversary { Day = 19, Month = 12, IsNameday = 1, Names = new[] { "Αγλαΐα", "Άρης" } });
            _AnnivsData.Add(new Anniversary { Day = 20, Month = 12, IsNameday = 1, Names = new[] { "Ιγνάτιος", "Ιγνάτης", "Ιγνατία" } });
            _AnnivsData.Add(new Anniversary { Day = 21, Month = 12, IsNameday = 1, Names = new[] { "Θεμιστοκλής", "Θέμης", "Θεμιστοκλεία", "Θέμιδα", "Θέμις", "Ιούλιος", "Ιουλία", "Ιουλιανή", "Ιουλίτσα", "Γιουλία", "Γιούλα", "Γιουλίτσα", "Τζούλια", "Γιούλη" } });
            _AnnivsData.Add(new Anniversary { Day = 22, Month = 12, IsNameday = 1, Names = new[] { "Αναστασία", "Νατάσα", "Νατάσσα", "Τασία", "Σία", "Τατία", "Τάσα", "Τέσα", "Ζωΐλος", "Ζωΐλα" } });
            _AnnivsData.Add(new Anniversary { Day = 23, Month = 12, IsNameday = 1, Names = new[] { "Νήφων" } });
            _AnnivsData.Add(new Anniversary { Day = 24, Month = 12, IsNameday = 1, Names = new[] { "Αχμέτ", "Ευγενία", "Ευγενούλα", "Ευγενίτσα", "Τζένη", "Τζενούλα", "Ευγενίκη" } });
            _AnnivsData.Add(new Anniversary { Day = 25, Month = 12, IsNameday = 1, Names = new[] { "Βηθλεέμ", "Γκασπάρ", "Γκάσπαρος", "Εμμανουήλ", "Μανώλης", "Μανόλης", "Μανουήλ", "Μάνος", "Μανούσος", "Μανουσάκης", "Μανουσάκι", "Εμμανουέλλα", "Εμμανουέλα", "Μανουέλα", "Μανωλία", "Μελχιώρ", "Μελχιόρ", "Μπαλταζάρ", "Μπαλτασάρ", "Χρήστος", "Χρίστος", "Χριστίνα", "Χριστιάνα", "Κριστιάνα", "Χρίστα", "Κρίστα", "Χρίστη", "Κρίστη", "Χριστινάκι", "Χρυσή", "Χρύσα", "Χρυσαλία", "Χρυσαυγή", "Χρυσούλα", "Σήλια", "Χρυστάλλα", "Χρυσταλλία" } });
            _AnnivsData.Add(new Anniversary { Day = 26, Month = 12, IsNameday = 1, Names = new[] { "Εμμανουήλ", "Μανώλης", "Μανόλης", "Μανουήλ", "Μάνος", "Μανούσος", "Μανουσάκης", "Μανουσάκι", "Εμμανουέλλα", "Εμμανουέλα", "Μανουέλα", "Μανωλία", "Κωνστάντιος", "Κωστάντιος", "Κωνσταντία", "Κωσταντία", "Ντία" } });
            _AnnivsData.Add(new Anniversary { Day = 27, Month = 12, IsNameday = 1, Names = new[] { "Μαυρίκιος", "Μαυρίκης", "Μωρίς", "Μαυρικία", "Μαυρίκα", "Στέφανος", "Στέφος", "Στέφας", "Στεφανής", "Στεφανία", "Στέφη", "Στεφάνα", "Στεφανιώ", "Στεφανίτσα", "Στεφανή", "Στέφα" } });
            _AnnivsData.Add(new Anniversary { Day = 28, Month = 12, IsNameday = 1, Names = new[] { "Δόμνα", "Θεοφίλη", "Θεοφιλίτσα", "Φιλιώ", "Φιλίτσα", "Μυγδόνιος", "Μυγδόνης", "Μυγδονία", "Μιγδονία" } });
            _AnnivsData.Add(new Anniversary { Day = 29, Month = 12, IsNameday = 1, Names = new[] { "Βενιαμίν" } });
            _AnnivsData.Add(new Anniversary { Day = 30, Month = 12, IsNameday = 1, Names = new[] { "Ανύσιος", "Ανυσία", "Γεδεών", "Φιλέταιρος", "Φιλεταίριος", "Φιλεταίρης", "Φιλεταίρη", "Φιλεταιρία", "Φιλεταίρα" } });
            _AnnivsData.Add(new Anniversary { Day = 31, Month = 12, IsNameday = 1, Names = new[] { "Μελανία", "Μέλανυ", "Μελανή", "Μαύρη" } });
        }

        private void AddAnnivsNonStatic(DateTime easterDate) {
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(-70).Day, Month = easterDate.AddDays(-70).Month, NonStatic = 1, IsΝationalDay = 1, Names = new[] { "Τελώνου και Φαρισαίου - Αρχή Τριωδίου" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(-63).Day, Month = easterDate.AddDays(-63).Month, NonStatic = 1, IsΝationalDay = 1, Names = new[] { "Του Ασώτου" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(-59).Day, Month = easterDate.AddDays(-59).Month, NonStatic = 1, IsΝationalDay = 1, Names = new[] { "Τσικνοπέμπτη" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(-57).Day, Month = easterDate.AddDays(-57).Month, NonStatic = 1, IsΝationalDay = 1, Names = new[] { "Ψυχοσάββατο Α'" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(-56).Day, Month = easterDate.AddDays(-56).Month, NonStatic = 1, IsΝationalDay = 1, Names = new[] { "Της Απόκρεω" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(-49).Day, Month = easterDate.AddDays(-49).Month, NonStatic = 1, IsΝationalDay = 1, Names = new[] { "Τυροφάγου" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(-48).Day, Month = easterDate.AddDays(-48).Month, NonStatic = 1, IsΝationalDay = 1, IsHoliday = 1, Names = new[] { "Καθαρά Δευτέρα" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(-43).Day, Month = easterDate.AddDays(-43).Month, NonStatic = 1, IsNameday = 1, Names = new[] { "Θεόδωρος", "Θεοδώρα", "Δώρα", "Ντόρα", "Θόδωρος", "Θοδώρα", "Θοδωρής", "Θοδωράκης", "Θώδης", "Θώδος", "Δώρης" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(-42).Day, Month = easterDate.AddDays(-42).Month, NonStatic = 1, IsNameday = 1, Names = new[] { "Ορθοδοξία", "Λωξάνδρα", "Λωξάντρα", "Ρωξάνη", "Αξία" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(-35).Day, Month = easterDate.AddDays(-35).Month, NonStatic = 1, IsNameday = 1, Names = new[] { "Γρηγόριος", "Γρηγόρης", "Γρηγορία", "Γόλης" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(-8).Day, Month = easterDate.AddDays(-8).Month, NonStatic = 1, IsNameday = 1, Names = new[] { "Λάζαρος", "Λάζος" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(-7).Day, Month = easterDate.AddDays(-7).Month, NonStatic = 1, IsNameday = 1, Names = new[] { "Βάϊος", "Βάϊα", "Βάγια", "Βαία", "Δάφνη" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(-6).Day, Month = easterDate.AddDays(-6).Month, NonStatic = 1, IsΝationalDay = 1, Names = new[] { "Μεγάλη Δευτέρα" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(-5).Day, Month = easterDate.AddDays(-5).Month, NonStatic = 1, IsΝationalDay = 1, Names = new[] { "Μεγάλη Τρίτη" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(-4).Day, Month = easterDate.AddDays(-4).Month, NonStatic = 1, IsΝationalDay = 1, Names = new[] { "Μεγάλη Τετάρτη" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(-3).Day, Month = easterDate.AddDays(-3).Month, NonStatic = 1, IsΝationalDay = 1, Names = new[] { "Μεγάλη Πέμπτη" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(-2).Day, Month = easterDate.AddDays(-2).Month, NonStatic = 1, IsΝationalDay = 1, IsHoliday = 1, Names = new[] { "Μεγάλη Παρασκευή" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(-1).Day, Month = easterDate.AddDays(-1).Month, NonStatic = 1, IsΝationalDay = 1, IsHoliday = 1, Names = new[] { "Μεγάλο Σάββατο" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.Day, Month = easterDate.Month, IsNameday = 1, IsHoliday = 1, NonStatic = 1, Names = new[] { "Αναστάσιος", "Αναστασία", "Τάσος", "Αναστάσης", "Ανέστης", "Λάμπρος", "Λαμπρινή", "Λαμπρίνα", "Πασχάλης", "Πασχαλίνα", "Λίνα", "Στασινός" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(1).Day, Month = easterDate.AddDays(1).Month, NonStatic = 1, IsΝationalDay = 1, Names = new[] { "2α Διακαινησίμου - Δευτέρα" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(2).Day, Month = easterDate.AddDays(2).Month, NonStatic = 1, IsΝationalDay = 1, Names = new[] { "3η Διακαινησίμου - Τρίτη (Λαμπροτρίτη)" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(3).Day, Month = easterDate.AddDays(3).Month, NonStatic = 1, IsΝationalDay = 1, Names = new[] { "4η Διακαινησίμου - Τετάρτη (Θεοχάρης)" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(4).Day, Month = easterDate.AddDays(4).Month, NonStatic = 1, IsΝationalDay = 1, Names = new[] { "5η Διακαινησίμου - Πέμπτη" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(5).Day, Month = easterDate.AddDays(5).Month, NonStatic = 1, IsΝationalDay = 1, Names = new[] { "6η Διακαινησίμου - Παρασκευή" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(5).Day, Month = easterDate.AddDays(5).Month, NonStatic = 1, IsNameday = 1, Names = new[] { "Πηγή", "Κρήνη", "Κρηνιώ", "Ζήσης", "Ζησούλα", "Ζήσιμος", "Ζωή", "Ζώης", "Ζωϊτσα", "Ζωζώ", "Παναγιώτης", "Πάνος", "Πανούσος", "Παναγής", "Πανάγος", "Γιώτης", "Πολυζώης", "Παναγιώτα", "Γιώτα", "Παναγιούλα", "Γιούλα", "Παναγούλα" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(6).Day, Month = easterDate.AddDays(6).Month, NonStatic = 1, IsNameday = 1, Names = new[] { "7η Διακαινησίμου - Σαββάτο" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(7).Day, Month = easterDate.AddDays(7).Month, NonStatic = 1, IsNameday = 1, Names = new[] { "Θωμάς", "Θωμαή", "Τόμας" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(14).Day, Month = easterDate.AddDays(14).Month, NonStatic = 1, IsΝationalDay = 1, Names = new[] { "Των Μυροφόρων (Μυροφόρα)" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(21).Day, Month = easterDate.AddDays(21).Month, NonStatic = 1, IsΝationalDay = 1, Names = new[] { "Του Παραλύτου (Βηθεσδά)" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(39).Day, Month = easterDate.AddDays(39).Month, NonStatic = 1, IsΝationalDay = 1, Names = new[] { "Ανάληψη του Χριστού (Νεφέλη)" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(48).Day, Month = easterDate.AddDays(48).Month, NonStatic = 1, IsΝationalDay = 1, Names = new[] { "Ψυχοσάββατο Β'" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(49).Day, Month = easterDate.AddDays(49).Month, NonStatic = 1, IsΝationalDay = 1, IsHoliday = 1, Names = new[] { "Πεντηκοστή" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(50).Day, Month = easterDate.AddDays(50).Month, NonStatic = 1, IsNameday = 1, IsHoliday = 1, Names = new[] { "Τριάδα", "Τριάς", "Κόρη", "Κορίνα", "Κορίνος" } });
            _AnnivsData.Add(new Anniversary { Day = easterDate.AddDays(56).Day, Month = easterDate.AddDays(56).Month, NonStatic = 1, IsΝationalDay = 1, Names = new[] { "Αγίων Πάντων" } });
        }

        private void AddAnnivsInternational() {
            _AnnivsData.Add(new Anniversary { Day = 14, Month = 2, Names = new[] { "Ημέρα των ερωτευμένων Καθολικών Χριστιανών" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 21, Month = 2, Names = new[] { "Ημέρα της μητρικής γλώσσας" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 8, Month = 3, Names = new[] { "Ημέρα της γυναίκας" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 15, Month = 3, Names = new[] { "Ημέρα του καταναλωτή" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 21, Month = 3, Names = new[] { "Ημέρα της ποίησης" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 22, Month = 3, Names = new[] { "Ημέρα του νερού" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 23, Month = 3, Names = new[] { "Ημέρα της μετεωρολογίας" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 24, Month = 3, Names = new[] { "Ημέρα κατά της φυματίωσης" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 27, Month = 3, Names = new[] { "Ημέρα του Θεάτρου" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 7, Month = 4, Names = new[] { "Ημέρα της Υγείας" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 22, Month = 4, Names = new[] { "Ημέρα της γης" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 23, Month = 4, Names = new[] { "Ημέρα του βιβλίου και των πνευματικών δικαιωμάτων" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 24, Month = 4, Names = new[] { "Ημέρα μνήμης της Γενοκτονίας 1.500.000 Αρμενίων από τους Τούρκους το 1915" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 29, Month = 4, Names = new[] { "Ημέρα του χορού" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 3, Month = 5, Names = new[] { "Ημέρα της ελευθερίας του τύπου" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 9, Month = 5, Names = new[] { "Ημέρα της Ευρώπης" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 13, Month = 5, Names = new[] { "Ημέρα της μητέρας, γιορτή της μητέρας" }, IsInternationalDay = 1 }); //TODO: (* 2η Κυριακή Μαίου)
            _AnnivsData.Add(new Anniversary { Day = 15, Month = 5, Names = new[] { "Ημέρα της οικογένειας" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 17, Month = 5, Names = new[] { "Ημέρα των τηλεπικοινωνιών" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 18, Month = 5, Names = new[] { "Ημέρα των μουσείων" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 19, Month = 5, Names = new[] { "Ημέρα μνήμης της Γενοκτονίας του Ποντιακού Ελληνισμού από τους Τούρκους το 1920" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 21, Month = 5, Names = new[] { "Ημέρα της πολιτιστικής ανάπτυξης" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 31, Month = 5, Names = new[] { "Ημέρα κατά του καπνίσματος" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 5, Month = 6, Names = new[] { "Ημέρα προστασίας του περιβάλλοντος" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 12, Month = 6, Names = new[] { "Ημέρα κατά της εργασίας παιδιών" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 17, Month = 6, Names = new[] { "Ημέρα κατά της ερημοποίησης και της ξηρασίας" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 15, Month = 6, Names = new[] { "Ημέρα του πατέρα, γιορτή του πατέρα" }, IsInternationalDay = 1 }); //TODO: (* 3η Κυριακή Ιουνίου)
            _AnnivsData.Add(new Anniversary { Day = 20, Month = 6, Names = new[] { "Ημέρα των προσφύγων" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 26, Month = 6, Names = new[] { "Ημέρα κατά των ναρκωτικών" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 26, Month = 6, Names = new[] { "Ημέρα υπέρ των θυμάτων βασανισμού" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 2, Month = 7, Names = new[] { "Ημέρα των συνεταιρισμών" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 3, Month = 7, Names = new[] { "Ημέρα των ερωτευμένων Ορθοδόξων Χριστιανών" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 11, Month = 7, Names = new[] { "Ημέρα των πληθυσμών" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 9, Month = 8, Names = new[] { "Ημέρα των αυτοχθόνων λαών του κόσμου" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 12, Month = 8, Names = new[] { "Ημέρα της νεότητας" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 23, Month = 8, Names = new[] { "Ημέρα κατά της σκλαβιάς, Ημέρα θύμησης του εμπορίου σκλάβων και της απαγόρευσής του" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 8, Month = 9, Names = new[] { "Ημέρα εξάλειψης του αναλφαβητισμού" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 16, Month = 9, Names = new[] { "Ημέρα προστασίας της ζώνης του οζοντος" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 20, Month = 9, Names = new[] { "Ημέρα χωρίς αυτοκίνητο" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 21, Month = 9, Names = new[] { "Ημέρα της ειρήνης" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 26, Month = 9, Names = new[] { "Ημέρα της ναυτιλίας" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 27, Month = 9, Names = new[] { "Ημέρα του τουρισμού" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 1, Month = 10, Names = new[] { "Ημέρα της μουσικής" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 1, Month = 10, Names = new[] { "Ημέρα των γηρατειών" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 4, Month = 10, Names = new[] { "Ημέρα των ζώων" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 5, Month = 10, Names = new[] { "Ημέρα των δασκάλων" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 9, Month = 10, Names = new[] { "Ημέρα των ταχυδρομείων" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 11, Month = 10, Names = new[] { "Ημέρα της μείωσης ζημιών απο τις φυσικές καταστροφές" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 16, Month = 10, Names = new[] { "Ημέρα της διατροφής" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 17, Month = 10, Names = new[] { "Ημέρα υπέρ της εξάλειψης της φτώχιας" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 20, Month = 10, Names = new[] { "Ημέρα κατά της οστεοπόρωσης" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 31, Month = 10, Names = new[] { "Ημέρα της αποταμίευσης" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 14, Month = 11, Names = new[] { "Ημέρα κατά του διαβήτη" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 16, Month = 11, Names = new[] { "Ημέρα υπέρ της ανοχής" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 21, Month = 11, Names = new[] { "Ημέρα της τηλεόρασης" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 25, Month = 11, Names = new[] { "Ημέρα κατα της βίας εναντίον των γυναικών" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 29, Month = 11, Names = new[] { "Ημέρα υπέρ των Παλαιστινίων" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 1, Month = 12, Names = new[] { "Ημέρα κατά του aids" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 2, Month = 12, Names = new[] { "Ημέρα κατά της σκλαβιάς" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 3, Month = 12, Names = new[] { "Ημέρα των ατόμων με αναπηρία" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 4, Month = 12, Names = new[] { "Ημέρα κατά των ναρκών" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 7, Month = 12, Names = new[] { "Ημέρα της πολιτικής αεροπορίας" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 9, Month = 12, Names = new[] { "Ημέρα κατά της διαφθοράς" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 10, Month = 12, Names = new[] { "Ημέρα των ανθρώπινων δικαιωμάτων και της διεθνούς αμνηστίας" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 11, Month = 12, Names = new[] { "Ημέρα του παιδιού" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 11, Month = 12, Names = new[] { "Ημέρα των βουνών" }, IsInternationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 18, Month = 12, Names = new[] { "Ημέρα των μεταναστών" }, IsInternationalDay = 1 });
        }

        private void AddAnnivsNational() {
            _AnnivsData.Add(new Anniversary { Day = 1, Month = 1, Names = new[] { "Πρωτοχρονιά" }, IsΝationalDay = 1, IsHoliday = 1 });
            _AnnivsData.Add(new Anniversary { Day = 6, Month = 1, Names = new[] { "Θεοφάνεια" }, IsΝationalDay = 1, IsHoliday = 1 });
            _AnnivsData.Add(new Anniversary { Day = 25, Month = 3, Names = new[] { "Ευαγγελισμός της Θεοτόκου" }, IsΝationalDay = 1, IsHoliday = 1 });
            _AnnivsData.Add(new Anniversary { Day = 1, Month = 5, Names = new[] { "Εργατική Πρωτομαγιά" }, IsΝationalDay = 1, IsHoliday = 1 });
            _AnnivsData.Add(new Anniversary { Day = 15, Month = 8, Names = new[] { "Κοίμηση της Θεοτόκου" }, IsΝationalDay = 1, IsHoliday = 1 });
            _AnnivsData.Add(new Anniversary { Day = 28, Month = 10, Names = new[] { "Επέτειος του Όχι" }, IsΝationalDay = 1, IsHoliday = 1 });
            _AnnivsData.Add(new Anniversary { Day = 17, Month = 11, Names = new[] { "Εξέγερση του Πολυτεχνείου" }, IsΝationalDay = 1 });
            _AnnivsData.Add(new Anniversary { Day = 25, Month = 12, Names = new[] { "Χριστούγεννα" }, IsΝationalDay = 1, IsHoliday = 1 });
            _AnnivsData.Add(new Anniversary { Day = 26, Month = 12, Names = new[] { "Σύναξη της Θεοτόκου" }, IsΝationalDay = 1, IsHoliday = 1 });
        }

        private void AddAnnivsSpecial(int year) {
            DateTime easterDate = Easter.CalcEaster(year);
            DateTime date;

            //εορτάζεται την πρώτη Κυριακή μέτα τις 13 Φεβρουαρίου εκτός αν η 13η Φεβρουαρίου είναι Κυριακή οπότε δεν μετατίθεται.
            date = new DateTime(year, 2, 13);
            if (date.DayOfWeek != DayOfWeek.Sunday) {
                while (date.DayOfWeek != DayOfWeek.Sunday) {
                    date = date.AddDays(1);
                }
            }
            _AnnivsData.Add(new Anniversary { Day = date.Day, Month = date.Month, NonStatic = 1, Names = new[] { "Χλόη" } });

            //εορτάζονται στις 23 Απριλίου εκτός εαν το Πάσχα πέφτει μετά τις 23 Απριλίου οπότε η γιορτή μετατίθεται 1 μέρα μετά το Πάσχα.
            date = new DateTime(year, 4, 23);
            if (easterDate.Date > date) {
                date = easterDate.AddDays(1);
            }
            _AnnivsData.Add(new Anniversary { Day = date.Day, Month = date.Month, NonStatic = 1, Names = new[] { "Γεώργιος", "Γεωργής", "Γιώργος", "Γκόγκος", "Γιώργης", "Γιωργίτσης", "Γεωργία", "Γιωργία", "Γεωργούλα", "Γιωργίτσα", "Γίτσα", "Γωγώ" } });

            //εορτάζονται στις 25 Απριλίου εκτός εαν το Πάσχα πέφτει μετά τις 23 Απριλίου οπότε η γιορτή μετατίθεται 2 μέρες μετά το Πάσχα.
            date = new DateTime(year, 4, 25);
            if (easterDate.Date > date) {
                date = easterDate.AddDays(2);
            }
            _AnnivsData.Add(new Anniversary { Day = date.Day, Month = date.Month, NonStatic = 1, Names = new[] { "Μάρκος", "Μαρκής", "Μαρκία", "Μαρκούλης", "Μαρκούλα" } });

            //εορτάζονται στις 11 Δεκεμβρίου και πάντοτε Κυριακή. Αν η 11η Δεκεμβρίου τύχει καθημερινή τότε η εορτή μετατίθεται την προσεχή Κυριακή.
            date = new DateTime(year, 12, 11);
            if (date.DayOfWeek != DayOfWeek.Sunday) {
                while (date.DayOfWeek != DayOfWeek.Sunday) {
                    date = date.AddDays(1);
                }
            }
            _AnnivsData.Add(new Anniversary { Day = date.Day, Month = date.Month, NonStatic = 1, Names = new[] { "Ααρών", "Αβραάμ", "Αδάμ", "Αδαμάντιος", "Διαμαντής", "Αδαμαντία", "Διαμαντούλα", "Διαμάντω", "Δαβίδ", "Δαυίδ", "Δαν", "Δανάη", "Δανιήλ", "Δεβόρα", "Εσθήρ", "Εύα", "Ισαάκ", "Ιώβ", "Νώε", "Ραχήλ", "Ρεβέκκα", "Ρουμπίνη", "Σάρα", "Μελχισεδέχ" } });
        }
    }

    public static class Easter {

        public static DateTime CalcEaster(int year) {
            /* Τρόπος υπολογισμού Πάσχα
             * A Από τον αριθμό του έτους, για το οποίο γίνεται ο προσδιορισμός, αφαιρούμε τον αριθμό 2	
             * B: Το υπόλοιπο το διαιρούμε με τον αριθμό 19	
             * C: Το υπόλοιπο της διαίρεσης το πολλαπλασιάζουμε με τον αριθμό 11
             * D: Το γινόμενο του πολλαπλασιασμού το διαιρούμε με τον αριθμό 30. Το υπόλοιπο της διαίρεσης λέγεται επακτή και συμβολίζεται με το γράμμα 'Ε'	
             * E: Τέλος αφαιρούμε το 'Ε' από τον αριθμό 44
             * F: Αν το 'Ε' είναι μεγαλύτερο από 23, το υπόλοιπο της αφαίρεσης '44-Ε' μας δίνει την ημερομηνία της Πασχαλινής Πανσελήνου το μήνα Απρίλιο του Ιουλιανού Ημερολογίου. 
             *    Εάν το 'Ε' είναι μικρότερο ή ίσο με το 23, τότε το υπόλοιπο της αφαίρεσης '44-Ε' μας δίνει την ημερομηνία της Πασχαλινής Πανσελήνου το μήνα Μάρτιο του Ιουλιανού Ημερολογίου.	
             * G: Στην ημερομηνία που βρήκαμε στο βήμα F προσθέτουμε 13 ημέρες και βρίσκουμε την ημέρα της Πασχαλινής Πανσελήνου στο Γρηγοριανό ημερολόγιο που χρησιμοποιούμε σήμερα. 
             * H: Την αμέσως επόμενη Κυριακή της ημερομηνίας που βρίσκουμε γιορτάζεται το Ελληνικό Ορθόδοξο Πάσχα.
             */

            int A = year - 2;
            int B = A % 19;
            int C = B * 11;
            int D = C % 30;
            int E = 44 - D;

            int month; //F
            if (D > 23) {
                month = 4;
            }
            else {
                month = 3;
            }

            DateTime easterDate = new DateTime(year, month, 1);
            easterDate = easterDate.AddDays(E);

            easterDate = easterDate.AddDays(13);

            while (easterDate.DayOfWeek != DayOfWeek.Sunday) {
                easterDate = easterDate.AddDays(1);
            }

            return easterDate;
        }
    }
}
