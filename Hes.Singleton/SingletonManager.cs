using System;
using System.Collections.Generic;
using Hes.Singleton.Attributes;
using Hes.Singleton.Exceptions;


namespace Hes.Singleton {
    public class SingletonManager : SingletonBase<SingletonManager> {
        
        /// <summary>
        /// Cache which holds Type and its lazily instantiated object.
        /// </summary>
        private readonly Dictionary<Type, Lazy<object>> _cache = new Dictionary<Type, Lazy<object>>();

        /// <summary>
        /// Classes implementing <see cref="SingletonBase{T}"/> can be registered at <see cref="SingletonManager"/>.
        /// </summary>
        private SingletonManager() {
        }

        /// <summary>
        /// Registers the given type to <see cref="SingletonManager"/>.
        /// </summary>
        /// <typeparam name="T">Type to register to <see cref="SingletonManager"/></typeparam>
        /// <exception cref="AlreadyRegisteredTypeException">Throws if the type being registered is already registered.</exception>
        [NotThreadSafe]
        public void Register<T>() where T : SingletonBase<T> {
            if (_cache.ContainsKey(typeof(T))) {
                throw new AlreadyRegisteredTypeException(typeof(T));
            }
            _cache[typeof(T)] = new Lazy<object>(() => SingletonBase<T>.Instance);
        }

        /// <summary>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [ThreadSafe]
        public T Get<T>() where T : SingletonBase<T> {
            if (_cache.TryGetValue(typeof(T), out var value)) {
                return (T) value.Value;
            }
            throw new NotRegisteredTypeException(typeof(T));
        }
    }
}