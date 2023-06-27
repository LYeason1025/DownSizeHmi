using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataConvertLib;

namespace Comm.MelsecLib
{
    /// <summary>
    /// 通用读写接口
    /// </summary>
    internal interface IReadWrite
    {
        OperateResult<byte[]> ReadByteArray(string address, ushort length);

        OperateResult<bool[]> ReadBoolArray(string address, ushort length);

        OperateResult WriteByteArray(string address, byte[] value);

        OperateResult WriteBoolArray(string address, bool[] value);

    }
}
