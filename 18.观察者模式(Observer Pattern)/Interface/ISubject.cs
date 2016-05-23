﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    public interface ISubject
    {
        void Notify();

        string SubjectState
        {
            get;
            set;
        }
    }
}
