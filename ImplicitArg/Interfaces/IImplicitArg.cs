using System;
using System.Linq.Expressions;

namespace ImplicitArg.Interfaces
{
    public interface IImplicitArg<out TSource> where TSource: class
    {
        IImplicitArg<TSource> SetCalleThis<T>(T @this) where T: class;

        T GetCalleThis<T>() where T: class;

        TSource Self();
    }
}