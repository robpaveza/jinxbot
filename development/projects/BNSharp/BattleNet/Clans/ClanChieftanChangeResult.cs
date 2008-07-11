﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace BNSharp.BattleNet.Clans
{
    /// <summary>
    /// Specifies result codes for an attempt to change the clan chieftan (leader).
    /// </summary>
#if !NET_2_ONLY
    [DataContract]
#endif
    public enum ClanChieftanChangeResult
    {
        /// <summary>
        /// Indicates that the change succeeded.
        /// </summary>
        Success = 0,
        /// <summary>
        /// Indicates that the clan is less than a week old.
        /// </summary>
        ClanTooYoung = 2,
        /// <summary>
        /// Indicates that the designee did not accept becoming chieftan.
        /// </summary>
        Declined = 4,
        /// <summary>
        /// Indicates that the request has failed.
        /// </summary>
        Failed = 5, 
        /// <summary>
        /// Indicates that the client is not the present clan chieftan.
        /// </summary>
        NotAuthorized = 7,
        /// <summary>
        /// Indicates that the user does not exist, is not in the clan, or that the user has not been in the clan long enough.
        /// </summary>
        NoSuchUser = 8,
    }
}
