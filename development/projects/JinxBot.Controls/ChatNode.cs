﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace JinxBot.Controls
{
    /// <summary>
    /// Represents a substring of text to be displayed on a chat box.
    /// </summary>
    [Serializable]
    public class ChatNode : MarshalByRefObject
    {
        //RAP: Excluded CA2104 because this type is immutable.
        /// <summary>
        /// Represents a <b>ChatNode</b> that creates a new line.
        /// </summary>
        public static readonly ChatNode NewLine = new ChatNode(null, Color.Empty);

        private string m_text;
        private Color m_col;
        private Uri m_uri;

        /// <summary>
        /// Initializes a new <b>ChatNode</b>.
        /// </summary>
        /// <param name="text">The text to be displayed.</param>
        /// <param name="color">The color of the text.</param>
        public ChatNode(string text, Color color)
        {
            m_text = text;
            m_col = color;
        }

        /// <summary>
        /// Initializes a new <b>ChatNode</b>.
        /// </summary>
        /// <param name="text">The text to be displayed.</param>
        /// <param name="color">The color of the text.</param>
        /// <param name="linkUrl">The URL the link for this text.</param>
        public ChatNode(string text, Color color, string linkUrl)
            : this(text, color, new Uri(linkUrl))
        {
        }

        /// <summary>
        /// Initializes a new <b>ChatNode</b>.
        /// </summary>
        /// <param name="text">The text to be displayed.</param>
        /// <param name="color">The color of the text.</param>
        /// <param name="linkUri">The URL the link for this text.</param>
        public ChatNode(string text, Color color, Uri linkUri)
            : this(text, color)
        {
            m_uri = linkUri;
        }

        /// <summary>
        /// Gets the text displayed by this ChatNode.
        /// </summary>
        public string Text { get { return m_text; } }
        /// <summary>
        /// Gets the color of the text of this ChatNode.
        /// </summary>
        public Color Color { get { return m_col; } }
        /// <summary>
        /// Gets the URL that this text should link to.
        /// </summary>
        public Uri LinkUri { get { return m_uri; } }

        #region ICloneable Members

        /// <summary>
        /// Copies the specified <b>ChatNode</b> object.
        /// </summary>
        /// <param name="source">The source ChatNode to copy.</param>
        /// <remarks>
        /// <para>This overload is provided for use when marshaling messages across AppDomain boundaries
        /// and when the specified system message will be used to render GUI elements.</para>
        /// </remarks>
        public ChatNode(ChatNode source)
        {
            this.m_col = source.Color;
            this.m_text = source.Text;
            this.m_uri = source.LinkUri;
        }

        #endregion
    }
}
