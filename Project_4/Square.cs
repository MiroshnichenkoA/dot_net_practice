using System;
using System.Collections.Generic;
using System.Text;

namespace Project_4
{
    public class Square : Shape, IScale
    {
        readonly string _name;
        double _firstSideOfSquare;
        double _secondSideOfSquare;

        public double FirstSideOfSquare
        {
            get { return _firstSideOfSquare; }
            set {_firstSideOfSquare = value; }
        }

        public double SecondSideOfSquare
        {
            get { return _secondSideOfSquare; }
            set {_secondSideOfSquare = value; }
        }

        public override double Scale()
        {
            double scale = _firstSideOfSquare * _secondSideOfSquare;
            return scale;
        }

        public Square()
        {
            _name = "Square";
            AskUser(_name);
            _firstSideOfSquare = UserInsert();
            _secondSideOfSquare = UserInsert();
        }
    }
}
