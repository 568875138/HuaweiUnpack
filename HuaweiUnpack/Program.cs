using HuaweiUpdateLibrary.Core;

namespace HuaweiUnpack
{
    static class Program
    {
        static void Main(string[] args)
        {
            var u = UpdateFile.Open(@args[0]);
            for (int i = 0; i < 100; i++)
            {
                u.Extract(i, @args[0] + "-" + i + ".fs");
            }
        }
    }
}
