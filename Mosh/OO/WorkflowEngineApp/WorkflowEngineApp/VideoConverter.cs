﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineApp
{
    public class VideoConverter : IWorkflowActivity
    {
        public void Execute()
        {
            Console.WriteLine("Videos converted.");
        }
    }
}
