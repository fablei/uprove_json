namespace uprove_json.VerifierAuthenticationCredentials
{
    /// <summary>
    /// contains the information to create a range proof, used from the verifier to initiate
    /// and interpreted by the prover
    /// </summary>
    public class VerifierRanges
    {
        public int verifiersRangeProofId { get; set; }
        public int number { get; set; }
        public string rangeProofType { get; set; }
        public string rangeProofAttribute { get; set; }
        public int sibling { get; set; } // if there is no sibling, set -1

        //public int Start { get; set; }
        //public string StartSymbol { get; set; }
        //public int End { get; set; }
        //public string EndSymbol { get; set; }
        //public string RangeAttribute { get; set; }
    }
}
