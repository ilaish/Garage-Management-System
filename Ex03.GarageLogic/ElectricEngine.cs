﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class ElectricEngine : Engine
    {
        private float m_RemainingOperationTime;
        public ElectricEngine(float i_EngineMaxCapacity) : base(i_EngineMaxCapacity)
        {
        }

        public float RemainingOperationTime
        {
            get
            {
                return m_RemainingOperationTime;
            }
            set
            {
                m_RemainingOperationTime = value;
            }
        }

        public void Recharge(float i_HoursToAdd)
        {
            if(i_HoursToAdd + RemainingOperationTime <= EngineMaxCapacity)
            {
                m_RemainingOperationTime += i_HoursToAdd;
            }
            else
            {
                //TODO: outOfValue Exception
            }
        }

    }
}
