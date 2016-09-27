﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace XModemProtocol.Options {
    using Factories;
    using Communication;
    public interface IRequirements {
        IXModemProtocolOptions Options { get; }
        IContext Context { get; }
        ICommunicator Communicator { get; }
    }
}