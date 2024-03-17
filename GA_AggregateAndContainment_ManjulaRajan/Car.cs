using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_ManjulaRajan
{
    internal class Car
    {

        string _make;
        string _model;
        Engine _engine;
        Suspension _suspension;

        public Car(string make, string model, Engine engine, Suspension suspension)
        {
            _make = make;
            _model = model;
            _engine = engine;
            _suspension = suspension;
        }

        public override string ToString()
        {
            return $"{_make} {_model} : {_engine.Hp}";
        }
    }
}
