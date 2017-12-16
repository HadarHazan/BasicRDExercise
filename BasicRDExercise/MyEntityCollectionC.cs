using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRDExercise
{
    public class MyEntityCollectionC : EntityCollection
    {
        private LinkedList<MyEntity> _collection;

        public MyEntityCollectionC()
        {
            _collection = new LinkedList<MyEntity>();
        }

        public void Add(Entity entity)
        {
            // O(n)
            sortedInsert(entity as MyEntity);
        }

        public Entity RemoveMaxValue()
        {
            // O(1)
            var maxEntity = _collection.Last();

            // O(1)
            _collection.Remove(maxEntity);

            return maxEntity;
        }

        private void sortedInsert(MyEntity newEntity)
        {
            if (_collection.Count() == 0)
            {
                _collection.AddFirst(newEntity);
            }
            else
            {
                LinkedListNode<MyEntity> current = _collection.First;

                while (current.Next != null && (newEntity.CompareTo(current.Next.Value) > -1) )
                {
                    current = current.Next;
                }

                _collection.AddAfter(current, newEntity);
            }
        }
    }
}