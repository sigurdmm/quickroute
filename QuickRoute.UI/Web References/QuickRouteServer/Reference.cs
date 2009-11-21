﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.3053.
// 
#pragma warning disable 1591

namespace QuickRoute.UI.QuickRouteServer {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="QuickRouteServerBinding", Namespace="http://www.matstroeng.se/quickroute/server")]
    public partial class QuickRouteServer : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetCurrentVersionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public QuickRouteServer() {
            this.Url = global::QuickRoute.UI.Properties.Settings.Default.QuickRoute_QuickRouteServer_QuickRouteServer;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetCurrentVersionCompletedEventHandler GetCurrentVersionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.matstroeng.se/quickroute/server/index.php/GetCurrentVersion", RequestNamespace="http://www.matstroeng.se/quickroute/server", ResponseNamespace="http://www.matstroeng.se/quickroute/server")]
        [return: System.Xml.Serialization.SoapElementAttribute("response")]
        public GetCurrentVersionResponse GetCurrentVersion(GetCurrentVersionRequest request) {
            object[] results = this.Invoke("GetCurrentVersion", new object[] {
                        request});
            return ((GetCurrentVersionResponse)(results[0]));
        }
        
        /// <remarks/>
        public void GetCurrentVersionAsync(GetCurrentVersionRequest request) {
            this.GetCurrentVersionAsync(request, null);
        }
        
        /// <remarks/>
        public void GetCurrentVersionAsync(GetCurrentVersionRequest request, object userState) {
            if ((this.GetCurrentVersionOperationCompleted == null)) {
                this.GetCurrentVersionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCurrentVersionOperationCompleted);
            }
            this.InvokeAsync("GetCurrentVersion", new object[] {
                        request}, this.GetCurrentVersionOperationCompleted, userState);
        }
        
        private void OnGetCurrentVersionOperationCompleted(object arg) {
            if ((this.GetCurrentVersionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCurrentVersionCompleted(this, new GetCurrentVersionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://www.matstroeng.se/quickroute/server")]
    public partial class GetCurrentVersionRequest {
        
        private string userVersionField;
        
        private string userLanguageField;
        
        /// <remarks/>
        public string UserVersion {
            get {
                return this.userVersionField;
            }
            set {
                this.userVersionField = value;
            }
        }
        
        /// <remarks/>
        public string UserLanguage {
            get {
                return this.userLanguageField;
            }
            set {
                this.userLanguageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://www.matstroeng.se/quickroute/server")]
    public partial class GetCurrentVersionResponse {
        
        private string currentVersionField;
        
        private string downloadUrlField;
        
        private string[] featuresField;
        
        /// <remarks/>
        public string CurrentVersion {
            get {
                return this.currentVersionField;
            }
            set {
                this.currentVersionField = value;
            }
        }
        
        /// <remarks/>
        public string DownloadUrl {
            get {
                return this.downloadUrlField;
            }
            set {
                this.downloadUrlField = value;
            }
        }
        
        /// <remarks/>
        public string[] Features {
            get {
                return this.featuresField;
            }
            set {
                this.featuresField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetCurrentVersionCompletedEventHandler(object sender, GetCurrentVersionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCurrentVersionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCurrentVersionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GetCurrentVersionResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GetCurrentVersionResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591