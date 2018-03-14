using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uprove_json.Message
{
    /// <summary>
    ///  for more details see JWT https://tools.ietf.org/html/rfc7519
    /// </summary>
    public class JwtPayload
    {
        public string iss { get; set; }

        public string sub { get; set; }

        public string aud { get; set; }

        public string exp { get; set; }

        public string nbf { get; set; }

        public string iat { get; set; }

        public string jti { get; set; }

        // extension for communicating over the network
        public List<BasicClaim> claims { get; set; }
        public bool deviceProtected { get; set; }
        public FirstMessage firstMessage { get; set; }
        public SecondMessage secondMessage { get; set; }
        public ThirdMessage thirdMessage { get; set; }
        public string deviceMessage { get; set; }
        public string message { get; set; }
    }
}
