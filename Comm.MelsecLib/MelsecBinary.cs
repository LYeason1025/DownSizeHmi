using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataConvertLib;

namespace Comm.MelsecLib
{
    public class MelsecBinary : NetDeviceBase
    {
        public MelsecBinary(DataFormat dataFormat = DataFormat.DCBA)
        {
            this.DataFormat = dataFormat;
        }

        public byte NetworkNo { get; set; } = 0x00;

        public byte DstModuleNo { get; set; } = 0x00;

        public override OperateResult<byte[]> ReadByteArray(string address, ushort length)
        {
            //拼接报文
            var result = BuildReadMessageFrame(address, length);

            if (result.IsSuccess == false) return result;


            byte[] response = null;

            //发送报文

            //接收报文

            var recieve = SendAndReceive(result.Content, ref response);

            if (recieve.IsSuccess)
            {
                //验证报文
                if (response.Length > 10)
                {
                    ushort errorcode = BitConverter.ToUInt16(response, 9);

                    if (errorcode != 0) return OperateResult.CreateFailResult<byte[]>(new OperateResult()
                    {
                        ErrorCode = errorcode
                    });

                    //解析数据
                    return OperateResult.CreateSuccessResult<byte[]>(new byte[] { 0x00 });
                }

                return OperateResult.CreateFailResult<byte[]>(new OperateResult()
                {
                    Message = "返回报文长度不足"
                });
            }
            else
            {
                return OperateResult.CreateFailResult<byte[]>(recieve);
            }
        }


        /// <summary>
        /// 组织报文
        /// </summary>
        /// <param name="address"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        private OperateResult<byte[]> BuildReadMessageFrame(string address, ushort length)
        {
            var result = MelsecAddressAnalysis(address);

            if (result.IsSuccess == false) return OperateResult.CreateFailResult<byte[]>(result.Message);

            //报文拼接

            ByteArray sendCommand = new ByteArray();

            //副头部
            sendCommand.Add(0x50, 0x00);

            //网络编号
            sendCommand.Add(NetworkNo);

            //可编程控制器编号
            sendCommand.Add(0xFF);

            //目标模块IO编号
            sendCommand.Add(0xFF, 0X03);

            //请求目标模块编号
            sendCommand.Add(DstModuleNo);

            //请求长度
            sendCommand.Add(0x0C, 0x00);

            //CPU定时器
            sendCommand.Add(0x0A, 0x00);


            //指令
            sendCommand.Add(0x01, 0x04);

            //子指令
            sendCommand.Add(result.Content1.AreaType, 0x00);

            //起始软元件

            byte[] startAddress = BitConverter.GetBytes(result.Content2);

            sendCommand.Add(startAddress[0], startAddress[1], startAddress[2]);

            //软元件代号
            sendCommand.Add(result.Content1.AreaBinaryCode);

            //软元件数量
            sendCommand.Add((byte)(length % 256), (byte)(length / 256));

            return OperateResult.CreateSuccessResult(sendCommand.array);

        }

        /// <summary>
        /// X0
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        private OperateResult<MelsecStoreArea, int> MelsecAddressAnalysis(string address)
        {
            var result = new OperateResult<MelsecStoreArea, int>();

            result.IsSuccess = true;

            try
            {
                switch (address[0].ToString().ToUpper())
                {
                    case "X":
                        result.Content1 = MelsecStoreArea.X;
                        result.Content2 = Convert.ToInt32(address.Substring(1), MelsecStoreArea.X.FromBase);
                        break;
                    case "Y":
                        result.Content1 = MelsecStoreArea.Y;
                        result.Content2 = Convert.ToInt32(address.Substring(1), MelsecStoreArea.Y.FromBase);
                        break;
                    case "M":
                        result.Content1 = MelsecStoreArea.M;
                        result.Content2 = Convert.ToInt32(address.Substring(1), MelsecStoreArea.M.FromBase);
                        break;
                    case "D":
                        result.Content1 = MelsecStoreArea.D;
                        result.Content2 = Convert.ToInt32(address.Substring(1), MelsecStoreArea.D.FromBase);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }
            return result;
        }

    }
}
