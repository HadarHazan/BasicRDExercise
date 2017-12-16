using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRDExercise
{
    public class MyEntityCollectionA : EntityCollection
    {
        private LinkedList<MyEntity> _collection;

        public MyEntityCollectionA()
        {
            _collection = new LinkedList<MyEntity>();
        }

        public void Add(Entity entity)
        {
            // O(1)
            _collection.AddFirst(entity as MyEntity);
        }

        public Entity RemoveMaxValue()
        {   
            // O(n)
            var maxEntity = _collection.Max();

            // O(1)
            _collection.Remove(maxEntity);

            return maxEntity;
        }
    }
}
