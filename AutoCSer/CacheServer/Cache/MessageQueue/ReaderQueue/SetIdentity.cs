﻿using System;

namespace AutoCSer.CacheServer.Cache.MessageQueue.ReaderQueue
{
    /// <summary>
    /// 设置当前读取数据标识
    /// </summary>
    internal sealed class SetIdentity : Node
    {
        /// <summary>
        /// 队列数据 读文件
        /// </summary>
        private readonly File.QueueReader reader;
        /// <summary>
        /// 添加获取数据任务
        /// </summary>
        /// <param name="reader"></param>
        internal SetIdentity(File.QueueReader reader) : base(reader.Node)
        {
            this.reader = reader;
        }
        /// <summary>
        /// 获取当前读取数据标识
        /// </summary>
        /// <returns></returns>
        internal override Node RunTask()
        {
            Node next = LinkNext;
            reader.SaveIdentity();
            LinkNext = null;
            System.Threading.Interlocked.Exchange(ref reader.SetIdentity, this);
            return next;
        }
    }
}