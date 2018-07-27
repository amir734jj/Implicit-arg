using System;
using System.Collections.Generic;
using ImplicitArg.Interfaces;
using static ImplicitArg.Utilities.LambdaHelper;

namespace ImplicitArg
{
    public abstract class ImplicitArg<TSource> : IImplicitArg<TSource> where TSource : class
    {
        /// <summary>
        /// Initialize the implicits dictionary
        /// </summary>
        private readonly Dictionary<Type, object> _implicits = new Dictionary<Type, object>();

        /// <summary>
        /// Set calle instance
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        public IImplicitArg<TSource> SetCalleThis<T>(T @this) where T : class =>
            Chain(this, () => _implicits[typeof(T)] = @this);

        /// <summary>
        /// Returns calle instance
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetCalleThis<T>() where T : class => Chain(_implicits.ContainsKey(typeof(T)) ?
            _implicits[typeof(T)] as T : Activator.CreateInstance<T>());

        /// <summary>
        /// Return self
        /// </summary>
        /// <returns></returns>
        public TSource Self()=> this as TSource;
    }
}