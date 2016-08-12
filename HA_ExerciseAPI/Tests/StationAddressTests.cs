using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using Newtonsoft.Json.Linq;
using SeleniumAssignmentPart2.ServiceHelper;

namespace SeleniumAssignmentPart2.Tests
{
    [TestClass]
    public class StationAddressTests
    {
        [TestMethod]
        [Description("Verify the Station Address is 208 Barton Springs, Austin, Texas, USA, 78704")]

        public void VerifyStationAddress()
        {

            string url = ConfigurationManager.AppSettings["TestServiceUrl"] + "62029" + ".json?api_key=qokaQnJdfoENg5f8pod2WOLgXmntI7sH3FRDbZL9";
            ServiceResponse serviceResponse = new ServiceResponse();
            string response = serviceResponse.GetServiceResponse(url);
            if (response != null)
            {
                JObject data = JObject.Parse(response);
                IEnumerable<JToken> dataToken = data.Values().FirstOrDefault();
                foreach (var item in dataToken)
                {
                    JProperty oneTokenProp = item as JProperty;
                    string tokenValue = Convert.ToString(oneTokenProp.Value);
                    switch (oneTokenProp.Name)
                    {
                        case "street_address":
                            Assert.AreEqual(tokenValue, "208 Barton Springs Rd");
                            break;
                        case "city":
                            Assert.AreEqual(tokenValue, "Austin");
                            break;
                        case "state":
                            Assert.AreEqual(tokenValue, "TX");
                            break;
                        case "zip":
                            Assert.AreEqual(tokenValue, "78704");
                            break;
                    }
                }
                Console.WriteLine("Address verified");
                serviceResponse.CloseResponseReader();
            }

        }
    }
}
