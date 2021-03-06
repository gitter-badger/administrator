﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tAlert.DbVersion.Statements {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class MsSql {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MsSql() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("tAlert.DbVersion.Statements.MsSql", typeof(MsSql).Assembly);
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
        ///   Looks up a localized string similar to if NOT EXISTS (SELECT 1
        ///            FROM  sysobjects
        ///           WHERE  id = object_id(&apos;setting&apos;)
        ///            AND   type = &apos;U&apos;)
        ///BEGIN
        ///   
        ///CREATE TABLE setting (
        ///   [key]            nvarchar(50)          not null,
        ///   [value]          nvarchar(max)            not null,
        ///   constraint PK_SETTING_KEY primary key  ([key])
        ///)
        ///
        ///END
        ///
        ///IF NOT EXISTS(SELECT value as version
        ///				FROM [dbo].[setting]
        ///				WHERE [key] = &apos;DB.VERSION&apos;)
        ///INSERT INTO [dbo].[setting] ([key] ,[value])
        ///     VALUES
        ///           (&apos;DB. [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string QuerryGetCurrentVersion {
            get {
                return ResourceManager.GetString("QuerryGetCurrentVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IF db_id(@dbname) is null 
        ///	SELECT 0 AS bit
        ///ELSE 
        ///	SELECT 1 AS bit.
        /// </summary>
        internal static string QuerryIsDbExists {
            get {
                return ResourceManager.GetString("QuerryIsDbExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE [dbo].[setting]
        ///SET [value] = @dbversion
        ///WHERE [key] = &apos;DB.VERSION&apos;.
        /// </summary>
        internal static string UpdateDbVersion {
            get {
                return ResourceManager.GetString("UpdateDbVersion", resourceCulture);
            }
        }
    }
}
