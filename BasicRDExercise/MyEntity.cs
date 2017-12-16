using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRDExercise
{
    public class MyEntity : Entity, IComparable<Entity>
    {
        private int id;

        public MyEntity(int newId)
        {
            id = newId;
        }

        public int CompareTo(Entity other)
        {
            if (other == null) return 1;

            return this.id.CompareTo(other.GetValue());
        }

        public int GetValue()
        {
            return id;
        }
    }
}