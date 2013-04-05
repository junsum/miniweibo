﻿/*********************************************************************
 * Project Name : MiniWeibo SDK
 * File Name    : WeiboRelation.cs
 * Copyright (c): Jackson Huang
 * Description  : 
 * Reference    : 
 * Author       : Jackson Huang
 * Email        : j.k.jackson023{AT}gmail.com ( {AT} -> @ )
 * Blog         : http://www.cnblogs.com/rush/
 * Create On    : 2013-03-24 11:02:01
 * *******************************************************************/

using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace MiniWeibo.Net.Common
{
    [Serializable]
    [DataContract]
    [DebuggerDisplay("{User.ScreenName}: {Text}")]
    [JsonObject(MemberSerialization.OptIn)]
    public class WeiboRelation : IWeiboModel
    {
        [DataMember]
        public WeiboRelationTarget Target { get; set; }

        [DataMember]
        public WeiboRelationSource Source { get; set; }

        public string RawSource { get; set; }
    }
}