﻿using System;
using System.Collections.Generic;
using System.Text;
using BNSharp.Plugins;
using System.Diagnostics;
using BNSharp.BattleNet.Clans;

namespace BNSharp.Net
{
    partial class BattleNetClient
    {
        private class EventSink : IBattleNetEvents
        {
            private BattleNetClient m_host;
            public EventSink(BattleNetClient host)
            {
                Debug.Assert(host != null);

                m_host = host;
            }

            #region IBattleNetEvents Members

            public void OnChannelDidNotExist(ServerChatEventArgs e)
            {
                m_host.OnChannelDidNotExist(e);
            }

            public void OnChannelListReceived(ChannelListEventArgs e)
            {
                m_host.OnChannelListReceived(e);
            }

            public void OnChannelWasFull(ServerChatEventArgs e)
            {
                m_host.OnChannelWasFull(e);
            }

            public void OnChannelWasRestricted(ServerChatEventArgs e)
            {
                m_host.OnChannelWasRestricted(e);
            }

            public void OnClanMemberListReceived(ClanMemberListEventArgs e)
            {
                m_host.OnClanMemberListReceived(e);
            }

            public void OnClanMemberQuit(BNSharp.BattleNet.Clans.ClanMemberStatusEventArgs e)
            {
                m_host.OnClanMemberQuit(e);
            }

            public void OnClanMemberRemoved(BNSharp.BattleNet.Clans.ClanMemberStatusEventArgs e)
            {
                m_host.OnClanMemberRemoved(e);
            }

            public void OnClanMembershipReceived(BNSharp.BattleNet.Clans.ClanMembershipEventArgs e)
            {
                m_host.OnClanMembershipReceived(e);
            }

            public void OnClanMemberStatusChanged(BNSharp.BattleNet.Clans.ClanMemberStatusEventArgs e)
            {
                m_host.OnClanMemberStatusChanged(e);
            }

            public void OnClanMessageOfTheDay(InformationEventArgs e)
            {
                m_host.OnClanMessageOfTheDay(e);
            }

            public void OnClanRankChanged(BNSharp.BattleNet.Clans.ClanRankChangeEventArgs e)
            {
                m_host.OnClanRankChanged(e);
            }

            public void OnClientCheckFailed(ClientCheckFailedEventArgs e)
            {
                m_host.OnClientCheckFailed(e);
            }

            public void OnClientCheckPassed(BaseEventArgs e)
            {
                m_host.OnClientCheckPassed(e);
            }

            public void OnCommandSent(InformationEventArgs e)
            {
                m_host.OnCommandSent(e);
            }

            public void OnEnteredChat(EnteredChatEventArgs e)
            {
                m_host.OnEnteredChat(e);
            }

            public void OnError(ErrorEventArgs e)
            {
                m_host.OnError(e);
            }

            public void OnInformation(InformationEventArgs e)
            {
                m_host.OnInformation(e);
            }

            public void OnInformationReceived(ServerChatEventArgs e)
            {
                m_host.OnInformationReceived(e);
            }

            public void OnJoinedChannel(ServerChatEventArgs e)
            {
                m_host.OnJoinedChannel(e);
            }

            public void OnLoginFailed(EventArgs e)
            {
                m_host.OnLoginFailed(e);
            }

            public void OnLoginSucceeded(EventArgs e)
            {
                m_host.OnLoginSucceeded(e);
            }

            public void OnMessageSent(ChatMessageEventArgs e)
            {
                m_host.OnMessageSent(e);
            }

            public void OnServerBroadcast(ServerChatEventArgs e)
            {
                m_host.OnServerBroadcast(e);
            }

            public void OnServerErrorReceived(ServerChatEventArgs e)
            {
                m_host.OnServerErrorReceived(e);
            }

            public void OnServerNews(BNSharp.BattleNet.ServerNewsEventArgs e)
            {
                m_host.OnServerNews(e);
            }

            public void OnUserEmoted(ChatMessageEventArgs e)
            {
                m_host.OnUserEmoted(e);
            }

            public void OnUserFlagsChanged(UserEventArgs e)
            {
                m_host.OnUserFlagsChanged(e);
            }

            public void OnUserJoined(UserEventArgs e)
            {
                m_host.OnUserJoined(e);
            }

            public void OnUserLeft(UserEventArgs e)
            {
                m_host.OnUserLeft(e);
            }

            public void OnUserShown(UserEventArgs e)
            {
                m_host.OnUserShown(e);
            }

            public void OnUserSpoke(ChatMessageEventArgs e)
            {
                m_host.OnUserSpoke(e);
            }

            public void OnWhisperReceived(ChatMessageEventArgs e)
            {
                m_host.OnWhisperReceived(e);
            }

            public void OnWhisperSent(ChatMessageEventArgs e)
            {
                m_host.OnWhisperSent(e);
            }

            #endregion
        }
    }
}
