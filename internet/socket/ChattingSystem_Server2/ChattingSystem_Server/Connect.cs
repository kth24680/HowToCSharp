﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ChattingSystem_Server
{
    public partial class ServerForm 
    {

        Socket SetupSocket()
        {
            return new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        protected static string LocalIPAddress()
        {
            IPHostEntry host;
            string LocalIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    LocalIP = ip.ToString();
                    break;
                }
            }
            return LocalIP;
        }

        protected static void Disconnect(Socket AcceptSocket,Socket Listener)
        {
            if (AcceptSocket != null)
            {
                AcceptSocket.Close();
                AcceptSocket.Dispose();
            }
            if (Listener != null)
            {
                Listener.Close();
                Listener.Dispose();
            }
        }
        protected void ButtonStatusChange()
        {
            StartButton.Enabled = !(StartButton.Enabled);
            StopButton.Enabled = !(StopButton.Enabled);
        }
        protected void DisconnectMessgae()
        {
            ReceivedData_TextBox.Text += _getClientIP + " 와의 연결이 끊어졌습니다...";
        }
    }
}