﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ism7mqtt {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ism7mqtt.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] client {
            get {
                object obj = ResourceManager.GetObject("client", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;ConverterTemplateConfig xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot; xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; Version=&quot;1&quot;&gt;
        ///  &lt;ConverterTemplates&gt;
        ///    &lt;NumericConverter16Template CTID=&quot;1000&quot;&gt;
        ///      &lt;TelegramNr&gt;5&lt;/TelegramNr&gt;
        ///      &lt;Type&gt;SS10&lt;/Type&gt;
        ///    &lt;/NumericConverter16Template&gt;
        ///    &lt;NumericConverter16Template CTID=&quot;1001&quot;&gt;
        ///      &lt;TelegramNr&gt;8&lt;/TelegramNr&gt;
        ///      &lt;Type&gt;SS10&lt;/Type&gt;
        ///    &lt;/NumericConverter16Template&gt;
        ///    &lt;NumericConverter16Templat [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ConverterTemplates {
            get {
                return ResourceManager.GetString("ConverterTemplates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;DeviceTemplateConfig xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot; xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; Version=&quot;1&quot;&gt;
        ///  &lt;DeviceTemplates&gt;
        ///    &lt;DeviceTemplate DTID=&quot;1000&quot; Name=&quot;DHK_BM&quot;&gt;
        ///      &lt;CustomerId&gt;WOLF&lt;/CustomerId&gt;
        ///      &lt;SoftwareNumber&gt;0x0&lt;/SoftwareNumber&gt;
        ///      &lt;WRSDeviceIds&gt;0x0&lt;/WRSDeviceIds&gt;
        ///      &lt;EnableEBus5InfoNumberTelegram&gt;false&lt;/EnableEBus5InfoNumberTelegram&gt;
        ///      &lt;HasOwnFaultMessageHistory&gt;false&lt;/HasOwnFaultMessageHistory&gt;
        ///    [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DeviceTemplates {
            get {
                return ResourceManager.GetString("DeviceTemplates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;ParameterTemplateConfig xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot; xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; Version=&quot;1&quot;&gt;
        ///  &lt;ParameterList&gt;
        ///    &lt;NumericParameterDescriptor PTID=&quot;1000&quot;&gt;
        ///      &lt;Name&gt;Tagtemperatur&lt;/Name&gt;
        ///      &lt;UnitName&gt;°C&lt;/UnitName&gt;
        ///      &lt;App&gt;true&lt;/App&gt;
        ///      &lt;RemoveConditionId&gt;False&lt;/RemoveConditionId&gt;
        ///      &lt;ReadOnlyConditionId&gt;False&lt;/ReadOnlyConditionId&gt;
        ///      &lt;InactiveConditionId&gt;False&lt;/InactiveConditionId&gt;
        ///      &lt;IsSnapshot [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ParameterTemplates {
            get {
                return ResourceManager.GetString("ParameterTemplates", resourceCulture);
            }
        }
    }
}
