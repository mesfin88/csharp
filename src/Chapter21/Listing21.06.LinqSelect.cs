// TODO: Update listing in Manuscript
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_06
{
    using AddisonWesley.Michaelis.EssentialCSharp.Shared;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        // ...
        public static List<string>
          Encrypt(IEnumerable<string> data)
        {
            return data.Select(
                item => Program.Encrypt(item)).ToList();
        }

        // ...

        private static string Encrypt(string item)
        {
            Console.WriteLine($">>>>>Encrypting '{ item }'.");
            Cryptographer cryptographer = new Cryptographer();
            string itemEncrypted = System.Text.Encoding.UTF8.GetString(cryptographer.Encrypt(item));
            Console.WriteLine($"<<<<<Finished encrypting '{ itemEncrypted }'.");
            return itemEncrypted;
        }
    }
}


