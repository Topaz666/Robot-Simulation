using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circuit_png
{
    public enum Elements
    {
        Resistor = 1,
        Inductor,
        Capcitor,
        Power,
    }

    public class ElementHome
    {
        public readonly Elements Elementkeywords;
        public readonly int ElementNum;

        public ElementHome(Elements Element, int num)
        {

        }

        public ElementHome()
        {
            throw new System.NotImplementedException();
        }
    }
}