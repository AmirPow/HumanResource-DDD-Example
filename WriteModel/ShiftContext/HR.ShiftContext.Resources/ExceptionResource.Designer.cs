﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HR.ShiftContext.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ExceptionResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HR.ShiftContext.Resources.ExceptionResource", typeof(ExceptionResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ایندکس وارد شده باید بزرگتر از صفر باشد..
        /// </summary>
        public static string IndexMustMoreThanZeroExceptions {
            get {
                return ResourceManager.GetString("IndexMustMoreThanZeroExceptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ایندکس وارد شده حتما باید بصورت عددی باشد..
        /// </summary>
        public static string IndexShouldBeNumberExceptions {
            get {
                return ResourceManager.GetString("IndexShouldBeNumberExceptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ایندکس وارد شده تکراری می باشد..
        /// </summary>
        public static string ShiftSegmentIndexCanNotBeDuplicateExceptions {
            get {
                return ResourceManager.GetString("ShiftSegmentIndexCanNotBeDuplicateExceptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ساعت خروج نباید قبل از ساعت ورود باشد..
        /// </summary>
        public static string ShiftSegmentTimeDifferenceExceptions {
            get {
                return ResourceManager.GetString("ShiftSegmentTimeDifferenceExceptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to عنوان شیفت نباید خالی باشد..
        /// </summary>
        public static string ShiftTitleMustNotBeEmptyOrWhiteSpaceExceptions {
            get {
                return ResourceManager.GetString("ShiftTitleMustNotBeEmptyOrWhiteSpaceExceptions", resourceCulture);
            }
        }
    }
}
