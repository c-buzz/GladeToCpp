﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GladeConstructor {
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
    internal class ConfigurationResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ConfigurationResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GladeConstructor.ConfigurationResource", typeof(ConfigurationResource).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;configuration&gt;
        ///	&lt;objectlist&gt;
        ///		&lt;object&gt;&lt;/object&gt;
        ///	&lt;/objectlist&gt;
        ///&lt;/configuration&gt;.
        /// </summary>
        internal static string config {
            get {
                return ResourceManager.GetString("config", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;signals&gt;
        ///  &lt;signal name=&quot;activate-link&quot; caller=&quot;aboutdialog&quot;&gt;
        ///    &lt;method&gt;signal_activate_link()&lt;/method&gt;
        ///    &lt;prototype&gt;bool on_activate_link(const std::string&amp;amp; uri)&lt;/prototype&gt;
        ///  &lt;/signal&gt;
        ///  &lt;signal name=&quot;activate&quot; caller=&quot;action&quot;&gt;
        ///    &lt;method&gt;signal_activate()&lt;/method&gt;
        ///    &lt;prototype&gt;void on_activate()&lt;/prototype&gt;
        ///  &lt;/signal&gt;
        ///  &lt;signal name=&quot;changed&quot; caller=&quot;adjustment&quot;&gt;
        ///    &lt;method&gt;signal_changed()&lt;/method&gt;
        ///    &lt;prototype&gt;void on_changed()&lt;/prototy [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string signals {
            get {
                return ResourceManager.GetString("signals", resourceCulture);
            }
        }
    }
}
