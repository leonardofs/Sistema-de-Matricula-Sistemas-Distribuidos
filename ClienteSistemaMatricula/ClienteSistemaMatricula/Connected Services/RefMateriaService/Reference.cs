﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteSistemaMatricula.RefMateriaService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Materia", Namespace="http://schemas.datacontract.org/2004/07/Sistema_de_Matricula.Models")]
    public partial class Materia : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int IDField;
        
        private string NomeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RefMateriaService.IMateriaService")]
    public interface IMateriaService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMateriaService/Add", ReplyAction="http://tempuri.org/IMateriaService/AddResponse")]
        System.IAsyncResult BeginAdd(ClienteSistemaMatricula.RefMateriaService.Materia m, System.AsyncCallback callback, object asyncState);
        
        void EndAdd(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMateriaService/Buscar", ReplyAction="http://tempuri.org/IMateriaService/BuscarResponse")]
        System.IAsyncResult BeginBuscar(int id, System.AsyncCallback callback, object asyncState);
        
        ClienteSistemaMatricula.RefMateriaService.Materia EndBuscar(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMateriaService/Remover", ReplyAction="http://tempuri.org/IMateriaService/RemoverResponse")]
        System.IAsyncResult BeginRemover(int id, System.AsyncCallback callback, object asyncState);
        
        void EndRemover(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMateriaServiceChannel : ClienteSistemaMatricula.RefMateriaService.IMateriaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BuscarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public BuscarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public ClienteSistemaMatricula.RefMateriaService.Materia Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((ClienteSistemaMatricula.RefMateriaService.Materia)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MateriaServiceClient : System.ServiceModel.ClientBase<ClienteSistemaMatricula.RefMateriaService.IMateriaService>, ClienteSistemaMatricula.RefMateriaService.IMateriaService {
        
        private BeginOperationDelegate onBeginAddDelegate;
        
        private EndOperationDelegate onEndAddDelegate;
        
        private System.Threading.SendOrPostCallback onAddCompletedDelegate;
        
        private BeginOperationDelegate onBeginBuscarDelegate;
        
        private EndOperationDelegate onEndBuscarDelegate;
        
        private System.Threading.SendOrPostCallback onBuscarCompletedDelegate;
        
        private BeginOperationDelegate onBeginRemoverDelegate;
        
        private EndOperationDelegate onEndRemoverDelegate;
        
        private System.Threading.SendOrPostCallback onRemoverCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public MateriaServiceClient() : 
                base(MateriaServiceClient.GetDefaultBinding(), MateriaServiceClient.GetDefaultEndpointAddress()) {
        }
        
        public MateriaServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(MateriaServiceClient.GetBindingForEndpoint(endpointConfiguration), MateriaServiceClient.GetEndpointAddress(endpointConfiguration)) {
        }
        
        public MateriaServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MateriaServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
        }
        
        public MateriaServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MateriaServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
        }
        
        public MateriaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Não é possível definiro CookieContainer. Verifique se que a ligação contém um Htt" +
                            "pCookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> AddCompleted;
        
        public event System.EventHandler<BuscarCompletedEventArgs> BuscarCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> RemoverCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult ClienteSistemaMatricula.RefMateriaService.IMateriaService.BeginAdd(ClienteSistemaMatricula.RefMateriaService.Materia m, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginAdd(m, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void ClienteSistemaMatricula.RefMateriaService.IMateriaService.EndAdd(System.IAsyncResult result) {
            base.Channel.EndAdd(result);
        }
        
        private System.IAsyncResult OnBeginAdd(object[] inValues, System.AsyncCallback callback, object asyncState) {
            ClienteSistemaMatricula.RefMateriaService.Materia m = ((ClienteSistemaMatricula.RefMateriaService.Materia)(inValues[0]));
            return ((ClienteSistemaMatricula.RefMateriaService.IMateriaService)(this)).BeginAdd(m, callback, asyncState);
        }
        
        private object[] OnEndAdd(System.IAsyncResult result) {
            ((ClienteSistemaMatricula.RefMateriaService.IMateriaService)(this)).EndAdd(result);
            return null;
        }
        
        private void OnAddCompleted(object state) {
            if ((this.AddCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.AddCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void AddAsync(ClienteSistemaMatricula.RefMateriaService.Materia m) {
            this.AddAsync(m, null);
        }
        
        public void AddAsync(ClienteSistemaMatricula.RefMateriaService.Materia m, object userState) {
            if ((this.onBeginAddDelegate == null)) {
                this.onBeginAddDelegate = new BeginOperationDelegate(this.OnBeginAdd);
            }
            if ((this.onEndAddDelegate == null)) {
                this.onEndAddDelegate = new EndOperationDelegate(this.OnEndAdd);
            }
            if ((this.onAddCompletedDelegate == null)) {
                this.onAddCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnAddCompleted);
            }
            base.InvokeAsync(this.onBeginAddDelegate, new object[] {
                        m}, this.onEndAddDelegate, this.onAddCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult ClienteSistemaMatricula.RefMateriaService.IMateriaService.BeginBuscar(int id, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginBuscar(id, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteSistemaMatricula.RefMateriaService.Materia ClienteSistemaMatricula.RefMateriaService.IMateriaService.EndBuscar(System.IAsyncResult result) {
            return base.Channel.EndBuscar(result);
        }
        
        private System.IAsyncResult OnBeginBuscar(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int id = ((int)(inValues[0]));
            return ((ClienteSistemaMatricula.RefMateriaService.IMateriaService)(this)).BeginBuscar(id, callback, asyncState);
        }
        
        private object[] OnEndBuscar(System.IAsyncResult result) {
            ClienteSistemaMatricula.RefMateriaService.Materia retVal = ((ClienteSistemaMatricula.RefMateriaService.IMateriaService)(this)).EndBuscar(result);
            return new object[] {
                    retVal};
        }
        
        private void OnBuscarCompleted(object state) {
            if ((this.BuscarCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.BuscarCompleted(this, new BuscarCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void BuscarAsync(int id) {
            this.BuscarAsync(id, null);
        }
        
        public void BuscarAsync(int id, object userState) {
            if ((this.onBeginBuscarDelegate == null)) {
                this.onBeginBuscarDelegate = new BeginOperationDelegate(this.OnBeginBuscar);
            }
            if ((this.onEndBuscarDelegate == null)) {
                this.onEndBuscarDelegate = new EndOperationDelegate(this.OnEndBuscar);
            }
            if ((this.onBuscarCompletedDelegate == null)) {
                this.onBuscarCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnBuscarCompleted);
            }
            base.InvokeAsync(this.onBeginBuscarDelegate, new object[] {
                        id}, this.onEndBuscarDelegate, this.onBuscarCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult ClienteSistemaMatricula.RefMateriaService.IMateriaService.BeginRemover(int id, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginRemover(id, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void ClienteSistemaMatricula.RefMateriaService.IMateriaService.EndRemover(System.IAsyncResult result) {
            base.Channel.EndRemover(result);
        }
        
        private System.IAsyncResult OnBeginRemover(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int id = ((int)(inValues[0]));
            return ((ClienteSistemaMatricula.RefMateriaService.IMateriaService)(this)).BeginRemover(id, callback, asyncState);
        }
        
        private object[] OnEndRemover(System.IAsyncResult result) {
            ((ClienteSistemaMatricula.RefMateriaService.IMateriaService)(this)).EndRemover(result);
            return null;
        }
        
        private void OnRemoverCompleted(object state) {
            if ((this.RemoverCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.RemoverCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void RemoverAsync(int id) {
            this.RemoverAsync(id, null);
        }
        
        public void RemoverAsync(int id, object userState) {
            if ((this.onBeginRemoverDelegate == null)) {
                this.onBeginRemoverDelegate = new BeginOperationDelegate(this.OnBeginRemover);
            }
            if ((this.onEndRemoverDelegate == null)) {
                this.onEndRemoverDelegate = new EndOperationDelegate(this.OnEndRemover);
            }
            if ((this.onRemoverCompletedDelegate == null)) {
                this.onRemoverCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnRemoverCompleted);
            }
            base.InvokeAsync(this.onBeginRemoverDelegate, new object[] {
                        id}, this.onEndRemoverDelegate, this.onRemoverCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override ClienteSistemaMatricula.RefMateriaService.IMateriaService CreateChannel() {
            return new MateriaServiceClientChannel(this);
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.EndMateria)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.MaxReceivedMessageSize = int.MaxValue;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.EndMateria)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Materia/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return MateriaServiceClient.GetBindingForEndpoint(EndpointConfiguration.EndMateria);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return MateriaServiceClient.GetEndpointAddress(EndpointConfiguration.EndMateria);
        }
        
        private class MateriaServiceClientChannel : ChannelBase<ClienteSistemaMatricula.RefMateriaService.IMateriaService>, ClienteSistemaMatricula.RefMateriaService.IMateriaService {
            
            public MateriaServiceClientChannel(System.ServiceModel.ClientBase<ClienteSistemaMatricula.RefMateriaService.IMateriaService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginAdd(ClienteSistemaMatricula.RefMateriaService.Materia m, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = m;
                System.IAsyncResult _result = base.BeginInvoke("Add", _args, callback, asyncState);
                return _result;
            }
            
            public void EndAdd(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("Add", _args, result);
            }
            
            public System.IAsyncResult BeginBuscar(int id, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = id;
                System.IAsyncResult _result = base.BeginInvoke("Buscar", _args, callback, asyncState);
                return _result;
            }
            
            public ClienteSistemaMatricula.RefMateriaService.Materia EndBuscar(System.IAsyncResult result) {
                object[] _args = new object[0];
                ClienteSistemaMatricula.RefMateriaService.Materia _result = ((ClienteSistemaMatricula.RefMateriaService.Materia)(base.EndInvoke("Buscar", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginRemover(int id, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = id;
                System.IAsyncResult _result = base.BeginInvoke("Remover", _args, callback, asyncState);
                return _result;
            }
            
            public void EndRemover(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("Remover", _args, result);
            }
        }
        
        public enum EndpointConfiguration {
            
            EndMateria,
        }
    }
}