using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRDExercise
{
    public class MyEntityCollectionB : EntityCollection
    {
        private SortedDictionary<int, Entity> _collection;

        public MyEntityCollectionB()
        {
            _collection = new SortedDictionary<int, Entity>();
        }

        public void Add(Entity entity)
        {
            // O(log n)
            _collection.Add(entity.GetValue(), entity);
        }

        public Entity RemoveMaxValue()
        {
            // O(1)
            var maxEntity = _collection.LastOrDefault();

            // O(log n)
            _collection.Remove(maxEntity.Key);

            return maxEntity.Value;
        }
    }
}
