﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wpftest.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Provider=VFPOLEDB.1;Data Source=C:\\Users\\pmolina\\Downloads\\Tablas\\TablasSource")]
        public string ConnectionString {
            get {
                return ((string)(this["ConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\pmolina\\Documents\\Visual Studio 2015\\Projects\\wpftest\\wpftest\\TablasSour" +
            "ce")]
        public string SourceDirectory {
            get {
                return ((string)(this["SourceDirectory"]));
            }
            set {
                this["SourceDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>merc.DBF</string>
  <string>movde.DBF</string>
  <string>movma.DBF</string>
  <string>sucursales.DBF</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection DBFFiles {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["DBFFiles"]));
            }
            set {
                this["DBFFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\pmolina\\Documents\\Visual Studio 2015\\Projects\\wpftest\\wpftest\\TablasSour" +
            "ce\\zipped")]
        public string DestDirectory {
            get {
                return ((string)(this["DestDirectory"]));
            }
            set {
                this["DestDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Facturas.Zip")]
        public string ZipFilename {
            get {
                return ((string)(this["ZipFilename"]));
            }
            set {
                this["ZipFilename"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\pmolina\\Documents\\Visual Studio 2015\\Projects\\wpftest\\wpftest\\TablasSour" +
            "ce\\temp")]
        public string TempDirectory {
            get {
                return ((string)(this["TempDirectory"]));
            }
            set {
                this["TempDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CleanTempFolderFlag {
            get {
                return ((bool)(this["CleanTempFolderFlag"]));
            }
            set {
                this["CleanTempFolderFlag"] = value;
            }
        }
    }
}
