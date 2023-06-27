using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataConvertLib;

namespace Comm.MelsecLib
{
    public class ReadWriteBase : IReadWrite
    {

        /// <summary>
        /// 字节大小端顺序
        /// </summary>
        public DataFormat DataFormat { get; set; } = DataFormat.ABCD;


        public int ByteLength = 2;

        public virtual OperateResult<bool[]> ReadBoolArray(string address, ushort length)
        {
            throw new NotImplementedException();
        }

        public virtual OperateResult<byte[]> ReadByteArray(string address, ushort length)
        {
            throw new NotImplementedException();
        }

        public virtual OperateResult WriteBoolArray(string address, bool[] value)
        {
            throw new NotImplementedException();
        }

        public virtual OperateResult WriteByteArray(string address, byte[] value)
        {
            throw new NotImplementedException();
        }

        #region 通用读取方法

        #region Read Bool 

        /// <summary>
        /// 读取布尔数组
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="length">长度</param>
        /// <returns>布尔数组</returns>
        public virtual OperateResult<bool[]> ReadBool(string address, ushort length)
        {
            return ReadBoolArray(address, length);
        }

        /// <summary>
        /// 读取单个布尔
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">返回值</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult<bool> ReadBool(string address)
        {
            var result = ReadBool(address, 1);

            if (result.IsSuccess)
            {
                return OperateResult.CreateSuccessResult(result.Content[0]);
            }
            else
            {
                return OperateResult.CreateFailResult<bool>(result);
            }
        }
        #endregion

        #region Read Byte
        /// <summary>
        /// 读取字节数组
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="length">长度</param>
        /// <returns>字节数组</returns>
        public virtual OperateResult<byte[]> ReadByte(string address, ushort length)
        {
            return ReadByteArray(address, length);
        }

        /// <summary>
        /// 读取单个字节
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">返回值</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult<byte> ReadByte(string address)
        {
            var result = ReadByte(address, 1);

            if (result.IsSuccess)
            {
                return OperateResult.CreateSuccessResult(result.Content[0]);
            }
            else
            {
                return OperateResult.CreateFailResult<byte>(result);
            }
        }


        #endregion

        #region Read Int16
        /// <summary>
        /// 读取Short数组
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="length">长度</param>
        /// <returns>Short数组</returns>
        public virtual OperateResult<short[]> ReadShort(string address, ushort length)
        {
            OperateResult<byte[]> result = ReadByteArray(address, (ushort)(length * 2 / ByteLength));

            if (result.IsSuccess)
            {
                return OperateResult.CreateSuccessResult(ShortLib.GetShortArrayFromByteArray(result.Content, this.DataFormat));
            }
            else
            {
                return OperateResult.CreateFailResult<short[]>(result);
            }
        }

        /// <summary>
        /// 读取单个Short
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">返回值</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult<short> ReadShort(string address)
        {
            var result = ReadShort(address, 1);

            if (result.IsSuccess)
            {
                return OperateResult.CreateSuccessResult(result.Content[0]);
            }
            else
            {
                return OperateResult.CreateFailResult<short>(result);
            }
        }


        #endregion

        #region Read UInt16
        /// <summary>
        /// 读取UShort数组
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="length">长度</param>
        /// <returns>UShort数组</returns>
        public virtual OperateResult<ushort[]> ReadUShort(string address, ushort length)
        {
            OperateResult<byte[]> result = ReadByteArray(address, (ushort)(length * 2 / ByteLength));

            if (result.IsSuccess)
            {
                return OperateResult.CreateSuccessResult(UShortLib.GetUShortArrayFromByteArray(result.Content, this.DataFormat));
            }
            else
            {
                return OperateResult.CreateFailResult<ushort[]>(result);
            }
        }

        /// <summary>
        /// 读取单个UShort
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">返回值</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult<ushort> ReadUShort(string address)
        {
            var result = ReadUShort(address, 1);

            if (result.IsSuccess)
            {
                return OperateResult.CreateSuccessResult(result.Content[0]);
            }
            else
            {
                return OperateResult.CreateFailResult<ushort>(result);
            }
        }
        #endregion

        #region Read Int32
        /// <summary>
        /// 读取Int数组
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="length">长度</param>
        /// <returns>Int数组</returns>
        public virtual OperateResult<int[]> ReadInt(string address, ushort length)
        {
            OperateResult<byte[]> result = ReadByteArray(address, (ushort)(length * 4 / ByteLength));

            if (result.IsSuccess)
            {
                return OperateResult.CreateSuccessResult(IntLib.GetIntArrayFromByteArray(result.Content, this.DataFormat));
            }
            else
            {
                return OperateResult.CreateFailResult<int[]>(result);
            }
        }

        /// <summary>
        /// 读取单个Int
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult<int> ReadInt(string address)
        {
            var result = ReadInt(address, 1);

            if (result.IsSuccess)
            {
                return OperateResult.CreateSuccessResult(result.Content[0]);
            }
            else
            {
                return OperateResult.CreateFailResult<int>(result);
            }
        }
        #endregion

        #region Read UInt32
        /// <summary>
        /// 读取UInt数组
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="length">长度</param>
        /// <returns>UInt数组</returns>
        public virtual OperateResult<uint[]> ReadUInt(string address, ushort length)
        {
            OperateResult<byte[]> result = ReadByteArray(address, (ushort)(length * 4 / ByteLength));

            if (result.IsSuccess)
            {
                return OperateResult.CreateSuccessResult(UIntLib.GetUIntArrayFromByteArray(result.Content, this.DataFormat));
            }
            else
            {
                return OperateResult.CreateFailResult<uint[]>(result);
            }
        }

        /// <summary>
        /// 读取单个UInt
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult<uint> ReadUInt(string address)
        {
            var result = ReadUInt(address, 1);

            if (result.IsSuccess)
            {
                return OperateResult.CreateSuccessResult(result.Content[0]);
            }
            else
            {
                return OperateResult.CreateFailResult<uint>(result);
            }
        }
        #endregion

        #region Read Float
        /// <summary>
        /// 读取Float数组
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="length">长度</param>
        /// <returns>UInt数组</returns>
        public virtual OperateResult<float[]> ReadFloat(string address, ushort length)
        {
            OperateResult<byte[]> result = ReadByteArray(address, (ushort)(length * 4 / ByteLength));

            if (result.IsSuccess)
            {
                return OperateResult.CreateSuccessResult(FloatLib.GetFloatArrayFromByteArray(result.Content, this.DataFormat));
            }
            else
            {
                return OperateResult.CreateFailResult<float[]>(result);
            }
        }

        /// <summary>
        /// 读取单个Float
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">返回值</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult<float> ReadFloat(string address, ref float value)
        {
            var result = ReadFloat(address, 1);

            if (result.IsSuccess)
            {
                return OperateResult.CreateSuccessResult(result.Content[0]);
            }
            else
            {
                return OperateResult.CreateFailResult<float>(result);
            }
        }
        #endregion

        #region Read Int64
        /// <summary>
        /// 读取Long数组
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="length">长度</param>
        /// <returns>Long数组</returns>
        public virtual OperateResult<long[]> ReadLong(string address, ushort length)
        {
            OperateResult<byte[]> result = ReadByteArray(address, (ushort)(length * 8 / ByteLength));

            if (result.IsSuccess)
            {
                return OperateResult.CreateSuccessResult(LongLib.GetLongArrayFromByteArray(result.Content, this.DataFormat));
            }
            else
            {
                return OperateResult.CreateFailResult<long[]>(result);
            }
        }

        /// <summary>
        /// 读取单个Long
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">返回值</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult<long> ReadLong(string address)
        {
            var result = ReadLong(address, 1);

            if (result.IsSuccess)
            {
                return OperateResult.CreateSuccessResult(result.Content[0]);
            }
            else
            {
                return OperateResult.CreateFailResult<long>(result);
            }
        }
        #endregion

        #region Read UInt64
        /// <summary>
        /// 读取ULong数组
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="length">长度</param>
        /// <returns>ULong数组</returns>
        public virtual OperateResult<ulong[]> ReadULong(string address, ushort length)
        {
            OperateResult<byte[]> result = ReadByteArray(address, (ushort)(length * 8 / ByteLength));

            if (result.IsSuccess)
            {
                return OperateResult.CreateSuccessResult(ULongLib.GetULongArrayFromByteArray(result.Content, this.DataFormat));
            }
            else
            {
                return OperateResult.CreateFailResult<ulong[]>(result);
            }
        }

        /// <summary>
        /// 读取单个ULong
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">返回值</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult<ulong> ReadULong(string address, ref ulong value)
        {
            var result = ReadULong(address, 1);

            if (result.IsSuccess)
            {
                return OperateResult.CreateSuccessResult(result.Content[0]);
            }
            else
            {
                return OperateResult.CreateFailResult<ulong>(result);
            }
        }
        #endregion

        #region Read Double   
        /// <summary>
        /// 读取Double数组
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="length">长度</param>
        /// <returns>Double数组</returns>
        public virtual OperateResult<double[]> ReadDouble(string address, ushort length)
        {
            OperateResult<byte[]> result = ReadByteArray(address, (ushort)(length * 8 / ByteLength));

            if (result.IsSuccess)
            {
                return OperateResult.CreateSuccessResult(DoubleLib.GetDoubleArrayFromByteArray(result.Content, this.DataFormat));
            }
            else
            {
                return OperateResult.CreateFailResult<double[]>(result);
            }
        }

        /// <summary>
        /// 读取单个Double
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult<double> ReadDouble(string address)
        {
            var result = ReadDouble(address, 1);

            if (result.IsSuccess)
            {
                return OperateResult.CreateSuccessResult(result.Content[0]);
            }
            else
            {
                return OperateResult.CreateFailResult<double>(result);
            }
        }
        #endregion

        #region Read String
        /// <summary>
        /// 读取String
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="length">长度</param>
        /// <param name="stringType">返回字符串类型，0表示10进制组合，1表示16进制组合，2表示ASCII编码格式，3表示使用BitConvert</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult<string> ReadString(string address, int length, int stringType = 0)
        {
            OperateResult<byte[]> result = ReadByteArray(address, (ushort)(length / ByteLength));

            if (result.IsSuccess)
            {
                switch (stringType)
                {
                    case 0: return OperateResult.CreateSuccessResult(StringLib.GetStringFromValueArray(result.Content, 0, result.Content.Length * 2));
                    case 1: return OperateResult.CreateSuccessResult(StringLib.GetHexStringFromByteArray(result.Content, 0, result.Content.Length * 2));
                    case 2: return OperateResult.CreateSuccessResult(StringLib.GetStringFromByteArrayByEncoding(result.Content, 0, result.Content.Length * 2, Encoding.ASCII));
                    case 3: return OperateResult.CreateSuccessResult(StringLib.GetStringFromByteArrayByBitConvert(result.Content, 0, result.Content.Length * 2));
                    default: return OperateResult.CreateSuccessResult(StringLib.GetStringFromValueArray(result.Content, 0, result.Content.Length * 2));
                }
            }
            else
            {
                return OperateResult.CreateFailResult<string>(result);
            }
        }

        #endregion

        #endregion

        #region 通用写入方法

        #region Write Common
        /// <summary>
        /// 通用写入方法
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">变量值</param>
        /// <param name="dataType">数据类型</param>
        /// <returns>返回对象</returns>
        public virtual OperateResult Write(string address, object value, DataType dataType)
        {
            try
            {
                switch (dataType)
                {
                    case DataType.Bool:
                        return WriteBool(address, BitLib.IsBoolean(value.ToString()));
                    case DataType.Byte:
                        return WriteByte(address, Convert.ToByte(value));
                    case DataType.Short:
                        return WriteShort(address, Convert.ToInt16(value));
                    case DataType.Int:
                        return WriteInt(address, Convert.ToInt32(value));
                    case DataType.Long:
                        return WriteLong(address, Convert.ToInt64(value));
                    case DataType.UShort:
                        return WriteUShort(address, Convert.ToUInt16(value));
                    case DataType.UInt:
                        return WriteUInt(address, Convert.ToUInt32(value));
                    case DataType.ULong:
                        return WriteULong(address, Convert.ToUInt64(value));
                    case DataType.Float:
                        return WriteFloat(address, Convert.ToSingle(value));
                    case DataType.Double:
                        return WriteDouble(address, Convert.ToDouble(value));
                    case DataType.String:
                        return WriteString(address, value.ToString());
                    default:
                        return OperateResult.CreateFailResult();
                }
            }
            catch (Exception ex)
            {
                return new OperateResult(false, ex.Message);
            }
        }

        #endregion

        #region Write bool
        /// <summary>
        /// 写入布尔数组
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">布尔数组</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteBool(string address, bool[] value)
        {
            return WriteBoolArray(address, value);
        }

        /// <summary>
        /// 写入单个布尔
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">布尔</param>
        /// <param name="IsRegBool">是否为寄存器布尔</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteBool(string address, bool value, bool isRegBool = false)
        {
            if (isRegBool)
            {
                string[] str = address.Split('.');

                if (str.Length == 2)
                {
                    var result = ReadUShort(str[0]);

                    if (result.IsSuccess)
                    {
                        int index = Convert.ToInt32(str[1], 16);

                        ushort setValue = UShortLib.SetBitValueFromUShort(result.Content, index, value);

                        return WriteUShort(str[0], setValue);
                    }
                    else
                    {
                        return new OperateResult(false, "读取寄存器结果失败");
                    }
                }
                else
                {
                    return new OperateResult(false, "变量地址按.分割后长度不为2");
                }
            }

            else
            {
                return WriteBool(address, new bool[] { value });
            }
        }

        #endregion

        #region Write byte
        /// <summary>
        /// 写入字节数组
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">字节数组</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteByte(string address, byte[] value)
        {
            return WriteByteArray(address, value);
        }

        /// <summary>
        /// 写入单个字节
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">字节数据</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteByte(string address, byte value)
        {
            return WriteByte(address, new byte[] { value });
        }
        #endregion

        #region Write Int16
        /// <summary>
        /// 写入Short数组
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="values">Short数组</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteShort(string address, short[] values)
        {
            return WriteByteArray(address, ByteArrayLib.GetByteArrayFromShortArray(values, this.DataFormat));
        }
        /// <summary>
        /// 写入单个Short
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">Short</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteShort(string address, short value)
        {
            return WriteShort(address, new short[] { value });
        }

        #endregion

        #region Write UInt16
        /// <summary>
        /// 写入UShort数组
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="values">UShort数组</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteUShort(string address, ushort[] values)
        {
            return WriteByteArray(address, ByteArrayLib.GetByteArrayFromUShortArray(values, this.DataFormat));
        }
        /// <summary>
        /// 写入单个UShort
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">UShort</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteUShort(string address, ushort value)
        {
            return WriteUShort(address, new ushort[] { value });
        }
        #endregion

        #region Write Int32
        /// <summary>
        /// 写入Int数组
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="values">Int数组</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteInt(string address, int[] values)
        {
            return WriteByteArray(address, ByteArrayLib.GetByteArrayFromIntArray(values, this.DataFormat));
        }
        /// <summary>
        /// 写入单个Int
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">Int</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteInt(string address, int value)
        {
            return WriteInt(address, new int[] { value });
        }

        #endregion

        #region Write UInt32
        /// <summary>
        /// 写入UInt数组
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="values">UInt数组</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteUInt(string address, uint[] values)
        {
            return WriteByteArray(address, ByteArrayLib.GetByteArrayFromUIntArray(values, this.DataFormat));
        }

        /// <summary>
        /// 写入单个UInt
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">UInt</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteUInt(string address, uint value)
        {
            return WriteUInt(address, new uint[] { value });
        }

        #endregion

        #region Write Float
        /// <summary>
        /// 写入Float数组
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="values">Float数组</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteFloat(string address, float[] values)
        {
            return WriteByteArray(address, ByteArrayLib.GetByteArrayFromFloatArray(values, this.DataFormat));
        }

        /// <summary>
        /// 写入单个Float
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">Float</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteFloat(string address, float value)
        {
            return WriteFloat(address, new float[] { value });
        }

        #endregion

        #region Write Int64
        /// <summary>
        /// 写入Long数组
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="values">Long数组</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteLong(string address, long[] values)
        {
            return WriteByteArray(address, ByteArrayLib.GetByteArrayFromLongArray(values, this.DataFormat));
        }
        /// <summary>
        /// 写入单个Long
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">Long</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteLong(string address, long value)
        {
            return WriteLong(address, new long[] { value });
        }

        #endregion

        #region Write UInt64

        /// <summary>
        /// 写入ULong数组
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="values">ULong数组</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteULong(string address, ulong[] values)
        {
            return WriteByteArray(address, ByteArrayLib.GetByteArrayFromULongArray(values, this.DataFormat));
        }
        /// <summary>
        /// 写入单个ULong
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">ULong</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteULong(string address, ulong value)
        {
            return WriteULong(address, new ulong[] { value });
        }

        #endregion

        #region Write Double
        /// <summary>
        /// 写入Double数组
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="values">Double数组</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteDouble(string address, double[] values)
        {
            return WriteByteArray(address, ByteArrayLib.GetByteArrayFromDoubleArray(values, this.DataFormat));
        }
        /// <summary>
        /// 写入单个Double
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">Double</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteDouble(string address, double value)
        {
            return WriteDouble(address, new double[] { value });
        }

        #endregion

        #region Write String
        /// <summary>
        /// 写入String类型
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">String</param>
        /// <param name="encoding">编码格式</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteString(string address, string value, Encoding encoding)
        {
            if (address.Contains('.'))
            {
                string[] str = address.Split('.');

                if (str.Length == 2)
                {
                    int length = Convert.ToInt32(str[1]);

                    if (value.Length > length)
                    {
                        return WriteByteArray(str[0], ByteArrayLib.GetByteArrayFromString(value.Substring(0, length), encoding));
                    }
                    else
                    {
                        return WriteByteArray(str[0], ByteArrayLib.GetByteArrayFromString(value.PadRight(length, ' '), encoding));
                    }
                }
                else
                {
                    return new OperateResult(false, "变量地址按.分割后长度不为2");
                }
            }

            else
            {
                return WriteByteArray(address, ByteArrayLib.GetByteArrayFromString(value, encoding));
            }
        }

        /// <summary>
        /// 写入String类型
        /// </summary>
        /// <param name="address">变量地址</param>
        /// <param name="value">String</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult WriteString(string address, string value)
        {
            return WriteString(address, value, Encoding.ASCII);
        }


        #endregion

        #endregion
    }
}
