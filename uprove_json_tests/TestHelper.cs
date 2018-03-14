using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using uprove_json;
using uprove_json.IssuerVerification;
using uprove_json.Proofs;

namespace uprove_json_tests
{
    public class TestHelper
    {

        public void TestIP(IP expected, IP result)
        {
            Assert.AreEqual(expected.uidp, result.uidp);
            Assert.AreEqual(expected.uidh, result.uidh);
            Assert.AreEqual(expected.descGq.name, result.descGq.name);
            Assert.AreEqual(expected.descGq.type, result.descGq.type);
            Assert.AreEqual(expected.g.Count, result.g.Count);
            for (int i = 0; i < expected.g.Count; i++)
                Assert.AreEqual(expected.g[i], result.g[i]);
            Assert.AreEqual(expected.e, result.e);
            Assert.AreEqual(expected.s, result.s);
            Assert.AreEqual(expected.MaxNumberOfAttributes, result.MaxNumberOfAttributes);
        }

        public IP GetIPObject()
        {
            return new IP()
            {
                uidp = "c2FtcGxlIHNldCBtZW1iZXJzaGlwIGlzc3Vlcg==",
                uidh = "SHA-256",
                descGq = new DescGq() { name = "1.3.6.1.4.1.311.75.1.2.1", type = "named" },
                g = new List<string>() { "BLR7tc2wJQesN3PkMZWIP5lnyPKNLo7LtnklC35jTmDPbfitX9Y1qPSgqs753LAs7MYYUfwE9ES9jNcHdnKI1ss=" },
                e = "AQEB",
                s = "YXBwbGljYXRpb24tc3BlY2lmaWMgc3BlY2lmaWNhdGlvbg==",
                MaxNumberOfAttributes = 3
            };
        }

        public string GetIPJson()
        {
            return "{\"uidp\":\"c2FtcGxlIHNldCBtZW1iZXJzaGlwIGlzc3Vlcg==\",\"descGq\":{\"type\":\"named\",\"name\":\"1.3.6.1.4.1.311.75.1.2.1\"},\"uidh\":\"SHA-256\",\"g\":[\"BLR7tc2wJQesN3PkMZWIP5lnyPKNLo7LtnklC35jTmDPbfitX9Y1qPSgqs753LAs7MYYUfwE9ES9jNcHdnKI1ss=\"],\"e\":\"AQEB\",\"s\":\"YXBwbGljYXRpb24tc3BlY2lmaWMgc3BlY2lmaWNhdGlvbg==\",\"MaxNumberOfAttributes\":3}";
        }


        public void TestBasicClaim(BasicClaim expected, BasicClaim result)
        {
            Assert.AreEqual(expected.name, result.name);
            Assert.AreEqual(expected.values.Count, result.values.Count);
            for (int i = 0; i < expected.values.Count; i++)
                Assert.AreEqual(expected.values[i], result.values[i]);

            Assert.AreEqual(expected.propertiesbase64encoded.ToString(), result.propertiesbase64encoded.ToString());
            Assert.AreEqual(expected.qualitylevel, result.qualitylevel);
            Assert.AreEqual(expected.valuesbase64encoded.ToString(), result.valuesbase64encoded.ToString());
            Assert.AreEqual(expected.essential, result.essential);

            Assert.AreEqual(expected.requestedqualitylevels.Count, result.requestedqualitylevels.Count);
            for (int i = 0; i < expected.requestedqualitylevels.Count; i++)
                Assert.AreEqual(expected.requestedqualitylevels[i], result.requestedqualitylevels[i]);
        }

        public void CompareList<T>(List<T> expected, List<T> result)
        {
            Assert.AreEqual(expected.Count, result.Count);
            for (int i = 0; i < expected.Count; i++)
                Assert.AreEqual(expected[i], result[i]);
        }

        public void CompareArray<T>(T[] expected, T[] result)
        {
            Assert.AreEqual(expected.Length, result.Length);
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], result[i]);
        }



        public string ReadFile(string filename)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Files\" + filename + ".txt");
            string[] files = File.ReadAllLines(path);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < files.Length; i++)
                sb.Append(files[i].ToString().Trim());

            return sb.ToString();
        }

    }
}
