using System;
using System.Collections.Generic;
using System.Text;

namespace Basic1
{
    class Car
    {
        private Engine _engine;

        public Car(Engine engine)
        {
            this._engine = engine;
        }

        public bool Start()
        {
            if (this._engine is null)
            {
                return false;
            }
            else
            {
                this._engine.Start();
                return true;
            }
        }
    }
}
