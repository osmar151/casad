﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace casad
{
    class Casa
    {

        private static SerialPort Arduino = new SerialPort("COM9", 9600);

        public void EnviarCaracter(string dato)
        {
            Arduino.Open();
            Arduino.Write(dato);
            Arduino.Close();
        }

    }

}
