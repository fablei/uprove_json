using System.Collections.Generic;

namespace uprove_json.Proofs
{
    /// <summary>
    /// represents the bitproof from uprove
    /// </summary>
    public class BitProof
    {
        public List<string> a { get; set; }
        public List<string> c { get; set; }
        public List<string> r { get; set; }
    }
}
