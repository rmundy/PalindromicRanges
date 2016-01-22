namespace PalindromicRanges
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Program Class
    /// </summary>
    public sealed class Program
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(String[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
            {
                while (!reader.EndOfStream)
                {
                    String line = reader.ReadLine();
                    if (null == line)
                    {
                        continue;
                    }
                    else
                    {

                    }
                }
            }                
        }
    }
}
