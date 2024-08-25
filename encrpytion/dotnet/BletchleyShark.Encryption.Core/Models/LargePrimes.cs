namespace BletchleyShark.Encryption.Domain.Models;
public static class LargePrimes
{
    private readonly static int[] _primes =
    [
        1_037_252_497,
        1_037_256_617,
        1_037_256_629,
        1_037_256_643,
        1_037_256_733,
        1_037_256_739,
        1_037_256_743,
        1_037_256_761,
        1_037_256_763,
        1_037_256_791,
        1_037_256_809,
        1_854_168_551,
        1_854_959_423,
        1_866_428_261,
        2_016_640_643,
        2_025_198_943
    ];

    private readonly static Random _rnd = new();

    public static int GetRandom32BitPrime() => _primes[_rnd.Next(0, _primes.Length)];
}
