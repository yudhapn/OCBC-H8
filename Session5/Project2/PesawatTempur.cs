using System;

namespace Project2
{
    class PesawatTempur : Pesawat
    {
        public PesawatTempur()
        {
            inputPesawatData();
        }

        private void inputPesawatData()
        {
            Console.Write("\nName: ");
            this.name = Console.ReadLine();
            Console.Write("Amount wheels: ");
            this.wheelAmount = int.Parse(Console.ReadLine());
            Console.Write("Passenger capacity: ");
            this.passengerAmount = int.Parse(Console.ReadLine());
            Console.Write("Height: ");
            this.height = Console.ReadLine();
        }

        public override void terbang()
        {
            Console.WriteLine("Pesawat tempur dengan nama: {0}, yang mempunyai jumlah roda: {1}, sedang berada pada ketinggian: {2} dengan membawa jumlah penumpang sebanyak {3} akan meledakkan senjata", this._name, this._wheelAmount, this._height, this._passengerAmount);
        }
    }
}
