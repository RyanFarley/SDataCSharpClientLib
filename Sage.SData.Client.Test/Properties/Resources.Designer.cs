﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.21006.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sage.SData.Client.Test.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Sage.SData.Client.Test.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;entry xmlns:sme=&quot;http://schemas.sage.com/sdata/sme/2007&quot;
        ///       xmlns:sdata=&quot;http://schemas.sage.com/sdata/2008/1&quot;
        ///       xmlns:cf=&quot;http://www.microsoft.com/schemas/rss/core/2005&quot;
        ///       xmlns=&quot;http://www.w3.org/2005/Atom&quot;&gt;
        ///  &lt;id&gt;http://localhost:8001/sdata/aw/dynamic/-/employees(1)&lt;/id&gt;
        ///  &lt;link href=&quot;http://localhost:8001/sdata/aw/dynamic/-/employees(1)?format=html&quot; rel=&quot;alternate&quot; type=&quot;text/html&quot; title=&quot;&quot; /&gt;
        ///  &lt;link href=&quot;http://localhost:8001/sdata/aw/dynam [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TestEntry {
            get {
                return ResourceManager.GetString("TestEntry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;feed xmlns:sme=&quot;http://schemas.sage.com/sdata/sme/2007&quot;
        ///      xmlns:sdata=&quot;http://schemas.sage.com/sdata/2008/1&quot;
        ///      xmlns:cf=&quot;http://www.microsoft.com/schemas/rss/core/2005&quot;
        ///      xmlns:opensearch=&quot;http://a9.com/-/spec/opensearch/1.1/&quot;
        ///      xmlns=&quot;http://www.w3.org/2005/Atom&quot;&gt;
        ///  &lt;author&gt;
        ///    &lt;name&gt;aw&lt;/name&gt;
        ///    &lt;uri /&gt;
        ///    &lt;email /&gt;
        ///  &lt;/author&gt;
        ///  &lt;category term=&quot;&quot; scheme=&quot;&quot; label=&quot;&quot; /&gt;
        ///  &lt;generator uri=&quot;&quot; version=&quot;1.0&quot;&gt;Sage Dynamic Integration Adapter&lt; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TestFeed {
            get {
                return ResourceManager.GetString("TestFeed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xs:schema xmlns:tns=&quot;http://schemas.sage.com/demoErp&quot; targetNamespace=&quot;http://schemas.sage.com/demoErp&quot; xmlns:sme=&quot;http://schemas.sage.com/sdata/sme/2007&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot; elementFormDefault=&quot;qualified&quot;&gt;
        ///  &lt;!-- Resource Kind Definition --&gt;
        ///  &lt;xs:element name=&quot;product&quot; type=&quot;tns:product--type&quot; sme:role=&quot;resourceKind&quot; sme:pluralName=&quot;products&quot; sme:label=&quot;Product&quot; sme:canGet=&quot;true&quot; sme:canPost=&quot;true&quot; sme:canPut=&quot;true&quot; sme:canDelete=&quot;true&quot; sm [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TestSchema {
            get {
                return ResourceManager.GetString("TestSchema", resourceCulture);
            }
        }
    }
}
