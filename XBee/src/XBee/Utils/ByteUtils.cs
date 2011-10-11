﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XBee.Utils
{
    class ByteUtils
    {
        public static string toBase16(byte[] data)
        {
            if (data == null)
                return "";

            StringBuilder sb = new StringBuilder();
            foreach (byte b in data) {
                sb.Append(String.Format("0x{0:x2}", b));
            }
            return sb.ToString();
        }
    }
}