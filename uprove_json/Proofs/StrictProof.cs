using System.Collections.Generic;

namespace uprove_json.Proofs
{
    /// <summary>
    /// represents the strictproof from uprove
    /// </summary>
    public class StrictProof
    {
        public List<string> b { get; set; }
        public List<string> rNeq { get; set; }
        public List<string> rEq { get; set; }   // TODO was List<object> but I thought this is maybe wrong
    }
}
