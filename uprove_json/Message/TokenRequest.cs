using System.Collections.Generic;

namespace uprove_json.Message
{
    public class TokenRequest
    {
        /// <summary>
        /// requested claim by prover or verifier
        /// </summary>
        public List<BasicClaim> requestedclaims { get; set; }

        /// <summary>
        /// number of tokens the prover want to create together with the issuer
        /// </summary>
        public int numberoftokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ti { get; set; }
    }
}
