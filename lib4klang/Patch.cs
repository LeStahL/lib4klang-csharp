using System;
using System.IO;

namespace Lib4klang
{
    public class Patch
    {
        public enum PatchType {
            Version10 = 0x30316b34,
            Version11 = 0x31316b34,
            Version12 = 0x32316b34,
            Version13 = 0x33316b34,
            Empty = 0x34316b34
        };

        public PatchType version;
        static Patch None = new Patch();

        public Patch()
        {
            this.version = PatchType.Empty;
        }

        public static Patch deserialize(string fileName)
        {
            Patch patch = new Patch();

            if(!File.Exists(fileName)) {
                throw new Exception("Could not deserialize: " + fileName + ". File does not exist.");
            }

            Stream fs = File.OpenRead(fileName);
            
            byte[] buf = new byte[1024];
            fs.Read(buf, 0, 1);
            patch.version = (PatchType) buf[0];

            return patch;
        }

        public void serialize(string fileName)
        {

        }
    }
}