using System.Collections.Generic;

namespace uprove_json.Proofs
{
    /// <summary>
    /// represents the setmembershipproof from uprove
    /// </summary>
    public class SetMembershipProof
    {
        public Group Group { get; set; }
        public List<string> a { get; set; }
        public List<string> c { get; set; }
        public List<string> r { get; set; }
        public byte[][] setValues { get; set; }
        public int commitmentIndex { get; set; }
        public int verifiersSetMembershipProofId { get; set; }
    }
}
