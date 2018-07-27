using System;
using ImplicitArg.Extensions;

namespace ImplicitArg.Utilities
{
    public static class LambdaHelper
    {
        /// <summary>
        /// Run the action and return this;
        /// </summary>
        /// <param name="this"></param>
        /// <param name="action"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private static T Run<T>(T @this, Action action)
        {
            action();
            return @this;
        }

        /// <summary>
        /// Chain the actions and return this
        /// </summary>
        /// <param name="retVal"></param>
        /// <param name="actions"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Chain<T>(T retVal, params Action[] actions) =>
            Run(retVal, () => actions.ForEach(x => x.Invoke()));
    }
}