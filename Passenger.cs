﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Elevator
{
    class Passenger
    {
        public int destination { get; private set; }
        public Passenger(int _destination)
        {
            destination = _destination;   
        }
    }
}
