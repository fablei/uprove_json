using System.Collections.Generic;

namespace uprove_json
{
    public class BasicClaim
    {
        /// <summary>
        /// name of the claim e.g surname, givenName
        /// </summary>
        public string name { get; set; }
        
        /// <summary>
        /// values of the claim e.g Alice John
        /// </summary>
        public List<string> values { get; set; }
        
        /// <summary>
        /// base64 encoded values
        /// </summary>
        public byte[] valuesbase64encoded { get; set; }
        
        /// <summary>
        /// base64 encoded properties, formed as follow
        /// { "name" : "namevalues", "qualitylevel" : "qualitylevelvalue", .. }
        /// </summary>
        public byte[] propertiesbase64encoded { get; set; }

        /// <summary>
        /// holds the quality of this claim; e.g eCH-0171
        /// </summary>
        public string qualitylevel { get; set; }

        /// <summary>
        /// contains the requested quality levels; quaility levels e.g qualitylevel
        /// could hold a set of feasible qualities, if so, the values appearing in order of preference
        /// </summary>
        public List<string> requestedqualitylevels { get; set; }

        /// <summary>
        /// defines if the claim is mandatory or optional
        /// </summary>
        public bool essential { get; set; }
    }
}
