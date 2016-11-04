﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SIPSorcery.GB28181.Sys.XML
{
    /// <summary>
    /// 心跳请求
    /// </summary>
    [XmlRoot("Notify")]
    public class KeepAlive : XmlHelper<KeepAlive>
    {
        private static KeepAlive _instance;

        /// <summary>
        /// 单例模式访问
        /// </summary>
        public static KeepAlive Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new KeepAlive();
                }
                return _instance;
            }
        }

        /// <summary>
        /// 命令类型
        /// </summary>
        [XmlElement("CmdType")]
        public CommandType CmdType { get; set; }

        /// <summary>
        /// 设备编码
        /// </summary>
        [XmlElement("DeviceID")]
        public string DeviceID { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("Status")]
        public string Status { get; set; }
    }
}
