﻿namespace Util.Signatures {
    /// <summary>
    /// 签名服务
    /// </summary>
    public interface ISignManager {
        /// <summary>
        /// 添加参数
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        ISignManager Add( string key, object value );
        /// <summary>
        /// 签名
        /// </summary>
        string Sign();
    }
}
