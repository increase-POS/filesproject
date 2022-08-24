using System;
using System.Linq;
using System.IO;
using System.Collections;
 
namespace DecodeApp.Classes
{
   
    public class BackupDecode 
    {
    
        public bool decodefile(string source, string dest)
        {
            try
            {
                //string source = System.IO.Path.Combine(@"D:/temp/", "backlocal3.bak");
                //string dest = System.IO.Path.Combine(@"D:/temp/", "backlocal4.bak");
                int firstpartLength = 100;
                int resfirstpartLength;
                int resreverslength = 50;
                int resinjlength;
                byte[] resresult = System.Text.Encoding.ASCII.GetBytes("null");
                resinjlength = resresult.Length;
                resfirstpartLength = firstpartLength + resinjlength;//100+4
                byte[] restorearr = File.ReadAllBytes(source);
                restorearr = Decrypt(restorearr);

                restorearr = restorearr.Reverse().ToArray();

                byte[] resarr1 = new byte[resfirstpartLength];
                int secondpartLength = restorearr.Length - resfirstpartLength;
                byte[] resarr2 = new byte[secondpartLength];//120
                Buffer.BlockCopy(restorearr, 0, resarr1, 0, resfirstpartLength);

                Buffer.BlockCopy(restorearr, resfirstpartLength, resarr2, 0, secondpartLength);

                byte[] resreversarr = new byte[resreverslength];
                Buffer.BlockCopy(resarr1, resreverslength, resreversarr, 0, resreverslength);
                resreversarr = resreversarr.Reverse().ToArray();
                Buffer.BlockCopy(resreversarr, 0, resarr1, resreverslength, resreverslength);
                byte[] resarrnoinj = new byte[firstpartLength];//120
                Buffer.BlockCopy(resarr1, 0, resarrnoinj, 0, firstpartLength);
                restorearr = Combine(resarrnoinj, resarr2);
                File.WriteAllBytes(dest, restorearr);
                return true;

            }
            catch
            {
                return false;
            }


        }
        public static byte[] Combine(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }

        //encript decript
        public static byte[] Decrypt(byte[] Encrypted)
        {
            BitArray enc = ToBits(Encrypted);
            BitArray XorH = SubBits(enc, 0, enc.Length / 2);
            XorH = XorH.Not();
            BitArray RHH = SubBits(enc, enc.Length / 2, enc.Length / 2);
            RHH = RHH.Not();
            BitArray LHH = XorH.Xor(RHH);
            BitArray bits = ConcateBits(LHH, RHH);
            byte[] decr = new byte[bits.Length / 8];
            bits.CopyTo(decr, 0);
            return decr;
        }
      
        private static BitArray ToBits(byte[] Bytes)
        {
            BitArray bits = new BitArray(Bytes);
            return bits;
        }
        private static BitArray SubBits(BitArray Bits, int Start, int Length)
        {
            BitArray half = new BitArray(Length);
            for (int i = 0; i < half.Length; i++)
                half[i] = Bits[i + Start];
            return half;
        }
        private static BitArray ConcateBits(BitArray LHH, BitArray RHH)
        {
            BitArray bits = new BitArray(LHH.Length + RHH.Length);
            for (int i = 0; i < LHH.Length; i++)
                bits[i] = LHH[i];
            for (int i = 0; i < RHH.Length; i++)
                bits[i + LHH.Length] = RHH[i];
            return bits;
        }
    }
}