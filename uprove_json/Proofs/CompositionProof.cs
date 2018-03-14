using System.Collections.Generic;

namespace uprove_json.Proofs
{
    /// <summary>
    /// represents the compositionproof from uprove
    /// </summary>
    public class CompositionProof
    {
        public List<string> b { get; set; }
        public List<string> rNeq { get; set; }
        public List<string> rEq { get; set; }
    }
}
