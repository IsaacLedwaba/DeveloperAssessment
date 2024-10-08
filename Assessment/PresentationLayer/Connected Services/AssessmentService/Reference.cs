﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PresentationLayer.AssessmentService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Client", Namespace="http://schemas.datacontract.org/2004/07/DataAccessLayer")]
    [System.SerializableAttribute()]
    public partial class Client : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PresentationLayer.AssessmentService.Address[] AddressesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClientIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PresentationLayer.AssessmentService.Contact[] ContactsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OtherDetailsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PresentationLayer.AssessmentService.Address[] Addresses {
            get {
                return this.AddressesField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressesField, value) != true)) {
                    this.AddressesField = value;
                    this.RaisePropertyChanged("Addresses");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClientID {
            get {
                return this.ClientIDField;
            }
            set {
                if ((this.ClientIDField.Equals(value) != true)) {
                    this.ClientIDField = value;
                    this.RaisePropertyChanged("ClientID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientName {
            get {
                return this.ClientNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientNameField, value) != true)) {
                    this.ClientNameField = value;
                    this.RaisePropertyChanged("ClientName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PresentationLayer.AssessmentService.Contact[] Contacts {
            get {
                return this.ContactsField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactsField, value) != true)) {
                    this.ContactsField = value;
                    this.RaisePropertyChanged("Contacts");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OtherDetails {
            get {
                return this.OtherDetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.OtherDetailsField, value) != true)) {
                    this.OtherDetailsField = value;
                    this.RaisePropertyChanged("OtherDetails");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Address", Namespace="http://schemas.datacontract.org/2004/07/DataAccessLayer")]
    [System.SerializableAttribute()]
    public partial class Address : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AddressIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClientIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostalCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StreetField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AddressID {
            get {
                return this.AddressIDField;
            }
            set {
                if ((this.AddressIDField.Equals(value) != true)) {
                    this.AddressIDField = value;
                    this.RaisePropertyChanged("AddressID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AddressType {
            get {
                return this.AddressTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressTypeField, value) != true)) {
                    this.AddressTypeField = value;
                    this.RaisePropertyChanged("AddressType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClientID {
            get {
                return this.ClientIDField;
            }
            set {
                if ((this.ClientIDField.Equals(value) != true)) {
                    this.ClientIDField = value;
                    this.RaisePropertyChanged("ClientID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostalCode {
            get {
                return this.PostalCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.PostalCodeField, value) != true)) {
                    this.PostalCodeField = value;
                    this.RaisePropertyChanged("PostalCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Street {
            get {
                return this.StreetField;
            }
            set {
                if ((object.ReferenceEquals(this.StreetField, value) != true)) {
                    this.StreetField = value;
                    this.RaisePropertyChanged("Street");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contact", Namespace="http://schemas.datacontract.org/2004/07/DataAccessLayer")]
    [System.SerializableAttribute()]
    public partial class Contact : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClientIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ContactIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactTypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClientID {
            get {
                return this.ClientIDField;
            }
            set {
                if ((this.ClientIDField.Equals(value) != true)) {
                    this.ClientIDField = value;
                    this.RaisePropertyChanged("ClientID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ContactID {
            get {
                return this.ContactIDField;
            }
            set {
                if ((this.ContactIDField.Equals(value) != true)) {
                    this.ContactIDField = value;
                    this.RaisePropertyChanged("ContactID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactNumber {
            get {
                return this.ContactNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactNumberField, value) != true)) {
                    this.ContactNumberField = value;
                    this.RaisePropertyChanged("ContactNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactType {
            get {
                return this.ContactTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactTypeField, value) != true)) {
                    this.ContactTypeField = value;
                    this.RaisePropertyChanged("ContactType");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AssessmentService.IClientService")]
    public interface IClientService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/GetClientById", ReplyAction="http://tempuri.org/IClientService/GetClientByIdResponse")]
        PresentationLayer.AssessmentService.Client GetClientById(int clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/GetClientById", ReplyAction="http://tempuri.org/IClientService/GetClientByIdResponse")]
        System.Threading.Tasks.Task<PresentationLayer.AssessmentService.Client> GetClientByIdAsync(int clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/AddClient", ReplyAction="http://tempuri.org/IClientService/AddClientResponse")]
        void AddClient(PresentationLayer.AssessmentService.Client client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/AddClient", ReplyAction="http://tempuri.org/IClientService/AddClientResponse")]
        System.Threading.Tasks.Task AddClientAsync(PresentationLayer.AssessmentService.Client client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/RemoveClient", ReplyAction="http://tempuri.org/IClientService/RemoveClientResponse")]
        void RemoveClient(int clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/RemoveClient", ReplyAction="http://tempuri.org/IClientService/RemoveClientResponse")]
        System.Threading.Tasks.Task RemoveClientAsync(int clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/UpdateClient", ReplyAction="http://tempuri.org/IClientService/UpdateClientResponse")]
        void UpdateClient(PresentationLayer.AssessmentService.Client client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/UpdateClient", ReplyAction="http://tempuri.org/IClientService/UpdateClientResponse")]
        System.Threading.Tasks.Task UpdateClientAsync(PresentationLayer.AssessmentService.Client client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/GetClientList", ReplyAction="http://tempuri.org/IClientService/GetClientListResponse")]
        PresentationLayer.AssessmentService.Client[] GetClientList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientService/GetClientList", ReplyAction="http://tempuri.org/IClientService/GetClientListResponse")]
        System.Threading.Tasks.Task<PresentationLayer.AssessmentService.Client[]> GetClientListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientServiceChannel : PresentationLayer.AssessmentService.IClientService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientServiceClient : System.ServiceModel.ClientBase<PresentationLayer.AssessmentService.IClientService>, PresentationLayer.AssessmentService.IClientService {
        
        public ClientServiceClient() {
        }
        
        public ClientServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PresentationLayer.AssessmentService.Client GetClientById(int clientId) {
            return base.Channel.GetClientById(clientId);
        }
        
        public System.Threading.Tasks.Task<PresentationLayer.AssessmentService.Client> GetClientByIdAsync(int clientId) {
            return base.Channel.GetClientByIdAsync(clientId);
        }
        
        public void AddClient(PresentationLayer.AssessmentService.Client client) {
            base.Channel.AddClient(client);
        }
        
        public System.Threading.Tasks.Task AddClientAsync(PresentationLayer.AssessmentService.Client client) {
            return base.Channel.AddClientAsync(client);
        }
        
        public void RemoveClient(int clientId) {
            base.Channel.RemoveClient(clientId);
        }
        
        public System.Threading.Tasks.Task RemoveClientAsync(int clientId) {
            return base.Channel.RemoveClientAsync(clientId);
        }
        
        public void UpdateClient(PresentationLayer.AssessmentService.Client client) {
            base.Channel.UpdateClient(client);
        }
        
        public System.Threading.Tasks.Task UpdateClientAsync(PresentationLayer.AssessmentService.Client client) {
            return base.Channel.UpdateClientAsync(client);
        }
        
        public PresentationLayer.AssessmentService.Client[] GetClientList() {
            return base.Channel.GetClientList();
        }
        
        public System.Threading.Tasks.Task<PresentationLayer.AssessmentService.Client[]> GetClientListAsync() {
            return base.Channel.GetClientListAsync();
        }
    }
}
