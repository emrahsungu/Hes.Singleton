using System;

namespace Hes.Singleton.Attributes {
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Class)]
    public class ThreadSafeAttribute : Attribute {

        /// <summary>
        /// 
        /// </summary>
        public ThreadSafeAttribute() {
        
        }
    }
}