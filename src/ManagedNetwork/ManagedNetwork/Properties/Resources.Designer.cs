﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedNetwork.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.PowerShell.Cmdlets.ManagedNetwork.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {0} exists. Are you sure you want to delete it..
        /// </summary>
        internal static string ConfirmDeleteResource {
            get {
                return ResourceManager.GetString("ConfirmDeleteResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} already exists. Are you sure you want to overwrite it..
        /// </summary>
        internal static string ConfirmOverwriteResource {
            get {
                return ResourceManager.GetString("ConfirmOverwriteResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating Resource....
        /// </summary>
        internal static string CreatingResource {
            get {
                return ResourceManager.GetString("CreatingResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting Resource....
        /// </summary>
        internal static string DeletingResource {
            get {
                return ResourceManager.GetString("DeletingResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A Managed Network with name &apos;{0}&apos; in resource group &apos;{1}&apos; does not exist. Please use New-AzManagedNetwork to create a Managed Network with these properties..
        /// </summary>
        internal static string ManagedNetworkDoesNotExist {
            get {
                return ResourceManager.GetString("ManagedNetworkDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A Managed Network Group with name &apos;{0}&apos; in managed network &apos;{1}&apos; and  resource group &apos;{2}&apos; does not exist. Please use New-AzManagedNetwork to create a Managed Network with these properties..
        /// </summary>
        internal static string ManagedNetworkGroupDoesNotExist {
            get {
                return ResourceManager.GetString("ManagedNetworkGroupDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A Managed Network Peering Policy with name &apos;{0}&apos; in managed network &apos;{1}&apos; and  resource group &apos;{2}&apos; does not exist. Please use New-AzManagedNetwork to create a Managed Network with these properties..
        /// </summary>
        internal static string ManagedNetworkPeeringPolicyDoesNotExist {
            get {
                return ResourceManager.GetString("ManagedNetworkPeeringPolicyDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating Resource....
        /// </summary>
        internal static string UpdatingResource {
            get {
                return ResourceManager.GetString("UpdatingResource", resourceCulture);
            }
        }
    }
}
