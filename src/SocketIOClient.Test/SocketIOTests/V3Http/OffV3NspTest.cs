﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace SocketIOClient.Test.SocketIOTests.V3Http
{
    [TestClass]
    public class OffV3NspTest : OffTest
    {
        public OffV3NspTest()
        {
            SocketIOCreator = new SocketIOV3NspCreator();
        }

        protected override ISocketIOCreateable SocketIOCreator { get; }

        [TestMethod]
        public override async Task Test()
        {
            await base.Test();
        }
    }
}
