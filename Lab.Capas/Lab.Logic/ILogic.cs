using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    interface ILogic<T>
    {
        List<T> GetAll();

        T GetOne(int id);

        T GetOne(T obj);

        int GetId(T obj);

        bool Create(T obj);

        bool Update(T obj);

        bool Delete(T obj);




    }
}
