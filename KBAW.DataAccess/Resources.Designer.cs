﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KBAW.DataAccess {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("KBAW.DataAccess.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to No material found with this key: {0}.
        /// </summary>
        public static string material_does_not_exist_msg {
            get {
                return ResourceManager.GetString("material_does_not_exist_msg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Material not found in table..
        /// </summary>
        public static string material_not_found_msg {
            get {
                return ResourceManager.GetString("material_not_found_msg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not data or not explored.
        /// </summary>
        public static string wr_not_data_lbl {
            get {
                return ResourceManager.GetString("wr_not_data_lbl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Poor quality connection.
        /// </summary>
        public static string wr_poor_quality_connection_lbl {
            get {
                return ResourceManager.GetString("wr_poor_quality_connection_lbl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Quality connection.
        /// </summary>
        public static string wr_quality_connection_lbl {
            get {
                return ResourceManager.GetString("wr_quality_connection_lbl", resourceCulture);
            }
        }
    }
}
