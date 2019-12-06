using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Razor.Extensions
{
    public static class StreamExtensions
    {

        public async static Task<string> GetStringAsync(this Stream stream)
        {
            string result = string.Empty;
            using(Stream receivedStream = stream)
            {
                using(StreamReader streamReader = new StreamReader(receivedStream, Encoding.UTF8))
                {
                    result = await streamReader.ReadToEndAsync();
                }
            }
            return result;
        }
    }
}
