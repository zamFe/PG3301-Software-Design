﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PG3301_Software_Design
{
    abstract class ThreadProxy
    {
        protected Thread _thread;
        protected bool _isRunning;

        public Thread Thread { get => _thread; }
        public bool IsAlive { get => _thread.IsAlive; }
        public bool IsRunning { get => _isRunning;  }

        public ThreadProxy()
        {
            _thread = new Thread(new ThreadStart(TLoop));
            _isRunning = false;
        }

        //the task of the thread must be inplemented in extended class
        protected abstract void Task();
        
        //keep doing task from start is called until stop is called
        protected void TLoop()
        {
            while(_isRunning)
            {
                Task();
            }
        }

        //starts the thread and implemented task
        public void Start()
        {
            _isRunning = true;
            _thread.Start();
            while (!_thread.IsAlive) ;
        }

        //upon stopping, join the thread
        public void Stop()
        {
            _isRunning = false;
            _thread.Join();
        }
    }
}