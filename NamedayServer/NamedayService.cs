using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace NamedayServer {

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class NamedayService : INamedayService {

        public IEnumerable<Anniversary> GetHolidays() {
            Anniversaries _Αnniversaries = new Anniversaries(DateTime.Now.Year);
            IEnumerable<Anniversary> data = _Αnniversaries.AnnivsData.Where(p => p.IsHoliday == 1);
            return data;
        }

        public IEnumerable<AnniversariesForYear> GetAnniversaries(string year, string name) {
            int yearNo = 0;
            if (!int.TryParse(year, out yearNo)) return null;

            Anniversaries _Αnniversaries = new Anniversaries(yearNo);
            List<AnniversariesForYear> data = new List<AnniversariesForYear>();

            if (string.IsNullOrEmpty(name)) {
                #region National Anniversaries
                var anniversaries = new List<AnniversariesForMonth>();
                for (int i = 1; i <= 12; i++) {
                    anniversaries.Add(new AnniversariesForMonth {
                        Month = i,
                        Anniversary = _Αnniversaries.AnnivsData.Where(p => p.Month == i && p.IsΝationalDay == 1).ToList()
                    });
                }
                data.Add(new AnniversariesForYear {
                    AnniversaryType = Enum.GetName(typeof(AnniversaryType), AnniversaryType.National),
                    Anniversaries = anniversaries
                });
                #endregion

                #region International Anniversaries
                anniversaries = new List<AnniversariesForMonth>();
                for (int i = 1; i <= 12; i++) {
                    anniversaries.Add(new AnniversariesForMonth {
                        Month = i,
                        Anniversary = _Αnniversaries.AnnivsData.Where(p => p.Month == i && p.IsInternationalDay == 1).ToList()
                    });
                }
                data.Add(new AnniversariesForYear {
                    AnniversaryType = Enum.GetName(typeof(AnniversaryType), AnniversaryType.International),
                    Anniversaries = anniversaries
                });
                #endregion

                #region Nameday Anniversaries
                anniversaries = new List<AnniversariesForMonth>();
                for (int i = 1; i <= 12; i++) {
                    anniversaries.Add(new AnniversariesForMonth {
                        Month = i,
                        Anniversary = _Αnniversaries.AnnivsData.Where(p => p.Month == i && p.IsNameday == 1).ToList()
                    });
                }
                data.Add(new AnniversariesForYear {
                    AnniversaryType = Enum.GetName(typeof(AnniversaryType), AnniversaryType.Nameday),
                    Anniversaries = anniversaries
                });
                #endregion
            }
            else {
                var anniversaries = new List<AnniversariesForMonth>();

                var anniversary = _Αnniversaries.AnnivsData.Where(p => p.Names.FirstOrDefault(o => string.Compare(o, name, StringComparison.InvariantCultureIgnoreCase) == 0) != null).ToList();

                anniversaries.Add(new AnniversariesForMonth {
                    Anniversary = anniversary,
                    Month = anniversary.Count > 0 ? anniversary.FirstOrDefault().Month : 0
                });

                data.Add(new AnniversariesForYear {
                    AnniversaryType = Enum.GetName(typeof(AnniversaryType), AnniversaryType.Nameday),
                    Anniversaries = anniversaries
                });
            }
            return data;
        }

        public string GetEaster(string year) {
            int yearNo = 0;
            if (!int.TryParse(year, out yearNo)) return null;

            return Easter.CalcEaster(yearNo).ToShortDateString();
        }

        public IEnumerable<Anniversary> GetTodayAnniversaries() {
            Anniversaries _Αnniversaries = new Anniversaries(DateTime.Now.Year);
            IEnumerable<Anniversary> data = _Αnniversaries.AnnivsData.Where(p => p.Month == DateTime.Now.Month && p.Day == DateTime.Now.Day);
            return data;
        }
    }
}
