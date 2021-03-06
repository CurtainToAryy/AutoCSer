﻿using System;

namespace AutoCSer.Net
{
    /// <summary>
    /// TCP 服务默认端口号
    /// </summary>
    internal enum ServerPort
    {
        /// <summary>
        /// K-V 数据库从服务 8988
        /// </summary>
        KeyValueStreamSlaveServer = 9000 - 12,
        /// <summary>
        /// K-V 数据库主服务 8989
        /// </summary>
        KeyValueStreamMasterServer = 9000 - 11,
        /// <summary>
        /// 可持久化缓存从服务 8990
        /// </summary>
        SlaveCacheServer = 9000 - 10,
        /// <summary>
        /// 可持久化缓存主服务 8991
        /// </summary>
        MasterCacheServer = 9000 - 9,
        /// <summary>
        /// 搜索服务 8992
        /// </summary>
        Search = 9000 - 8,
        /// <summary>
        /// 磁盘块服务 8993
        /// </summary>
        DiskBlock = 9000 - 7,
        /// <summary>
        /// 部署服务 8994
        /// </summary>
        Deploy = 9000 - 6,
        /// <summary>
        /// 进程复制重启服务 8995
        /// </summary>
        ProcessCopy = 9000 - 5,
        /// <summary>
        /// HTTP 会话标识服务 8996
        /// </summary>
        HttpSession = 9000 - 4,
        /// <summary>
        /// HTTP 注册管理服务 8997
        /// </summary>
        HttpServerRegister = 9000 - 3,
        /// <summary>
        /// TCP 内部注册写服务 8998
        /// </summary>
        TcpRegister = 9000 - 2,
        /// <summary>
        /// TCP 内部注册读取服务 8999
        /// </summary>
        TcpRegisterReader = 9000 - 1
    }
}
