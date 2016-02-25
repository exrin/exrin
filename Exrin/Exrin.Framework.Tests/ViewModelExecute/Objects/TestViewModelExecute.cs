﻿using Exrin.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrin.Framework.Tests.ViewModelExecute.Objects
{

    public class TestViewModelExecute : IViewModelExecute
    {
        public List<IOperation> Operations { get; set; }

        public int TimeoutMilliseconds { get; set; }

    }
}
