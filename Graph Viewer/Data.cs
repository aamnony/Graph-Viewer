using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Graph_Viewer
{
    static class Data
    {
        private static byte[] packet;
        private static short[] words;
        private static Decoder decoder;
        public enum Decoder
        { 
            BIG_ENDIAN,
            LITTLE_ENDIAN
        }

        static Data()
        {
            //default decoder
            decoder = Decoder.LITTLE_ENDIAN;
        }
        public static void LoadFile(string path)
        {
            packet = File.ReadAllBytes(path);
        }

        public static void SetDecoder(Decoder dec)
        {
            decoder = dec;
        }

        public static Decoder GetDecoder()
        {
            return decoder;
        }

        public static short[] GetWords()
        {
            return words;
        }

        public static int[] GetWords(int start, int end)
        {
            List<int> output = new List<int>();
            int i;
            if (end > words.Length)
            {
                end = words.Length;
            }
            for (i = start; i < end; i++)
            {
                output.Add(words[i]);
            }
            return output.ToArray();
        }

        public static short[] Decode()
        {
            if (decoder == Decoder.LITTLE_ENDIAN)
            {
                //b1=lsb,b2=msb,b3=lsb,b4=msb...
                words = new short[packet.Length / 2];
                short msb, lsb;
                uint i;

                for (i = 0; i < words.Length; i++)
                {
                    msb = (short)(packet[i * 2 + 1] << 8);
                    lsb = packet[i * 2];
                    words[i] = (short)(msb | lsb);
                }
                return words;
            }

            if (decoder == Decoder.BIG_ENDIAN)
            {
                //b1=msb,b2=lsb,b3=msb,b4=lsb...
                words = new short[packet.Length / 2];
                short msb, lsb;
                uint i;

                for (i = 0; i < words.Length; i++)
                {
                    msb = (short)(packet[i * 2] << 8);
                    lsb = packet[i * 2 + 1];
                    words[i] = (short)(msb | lsb);
                }
                return words;
            }
            return null;
        }
    }
}
