using System;

namespace Hes.Singleton.Attributes {
    [AttributeUsage(AttributeTargets.Method|AttributeTargets.Class)]
    public class NotThreadSafeAttribute : Attribute {
    
        /// <summary>
        /// 
        /// </summary>
        public NotThreadSafeAttribute()
        {

        }
    }
}