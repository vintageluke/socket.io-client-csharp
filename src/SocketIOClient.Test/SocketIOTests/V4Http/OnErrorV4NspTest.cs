﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace SocketIOClient.Test.SocketIOTests.V4Http
{
    [TestClass]
    public class OnErrorV4NspTest : OnErrorHttpTest
    {
        public OnErrorV4NspTest()
        {
            SocketIOCreator = new SocketIOV4NspCreator();
        }

        protected override ISocketIOCreateable SocketIOCreator { get; }


        [TestMethod]
        public override async Task Test()
        {
            await base.Test();
        }
    }
}
