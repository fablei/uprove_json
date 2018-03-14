
namespace uprove_json.IssuerVerification
{
    /// <summary>
    /// represents an issuer and its private key, allows to create an issuer from an existing file (json)
    /// </summary>
    public class IssuerParameterWithPK
    {
        public IP ip { get; set; }
        public string privateKey { get; set; }
    }
}
