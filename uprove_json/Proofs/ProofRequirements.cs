
namespace uprove_json.Proofs
{
    /// <summary>
    /// defines the requirements of a proof
    /// this class is used for exchange the chosen information - by the prover - to the issuer
    /// </summary>
    public class ProofRequirements
    {
        public int[] disclosedAttributes { get; set; }

        public int[] committedAttributes { get; set; }

        public byte[] message { get; set; }

        public byte[] deviceMessage { get; set; }

        public byte[] scope { get; set; }
    }
}
