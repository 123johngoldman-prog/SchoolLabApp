using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.Repositories
{
    public interface ICategory<T>:IBaseRepo<T> where T : class
    {
    }
}
