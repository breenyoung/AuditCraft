﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuditTool.Properties {
    
    
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
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PREFERRED_REALM {
            get {
                return ((string)(this["PREFERRED_REALM"]));
            }
            set {
                this["PREFERRED_REALM"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection RECENT_QUERIES {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["RECENT_QUERIES"]));
            }
            set {
                this["RECENT_QUERIES"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PREFERRED_AUDITMODE {
            get {
                return ((string)(this["PREFERRED_AUDITMODE"]));
            }
            set {
                this["PREFERRED_AUDITMODE"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int PREFERRED_MINLEVEL {
            get {
                return ((int)(this["PREFERRED_MINLEVEL"]));
            }
            set {
                this["PREFERRED_MINLEVEL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int PREFERRED_MINILEVEL {
            get {
                return ((int)(this["PREFERRED_MINILEVEL"]));
            }
            set {
                this["PREFERRED_MINILEVEL"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.96")]
        public double VERSION {
            get {
                return ((double)(this["VERSION"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int HISTORY_ENTRIES {
            get {
                return ((int)(this["HISTORY_ENTRIES"]));
            }
            set {
                this["HISTORY_ENTRIES"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("US")]
        public string REGION {
            get {
                return ((string)(this["REGION"]));
            }
            set {
                this["REGION"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection LABELS {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["LABELS"]));
            }
            set {
                this["LABELS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CHAR_CACHE_ENABLE {
            get {
                return ((bool)(this["CHAR_CACHE_ENABLE"]));
            }
            set {
                this["CHAR_CACHE_ENABLE"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7")]
        public int CHAR_CACHE_DAYS {
            get {
                return ((int)(this["CHAR_CACHE_DAYS"]));
            }
            set {
                this["CHAR_CACHE_DAYS"] = value;
            }
        }
    }
}
