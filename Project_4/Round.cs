using System;
using System.Collections.Generic;
using System.Text;

namespace Project_4
{
    class Round : Shape, IScale
    {
        readonly string _name;
        double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public override double Scale()
        {
            double result = Math.PI * Math.Pow(_radius,2);
            return result;
        }

        public Round()
        {
            _name = "Round";
            AskUser(_name);
            _radius = UserInsert();
        }
    }
}
