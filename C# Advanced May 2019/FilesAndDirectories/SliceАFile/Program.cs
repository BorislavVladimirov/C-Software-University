using System;
using System.IO;

namespace SliceАFile
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var inputFile = new FileStream(@"Slice File\sliceMe.txt", FileMode.Open))
            {
                long size = inputFile.Length;
                int partSize = (int)Math.Ceiling((double)size / 4);
                byte[] buffer = new byte[partSize];

                for (int i = 1; i <= 4; i++)
                {
                    using (var outputFIle = new FileStream($"Slice File\\Part-{i}.txt", FileMode.Create))
                    {
                        int readedBytes = inputFile.Read(buffer, 0, partSize);
                        outputFIle.Write(buffer, 0, readedBytes);
                    }                    
                }
            }
        }
    }
}
