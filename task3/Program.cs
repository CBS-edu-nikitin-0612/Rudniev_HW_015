using System;

namespace task3
{
    class Program
    {
        private static void playableMethod(IPlayable player)
        {
            player.Play();
            player.Pause();
            player.Stop();
        }
        private static void recodableMethod(IRecodable player)
        {
            player.Record();
            player.Pause();
            player.Stop();
        }
        static void Main(string[] args)
        {
            Player player = new Player("newFile");
            Console.Write("Выберите действие, проигрывание-'P' запись-'R': ");
            string sw1 = Console.ReadLine().ToUpper();
            switch (sw1)
            {
                case "P":
                    playableMethod(player);
                    break;
                case "R":
                    recodableMethod(player);
                    break;
            }
        }
    }
}
