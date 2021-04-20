using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    interface IDataAccess
    {
        public List<Products> LoadData();
        public void SaveData();

    }
}
