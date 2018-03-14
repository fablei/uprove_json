using System.Collections.Generic;

namespace uprove_json.Message
{
    /// <summary>
    /// represents the firstmessage from uprove
    /// </summary>
    public class FirstMessage
    {
        public string sz { get; set; }
        public List<string> sa { get; set; }
        public List<string> sb { get; set; }
    }
}
