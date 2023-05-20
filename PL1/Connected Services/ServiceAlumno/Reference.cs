﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PL1.ServiceAlumno {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Result", Namespace="http://schemas.datacontract.org/2004/07/SLWCF")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ML.alumnos))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(object[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Exception))]
    public partial class Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CorrectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Exception ExField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object ObjectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object[] ObjectsField;
        
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
        public bool Correct {
            get {
                return this.CorrectField;
            }
            set {
                if ((this.CorrectField.Equals(value) != true)) {
                    this.CorrectField = value;
                    this.RaisePropertyChanged("Correct");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Exception Ex {
            get {
                return this.ExField;
            }
            set {
                if ((object.ReferenceEquals(this.ExField, value) != true)) {
                    this.ExField = value;
                    this.RaisePropertyChanged("Ex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Object {
            get {
                return this.ObjectField;
            }
            set {
                if ((object.ReferenceEquals(this.ObjectField, value) != true)) {
                    this.ObjectField = value;
                    this.RaisePropertyChanged("Object");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object[] Objects {
            get {
                return this.ObjectsField;
            }
            set {
                if ((object.ReferenceEquals(this.ObjectsField, value) != true)) {
                    this.ObjectsField = value;
                    this.RaisePropertyChanged("Objects");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceAlumno.IAlumnos")]
    public interface IAlumnos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnos/GetAll", ReplyAction="http://tempuri.org/IAlumnos/GetAllResponse")]
        PL1.ServiceAlumno.Result GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnos/GetAll", ReplyAction="http://tempuri.org/IAlumnos/GetAllResponse")]
        System.Threading.Tasks.Task<PL1.ServiceAlumno.Result> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnos/GetById", ReplyAction="http://tempuri.org/IAlumnos/GetByIdResponse")]
        PL1.ServiceAlumno.Result GetById(int IdAlumno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnos/GetById", ReplyAction="http://tempuri.org/IAlumnos/GetByIdResponse")]
        System.Threading.Tasks.Task<PL1.ServiceAlumno.Result> GetByIdAsync(int IdAlumno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnos/Add", ReplyAction="http://tempuri.org/IAlumnos/AddResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PL1.ServiceAlumno.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        PL1.ServiceAlumno.Result Add(ML.alumnos Alumnos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnos/Add", ReplyAction="http://tempuri.org/IAlumnos/AddResponse")]
        System.Threading.Tasks.Task<PL1.ServiceAlumno.Result> AddAsync(ML.alumnos Alumnos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnos/Update", ReplyAction="http://tempuri.org/IAlumnos/UpdateResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PL1.ServiceAlumno.Result))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        PL1.ServiceAlumno.Result Update(ML.alumnos Alumnos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnos/Update", ReplyAction="http://tempuri.org/IAlumnos/UpdateResponse")]
        System.Threading.Tasks.Task<PL1.ServiceAlumno.Result> UpdateAsync(ML.alumnos Alumnos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnos/Delete", ReplyAction="http://tempuri.org/IAlumnos/DeleteResponse")]
        PL1.ServiceAlumno.Result Delete(int IdAlumno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnos/Delete", ReplyAction="http://tempuri.org/IAlumnos/DeleteResponse")]
        System.Threading.Tasks.Task<PL1.ServiceAlumno.Result> DeleteAsync(int IdAlumno);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAlumnosChannel : PL1.ServiceAlumno.IAlumnos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AlumnosClient : System.ServiceModel.ClientBase<PL1.ServiceAlumno.IAlumnos>, PL1.ServiceAlumno.IAlumnos {
        
        public AlumnosClient() {
        }
        
        public AlumnosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AlumnosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AlumnosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AlumnosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PL1.ServiceAlumno.Result GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<PL1.ServiceAlumno.Result> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public PL1.ServiceAlumno.Result GetById(int IdAlumno) {
            return base.Channel.GetById(IdAlumno);
        }
        
        public System.Threading.Tasks.Task<PL1.ServiceAlumno.Result> GetByIdAsync(int IdAlumno) {
            return base.Channel.GetByIdAsync(IdAlumno);
        }
        
        public PL1.ServiceAlumno.Result Add(ML.alumnos Alumnos) {
            return base.Channel.Add(Alumnos);
        }
        
        public System.Threading.Tasks.Task<PL1.ServiceAlumno.Result> AddAsync(ML.alumnos Alumnos) {
            return base.Channel.AddAsync(Alumnos);
        }
        
        public PL1.ServiceAlumno.Result Update(ML.alumnos Alumnos) {
            return base.Channel.Update(Alumnos);
        }
        
        public System.Threading.Tasks.Task<PL1.ServiceAlumno.Result> UpdateAsync(ML.alumnos Alumnos) {
            return base.Channel.UpdateAsync(Alumnos);
        }
        
        public PL1.ServiceAlumno.Result Delete(int IdAlumno) {
            return base.Channel.Delete(IdAlumno);
        }
        
        public System.Threading.Tasks.Task<PL1.ServiceAlumno.Result> DeleteAsync(int IdAlumno) {
            return base.Channel.DeleteAsync(IdAlumno);
        }
    }
}
