using System;

namespace Project2
{
    class Pesawat
    {
        protected string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        protected int _wheelAmount;
        public int wheelAmount
        {
            get { return _wheelAmount; }
            set { _wheelAmount = value; }
        }
        protected int _passengerAmount;
        public int passengerAmount
        {
            get { return _passengerAmount; }
            set { _passengerAmount = value; }
        }
        protected string _height;
        public string height
        {
            get { return _height; }
            set { _height = value; }
        }

        public virtual void terbang()
        {
            Console.WriteLine("Pesawat dengan nama {0}, sedang take off", this._name);
        }
        public void sudahTerbang()
        {
            Console.WriteLine("Pesawat sekarang berada pada ketinggian {0}", this._height);
        }
    }
}
