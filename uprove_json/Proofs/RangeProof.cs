using System.Collections.Generic;

namespace uprove_json.Proofs
{
    /// <summary>
    /// represents the rangeproof from uprove
    /// </summary>
    public class RangeProof
    {
        public Group Group { get; set; }
        public List<string> A { get; set; }
        public BitProofA BitProofA { get; set; }
        public List<string> D { get; set; }
        public FullRangeProof FullRangeProof { get; set; }
        public StrictProof StrictProof { get; set; }
        public OrEqualProof OrEqualProof { get; set; }
        public List<string> X { get; set; }
        public int minBirthYear { get; set; }
        public int maxBirthYear { get; set; }
        public string targetDate { get; set; }
        public int verifiersRangeProofId { get; set; }
        public string rangeProofType { get; set; }
        public int commitmentIndex { get; set; }
    }
}
