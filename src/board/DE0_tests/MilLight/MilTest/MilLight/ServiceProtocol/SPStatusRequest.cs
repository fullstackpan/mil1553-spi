﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilTest.MilLight.ServiceProtocol
{
    public class SPStatusRequest : SPRequest
    {
        public override SPCommand Command
        {
            get { return SPCommand.Status; }
        }

        protected override UInt16 PostfixSize()
        {
            return (UInt16)(base.PostfixSize() + 2 /*size of SPStatusReply payload in words*/);
        }
    }
}
