using Microsoft.VisualStudio.TestTools.UnitTesting;
using uprove_json;
using uprove_json.IssuerVerification;
using System.Collections.Generic;

namespace uprove_json_tests
{
    [TestClass]
    public class IssuerVerificationTests
    {
        private static UProveJSONParser parser = new UProveJSONParser();
        private static TestHelper helper = new TestHelper();

        [TestMethod]
        public void TrustedIssuerListJson2Object()
        {
            string jsonTrustedIssuerList = helper.ReadFile("TrustesIssuerList");
            TrustedIssuerList trustedIssuerList = parser.ParseJsonToObject<TrustedIssuerList>(jsonTrustedIssuerList);
            TrustedIssuerList expectedTrustedIssuerList = GetTrustedIssuerListObject();

            Assert.IsNotNull(trustedIssuerList.issuers[0]);
            helper.TestIP(expectedTrustedIssuerList.issuers[0], trustedIssuerList.issuers[0]);
        }

        [TestMethod]
        public void TrustedIssuerListObject2Json()
        {
            Assert.AreEqual(GetTrustedIssuerListJson(), parser.ParseObjectToJson(GetTrustedIssuerListObject()));
        }

        [TestMethod]
        public void IssuerParameterWithPKJsonToObject()
        {
            IssuerParameterWithPK result = parser.ParseJsonToObject<IssuerParameterWithPK>(GetIPJson(true));
            IssuerParameterWithPK expected = GetIPObjectWithPK();

            helper.TestIP(expected.ip, result.ip);
            Assert.AreEqual(expected.privateKey, result.privateKey);
        }

        [TestMethod]
        public void IssuerParameterWithPKObjectToJson()
        {
            string jsonip = GetIPJson(true);
            string objectip = parser.ParseObjectToJson(GetIPObjectWithPK());

            Assert.AreEqual(GetIPJson(true), parser.ParseObjectToJson(GetIPObjectWithPK()));
        }




        #region private methods

        private TrustedIssuerList GetTrustedIssuerListObject()
        {
            return new TrustedIssuerList()
            {
                issuers = new List<IP>()
                {
                    helper.GetIPObject()
                }
            };
        }

        private string GetTrustedIssuerListJson()
        {
            return "{\"issuers\":[" + GetIPJson() + "]}";
        }

        private IssuerParameterWithPK GetIPObjectWithPK()
        {
            return new IssuerParameterWithPK()
            {
                ip = helper.GetIPObject(),
                privateKey = "NQ+lSRxQbZbEPWCKhSqa812+iSa3TcwvywYI0xYnbgI="
            };
        }

        private string GetIPJson(bool ipWithPK = false)
        {
            if (!ipWithPK)
                return helper.GetIPJson();

            return "{\"ip\":" + helper.GetIPJson() + ",\"privateKey\":\"NQ+lSRxQbZbEPWCKhSqa812+iSa3TcwvywYI0xYnbgI=\"}";
        }
    }
    #endregion private methods
}
