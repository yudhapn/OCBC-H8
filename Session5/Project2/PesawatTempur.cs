using System;

namespace Project2
{
    class PesawatTempur : Pesawat
    {
        public override void terbang()
        {
            Console.WriteLine("Pesawat tempur dengan nama: {0}, yang mempunyai jumlah roda: {1}, sedang berada pada ketinggian: {2} dengan membawa jumlah penumpang sebanyak {3} akan meledakkan senjata", this._name, this._wheelAmount, this._height, this._passengerAmount);
        }
    }
}
