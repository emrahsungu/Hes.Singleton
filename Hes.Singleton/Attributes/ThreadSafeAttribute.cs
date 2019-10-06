using System;

namespace Hes.Singleton.Attributes {

    /// <summary>
    /// Indicates that the implementation is thread safe.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Class)]
    public class ThreadSafeAttribute : Attribute {

    }
}