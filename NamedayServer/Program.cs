using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace NamedayServer {
    class Program {
        static void Main(string[] args) {

            ServiceHost host = null;
            try {
                string baseAddress = "http://localhost:8080/namedays";
                host = new ServiceHost(typeof(NamedayService), new Uri(baseAddress));

                host.AddServiceEndpoint(typeof(INamedayService), new NetTcpBinding(), "net.tcp://localhost/namedays");
                var webEP = host.AddServiceEndpoint(typeof(INamedayService), new WebHttpBinding(), "");
                webEP.Behaviors.Add(new WebHttpBehavior { DefaultBodyStyle = System.ServiceModel.Web.WebMessageBodyStyle.Wrapped, DefaultOutgoingResponseFormat = System.ServiceModel.Web.WebMessageFormat.Json, FaultExceptionEnabled = true, HelpEnabled = true });
                
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetUrl = new Uri("http://localhost:8080/namedays/mex");
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

                host.Open();

                Console.WriteLine("Service listening at '{0}'", baseAddress);
            }
            catch (Exception ex) {
                Console.WriteLine("An error has occured:");
                Console.WriteLine(ex.ToString());
            }
            finally {
                Console.WriteLine("\nPress Enter to exit");
                Console.ReadLine();
                if (host != null) {
                    host.Close();
                }
            }
        }
    }
}
