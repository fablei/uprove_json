using Microsoft.VisualStudio.TestTools.UnitTesting;
using uprove_json.VerifierAuthenticationCredentials;
using System.Collections.Generic;
using uprove_json;
using System.Text;

namespace uprove_json_tests
{
    [TestClass]
    public class VerifierAuthenticationCredentialsTest
    {
        private static UProveJSONParser parser = new UProveJSONParser();
        private static TestHelper helper = new TestHelper();
        private static Encoding encoding = System.Text.Encoding.UTF8;

        [TestMethod]
        public void MemberListObjectToJson()
        {
            VerifierMembers expected = GetMemberListObject();
            VerifierMembers result = parser.ParseJsonToObject<VerifierMembers>(GetMemberListJson());

            Assert.AreEqual(expected.MemberAttribute, result.MemberAttribute);
            Assert.AreEqual(expected.verifiersSetMembershipProofId, result.verifiersSetMembershipProofId);
            helper.CompareList<string>(expected.Members, result.Members);
        }

        [TestMethod]
        public void MemberListJsonToObject()
        {
            Assert.AreEqual(GetMemberListJson(), parser.ParseObjectToJson(GetMemberListObject()));
        }

        [TestMethod]
        public void VerifierRangesObjectToJson()
        {
            VerifierRanges expected = GetVerifierRangesObject();
            VerifierRanges result = parser.ParseJsonToObject<VerifierRanges>(GetVerifierRangesJson());

            Assert.AreEqual(expected.verifiersRangeProofId, result.verifiersRangeProofId);
            Assert.AreEqual(expected.number, result.number);
            Assert.AreEqual(expected.rangeProofAttribute, result.rangeProofAttribute);
            Assert.AreEqual(expected.rangeProofType, result.rangeProofType);
            Assert.AreEqual(expected.sibling, result.sibling);
        }

        [TestMethod]
        public void VerifierRangesJsonToObject()
        {
            Assert.AreEqual(GetVerifierRangesJson(), parser.ParseObjectToJson(GetVerifierRangesObject()));
        }

        [TestMethod]
        public void VerifierAuthCredentialsObjectToJson()
        {
            VerifierAuthCredentials expected = GetVerifierAuthCredentialsObject();
            VerifierAuthCredentials result = parser.ParseJsonToObject<VerifierAuthCredentials>(GetVerifierAuthCredentialsJson());

            Assert.AreEqual(expected.Certificate, result.Certificate);
            Assert.AreEqual(expected.Created, result.Created);
            Assert.AreEqual(expected.Domain, result.Domain);
            Assert.AreEqual(expected.Signature, result.Signature);
            Assert.AreEqual(expected.WantHardTokenAuthenticated, result.WantHardTokenAuthenticated);
            helper.CompareList<string>(expected.MandatoryAttributes, result.MandatoryAttributes);
            helper.CompareList<string>(expected.OptionalAttributes, result.OptionalAttributes);
        }

        [TestMethod]
        public void VerifierAuthCredentialsJsonToObject()
        {
            Assert.AreEqual(GetVerifierAuthCredentialsJson(), parser.ParseObjectToJson(GetVerifierAuthCredentialsObject()));
        }

        #region private methods

        private string GetMemberListJson()
        {
            return "{\"verifiersSetMembershipProofId\":0,\"Members\":[\"ETH\",\"BFH\",\"UniBern\"],\"MemberAttribute\":\"homeOrganization\"}";
        }

        private string GetVerifierRangesJson()
        {
            return "{\"verifiersRangeProofId\":0,\"number\":18,\"rangeProofType\":\">\",\"rangeProofAttribute\":\"dateofbirth\",\"sibling\":1}";
        }

        private string GetVerifierAuthCredentialsJson()
        {
            return "{\"MandatoryAttributes\":[\"surname\",\"givenName\"],\"OptionalAttributes\":[\"dateofbirth\"],\"WantHardTokenAuthenticated\":true,\"Domain\":\"domainString\",\"Certificate\":\"certString\",\"Signature\":\"signatureString\",\"Created\":154}";
        }

        private VerifierMembers GetMemberListObject()
        {
            return new VerifierMembers()
            {
                verifiersSetMembershipProofId = 0,
                Members = new List<string>() { "ETH", "BFH", "UniBern" },
                MemberAttribute = "homeOrganization"
            };
        }

        private VerifierRanges GetVerifierRangesObject()
        {
            return new VerifierRanges()
            {
                verifiersRangeProofId = 0,
                number = 18,
                rangeProofType = ">",
                sibling = 1,
                rangeProofAttribute = "dateofbirth"
            };
        }

        private VerifierAuthCredentials GetVerifierAuthCredentialsObject()
        {
            // MemberList, VerifierRange already tested

            return new VerifierAuthCredentials()
            {
                Certificate = "certString",
                Domain = "domainString",
                MandatoryAttributes = new List<string>() { "surname", "givenName" },
                OptionalAttributes = new List<string>() { "dateofbirth" },
                Signature = "signatureString",
                WantHardTokenAuthenticated = true,
                Created = 154
            };
        }

        #endregion private methods
    }
}
