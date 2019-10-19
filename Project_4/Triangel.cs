using System;
using System.Collections.Generic;
using System.Text;

namespace Project_4
{
    class Triangel : Shape, IScale
    {
        readonly string _name;
        double _triangelHight;
        double _triangelBase;

        public double TriangelHight
        {
            get { return _triangelHight; }
            set { _triangelHight = value; }
        }

        public double TriangelBase
        {
            get { return _triangelBase; }
            set { _triangelBase = value; }
        }

        public override double Scale()
        {
            double scale = 0.5 * _triangelBase * _triangelHight;
            return scale;
        }

        public Triangel()
        {
            _name = "Triangel";
            AskUser(_name);
            _triangelHight = UserInsert();
            _triangelBase = UserInsert();
        }
    }
}
