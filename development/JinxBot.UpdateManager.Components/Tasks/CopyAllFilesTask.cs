﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace JinxBot.UpdateManager.Components.Tasks
{
    internal class CopyAllFilesTask : Task
    {
        public CopyAllFilesTask(XElement element, Task parent)
            : base(element, parent)
        {

        }

        public override TaskStatus Execute()
        {
            return TaskStatus.Success;
        }
    }
}
