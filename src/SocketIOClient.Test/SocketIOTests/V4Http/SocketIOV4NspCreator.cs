﻿using System.Collections.Generic;

namespace SocketIOClient.Test.SocketIOTests.V4Http
{
    public class SocketIOV4NspCreator : ISocketIOCreateable
    {
        public SocketIO Create(bool reconnection = false)
        {
            return new SocketIO(Url, new SocketIOOptions
            {
                Reconnection = reconnection,
                AutoUpgrade = false,
                Query = new Dictionary<string, string>
                {
                    { "token", Token }
                }
            });
        }

        public string Prefix => "/nsp,V4: ";
        public string Url => "http://localhost:11004/nsp";
        public string Token => "V4NSP";
        public int EIO => 4;
    }
}
