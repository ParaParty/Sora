using System;
using Sora.Enumeration.ApiEnum;

namespace Sora.EventArgs.SoraEvent
{
    /// <summary>
    /// 客户端连接事件参数
    /// </summary>
    public sealed class ConnectEventArgs : BaseSoraEventArgs
    {
        #region 属性
        /// <summary>
        /// 连接客户端类型
        /// </summary>
        public ClientType CqHttpClientType { get; private set; }

        /// <summary>
        /// 连接客户端版本号
        /// </summary>
        public string ClientVersionCode { get; private set; }
        #endregion

        #region 构造函数

        public ConnectEventArgs(Guid connectionGuid, string eventName, long selfId, ClientType clientType,
                                string clientVersion, long time) : base(connectionGuid, eventName, selfId, time)
        {
            this.CqHttpClientType  = clientType;
            this.ClientVersionCode = clientVersion;
        }
        #endregion

        #region 公有方法
        /// <summary>
        /// 关闭客户端连接
        /// </summary>
        public void CloseConnection()
        {
            base.SoraApi.CloseConnection();
        }
        #endregion
    }
}
