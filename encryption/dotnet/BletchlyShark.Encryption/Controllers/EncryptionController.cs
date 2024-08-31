using BletchleyShark.Encryption.API.Controllers.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BletchleyShark.Encryption.API.Controllers;

public class EncryptionController : BaseController
{
    [HttpPost("XOREncrypt")]
    public IActionResult XOREncrypt([FromBody] string message, [FromQuery] int key)
    {
        var message_b2 = message
            .Select(x => $"{x}: {Convert.ToString(x, 2).PadLeft(8, '0')}")
            .ToList();

        string[] x32_string = new string[Convert.ToInt32(Math.Ceiling(message.Length / 4m))];
        string[] x32_string_encrypted = new string[x32_string.Length];

        var sw = new Stopwatch();

        sw.Start();

        for (int i = 0; i < x32_string.Length; i++)
        {
            var messageIdx = i * 4;

            var maxLookAhead = message.Length - messageIdx + 2 > 4 ? 4 : message.Length - messageIdx;
            int rowInt = 0;

            for (int j = 0; j < maxLookAhead; j++)
                rowInt |= message[messageIdx + j] << (j * 8);

            var rowEnc = rowInt ^ key;

            x32_string[i] = Convert.ToString(rowInt, 2).PadLeft(32, '0');
            x32_string_encrypted[i] = Convert.ToString(rowEnc, 2).PadLeft(32, '0');
        }

        sw.Stop();

        var result = new
        {
            TimeElapsed_MS = sw.ElapsedMilliseconds,
            OgMessage = message,
            OgMessageBinary = message_b2,
            Key = key,
            Mask = Convert.ToString(key, 2).PadLeft(32, '0'),
            x32String = x32_string,
            x32StringEncrypted = x32_string_encrypted,
        };

        return Ok(result);
    }

    //private static int CombineNext4Bits(int loopIndex, string message)
    //{
    //    var messageIdx = loopIndex * 4;

    //    var maxLookAhead = message.Length - messageIdx + 2 > 4 ? 4 : message.Length - messageIdx;
    //    int rowInt = 0;

    //    for (int j = 0; j < maxLookAhead; j++)
    //        rowInt |= message[messageIdx + j] << (j * 8);

    //    return rowInt;
    //}
}
