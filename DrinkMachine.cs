using System;

namespace C_EDX
{
    class DrinksMachine
    {
        public DrinksMachine(string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Model = model;
        }
        private string _location;

        public string Location 
        {
            get {return _location; }
            set { _location = value;}
        }
        private string _make;

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        private string _model;

        public string Model 
        {
            get { return _model; }
            set { _model = value; }
        }

        public void MakeCappuccino()
        {
            Console.WriteLine("Cappuccino has been made");
        }
        public void MakeEspresso() 
        {

        }
    }
}
