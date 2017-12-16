using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRDExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test implementations A
            MyEntityCollectionA aCollection = new MyEntityCollectionA();
            aCollection.Add(new MyEntity(1));
            aCollection.Add(new MyEntity(5));
            aCollection.Add(new MyEntity(3));
            aCollection.Add(new MyEntity(2));
            aCollection.Add(new MyEntity(6));

            var max = aCollection.RemoveMaxValue();
            Console.WriteLine("A - Remove " + max.GetValue());

            max = aCollection.RemoveMaxValue();
            Console.WriteLine("A - Remove " + max.GetValue());

            //Test implementations B
            MyEntityCollectionB bCollection = new MyEntityCollectionB();
            bCollection.Add(new MyEntity(1));
            bCollection.Add(new MyEntity(5));
            bCollection.Add(new MyEntity(3));
            bCollection.Add(new MyEntity(2));
            bCollection.Add(new MyEntity(6));

            max = bCollection.RemoveMaxValue();
            Console.WriteLine("B - Remove " + max.GetValue());

            max = bCollection.RemoveMaxValue();
            Console.WriteLine("B - Remove " + max.GetValue());

            //Test implementations C
            MyEntityCollectionC cCollection = new MyEntityCollectionC();
            cCollection.Add(new MyEntity(1));
            cCollection.Add(new MyEntity(5));
            cCollection.Add(new MyEntity(3));
            cCollection.Add(new MyEntity(2));
            cCollection.Add(new MyEntity(6));
            cCollection.Add(new MyEntity(3));

            max = cCollection.RemoveMaxValue();
            Console.WriteLine("C - Remove " + max.GetValue());

            max = cCollection.RemoveMaxValue();
            Console.WriteLine("C - Remove " + max.GetValue());

            max = cCollection.RemoveMaxValue();
            Console.WriteLine("C - Remove " + max.GetValue());
        }
    }
}
