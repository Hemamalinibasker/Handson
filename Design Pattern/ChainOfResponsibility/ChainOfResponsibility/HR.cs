﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class HR:ILeaveRequestHandler
    {
        private ILeaveRequestHandler nextHandler;

        public ILeaveRequestHandler NextHandler 
        { 
            get {return nextHandler; } 
            set {nextHandler=value; } 
        }

        public void HandlerRequest(LeaveRequest leave)
        {
            if (leave.LeaveDays > 5)
            {
                Console.WriteLine("HR Approved Leave");
            }
            else 
            {
                Console.WriteLine("Leave Rejected by HR");
            }
        }
    }
}
