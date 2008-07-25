﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace BNSharp.BattleNet
{
    /// <summary>
    /// Specifies the type of record key to look up for statistics.
    /// </summary>
    [DataContract]
    public enum RecordKeyType
    {
        /// <summary>
        /// Specifies the Wins value.
        /// </summary>
        Wins,
        /// <summary>
        /// Specifies the Losses value.
        /// </summary>
        Losses,
        /// <summary>
        /// Specifies the Disconnects value.
        /// </summary>
        Disconnects,
        /// <summary>
        /// Specifies the Last Game value.
        /// </summary>
        LastGame,
        /// <summary>
        /// Specifies the Last Game Result value.
        /// </summary>
        LastGameResult,
        /// <summary>
        /// Specifies the Rating value.  This is only valid for <see cref="ProfileRecordKeyType">Ladder</see> and 
        /// <see cref="ProfileRecordKeyType">IronManLadder</see> profile record key requests.
        /// </summary>
        Rating,
        /// <summary>
        /// Specifies the High Rating value.  This is only valid for <see cref="ProfileRecordKeyType">Ladder</see> and 
        /// <see cref="ProfileRecordKeyType">IronManLadder</see> profile record key requests.
        /// </summary>
        HighRating,
        /// <summary>
        /// Specifies the Rank value.  This is only valid for <see cref="ProfileRecordKeyType">Ladder</see> and 
        /// <see cref="ProfileRecordKeyType">IronManLadder</see> profile record key requests.
        /// </summary>
        Rank,
        /// <summary>
        /// Specifies the High Rank value.  This is only valid for <see cref="ProfileRecordKeyType">Ladder</see> and 
        /// <see cref="ProfileRecordKeyType">IronManLadder</see> profile record key requests.
        /// </summary>
        HighRank,
    }
}
