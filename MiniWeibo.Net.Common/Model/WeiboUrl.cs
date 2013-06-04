﻿/*********************************************************************
 * Project Name : MiniWeibo SDK
 * File Name    : WeiboUrl.cs
 * Copyright (c): Jackson Huang
 * Description  : 
 * Reference    : 
 * Author       : Jackson Huang
 * Email        : j.k.jackson023{AT}gmail.com ( {AT} -> @ )
 * Blog         : http://www.cnblogs.com/rush/
 * Create On    : 2013-05-10 09:19:57
 * *******************************************************************/
using System.Runtime.Serialization;

namespace MiniWeibo.Net.Common
{
    public class WeiboUrl : IWeiboModel
    {
        ////public virtual string Value { get; set; }

        ////public WeiboUrl()
        ////{
        ////    Initialize();
        ////}

        ////private void Initialize()
        ////{
        ////    EntityType = WeiboEntityType.Url;
        ////}
        /// 


        [DataMember]
        public string UrlShort { get; set; }

        [DataMember]
        public string UrlLong { get; set; }

        [DataMember]
        public int Type { get; set; }

        [DataMember]
        public string Result { get; set; }

        ////[DataMember]
        ////public string CommentCounts { get; set; }

        public string RawSource { get; set; }
    }
}
