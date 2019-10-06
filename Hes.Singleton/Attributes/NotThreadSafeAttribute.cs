using System;

namespace Hes.Singleton.Attributes {
    
    /// <summary>
    /// Indicates the implementation is not thread safe.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class NotThreadSafeAttribute : Attribute {
      
    }
}