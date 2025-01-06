using System.Security.Cryptography;
using System.Text;

namespace EnKdev.ItemTrackers.Core.Internal;

/// <summary>
/// A helper class for cryptographic operations, including encryption, decryption,
/// and encoding/decoding transformations.
/// </summary>
/// <remarks>
/// This class provides static methods for securely encrypting and decrypting text data
/// and transforming between different data formats (e.g., string to byte array and vice versa).
/// It is intended for internal use within the library.
/// </remarks>
internal static class CryptoHelper
{
    private static byte[] _keyBytes;
    private static byte[] _ivBytes;

    static CryptoHelper()
    {
        _keyBytes =
        [
            0x00, 0x02, 0x04, 0x06, 0x08, 0x0A,
            0x0C, 0x0E, 0x10, 0x12, 0x14, 0x16,
            0x18, 0x1A, 0x1C, 0x1E
        ];
        
        _ivBytes =
        [
            0x00, 0x04, 0x08, 0x0C, 0x10, 0x14,
            0x18, 0x1C, 0x20, 0x24, 0x28, 0x2C,
            0x30, 0x34, 0x38, 0x3C
        ];
    }

    /// <summary>
    /// Decodes the input hexadecimal cipher text, decrypts it using AES, and returns the plaintext string.
    /// </summary>
    /// <param name="cipherText">The hexadecimal string representing the encrypted data.</param>
    /// <returns>The decrypted plaintext string.</returns>
    public static string DecodeAndDecrypt(string cipherText)
    {
        var plainText = AesDecrypt(StringToByteArray(cipherText));

        return plainText;
    }

    /// <summary>
    /// Encrypts the plaintext string using AES and encodes the encrypted data into a hexadecimal string.
    /// </summary>
    /// <param name="plainText">The plaintext string to be encrypted.</param>
    /// <returns>A hexadecimal string representing the encrypted data.</returns>
    public static string EncryptAndEncode(string plainText) => ByteArrayToHexString(AesEncrypt(plainText));

    private static string ByteArrayToHexString(byte[] arr) => BitConverter.ToString(arr).Replace("-", "");
    private static byte[] StringToByteArray(string hex) => Enumerable.Range(0, hex.Length)
        .Where(x => x % 2 == 0)
        .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
        .ToArray();

    private static byte[] AesEncrypt(string input)
    {
        var inputBytes = Encoding.UTF8.GetBytes(input);
        
        using var ms = new MemoryStream();
        using var cs = new CryptoStream(ms, GetCryptoAlg().CreateEncryptor(_keyBytes, _ivBytes), CryptoStreamMode.Write);

        cs.Write(inputBytes, 0, inputBytes.Length);
        cs.FlushFinalBlock();
        
        return ms.ToArray();
    }

    private static string AesDecrypt(byte[] input)
    {
        var output = input;

        using var ms = new MemoryStream(output);
        using var cs = new CryptoStream(ms, GetCryptoAlg().CreateDecryptor(_keyBytes, _ivBytes), CryptoStreamMode.Read);
        using var sr = new StreamReader(cs);

        var plainText = sr.ReadToEnd();

        return plainText;
    }

    private static Aes GetCryptoAlg()
    {
        var alg = Aes.Create();
        alg.Padding = PaddingMode.PKCS7;
        alg.Mode = CipherMode.CBC;
        alg.KeySize = 128;
        alg.BlockSize = 128;

        return alg;
    }
}