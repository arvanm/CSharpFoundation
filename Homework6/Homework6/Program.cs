﻿using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;





namespace Homework6
{

    class Television
    {

        private int channel = 0;
        private int volume = 0;
        private bool isOn = false;

        public bool IsOn
        {
            get { return isOn; }
            set { isOn = IsOn; }
        }

        public int Volume
        {
            get { return volume; }
            set { volume = volume + 1; }
        }

        public int Channel
        {
            get { return channel; }
            set { channel = Channel; }
        }

    }
    
    class TestTV
    {
        static void Main()
        {
            Television tv = new Television();

            if (!tv.IsOn)
            {
                tv.IsOn = true;
            }

            tv.Channel = 3;

            tv.Volume++;

            tv.Volume++;

            tv.Volume++;

            tv.Volume++;

            tv.IsOn = false;
        }
    }
}