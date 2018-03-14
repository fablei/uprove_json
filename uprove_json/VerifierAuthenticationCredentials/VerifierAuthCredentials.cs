using System;
using System.Collections.Generic;

namespace uprove_json.VerifierAuthenticationCredentials
{
    public class VerifierAuthCredentials
    {
        /// <summary>
        /// lists all mandatory attibutes for accessing to this service
        /// e.g [ "givenName", "surname", .. ]
        /// </summary>
        public List<String> MandatoryAttributes { get; set; }
        
        /// <summary>
        /// lists all optional attributes for accessing to this service
        /// e.g [ "dob", .. ]
        /// </summary>
        public List<String> OptionalAttributes { get; set; }

        /// <summary>
        /// lists all feasible rangeproof, which could be used for accessing to this service
        /// e.g [ { "Start" : 14, "StartSymbol" : "<=", "End" : 18, "EndSymbol" : "<" } ]
        /// </summary>
        public List<VerifierRanges> Ranges { get; set; }

        /// <summary>
        /// lists all feasible setmembership lists, which could be used for accessing to this service
        /// e.g [ { "List" : [ "BFH", "ETH", .. ], "MemberAttribute" : "swissEduPersonHomeOrganization" }, { .. } ]
        /// </summary>
        public List<VerifierMembers> Members { get; set; }

        /// <summary>
        /// defines if the prover wants to protect his soft token (json) with a hard token
        /// true -> prover needs a hard token, false -> there is no hard token needed
        /// </summary>
        public bool WantHardTokenAuthenticated { get; set; }

        /// <summary>
        /// defines the domain of the verifier - used for validation reasons
        /// e.g  www.example-domain.ch
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// contains the public certificate of the signed certificate -> needs to be validated
        /// </summary>
        public string Certificate { get; set; }

        /// <summary>
        /// contains the signature of the verifierauthcredential object, signed by the verifiers certificate
        /// e.g TXkwexL...
        /// </summary>
        public string Signature { get; set; }

        /// <summary>
        /// contains the timestamp (in seconds) of the creation date
        /// e.g 1517003807
        /// </summary>
        public int Created { get; set; }                       // 06.12.2016
    }
}
