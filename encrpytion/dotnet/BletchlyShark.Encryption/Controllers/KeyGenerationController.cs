using BletchleyShark.Encryption.API.Controllers.Abstract;
using BletchleyShark.Encryption.Application.Strategy.KeyGeneration;
using BletchleyShark.Encryption.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BletchleyShark.Encryption.API.Controllers;

public class KeyGenerationController : BaseController
{
    [HttpGet("generate/32bitprime")]
    public IActionResult Generate32BitPrime()
    {
        var result = LargePrimes.GetRandom32BitPrime();
        return Ok(result);
    }

    [HttpGet("generate/DH/A")]
    public IActionResult DiffieHellmanPartA([FromQuery] int publicBase, [FromQuery] int partySecret, [FromQuery] int publicModulus) =>
        Ok(DiffieHellmanKeyGenerationStrategy.GeneratePublicTransportValue(publicBase, partySecret, publicModulus));

    [HttpGet("generate/DH/B")]
    public IActionResult DiffieHellmanPartB([FromQuery] int transportValue, [FromQuery] int partySecret, [FromQuery] int publicModulus) =>
        Ok(DiffieHellmanKeyGenerationStrategy.GenerateCommonSecretKey(transportValue, partySecret, publicModulus));
}
