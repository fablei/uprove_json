using System.Collections.Generic;

namespace uprove_json.IssuerVerification
{
    /// <summary>
    /// represents a list with trusted issuers from the verifier
    /// </summary>
    public class TrustedIssuerList
    {
        public List<IP> issuers { get; set; }
    }
}
