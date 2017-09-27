﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Insigma.Eyes.PSS.WinUI.BLLCommodity {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLLCommodity.ICommodityManagerService")]
    public interface ICommodityManagerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommodityManagerService/GetCommodities", ReplyAction="http://tempuri.org/ICommodityManagerService/GetCommoditiesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/ICommodityManagerService/GetCommoditiesExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        Insigma.Eyes.PSS.Model.CommodityModel[] GetCommodities(string name, string type, string manufacturer, string priceLow, string priceHigh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommodityManagerService/GetCommoditiesByCondition", ReplyAction="http://tempuri.org/ICommodityManagerService/GetCommoditiesByConditionResponse")]
        Insigma.Eyes.PSS.Model.CommodityModel[] GetCommoditiesByCondition(string condition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommodityManagerService/GetOneCommodity", ReplyAction="http://tempuri.org/ICommodityManagerService/GetOneCommodityResponse")]
        Insigma.Eyes.PSS.Model.CommodityModel GetOneCommodity(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommodityManagerService/AddCommodity", ReplyAction="http://tempuri.org/ICommodityManagerService/AddCommodityResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/ICommodityManagerService/AddCommodityExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        Insigma.Eyes.PSS.Model.CommodityModel AddCommodity(Insigma.Eyes.PSS.Model.CommodityModel oneCommodity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommodityManagerService/UpdateCommodity", ReplyAction="http://tempuri.org/ICommodityManagerService/UpdateCommodityResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/ICommodityManagerService/UpdateCommodityExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        bool UpdateCommodity(Insigma.Eyes.PSS.Model.CommodityModel commodity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommodityManagerService/GetCommdityUnits", ReplyAction="http://tempuri.org/ICommodityManagerService/GetCommdityUnitsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/ICommodityManagerService/GetCommdityUnitsExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        Insigma.Eyes.PSS.Model.UnitModel[] GetCommdityUnits();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommodityManagerService/AddCommdityUnit", ReplyAction="http://tempuri.org/ICommodityManagerService/AddCommdityUnitResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/ICommodityManagerService/AddCommdityUnitExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        bool AddCommdityUnit(Insigma.Eyes.PSS.Model.UnitModel oneUnit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommodityManagerService/UpdateCommdityUnit", ReplyAction="http://tempuri.org/ICommodityManagerService/UpdateCommdityUnitResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/ICommodityManagerService/UpdateCommdityUnitExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        bool UpdateCommdityUnit(Insigma.Eyes.PSS.Model.UnitModel oneUnit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommodityManagerService/GetCommdityTypes", ReplyAction="http://tempuri.org/ICommodityManagerService/GetCommdityTypesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/ICommodityManagerService/GetCommdityTypesExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        Insigma.Eyes.PSS.Model.TypeModel[] GetCommdityTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommodityManagerService/AddCommdityType", ReplyAction="http://tempuri.org/ICommodityManagerService/AddCommdityTypeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/ICommodityManagerService/AddCommdityTypeExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        bool AddCommdityType(Insigma.Eyes.PSS.Model.TypeModel oneType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommodityManagerService/UpdateCommdityType", ReplyAction="http://tempuri.org/ICommodityManagerService/UpdateCommdityTypeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/ICommodityManagerService/UpdateCommdityTypeExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        bool UpdateCommdityType(Insigma.Eyes.PSS.Model.TypeModel oneType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommodityManagerService/GetManufacturers", ReplyAction="http://tempuri.org/ICommodityManagerService/GetManufacturersResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/ICommodityManagerService/GetManufacturersExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        Insigma.Eyes.PSS.Model.ManufacturerModel[] GetManufacturers(string name, string person, string tel, string addr, string status);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICommodityManagerServiceChannel : Insigma.Eyes.PSS.WinUI.BLLCommodity.ICommodityManagerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CommodityManagerServiceClient : System.ServiceModel.ClientBase<Insigma.Eyes.PSS.WinUI.BLLCommodity.ICommodityManagerService>, Insigma.Eyes.PSS.WinUI.BLLCommodity.ICommodityManagerService {
        
        public CommodityManagerServiceClient() {
        }
        
        public CommodityManagerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CommodityManagerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommodityManagerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommodityManagerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Insigma.Eyes.PSS.Model.CommodityModel[] GetCommodities(string name, string type, string manufacturer, string priceLow, string priceHigh) {
            return base.Channel.GetCommodities(name, type, manufacturer, priceLow, priceHigh);
        }
        
        public Insigma.Eyes.PSS.Model.CommodityModel[] GetCommoditiesByCondition(string condition) {
            return base.Channel.GetCommoditiesByCondition(condition);
        }
        
        public Insigma.Eyes.PSS.Model.CommodityModel GetOneCommodity(int id) {
            return base.Channel.GetOneCommodity(id);
        }
        
        public Insigma.Eyes.PSS.Model.CommodityModel AddCommodity(Insigma.Eyes.PSS.Model.CommodityModel oneCommodity) {
            return base.Channel.AddCommodity(oneCommodity);
        }
        
        public bool UpdateCommodity(Insigma.Eyes.PSS.Model.CommodityModel commodity) {
            return base.Channel.UpdateCommodity(commodity);
        }
        
        public Insigma.Eyes.PSS.Model.UnitModel[] GetCommdityUnits() {
            return base.Channel.GetCommdityUnits();
        }
        
        public bool AddCommdityUnit(Insigma.Eyes.PSS.Model.UnitModel oneUnit) {
            return base.Channel.AddCommdityUnit(oneUnit);
        }
        
        public bool UpdateCommdityUnit(Insigma.Eyes.PSS.Model.UnitModel oneUnit) {
            return base.Channel.UpdateCommdityUnit(oneUnit);
        }
        
        public Insigma.Eyes.PSS.Model.TypeModel[] GetCommdityTypes() {
            return base.Channel.GetCommdityTypes();
        }
        
        public bool AddCommdityType(Insigma.Eyes.PSS.Model.TypeModel oneType) {
            return base.Channel.AddCommdityType(oneType);
        }
        
        public bool UpdateCommdityType(Insigma.Eyes.PSS.Model.TypeModel oneType) {
            return base.Channel.UpdateCommdityType(oneType);
        }
        
        public Insigma.Eyes.PSS.Model.ManufacturerModel[] GetManufacturers(string name, string person, string tel, string addr, string status) {
            return base.Channel.GetManufacturers(name, person, tel, addr, status);
        }
    }
}
