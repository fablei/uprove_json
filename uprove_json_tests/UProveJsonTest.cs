using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
using uprove_json;


namespace uprove_json_tests
{
    [TestClass]
    public class UProveJsonTest
    {
        private static UProveJSONParser parser = new UProveJSONParser();
        private static TestHelper helper = new TestHelper();
        private static Encoding encoding = System.Text.Encoding.UTF8;

        [TestMethod]
        public void IPObjectToJson()
        {
            Assert.AreEqual(helper.GetIPJson(), parser.ParseObjectToJson(helper.GetIPObject()));
        }

        [TestMethod]
        public void IPJsonToObject()
        {
            helper.TestIP(helper.GetIPObject(), parser.ParseJsonToObject<IP>(helper.GetIPJson()));
        }

        [TestMethod]
        public void TokenObjectToJson()
        {
            Assert.AreEqual(GetTokenJson(), parser.ParseObjectToJson(GetTokenObject()));
        }

        [TestMethod]
        public void TokenJsonToObject()
        {
            TestToken(GetTokenObject(), parser.ParseJsonToObject<Token>(GetTokenJson()));
        }

        [TestMethod]
        public void BasicClaimObjectToJson()
        {
            Assert.AreEqual(GetBasicClaimJson(), parser.ParseObjectToJson(GetBasicClaimObject()));
        }

        [TestMethod]
        public void BasicClaimJsonToObject()
        {
            helper.TestBasicClaim(GetBasicClaimObject(), parser.ParseJsonToObject<BasicClaim>(GetBasicClaimJson()));
        }

        #region private methods

        private void TestToken(Token expected, Token result)
        {
            Assert.AreEqual(expected.uidp, result.uidp);
            Assert.AreEqual(expected.h, result.h);
            Assert.AreEqual(expected.szp, result.szp);
            Assert.AreEqual(expected.scp, result.scp);
            Assert.AreEqual(expected.srp, result.srp);
            Assert.AreEqual(expected.d, result.d);
        }

        private string GetBasicClaimJson()
        {
            return "{\"name\":\"givenName\",\"values\":[\"Alice\",\"Mona\"],\"valuesbase64encoded\":\"W0FsaWNlTW9uYV0=\",\"propertiesbase64encoded\":\"eyJuYW1lIjoiZ2l2ZW5OYW1lIiwicXVhbGl0eWxldmVsIjoibG9hMSIsImVzc2VudGlhbCI6ZmFsc2V9\",\"qualitylevel\":\"loa1\",\"requestedqualitylevels\":[\"loa2\",\"loa1\"],\"essential\":true}";
        }

        private BasicClaim GetBasicClaimObject()
        {
            BasicClaim bc = new BasicClaim()
            {
                name = "givenName",
                qualitylevel = "loa1"
            };

            bc.propertiesbase64encoded = encoding.GetBytes(parser.ParseObjectToJson(bc));
            bc.values = new List<string>() { "Alice", "Mona" };

            string valuesToBase64 = "[";
            foreach (string value in bc.values)
                valuesToBase64 += value;
            valuesToBase64 += "]";
            bc.valuesbase64encoded = encoding.GetBytes(valuesToBase64);
            bc.requestedqualitylevels = new List<string>() { "loa2", "loa1" };
            bc.essential = true;

            return bc;
        }

        private string GetTokenJson()
        {
            return "{\"uidp\":\"c2FtcGxlIHJhbmdlIHByb29mIGlzc3Vlcg==\",\"h\":\"BBZiG2KagQDe7LET8EdtiqcFlittx9xSZsS4bd/UCXeodtOGxonCRliULGf+PEogRHs0iyQd+1uV9nm1dZTnU+c=\",\"szp\":\"BFuoeg2lA4z/P1xVF6BUv5PsSY2M65Ir7LhJQWM3qE9tGqKCYwWS5/unoAeObOqhR8LQuIQOtkzrwXKXOOWLMDk=\",\"scp\":\"gjcatJPYQ/sUwF1NjCYkDyjB+a7IIRUleaIG6v1d6Mk=\",\"srp\":\"Dabrg9WYXdFIKh4CC0zfRtYoSlpF6VF/pJ1GjO1FbfU=\",\"d\":false}";
        }

        private Token GetTokenObject()
        {
            return new Token()
            {
                uidp = "c2FtcGxlIHJhbmdlIHByb29mIGlzc3Vlcg==",
                h = "BBZiG2KagQDe7LET8EdtiqcFlittx9xSZsS4bd/UCXeodtOGxonCRliULGf+PEogRHs0iyQd+1uV9nm1dZTnU+c=",
                szp = "BFuoeg2lA4z/P1xVF6BUv5PsSY2M65Ir7LhJQWM3qE9tGqKCYwWS5/unoAeObOqhR8LQuIQOtkzrwXKXOOWLMDk=",
                scp = "gjcatJPYQ/sUwF1NjCYkDyjB+a7IIRUleaIG6v1d6Mk=",
                srp = "Dabrg9WYXdFIKh4CC0zfRtYoSlpF6VF/pJ1GjO1FbfU=",
                d = false
            };
        }

        #endregion private methods
    }
}
