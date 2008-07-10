﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace JinxBot.Controls.Docking
{
#pragma warning disable 1591
    public class FloatWindowCollection : ReadOnlyCollection<FloatWindow>
    {
        internal FloatWindowCollection()
            : base(new List<FloatWindow>())
        {
        }

        internal int Add(FloatWindow fw)
        {
            if (Items.Contains(fw))
                return Items.IndexOf(fw);

            Items.Add(fw);
            return Count - 1;
        }

        internal void Dispose()
        {
            for (int i = Count - 1; i >= 0; i--)
                this[i].Close();
        }

        internal void Remove(FloatWindow fw)
        {
            Items.Remove(fw);
        }

        internal void BringWindowToFront(FloatWindow fw)
        {
            Items.Remove(fw);
            Items.Add(fw);
        }
    }
}
#pragma warning restore 1591