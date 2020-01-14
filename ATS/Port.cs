﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS
{
    public class Port
    {
        private int _number;
        private PortStatus _status;
        private ITerminal _terminal;

        public Port(int number)
        {
            _number = number;
        }

        public int Number => _number;
        public PortStatus Status { get; private set; }

        public void Connect(ITerminal terminal)
        {
            if(terminal == null)
            {
                terminal = _terminal;
            }

            Status = PortStatus.Connected;
        }

        public void Disconnect(ITerminal terminal)
        {
            terminal = null;

            Status = PortStatus.Disconnected;
        }

        public void Dialing(int number)
        {
            Status = PortStatus.Busy;
        }

        public void Calling(int number)
        {

        }

        public void Talking()
        {
            Status = PortStatus.Busy;
        }

        public void FinishTalking()
        {
            Status = PortStatus.Disconnected;
        }

    }
}