using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace swatch.Core.DataAccess
{
    public static class CompressionHelper
    {
        public static string Serialize(object input)
        {
            return JsonConvert.SerializeObject(input);
        }

        public static T Deserialize<T>(string input)
        {
            return JsonConvert.DeserializeObject<T>(input);
        }

        public static byte[] Compress(string input)
        {
            var inputBuffer = Encoding.Unicode.GetBytes(input);
            using (var inputStream = new MemoryStream(inputBuffer))
            using (var outputStream = new MemoryStream())
            {
                using (var compressor = new GZipStream(outputStream, CompressionMode.Compress))
                {
                    Copy(inputStream, compressor);
                }
                return outputStream.ToArray();
            }
        }

        public static string Decompress(byte[] input)
        {
            using (var inputStream = new MemoryStream(input))
            using (var outputStream = new MemoryStream())
            {
                using (var compressor = new GZipStream(inputStream, CompressionMode.Decompress))
                {
                    Copy(compressor, outputStream);
                }
                var result = Encoding.Unicode.GetString(outputStream.ToArray());
                return result;
            }
        }

        private static void Copy(Stream source, Stream destination)
        {
            var bytesBuffer = new List<byte>();
            int count;
            while ((count = source.Read(bytesBuffer.ToArray(), 0, bytesBuffer.Count)) != 0)
            {
                destination.Write(bytesBuffer.ToArray(), 0, count);
            }
        }
    }
}
