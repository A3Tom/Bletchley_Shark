using System.ComponentModel;

namespace BletchleyShark.Encryption.Domain.Models;
public enum KeyGenerationAlgorithm
{
    [Description("Diffie-Hellman")]
    DiffieHellman,

    [Description("Elliptic-Curve Diffie-Hellman")]
    EC_DiffieHellman
}
