using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comm.MelsecLib
{
    public class MelsecStoreArea
    {

        public MelsecStoreArea(byte AreaType, byte AreaBinaryCode, string AreaASCIICode, int FromBase)
        {
            this.AreaType = AreaType;
            this.AreaBinaryCode = AreaBinaryCode;
            this.AreaASCIICode = AreaASCIICode;
            this.FromBase = FromBase;
        }

        /// <summary>
        /// 类型：字/位，0x00表示字，0x01表示位
        /// </summary>
        public byte AreaType { get; set; } = 0x00;


        /// <summary>
        /// 软件二进制代码
        /// </summary>
        public byte AreaBinaryCode { get; set; }

        /// <summary>
        /// 软件ASCII代码
        /// </summary>
        public string AreaASCIICode { get; set; }


        /// <summary>
        /// 存储区的进制
        /// </summary>
        public int FromBase { get; set; }


        public static MelsecStoreArea X = new MelsecStoreArea(0x01, 0x9C, "X*", 16);

        public static MelsecStoreArea Y = new MelsecStoreArea(0x01, 0x9D, "Y*", 16);

        public static MelsecStoreArea M = new MelsecStoreArea(0x01, 0x90, "M*", 10);

        public static MelsecStoreArea D = new MelsecStoreArea(0x00, 0xA8, "D*", 10);


    }
}
