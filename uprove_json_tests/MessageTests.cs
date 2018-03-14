using Microsoft.VisualStudio.TestTools.UnitTesting;
using uprove_json.Message;
using System.Collections.Generic;
using uprove_json;

namespace uprove_json_tests
{
    [TestClass]
    public class MessageTests
    {
        private static UProveJSONParser parser = new UProveJSONParser();
        private static TestHelper helper = new TestHelper();

        //[TestMethod]
        //public void Testli()
        //{
        //    string jsonTrustedIssuerList = ReadFile("TrustesIssuerList");
        //    TrustedIssuerList trustedIssuerList = mp.ParseEverything<TrustedIssuerList>(jsonTrustedIssuerList);

        //    Assert.AreEqual("c2FtcGxlIHNldCBtZW1iZXJzaGlwIGlzc3Vlcg==", trustedIssuerList.issuers[0].uidp);
        //}


        [TestMethod]
        public void FirstMessageJsonToObject()
        {
            FirstMessage result = parser.ParseJsonToObject<FirstMessage>(GetFirstMessageJson());
            FirstMessage expected = GetFirstMessageObject();

            helper.CompareList<string>(expected.sa, result.sa);
            helper.CompareList<string>(expected.sb, result.sb);
            Assert.AreEqual(expected.sz, result.sz);
        }

        [TestMethod]
        public void FirstMessageObjectToJson()
        {
            Assert.AreEqual(GetFirstMessageJson(), parser.ParseObjectToJson(GetFirstMessageObject()));
        }

        [TestMethod]
        public void SecondMessageJsonToObject()
        {
            helper.CompareList<string>(GetSecondMessageObject().sc, parser.ParseJsonToObject<SecondMessage>(GetSecondMessageJson()).sc);
        }

        [TestMethod]
        public void SecondMessageObjectToJson()
        {
            Assert.AreEqual(GetSecondMessageJson(), parser.ParseObjectToJson(GetSecondMessageObject()));
        }

        [TestMethod]
        public void ThirdMessageJsonToObject()
        {
            helper.CompareList<string>(GetThirdMessageObject().sr, parser.ParseJsonToObject<ThirdMessage>(GetThirdMessageJson()).sr);
        }

        [TestMethod]
        public void ThirdMessageObjectToJson()
        {
            Assert.AreEqual(GetThirdMessageJson(), parser.ParseObjectToJson(GetThirdMessageObject()));
        }

        [TestMethod]
        public void TokenRequestJsonToObject()
        {

        }

        [TestMethod]
        public void TokenRequestObjectToJson()
        {
            Assert.AreEqual(GetTokenRequestJson(), parser.ParseObjectToJson(GetTokenRequestObject()));
        }

        #region private methods

        private string GetFirstMessageJson()
        {
            return "{\"sz\":\"szstring\",\"sa\":[\"sa0\",\"sa1\",\"sa3\"],\"sb\":[\"sb0\",\"sb1\",\"sb3\"]}";
        }

        private string GetSecondMessageJson()
        {
            return "{\"sc\":[\"sc0\",\"sc1\",\"sc2\"]}";
        }

        private string GetThirdMessageJson()
        {
            return "{\"sr\":[\"sr0\",\"sr1\",\"sr2\"]}";
        }

        private string GetTokenRequestJson()
        {
            return "{\"requestedclaims\":[{\"name\":\"givenName\",\"requestedqualitylevels\":[\"loa2\",\"loa1\"],\"essential\":true},{\"name\":\"surname\",\"requestedqualitylevels\":[\"loa2\"],\"essential\":false}],\"numberoftokens\":2,\"ti\":\"TokenInformation\"}";
        }

        private FirstMessage GetFirstMessageObject()
        {
            return new FirstMessage()
            {
                sz = "szstring",
                sa = new List<string>() { "sa0", "sa1", "sa3" },
                sb = new List<string>() { "sb0", "sb1", "sb3" }
            };
        }

        private SecondMessage GetSecondMessageObject()
        {
            return new SecondMessage()
            {
                sc = new List<string>() { "sc0", "sc1", "sc2" }
            };
        }

        private ThirdMessage GetThirdMessageObject()
        {
            return new ThirdMessage()
            {
                sr = new List<string>() { "sr0", "sr1", "sr2" }
            };
        }

        private TokenRequest GetTokenRequestObject()
        {
            return new TokenRequest()
            {
                requestedclaims = new List<BasicClaim>()
                {
                    new BasicClaim()
                    {
                        name = "givenName",
                        essential = true,
                        requestedqualitylevels = new List<string>() { "loa2", "loa1" }
                    },
                    new BasicClaim()
                    {
                        name = "surname",
                        requestedqualitylevels = new List<string>() { "loa2" }
                    }
                },
                numberoftokens = 2,
                ti = "TokenInformation"
            };
        }

        #endregion private methods
    }
}
