﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Self_Discipline {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.3.0.0")]
    internal sealed partial class PlanSetting : global::System.Configuration.ApplicationSettingsBase {
        
        private static PlanSetting defaultInstance = ((PlanSetting)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new PlanSetting())));
        
        public static PlanSetting Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PlanJsonPath {
            get {
                return ((string)(this["PlanJsonPath"]));
            }
            set {
                this["PlanJsonPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Red")]
        public global::System.Drawing.Color PlanBackColor {
            get {
                return ((global::System.Drawing.Color)(this["PlanBackColor"]));
            }
            set {
                this["PlanBackColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection SoundFiles {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SoundFiles"]));
            }
            set {
                this["SoundFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoStart {
            get {
                return ((bool)(this["AutoStart"]));
            }
            set {
                this["AutoStart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.DateTime StartDate {
            get {
                return ((global::System.DateTime)(this["StartDate"]));
            }
            set {
                this["StartDate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool RemindUnComplete {
            get {
                return ((bool)(this["RemindUnComplete"]));
            }
            set {
                this["RemindUnComplete"] = value;
            }
        }
    }
}