using BCBigInt = Org.BouncyCastle.Math.BigInteger;

namespace uprove_json.Proofs
{
    /// <summary>
    /// represents the groupelementdevicepublickey from uprove
    /// </summary>
    public class GroupElementDevicePublicKey
    {
        public BCBigInt i { get; set; }
        public BCBigInt p { get; set; }
    }
}
