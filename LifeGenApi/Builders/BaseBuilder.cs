using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Troschuetz.Random;

namespace LifeGenApi.Builders
{
    public abstract class BaseBuilder<T>
    {
        protected T Entity { get; set; }

        public virtual T GetEntity => Entity;

        public abstract BaseBuilder<T> WithRandomizedDefaults(TRandom randomizer);

        public T Build()
        {
            return Entity;
        }
    }
}
