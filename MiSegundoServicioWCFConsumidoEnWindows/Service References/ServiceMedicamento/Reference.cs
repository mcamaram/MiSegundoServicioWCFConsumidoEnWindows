﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MedicamentoCLS", Namespace="http://schemas.datacontract.org/2004/07/ServiciosMedicamento.Clases")]
    [System.SerializableAttribute()]
    public partial class MedicamentoCLS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int iidmedicamentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string concentracionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int iidformafarmaceuticaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreFormaFarmaceuticaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal precioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int stockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string presentacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int bhabilitadoField;
        
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
        public int iidmedicamento {
            get {
                return this.iidmedicamentoField;
            }
            set {
                if ((this.iidmedicamentoField.Equals(value) != true)) {
                    this.iidmedicamentoField = value;
                    this.RaisePropertyChanged("iidmedicamento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string concentracion {
            get {
                return this.concentracionField;
            }
            set {
                if ((object.ReferenceEquals(this.concentracionField, value) != true)) {
                    this.concentracionField = value;
                    this.RaisePropertyChanged("concentracion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int iidformafarmaceutica {
            get {
                return this.iidformafarmaceuticaField;
            }
            set {
                if ((this.iidformafarmaceuticaField.Equals(value) != true)) {
                    this.iidformafarmaceuticaField = value;
                    this.RaisePropertyChanged("iidformafarmaceutica");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string nombreFormaFarmaceutica {
            get {
                return this.nombreFormaFarmaceuticaField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreFormaFarmaceuticaField, value) != true)) {
                    this.nombreFormaFarmaceuticaField = value;
                    this.RaisePropertyChanged("nombreFormaFarmaceutica");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public decimal precio {
            get {
                return this.precioField;
            }
            set {
                if ((this.precioField.Equals(value) != true)) {
                    this.precioField = value;
                    this.RaisePropertyChanged("precio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public int stock {
            get {
                return this.stockField;
            }
            set {
                if ((this.stockField.Equals(value) != true)) {
                    this.stockField = value;
                    this.RaisePropertyChanged("stock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public string presentacion {
            get {
                return this.presentacionField;
            }
            set {
                if ((object.ReferenceEquals(this.presentacionField, value) != true)) {
                    this.presentacionField = value;
                    this.RaisePropertyChanged("presentacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public int bhabilitado {
            get {
                return this.bhabilitadoField;
            }
            set {
                if ((this.bhabilitadoField.Equals(value) != true)) {
                    this.bhabilitadoField = value;
                    this.RaisePropertyChanged("bhabilitado");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FormaFarmaceuticaCLS", Namespace="http://schemas.datacontract.org/2004/07/ServiciosMedicamento.Clases")]
    [System.SerializableAttribute()]
    public partial class FormaFarmaceuticaCLS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int iidformafarmaceuticaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreFormaFarmaceuticaField;
        
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
        public int iidformafarmaceutica {
            get {
                return this.iidformafarmaceuticaField;
            }
            set {
                if ((this.iidformafarmaceuticaField.Equals(value) != true)) {
                    this.iidformafarmaceuticaField = value;
                    this.RaisePropertyChanged("iidformafarmaceutica");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombreFormaFarmaceutica {
            get {
                return this.nombreFormaFarmaceuticaField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreFormaFarmaceuticaField, value) != true)) {
                    this.nombreFormaFarmaceuticaField = value;
                    this.RaisePropertyChanged("nombreFormaFarmaceutica");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMedicamento.IMedicamentos")]
    public interface IMedicamentos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicamentos/listarMedicamentos", ReplyAction="http://tempuri.org/IMedicamentos/listarMedicamentosResponse")]
        System.Collections.Generic.List<MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento.MedicamentoCLS> listarMedicamentos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicamentos/listarMedicamentos", ReplyAction="http://tempuri.org/IMedicamentos/listarMedicamentosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento.MedicamentoCLS>> listarMedicamentosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicamentos/listarFormaFarmaceutica", ReplyAction="http://tempuri.org/IMedicamentos/listarFormaFarmaceuticaResponse")]
        System.Collections.Generic.List<MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento.FormaFarmaceuticaCLS> listarFormaFarmaceutica();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicamentos/listarFormaFarmaceutica", ReplyAction="http://tempuri.org/IMedicamentos/listarFormaFarmaceuticaResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento.FormaFarmaceuticaCLS>> listarFormaFarmaceuticaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicamentos/recuperarMedicamento", ReplyAction="http://tempuri.org/IMedicamentos/recuperarMedicamentoResponse")]
        MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento.MedicamentoCLS recuperarMedicamento(int iidMedicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicamentos/recuperarMedicamento", ReplyAction="http://tempuri.org/IMedicamentos/recuperarMedicamentoResponse")]
        System.Threading.Tasks.Task<MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento.MedicamentoCLS> recuperarMedicamentoAsync(int iidMedicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicamentos/registrarYActualizarMedicamentos", ReplyAction="http://tempuri.org/IMedicamentos/registrarYActualizarMedicamentosResponse")]
        int registrarYActualizarMedicamentos(MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento.MedicamentoCLS oMedicamentoCLS);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicamentos/registrarYActualizarMedicamentos", ReplyAction="http://tempuri.org/IMedicamentos/registrarYActualizarMedicamentosResponse")]
        System.Threading.Tasks.Task<int> registrarYActualizarMedicamentosAsync(MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento.MedicamentoCLS oMedicamentoCLS);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicamentos/eliminarMedicamento", ReplyAction="http://tempuri.org/IMedicamentos/eliminarMedicamentoResponse")]
        int eliminarMedicamento(int iidMedicamento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedicamentos/eliminarMedicamento", ReplyAction="http://tempuri.org/IMedicamentos/eliminarMedicamentoResponse")]
        System.Threading.Tasks.Task<int> eliminarMedicamentoAsync(int iidMedicamento);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMedicamentosChannel : MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento.IMedicamentos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MedicamentosClient : System.ServiceModel.ClientBase<MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento.IMedicamentos>, MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento.IMedicamentos {
        
        public MedicamentosClient() {
        }
        
        public MedicamentosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MedicamentosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MedicamentosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MedicamentosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento.MedicamentoCLS> listarMedicamentos() {
            return base.Channel.listarMedicamentos();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento.MedicamentoCLS>> listarMedicamentosAsync() {
            return base.Channel.listarMedicamentosAsync();
        }
        
        public System.Collections.Generic.List<MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento.FormaFarmaceuticaCLS> listarFormaFarmaceutica() {
            return base.Channel.listarFormaFarmaceutica();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento.FormaFarmaceuticaCLS>> listarFormaFarmaceuticaAsync() {
            return base.Channel.listarFormaFarmaceuticaAsync();
        }
        
        public MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento.MedicamentoCLS recuperarMedicamento(int iidMedicamento) {
            return base.Channel.recuperarMedicamento(iidMedicamento);
        }
        
        public System.Threading.Tasks.Task<MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento.MedicamentoCLS> recuperarMedicamentoAsync(int iidMedicamento) {
            return base.Channel.recuperarMedicamentoAsync(iidMedicamento);
        }
        
        public int registrarYActualizarMedicamentos(MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento.MedicamentoCLS oMedicamentoCLS) {
            return base.Channel.registrarYActualizarMedicamentos(oMedicamentoCLS);
        }
        
        public System.Threading.Tasks.Task<int> registrarYActualizarMedicamentosAsync(MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento.MedicamentoCLS oMedicamentoCLS) {
            return base.Channel.registrarYActualizarMedicamentosAsync(oMedicamentoCLS);
        }
        
        public int eliminarMedicamento(int iidMedicamento) {
            return base.Channel.eliminarMedicamento(iidMedicamento);
        }
        
        public System.Threading.Tasks.Task<int> eliminarMedicamentoAsync(int iidMedicamento) {
            return base.Channel.eliminarMedicamentoAsync(iidMedicamento);
        }
    }
}