using SchoolLabApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabApp.Repositories.Interfaces
{
    public interface ICategoryRepository<T> :IRepository<T>  where T : class
    {

    }
}
