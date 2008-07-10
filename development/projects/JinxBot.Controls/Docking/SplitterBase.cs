﻿using System;
using System.Collections.Generic;
using System.Text;
using JinxBot.Controls.Interop;
using System.Windows.Forms;
using System.Drawing;

namespace JinxBot.Controls.Docking
{
    internal class SplitterBase : Control
    {
        public SplitterBase()
        {
            SetStyle(ControlStyles.Selectable, false);
        }

        public override DockStyle Dock
        {
            get { return base.Dock; }
            set
            {
                SuspendLayout();
                base.Dock = value;

                if (Dock == DockStyle.Left || Dock == DockStyle.Right)
                    Width = SplitterSize;
                else if (Dock == DockStyle.Top || Dock == DockStyle.Bottom)
                    Height = SplitterSize;
                else
                    Bounds = Rectangle.Empty;

                if (Dock == DockStyle.Left || Dock == DockStyle.Right)
                    Cursor = Cursors.VSplit;
                else if (Dock == DockStyle.Top || Dock == DockStyle.Bottom)
                    Cursor = Cursors.HSplit;
                else
                    Cursor = Cursors.Default;

                ResumeLayout();
            }
        }

        protected virtual int SplitterSize
        {
            get { return 0; }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button != MouseButtons.Left)
                return;

            StartDrag();
        }

        protected virtual void StartDrag()
        {
        }

        protected override void WndProc(ref Message m)
        {
            // eat the WM_MOUSEACTIVATE message
            if (m.Msg == (int)Msgs.WM_MOUSEACTIVATE)
                return;

            base.WndProc(ref m);
        }
    }

}
