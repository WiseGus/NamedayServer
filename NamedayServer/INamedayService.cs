using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace NamedayServer {

    [ServiceContract]
    public interface INamedayService {

        [OperationContract, WebGet(UriTemplate = "anniversaries/today")]
        IEnumerable<Anniversary> GetTodayAnniversaries();

        [OperationContract, WebGet(UriTemplate = "holidays")]
        IEnumerable<Anniversary> GetHolidays();

        [OperationContract, WebGet(UriTemplate = "anniversaries/{year}?name={name}")]
        IEnumerable<AnniversariesForYear> GetAnniversaries(string year, string name);

        [OperationContract, WebGet(UriTemplate = "easter/{year}")]
        string GetEaster(string year);
    }
}
