using System;

namespace Hes.Singleton.Example {
    public class GameManager : SingletonBase<GameManager> {

        private GameManager() {

        }

        public void Initialize() {
            Console.WriteLine($"{nameof(GameManager)} is initialized...");
        }

        public void Update() {
            Console.WriteLine($"Calling Update...");
        }
    }
}