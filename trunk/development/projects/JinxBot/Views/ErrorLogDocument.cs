﻿using JinxBot.Controls.Docking;
using JinxBot.Controls;
using JinxBot.Views.Chat;
using JinxBot.Plugins.UI;

namespace JinxBot.Views
{
    internal partial class ErrorLogDocument : DockableDocument, IChatTab
    {
        public ErrorLogDocument()
        {
            InitializeComponent();
        }

        public void AddError(string message)
        {
            if (!IsAppClosing)
            {
                display.AddChat(new ChatNode(message, CssClasses.Error));
            }
        }

        public bool IsAppClosing
        {
            get;
            set;
        }

        #region IChatTab Members

        public System.Uri StylesheetUri
        {
            get;
            set;
        }

        #endregion
    }
}
