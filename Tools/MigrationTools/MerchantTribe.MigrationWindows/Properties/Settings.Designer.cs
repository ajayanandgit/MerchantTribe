﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MerchantTribe.MigrationWindows.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost/bv6")]
        public string DestinationRootUrl {
            get {
                return ((string)(this["DestinationRootUrl"]));
            }
            set {
                this["DestinationRootUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ApiKey {
            get {
                return ((string)(this["ApiKey"]));
            }
            set {
                this["ApiKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("BV5")]
        public global::MerchantTribe.Migration.MigrationSourceType SourceType {
            get {
                return ((global::MerchantTribe.Migration.MigrationSourceType)(this["SourceType"]));
            }
            set {
                this["SourceType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ImportCategories {
            get {
                return ((bool)(this["ImportCategories"]));
            }
            set {
                this["ImportCategories"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ImportProducts {
            get {
                return ((bool)(this["ImportProducts"]));
            }
            set {
                this["ImportProducts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ImportUsers {
            get {
                return ((bool)(this["ImportUsers"]));
            }
            set {
                this["ImportUsers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ImportAffiliates {
            get {
                return ((bool)(this["ImportAffiliates"]));
            }
            set {
                this["ImportAffiliates"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ImportOrders {
            get {
                return ((bool)(this["ImportOrders"]));
            }
            set {
                this["ImportOrders"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ImportOther {
            get {
                return ((bool)(this["ImportOther"]));
            }
            set {
                this["ImportOther"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ClearCategories {
            get {
                return ((bool)(this["ClearCategories"]));
            }
            set {
                this["ClearCategories"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ClearProducts {
            get {
                return ((bool)(this["ClearProducts"]));
            }
            set {
                this["ClearProducts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ClearOrders {
            get {
                return ((bool)(this["ClearOrders"]));
            }
            set {
                this["ClearOrders"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ClearAffiliates {
            get {
                return ((bool)(this["ClearAffiliates"]));
            }
            set {
                this["ClearAffiliates"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseMetricUnits {
            get {
                return ((bool)(this["UseMetricUnits"]));
            }
            set {
                this["UseMetricUnits"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SingleOrderImport {
            get {
                return ((string)(this["SingleOrderImport"]));
            }
            set {
                this["SingleOrderImport"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SingleSkuImport {
            get {
                return ((string)(this["SingleSkuImport"]));
            }
            set {
                this["SingleSkuImport"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SingleOrderOn {
            get {
                return ((bool)(this["SingleOrderOn"]));
            }
            set {
                this["SingleOrderOn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SingleSkuOn {
            get {
                return ((bool)(this["SingleSkuOn"]));
            }
            set {
                this["SingleSkuOn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("localhost")]
        public string SQLServer {
            get {
                return ((string)(this["SQLServer"]));
            }
            set {
                this["SQLServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("bvc5")]
        public string SQLDatabase {
            get {
                return ((string)(this["SQLDatabase"]));
            }
            set {
                this["SQLDatabase"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("sa")]
        public string SQLUsername {
            get {
                return ((string)(this["SQLUsername"]));
            }
            set {
                this["SQLUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SQLPassword {
            get {
                return ((string)(this["SQLPassword"]));
            }
            set {
                this["SQLPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("c:\\inetpub\\wwwroot")]
        public string ImagesRootFolder {
            get {
                return ((string)(this["ImagesRootFolder"]));
            }
            set {
                this["ImagesRootFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public string UserStartPage {
            get {
                return ((string)(this["UserStartPage"]));
            }
            set {
                this["UserStartPage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public string ProductStartPage {
            get {
                return ((string)(this["ProductStartPage"]));
            }
            set {
                this["ProductStartPage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ProductImagesOnly {
            get {
                return ((bool)(this["ProductImagesOnly"]));
            }
            set {
                this["ProductImagesOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisableMultiThreading {
            get {
                return ((bool)(this["DisableMultiThreading"]));
            }
            set {
                this["DisableMultiThreading"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SkipProductPrerequisites {
            get {
                return ((bool)(this["SkipProductPrerequisites"]));
            }
            set {
                this["SkipProductPrerequisites"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ClearUsers {
            get {
                return ((bool)(this["ClearUsers"]));
            }
            set {
                this["ClearUsers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost/bv6")]
        public string SourceRootUrl {
            get {
                return ((string)(this["SourceRootUrl"]));
            }
            set {
                this["SourceRootUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SourceApiKey {
            get {
                return ((string)(this["SourceApiKey"]));
            }
            set {
                this["SourceApiKey"] = value;
            }
        }
    }
}
