using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace BusinessForensics
{
    class Program
    {
        static void Main(string[] args)
        {
            var mammals = new ObservableCollection<Mammal>
            {
                new Dog(),
                new Wolf(),
                new Dolphin(),
                new Tarantula(),
                new Shark(),
            };

            IEnumerable<Mammal> dangerousAnimals = mammals.Where(m => m is IDangerous);
        }
    }
}
