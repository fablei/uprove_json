using System.Collections.Generic;

namespace uprove_json.Proofs
{
    /// <summary>
    /// represents the proof from uprove
    /// </summary>
    public class Proof
    {
        public List<string> D { get; set; }
        public string a { get; set; }
        public string ap { get; set; }
        public string Ps { get; set; }
        public List<string> r { get; set; }
        public List<string> tc { get; set; }
        public List<string> ta { get; set; }
        public List<string> tr { get; set; }

        public int na { get; set; }
        /// <summary>
        /// defines the requirements from this proof
        /// </summary>
        public ProofRequirements requirements { get; set; }
    }
}
