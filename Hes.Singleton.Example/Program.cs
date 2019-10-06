using System;
using System.Text;
using System.Threading.Tasks;
using Hes.Singleton;

namespace Hes.Singleton.Example {
    class Program
    {
        static void Main(string[] args) {


            var managers = SingletonManager.Instance;
            managers.Register<ParameterfulCtor>();
            var poar = managers.Get<GameManager>();
            try{
                var singleTonWithPublicCtor = WithPublicCtor.Instance;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} : {ex.Message}");
            }
        }
    }
}