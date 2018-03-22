﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace LoveStats.WsBL {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiceSoap", Namespace="http://tempuri.org/")]
    public partial class Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback LoginGetAllUserDataAndStatsOperationCompleted;
        
        private System.Threading.SendOrPostCallback RegisterNewUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback RegisterNewStatsOperationCompleted;
        
        private System.Threading.SendOrPostCallback isStatsExistsTodayOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service() {
            this.Url = global::LoveStats.Properties.Settings.Default.LoveStats_WsBL_Service;
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
        public event LoginGetAllUserDataAndStatsCompletedEventHandler LoginGetAllUserDataAndStatsCompleted;
        
        /// <remarks/>
        public event RegisterNewUserCompletedEventHandler RegisterNewUserCompleted;
        
        /// <remarks/>
        public event RegisterNewStatsCompletedEventHandler RegisterNewStatsCompleted;
        
        /// <remarks/>
        public event isStatsExistsTodayCompletedEventHandler isStatsExistsTodayCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LoginGetAllUserDataAndStats", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet LoginGetAllUserDataAndStats(string username, string password) {
            object[] results = this.Invoke("LoginGetAllUserDataAndStats", new object[] {
                        username,
                        password});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void LoginGetAllUserDataAndStatsAsync(string username, string password) {
            this.LoginGetAllUserDataAndStatsAsync(username, password, null);
        }
        
        /// <remarks/>
        public void LoginGetAllUserDataAndStatsAsync(string username, string password, object userState) {
            if ((this.LoginGetAllUserDataAndStatsOperationCompleted == null)) {
                this.LoginGetAllUserDataAndStatsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginGetAllUserDataAndStatsOperationCompleted);
            }
            this.InvokeAsync("LoginGetAllUserDataAndStats", new object[] {
                        username,
                        password}, this.LoginGetAllUserDataAndStatsOperationCompleted, userState);
        }
        
        private void OnLoginGetAllUserDataAndStatsOperationCompleted(object arg) {
            if ((this.LoginGetAllUserDataAndStatsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginGetAllUserDataAndStatsCompleted(this, new LoginGetAllUserDataAndStatsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RegisterNewUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet RegisterNewUser(string UserName, string FirstName, string LastName, string PassWord, string Email, string PhoneNumber) {
            object[] results = this.Invoke("RegisterNewUser", new object[] {
                        UserName,
                        FirstName,
                        LastName,
                        PassWord,
                        Email,
                        PhoneNumber});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void RegisterNewUserAsync(string UserName, string FirstName, string LastName, string PassWord, string Email, string PhoneNumber) {
            this.RegisterNewUserAsync(UserName, FirstName, LastName, PassWord, Email, PhoneNumber, null);
        }
        
        /// <remarks/>
        public void RegisterNewUserAsync(string UserName, string FirstName, string LastName, string PassWord, string Email, string PhoneNumber, object userState) {
            if ((this.RegisterNewUserOperationCompleted == null)) {
                this.RegisterNewUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRegisterNewUserOperationCompleted);
            }
            this.InvokeAsync("RegisterNewUser", new object[] {
                        UserName,
                        FirstName,
                        LastName,
                        PassWord,
                        Email,
                        PhoneNumber}, this.RegisterNewUserOperationCompleted, userState);
        }
        
        private void OnRegisterNewUserOperationCompleted(object arg) {
            if ((this.RegisterNewUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RegisterNewUserCompleted(this, new RegisterNewUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RegisterNewStats", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet RegisterNewStats(int UserId, string GoodThing, string BadThing) {
            object[] results = this.Invoke("RegisterNewStats", new object[] {
                        UserId,
                        GoodThing,
                        BadThing});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void RegisterNewStatsAsync(int UserId, string GoodThing, string BadThing) {
            this.RegisterNewStatsAsync(UserId, GoodThing, BadThing, null);
        }
        
        /// <remarks/>
        public void RegisterNewStatsAsync(int UserId, string GoodThing, string BadThing, object userState) {
            if ((this.RegisterNewStatsOperationCompleted == null)) {
                this.RegisterNewStatsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRegisterNewStatsOperationCompleted);
            }
            this.InvokeAsync("RegisterNewStats", new object[] {
                        UserId,
                        GoodThing,
                        BadThing}, this.RegisterNewStatsOperationCompleted, userState);
        }
        
        private void OnRegisterNewStatsOperationCompleted(object arg) {
            if ((this.RegisterNewStatsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RegisterNewStatsCompleted(this, new RegisterNewStatsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/isStatsExistsToday", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool isStatsExistsToday(int UserId) {
            object[] results = this.Invoke("isStatsExistsToday", new object[] {
                        UserId});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void isStatsExistsTodayAsync(int UserId) {
            this.isStatsExistsTodayAsync(UserId, null);
        }
        
        /// <remarks/>
        public void isStatsExistsTodayAsync(int UserId, object userState) {
            if ((this.isStatsExistsTodayOperationCompleted == null)) {
                this.isStatsExistsTodayOperationCompleted = new System.Threading.SendOrPostCallback(this.OnisStatsExistsTodayOperationCompleted);
            }
            this.InvokeAsync("isStatsExistsToday", new object[] {
                        UserId}, this.isStatsExistsTodayOperationCompleted, userState);
        }
        
        private void OnisStatsExistsTodayOperationCompleted(object arg) {
            if ((this.isStatsExistsTodayCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.isStatsExistsTodayCompleted(this, new isStatsExistsTodayCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void LoginGetAllUserDataAndStatsCompletedEventHandler(object sender, LoginGetAllUserDataAndStatsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginGetAllUserDataAndStatsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoginGetAllUserDataAndStatsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void RegisterNewUserCompletedEventHandler(object sender, RegisterNewUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RegisterNewUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RegisterNewUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void RegisterNewStatsCompletedEventHandler(object sender, RegisterNewStatsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RegisterNewStatsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RegisterNewStatsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void isStatsExistsTodayCompletedEventHandler(object sender, isStatsExistsTodayCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class isStatsExistsTodayCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal isStatsExistsTodayCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591