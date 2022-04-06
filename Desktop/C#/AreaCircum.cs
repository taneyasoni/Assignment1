using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            float Ar = c1.Area();
            float c = c1.circumference();
            Console.WriteLine("Area={0}, circumference={1}", Ar,c);
        }
    }
    class Circle
    {
        float _PI = 3.14f;
        int _Radius;

        public Circle(int Radius)
        {
            this._Radius = Radius;
        }
        public float Area()
        {
            return this._PI* this._Radius*this._Radius;
        }
        public float circumference()
        {
            return this._PI * this._Radius * 2;
        }
    }
}
