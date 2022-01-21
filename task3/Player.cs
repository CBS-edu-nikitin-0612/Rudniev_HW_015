using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Player : IPlayable, IRecodable
    {
        private readonly string fileName;
        public string FileName => fileName;
        public Player(string fileName) => this.fileName = fileName;

        void IPlayable.Play() => Console.WriteLine("playback started;");
        void IPlayable.Pause() => Console.WriteLine("playback paused;");
        void IPlayable.Stop() => Console.WriteLine("playback stopped;");

        void IRecodable.Record() => Console.WriteLine("recording started;");
        void IRecodable.Pause() => Console.WriteLine("recording paused;");
        void IRecodable.Stop() => Console.WriteLine("recording stopped;");
    }
}
