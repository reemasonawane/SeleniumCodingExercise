using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;
using SeleniumAssignmentPart2.ServiceHelper;

namespace SeleniumAssignmentPart2.Tests
{
    [TestClass]
    public class NearestStationTests
    {
        [TestMethod]
        [Description("Verify that “HYATT AUSTIN” appears in the results")]
        public void VerifyNearestStation()
        {
            string url = ConfigurationManager.AppSettings["TestServiceUrl"] + "nearest.json?api_key=qokaQnJdfoENg5f8pod2WOLgXmntI7sH3FRDbZL9&location=Austin+TX&ev_network=ChargePoint Network";
            ServiceResponse serviceResponse = new ServiceResponse();
            string response = serviceResponse.GetServiceResponse(url);
            if (response != null)
            {
                Assert.IsTrue(response.Contains("HYATT AUSTIN"));
                Console.WriteLine("Verified station");
                serviceResponse.CloseResponseReader();
            }
        }
    }
}
