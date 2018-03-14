using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using uprove_json;
using uprove_json.Proofs;

namespace uprove_json_tests
{
    [TestClass]
    public class ProofsTests
    {
        private static UProveJSONParser parser = new UProveJSONParser();
        private static TestHelper helper = new TestHelper();
        private static Encoding encoding = System.Text.Encoding.UTF8;

        [TestMethod]
        public void BitProofJsonToObject()
        {
            BitProof result = parser.ParseJsonToObject<BitProof>(GetBitProofJson());
            BitProof expected = GetBitProofObject();

            helper.CompareList<string>(expected.a, result.a);
            helper.CompareList<string>(expected.c, result.c);
            helper.CompareList<string>(expected.r, result.r);
        }

        [TestMethod]
        public void BitProofObjectToJson()
        {
            Assert.AreEqual(GetBitProofJson(), parser.ParseObjectToJson(GetBitProofObject()));
        }

        [TestMethod]
        public void BitProofAJsonToObject()
        {
            BitProofA result = parser.ParseJsonToObject<BitProofA>(GetBitProofAJson());
            BitProofA expected = GetBitProofAObject();

            Assert.AreEqual(expected.BitProof.Count, result.BitProof.Count);

            for (int i = 0; i < expected.BitProof.Count; i++)
            {
                helper.CompareList<string>(expected.BitProof[0].a, result.BitProof[0].a);
                helper.CompareList<string>(expected.BitProof[0].c, result.BitProof[0].c);
                helper.CompareList<string>(expected.BitProof[0].r, result.BitProof[0].r);
            }

            helper.CompareList<string>(expected.CompositionProof.b, result.CompositionProof.b);
            helper.CompareList<string>(expected.CompositionProof.rEq, result.CompositionProof.rEq);
            helper.CompareList<string>(expected.CompositionProof.rNeq, result.CompositionProof.rNeq);
        }

        [TestMethod]
        public void BitProofAObjectToJson()
        {
            Assert.AreEqual(GetBitProofAJson(), parser.ParseObjectToJson(GetBitProofAObject()));
        }

        [TestMethod]
        public void CompositionProofJsonToObject()
        {
            CompositionProof result = parser.ParseJsonToObject<CompositionProof>(GetCompositionProofJson());
            CompositionProof expected = GetCompositionProofObject();

            helper.CompareList<string>(expected.b, result.b);
            helper.CompareList<string>(expected.rEq, result.rEq);
            helper.CompareList<string>(expected.rNeq, result.rNeq);
        }

        [TestMethod]
        public void CompositionProofObjectToJson()
        {
            Assert.AreEqual(GetCompositionProofJson(), parser.ParseObjectToJson(GetCompositionProofObject()));
        }

        [TestMethod]
        public void DescGqJsonToObject()
        {

            DescGq expected = GetDescGqObject();
            DescGq result = parser.ParseJsonToObject<DescGq>(GetDescGqJson());

            Assert.AreEqual(expected.name, result.name);
            Assert.AreEqual(expected.type, result.type);
        }

        [TestMethod]
        public void DescGqObjectToJson()
        {
            Assert.AreEqual(GetDescGqJson(), parser.ParseObjectToJson(GetDescGqObject()));
        }

        [TestMethod]
        public void FullRangeProofJsonToObject()
        {
            FullRangeProof result = parser.ParseJsonToObject<FullRangeProof>(GetFullRangeProofJson());
            FullRangeProof expected = GetFullRangeProofObject();

            helper.CompareList<string>(expected.b, result.b);
            helper.CompareList<string>(expected.rEq, result.rEq);
            helper.CompareList<string>(expected.rNeq, result.rNeq);
        }

        [TestMethod]
        public void FullRangeProofObjectToJson()
        {
            Assert.AreEqual(GetFullRangeProofJson(), parser.ParseObjectToJson(GetFullRangeProofObject()));
        }

        [TestMethod]
        public void GroupJsonToObject()
        {

            DescGq expected = GetDescGqObject();
            DescGq result = parser.ParseJsonToObject<DescGq>(GetDescGqJson());

            Assert.AreEqual(expected.name, result.name);
            Assert.AreEqual(expected.type, result.type);
        }

        [TestMethod]
        public void GroupObjectToJson()
        {
            Assert.AreEqual(GetDescGqJson(), parser.ParseObjectToJson(GetDescGqObject()));
        }

        //[TestMethod]
        //public void GroupElementDevicePublicKeyJsonToObject()
        //{
        //    GroupElementDevicePublicKey expected = GetGroupElementDevicePublicKeyObject();
        //    string s = parser.ParseObjectToJson(expected);
        //    try
        //    {
        //        GroupElementDevicePublicKey result = parser.ParseJsonToObject<GroupElementDevicePublicKey>(GetGroupElementDevicePublicKeyJson());

        //        Assert.AreEqual(expected.i.BitCount, result.i.BitCount);
        //        Assert.AreEqual(expected.i.BitLength, result.i.BitLength);
        //        Assert.AreEqual(expected.i.IntValue, result.i.IntValue);
        //        Assert.AreEqual(expected.i.LongValue, result.i.LongValue);
        //        Assert.AreEqual(expected.i.SignValue, result.i.SignValue);
        //        Assert.AreEqual(expected.i.IsEven, result.i.IsEven);

        //        Assert.AreEqual(expected.p.BitCount, result.p.BitCount);
        //        Assert.AreEqual(expected.p.BitLength, result.p.BitLength);
        //        Assert.AreEqual(expected.p.IntValue, result.p.IntValue);
        //        Assert.AreEqual(expected.p.LongValue, result.p.LongValue);
        //        Assert.AreEqual(expected.p.SignValue, result.p.SignValue);
        //        Assert.AreEqual(expected.p.IsEven, result.p.IsEven);
        //    }
        //    catch (Exception e)
        //    {
        //        Assert.Fail(e.Message);
        //    }
        //}

        [TestMethod]
        public void GroupElementDevicePublicKeyObjectToJson()
        {
            Assert.AreEqual(GetGroupElementDevicePublicKeyJson(), parser.ParseObjectToJson(GetGroupElementDevicePublicKeyObject()));
        }

        [TestMethod]
        public void OrEqualProofJsonToObject()
        {
            OrEqualProof expected = GetOrEqualProofObject();
            OrEqualProof result = parser.ParseJsonToObject<OrEqualProof>(GetOrEqualProofJson());

            helper.CompareList<string>(expected.a, result.a);
            helper.CompareList<string>(expected.c, result.c);
            helper.CompareList<string>(expected.r, result.r);
        }

        [TestMethod]
        public void OrEqualProofObjectToJson()
        {
            Assert.AreEqual(GetOrEqualProofJson(), parser.ParseObjectToJson(GetOrEqualProofObject()));
        }

        [TestMethod]
        public void ProofJsonToObject()
        {
            Proof expected = GetProofObject();
            Proof result = parser.ParseJsonToObject<Proof>(GetProofJson());

            Assert.AreEqual(expected.a, result.a);
            Assert.AreEqual(expected.ap, result.ap);
            Assert.AreEqual(expected.Ps, result.Ps);
            helper.CompareList<string>(expected.tr, result.tr);
            helper.CompareList<string>(expected.D, result.D);
            helper.CompareList<string>(expected.r, result.r);
            helper.CompareList<string>(expected.ta, result.ta);
            helper.CompareList<string>(expected.tc, result.tc);
        }

        [TestMethod]
        public void ProofObjectToJson()
        {
            string json = parser.ParseObjectToJson(GetProofObject());
            Assert.AreEqual(GetProofJson(), parser.ParseObjectToJson(GetProofObject()));
        }

        [TestMethod]
        public void ProofRequirementsJsonToObject()
        {
            ProofRequirements expected = GetProofRequirementsObject();
            ProofRequirements result = parser.ParseJsonToObject<ProofRequirements>(GetProofRequirementsJson());
            
            helper.CompareArray<int>(expected.committedAttributes, result.committedAttributes);
            helper.CompareArray<byte>(expected.deviceMessage, result.deviceMessage);
            helper.CompareArray<int>(expected.disclosedAttributes, result.disclosedAttributes);
            helper.CompareArray<byte>(expected.message, result.message);
            helper.CompareArray<byte>(expected.scope, result.scope);
        }

        [TestMethod]
        public void ProofRequirementsObjectToJson()
        {
            Assert.AreEqual(GetProofJson(), parser.ParseObjectToJson(GetProofObject()));
        }

        [TestMethod]
        public void RangeProofJsonToObject()
        {
            RangeProof expected = GetRangeProofObject();
            RangeProof result = parser.ParseJsonToObject<RangeProof>(GetRangeProofJson());

            Assert.AreEqual(expected.commitmentIndex, result.commitmentIndex);
            Assert.AreEqual(expected.maxBirthYear, result.maxBirthYear);
            Assert.AreEqual(expected.minBirthYear, result.minBirthYear);
            Assert.AreEqual(expected.rangeProofType, result.rangeProofType);
            Assert.AreEqual(expected.targetDate, result.targetDate);
            Assert.AreEqual(expected.verifiersRangeProofId, result.verifiersRangeProofId);
            helper.CompareList<string>(expected.A, result.A);
            helper.CompareList<string>(expected.X, result.X);
            helper.CompareList<string>(expected.D, result.D);
        }

        [TestMethod]
        public void RangeProofObjectToJson()
        {
            Assert.AreEqual(GetRangeProofJson(), parser.ParseObjectToJson(GetRangeProofObject()));
        }

        [TestMethod]
        public void SetMembershipProofJsonToObject()
        {
            SetMembershipProof expected = GetSetMembershipProofObject();
            SetMembershipProof result = parser.ParseJsonToObject<SetMembershipProof>(GetSetMembershipProofJson());

            helper.CompareList<string>(expected.a, result.a);
            helper.CompareList<string>(expected.c, result.c);
            helper.CompareList<string>(expected.r, result.r);
            Assert.AreEqual(expected.commitmentIndex, result.commitmentIndex);
            Assert.AreEqual(expected.verifiersSetMembershipProofId, result.verifiersSetMembershipProofId);

            Assert.AreEqual(expected.setValues.Length, result.setValues.Length);
            for (int i = 0; i < expected.setValues.Length; i++)
                for(int j = 0; j < expected.setValues[i].Length; j++)
                Assert.AreEqual(expected.setValues[i][j], result.setValues[i][j]);
        }

        [TestMethod]
        public void SetMembershipProofObjectToJson()
        {
            Assert.AreEqual(GetSetMembershipProofJson(), parser.ParseObjectToJson(GetSetMembershipProofObject()));
        }

        [TestMethod]
        public void StrictProofJsonToObject()
        {
            StrictProof expected = GetStrictProofObject();
            StrictProof result = parser.ParseJsonToObject<StrictProof>(GetStrictProofJson());

            helper.CompareList<string>(expected.b, result.b);
            helper.CompareList<string>(expected.rEq, result.rEq);
            helper.CompareList<string>(expected.rNeq, result.rNeq);
        }

        [TestMethod]
        public void StrictProofObjectToJson()
        {
            Assert.AreEqual(GetStrictProofJson(), parser.ParseObjectToJson(GetStrictProofObject()));
        }


        #region private methods

        private string GetBitProofJson()
        {
            return "{\"a\":[\"a1\",\"a2\"],\"c\":[\"c1\",\"c2\",\"c3\"],\"r\":[\"r1\",\"r2\"]}";
        }

        private string GetBitProofAJson()
        {
            return "{\"BitProof\":[{\"a\":[\"a1\",\"a2\"],\"c\":[\"c1\",\"c2\",\"c3\"],\"r\":[\"r1\",\"r2\"]},{\"a\":[\"a1\",\"a2\"],\"c\":[\"c1\",\"c2\",\"c3\"],\"r\":[\"r1\",\"r2\"]}],\"CompositionProof\":{\"b\":[\"b1\",\"b2\"],\"rNeq\":[\"rn1\",\"rn2\",\"rn3\"],\"rEq\":[\"r1\",\"r2\"]}}";
        }

        private string GetCompositionProofJson()
        {
            return "{\"b\":[\"b1\",\"b2\"],\"rNeq\":[\"rn1\",\"rn2\",\"rn3\"],\"rEq\":[\"r1\",\"r2\"]}";
        }

        private string GetDescGqJson()
        {
            return "{\"type\":\"1.3.6.1.4.1.311.75.1.2.1\",\"name\":\"named\"}";
        }

        private string GetFullRangeProofJson()
        {
            return "{\"b\":[\"b1\",\"b2\"],\"rNeq\":[\"rn1\",\"rn2\",\"rn3\"],\"rEq\":[\"r1\",\"r2\"]}";
        }

        private string GetGroupJson()
        {
            return "{\"type\":\"groupType\",\"name\":\"groupName\"}";
        }

        private string GetGroupElementDevicePublicKeyJson()
        {
            return "{\"i\":{\"IsEven\":true,\"BitCount\":10,\"BitLength\":23,\"IntValue\":6382179,\"LongValue\":6382179,\"SignValue\":1},\"p\":{\"IsEven\":true,\"BitCount\":10,\"BitLength\":23,\"IntValue\":6382179,\"LongValue\":6382179,\"SignValue\":1}}";
        }

        private string GetOrEqualProofJson()
        {
            return "{\"a\":[\"a0\",\"a1\",\"a2\"],\"c\":[\"c1\",\"c2\",\"c3\"],\"r\":[\"r1\",\"r2\"]}";
        }

        private string GetProofJson()
        {
            return "{\"D\":[\"D1\"],\"a\":\"hYXWF42XcGyRcPNFU0GL4C9mxPrGDvQztTsghPfNso8=\",\"ap\":\"ap1\",\"Ps\":\"Ps1\",\"r\":[\"+vAkqmF18Egr2hWcA2y1fmuN8+4dhE6GLAs7871X1k=\",\"52huB9NY4GIdrvN2yx4jFx6h3mOQwbRZ9sndoxxsuA=\",\"3aN5sTKHSNLqwttuYHc4MxCuG++6DCLpqvCTXW15wU=\",\"WHiLq9RycLGNPRaYkqpn1jqqS164xXROabEA9nr9VWQ=\"],\"tc\":[\"BMf+XbYMmiE1TsNQdiGM1QIbF+jcE0UACcmiJsFBVxsomri9KEFHsF8P6wRiGSmTe4AcCJCN6H+NELm+INKfZw=\"],\"ta\":[\"Wc206GILzkZIvNkmirVA8NM1fKBgkQEypFohdoddxQ8=\"],\"tr\":[\"CUatA5mNd8l2STBVel+9W+EQqPFJkhie03D1Ojh3LxI=\"],\"requirements\":{\"disclosedAttributes\":[2],\"committedAttributes\":[3],\"message\":\"bm9ybWFsbWVzc2FnZQ==\",\"deviceMessage\":\"ZGV2aWNlbWVzc2FnZQ==\",\"scope\":\"c2NvcGVtZXNzYWdl\"}}";
        }

        private string GetProofRequirementsJson()
        {
            return "{\"disclosedAttributes\":[2],\"committedAttributes\":[3],\"message\":\"bm9ybWFsbWVzc2FnZQ==\",\"deviceMessage\":\"ZGV2aWNlbWVzc2FnZQ==\",\"scope\":\"c2NvcGVtZXNzYWdl\"}";
        }

        private string GetRangeProofJson()
        {
            return "{\"A\":[\"BJLJJ8Zbnn0VdNVkJ8utkdCQ+JjCnwK4Xkgx9wHlxV54gaMVSoja2STUAPvoEGn6ClpW2gCoaIuRVHUjuLuOI=\",\"BPWeMY59NdAvgn5PdKRdezVBSNyz0KIr1bkSs4feKAR3C4PZzVFxAnV62wcuBm5ZbYcSKkqMZ25OOfjiQUkPq0=\"],\"D\":[\"BMWrDGbeHOQboFeFCbq1Ir28ePS5tl++pGlvvX1p+R+sQEYb3Zf7xdOl8DphUqrn2ClJWKYdSb3SdXN0A6bVVU=\",\"BNg1J7oZmrbw2WJz3zrj8TQQtDeDDCxKXw84pRCQirO7rNJHQa9Z17uUj4gyjRhgXZqlpYTAJQOZbhzNg8=\"],\"X\":[\"BBXqtIufXh6hr6593VQMx4GYYqsiXtR7I1uMjLCLc2r0ksSg6CFdHImhOczX77oqN3J1pGz38Qc1uGRmZ79qe8=\",\"BJufExOSivyEhUXPcv4Bchhyccx1+CTwChSRH5pKaiuNYXMDWfpwZg8KkyTfLKAi3W98x74zhqbhb7iPLqtm4=\"],\"minBirthYear\":1900,\"maxBirthYear\":2026,\"targetDate\":\"04.10.2002 00:00:00\",\"verifiersRangeProofId\":0,\"rangeProofType\":\">\",\"commitmentIndex\":2}";
        }

        private string GetSetMembershipProofJson()
        {
            return "{\"a\":[\"BL+eEGZkH+LTSt696eFCqV0EuoEmpgUrWFpraOyjhzO5fL4GBErYP3UaztQ7WYCIoMmqdIT+dKCcaXwDfsiEXe8=\",\"BMbBmCcCXYNDxNAbsMw6Y6URT2eBFVib+GS49crEN6kpuMOowNmnYbbwVbzycPHYF8kGQOOr+OoUSAXANEOwg=\"],\"c\":[\"msfpjhC7w2KGODJEaSdumk4bYLA8XPNOfgKnJTq8Ohs=\",\"PX9cABa62+BIEELNnlEQse+V1hAO3Iq6NzZVyZfHprc=\"],\"r\":[\"LCGM81HDk35XBvxqXY5oNz3r81cghhxeiEEoTST2pGY=\",\"gA3wseN8g51G0oQoGJgKCnqiVGNj1PpsJyYccPnocI=\",\"Hv2igTH3jAYCksUItstqCCE53PmS4e9YNRhgS5PYTwc=\"],\"setValues\":[\"RVRI\",\"QkZI\",\"VW5pQmVybg==\"],\"commitmentIndex\":2,\"verifiersSetMembershipProofId\":0}";
        }

        private string GetStrictProofJson()
        {
            return "{\"b\":[\"b1\",\"b2\",\"b3\"],\"rNeq\":[\"rNeg1\",\"rNeg2\"],\"rEq\":[\"rEq1\",\"rEq2\"]}";
        }


        private BitProof GetBitProofObject()
        {
            return new BitProof()
            {
                a = new List<string>() {  "a1", "a2" },
                c = new List<string>() { "c1", "c2", "c3" },
                r = new List<string>() { "r1", "r2" }
            };
        }

        private BitProofA GetBitProofAObject()
        {
            return new BitProofA()
            {
                BitProof = new List<BitProof>() { GetBitProofObject(), GetBitProofObject() },
                CompositionProof = GetCompositionProofObject()
            };
        }

        private CompositionProof GetCompositionProofObject()
        {
            return new CompositionProof()
            {
                b = new List<string>() { "b1", "b2" },
                rEq = new List<string>() { "r1", "r2" },
                rNeq =  new List<string>() { "rn1", "rn2", "rn3" }
            };
        }

        private DescGq GetDescGqObject()
        {
            return new DescGq()
            {
                name = "named",
                type = "1.3.6.1.4.1.311.75.1.2.1"
            };
        }

        private FullRangeProof GetFullRangeProofObject()
        {
            return new FullRangeProof()
            {
                b = new List<string>() { "b1", "b2" },
                rEq = new List<string>() { "r1", "r2" },
                rNeq = new List<string>() { "rn1", "rn2", "rn3" }
            };
        }

        private Group GetGroupObject()
        {
            return new Group()
            {
                name = "groupName",
                type = "groupType"
            };
        }

        private GroupElementDevicePublicKey GetGroupElementDevicePublicKeyObject()
        {
            return new GroupElementDevicePublicKey()
            {
                i = new Org.BouncyCastle.Math.BigInteger(encoding.GetBytes("abc")),
                p = new Org.BouncyCastle.Math.BigInteger(encoding.GetBytes("abc"))
            };
        }

        private OrEqualProof GetOrEqualProofObject()
        {
            return new OrEqualProof()
            {
                a = new List<string>() { "a0", "a1", "a2" },
                c = new List<string>() { "c1", "c2", "c3" },
                r = new List<string>() { "r1", "r2" }
            };
        }

        private Proof GetProofObject()
        {
            // ProofRequirements already tested
            return new Proof()
            {
                D = new List<string>() { "D1" },
                a = "hYXWF42XcGyRcPNFU0GL4C9mxPrGDvQztTsghPfNso8=",
                r = new List<string>() { "+vAkqmF18Egr2hWcA2y1fmuN8+4dhE6GLAs7871X1k=", "52huB9NY4GIdrvN2yx4jFx6h3mOQwbRZ9sndoxxsuA=", "3aN5sTKHSNLqwttuYHc4MxCuG++6DCLpqvCTXW15wU=", "WHiLq9RycLGNPRaYkqpn1jqqS164xXROabEA9nr9VWQ=" },
                tc = new List<string>() { "BMf+XbYMmiE1TsNQdiGM1QIbF+jcE0UACcmiJsFBVxsomri9KEFHsF8P6wRiGSmTe4AcCJCN6H+NELm+INKfZw=" },
                ta = new List<string>() { "Wc206GILzkZIvNkmirVA8NM1fKBgkQEypFohdoddxQ8=" },
                tr = new List<string>() { "CUatA5mNd8l2STBVel+9W+EQqPFJkhie03D1Ojh3LxI=" },
                ap = "ap1",
                Ps = "Ps1",
                requirements = GetProofRequirementsObject()
            };
        }

        private ProofRequirements GetProofRequirementsObject()
        {
            return new ProofRequirements()
            {
                disclosedAttributes = new int[] { 2 },
                committedAttributes = new int[] { 3 },
				message = encoding.GetBytes("normalmessage"),
                deviceMessage = encoding.GetBytes("devicemessage"),
                scope = encoding.GetBytes("scopemessage")
            };
        }

        private RangeProof GetRangeProofObject()
        {
            // BitProof, FullRangeProof, OrEqualProof, Group, StrictProof were already tested

            return new RangeProof()
            {
                A = new List<string> { "BJLJJ8Zbnn0VdNVkJ8utkdCQ+JjCnwK4Xkgx9wHlxV54gaMVSoja2STUAPvoEGn6ClpW2gCoaIuRVHUjuLuOI=", "BPWeMY59NdAvgn5PdKRdezVBSNyz0KIr1bkSs4feKAR3C4PZzVFxAnV62wcuBm5ZbYcSKkqMZ25OOfjiQUkPq0=" },
				D = new List<string>() { "BMWrDGbeHOQboFeFCbq1Ir28ePS5tl++pGlvvX1p+R+sQEYb3Zf7xdOl8DphUqrn2ClJWKYdSb3SdXN0A6bVVU=", "BNg1J7oZmrbw2WJz3zrj8TQQtDeDDCxKXw84pRCQirO7rNJHQa9Z17uUj4gyjRhgXZqlpYTAJQOZbhzNg8=" },
				X = new List<string>() { "BBXqtIufXh6hr6593VQMx4GYYqsiXtR7I1uMjLCLc2r0ksSg6CFdHImhOczX77oqN3J1pGz38Qc1uGRmZ79qe8=", "BJufExOSivyEhUXPcv4Bchhyccx1+CTwChSRH5pKaiuNYXMDWfpwZg8KkyTfLKAi3W98x74zhqbhb7iPLqtm4=" },
				minBirthYear = 1900,
				maxBirthYear =2026,
				targetDate = "04.10.2002 00:00:00",
                verifiersRangeProofId = 0,
				rangeProofType = ">",
				commitmentIndex = 2
            };
        }

        private SetMembershipProof GetSetMembershipProofObject()
        {
            // Group already tested

            return new SetMembershipProof()
            {
                a = new List<string>() { "BL+eEGZkH+LTSt696eFCqV0EuoEmpgUrWFpraOyjhzO5fL4GBErYP3UaztQ7WYCIoMmqdIT+dKCcaXwDfsiEXe8=", "BMbBmCcCXYNDxNAbsMw6Y6URT2eBFVib+GS49crEN6kpuMOowNmnYbbwVbzycPHYF8kGQOOr+OoUSAXANEOwg=" },
                c = new List<string>() { "msfpjhC7w2KGODJEaSdumk4bYLA8XPNOfgKnJTq8Ohs=", "PX9cABa62+BIEELNnlEQse+V1hAO3Iq6NzZVyZfHprc=" },
                r = new List<string>() { "LCGM81HDk35XBvxqXY5oNz3r81cghhxeiEEoTST2pGY=", "gA3wseN8g51G0oQoGJgKCnqiVGNj1PpsJyYccPnocI=", "Hv2igTH3jAYCksUItstqCCE53PmS4e9YNRhgS5PYTwc=" },
                setValues = new byte[][] { encoding.GetBytes("ETH"), encoding.GetBytes("BFH"), encoding.GetBytes("UniBern") },
                commitmentIndex = 2,
                verifiersSetMembershipProofId = 0
            };
        }

        private StrictProof GetStrictProofObject()
        {
            return new StrictProof()
            {
                b = new List<string>() { "b1", "b2", "b3" },
                rNeq = new List<string>() { "rNeg1", "rNeg2" },
                rEq = new List<string>() { "rEq1", "rEq2" }
            };
        }

        #endregion private methods
    }
}
