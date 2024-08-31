using System.Numerics;

namespace BletchleyShark.Encryption.Application.Strategy.KeyGeneration;
public static class DiffieHellmanKeyGenerationStrategy
{
    public static BigInteger GeneratePublicTransportValue(BigInteger publicBase, BigInteger partySecret, BigInteger publicModulus) => BigInteger.ModPow(publicBase, partySecret, publicModulus);

    public static BigInteger GenerateCommonSecretKey(BigInteger incomingTransportValue, BigInteger partySecret, BigInteger publicModulus) => BigInteger.ModPow(incomingTransportValue, partySecret, publicModulus);
}
