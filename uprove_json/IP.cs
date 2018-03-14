using System.Collections.Generic;
using uprove_json.Proofs;

namespace uprove_json
{
    /// <summary>
    /// represents the issuer parameter from uprove
    /// </summary>
    public class IP
    {
        public string uidp { get; set; }
        public DescGq descGq { get; set; }
        public string uidh { get; set; }
        public List<string> g { get; set; }
        public string e { get; set; }
        public string s { get; set; }

        /// <summary>
        /// defines the maximum feasible attributes in a uprove token
        /// -> important for the issuer
        /// </summary>
        public int MaxNumberOfAttributes { get; set; }
    }
}
