using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DataConvertLib;

namespace Comm.MelsecLib
{
    public class NetDeviceBase : ReadWriteBase
    {
        //Socket对象
        private Socket tcpclient;

        /// <summary>
        /// 接受返回报文等待次数，默认为10次
        /// </summary>
        public int WaitTimes { get; set; } = 10;

        /// <summary>
        /// 接受返回报文等待时间，每次为10ms
        /// </summary>
        public int SleepTime { get; set; } = 10;

        public const int DefaultTimeout = 2000;

        private int readTimeout = DefaultTimeout;
        private int writeTimeout = DefaultTimeout;

        /// <summary>
        /// 接收超时时间
        /// </summary>
        public int ReadTimeout
        {
            get => readTimeout;
            set
            {
                readTimeout = value;
                if (tcpclient != null) tcpclient.ReceiveTimeout = readTimeout;
            }
        }

        /// <summary>
        /// 发送超时时间
        /// </summary>
        public int WriteTimeout
        {
            get => writeTimeout;
            set
            {
                writeTimeout = value;
                if (tcpclient != null) tcpclient.SendTimeout = writeTimeout;
            }
        }

        /// <summary>
        /// 连接超时时间
        /// </summary>
        public int ConnectTimeOut { get; set; } = 2000;

        //连接


        //断开

        #region 建立及断开连接
        /// <summary>
        /// 建立Socket连接
        /// </summary>
        /// <param name="ip">IP地址或域名</param>
        /// <param name="port">端口号</param>
        /// <returns>是否成功</returns>
        public virtual bool Connect(string ip, int port)
        {
            //1、Sokcet对象连接
            this.tcpclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.tcpclient.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, readTimeout);
            this.tcpclient.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, writeTimeout);

            try
            {
                if (IPAddress.TryParse(ip, out IPAddress iPAddress))
                {
                    IAsyncResult asyncResult = tcpclient.BeginConnect(iPAddress, port, null, null);

                    bool connectSuccess = asyncResult.AsyncWaitHandle.WaitOne(ConnectTimeOut, false);

                    if (!connectSuccess)
                    {
                        return false;
                    }
                }
                else
                {
                    IAsyncResult asyncResult = tcpclient.BeginConnect(ip, port, null, null);

                    bool connectSuccess = asyncResult.AsyncWaitHandle.WaitOne(ConnectTimeOut, false);

                    if (!connectSuccess)
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        public virtual void DisConnect()
        {
            if (tcpclient != null)
            {
                tcpclient?.Shutdown(SocketShutdown.Both);
                Thread.Sleep(50);
                tcpclient?.Close();
            }
        }
        #endregion


        //发送并接收

        #region 发送并接收
        /// <summary>
        /// 发送并接收
        /// </summary>
        /// <param name="request">字节数组</param>
        /// <param name="response">返回报文</param>
        /// <param name="message">IMessage对象</param>
        /// <returns>是否成功</returns>
        public virtual OperateResult SendAndReceive(byte[] request, ref byte[] response)
        {

            MemoryStream ms = new MemoryStream();
            try
            {
                tcpclient.Send(request, request.Length, SocketFlags.None);
                int timer = 0;
                byte[] buffer = new byte[1024];
                while (true)
                {
                    Thread.Sleep(SleepTime);
                    if (tcpclient.Available > 0)
                    {
                        int num = tcpclient.Receive(buffer, SocketFlags.None);
                        ms.Write(buffer, 0, num);
                    }
                    else
                    {
                        timer++;
                        if (timer >= WaitTimes)
                        {
                            return new OperateResult(false, "请求超时");
                        }
                        else if (ms.Length > 0)
                        {
                            break;
                        }
                    }
                }
                response = ms.ToArray();

                ms.Dispose();

                return OperateResult.CreateSuccessResult();
            }
            catch (Exception ex)
            {
                return new OperateResult(false, ex.Message);
            }
        }
        #endregion

    }
}
