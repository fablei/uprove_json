using System.Collections.Generic;

namespace uprove_json.Proofs
{
    /// <summary>
    /// represents the fullrangeproof from uprove
    /// </summary>
    public class FullRangeProof
    {
        public List<string> b { get; set; }
        public List<string> rNeq { get; set; }
        public List<string> rEq { get; set; }
    }
}
