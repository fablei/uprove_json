using System.Collections.Generic;

namespace uprove_json.VerifierAuthenticationCredentials
{
    /// <summary>
    /// represents a memberlist from the verifier and is used for the setmembership proof and
    /// intrepreted by the prover
    /// </summary>
    public class VerifierMembers
    {
        public int verifiersSetMembershipProofId { get; set; }
        public List<string> Members { get; set; }
        public string MemberAttribute { get; set; }
    }
}
