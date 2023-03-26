
namespace HomeWork2
{
    public class Audio : Appliances
    {
        public int MaxVolume { get; set; } = 0;
        public string? Brand { get; }
        internal bool IsUsed { get; set; } = false;
        public Audio(int price, string? name, string brand) : base(price, name)
        {
            Brand = brand;
        }

        public Audio()
        {
            Console.WriteLine("No name audio equipment created!");
        }
        public override void Action()
        {
            PrintInformation();
        }

        private void PrintInformation()
        {
            Console.WriteLine("Playing music");
        }

        public static bool operator >(Audio a, Audio b) => a.Price > b.Price;
        public static bool operator <(Audio a, Audio b) => a.Price < b.Price;

    }
}
