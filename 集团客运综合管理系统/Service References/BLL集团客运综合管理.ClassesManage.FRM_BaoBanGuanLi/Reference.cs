﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 集团客运综合管理系统.BLL集团客运综合管理.ClassesManage.FRM_BaoBanGuanLi {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLL集团客运综合管理.ClassesManage.FRM_BaoBanGuanLi.FRM_BaoBanGuanLi")]
    public interface FRM_BaoBanGuanLi {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_BaoBanGuanLi/SelectCheLiangBianHao", ReplyAction="http://tempuri.org/FRM_BaoBanGuanLi/SelectCheLiangBianHaoResponse")]
        System.Data.DataSet SelectCheLiangBianHao();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_BaoBanGuanLi/SelectCheLiangBianHao", ReplyAction="http://tempuri.org/FRM_BaoBanGuanLi/SelectCheLiangBianHaoResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectCheLiangBianHaoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_BaoBanGuanLi/SelectBaoBanXinXiByChePaiHao", ReplyAction="http://tempuri.org/FRM_BaoBanGuanLi/SelectBaoBanXinXiByChePaiHaoResponse")]
        System.Data.DataSet SelectBaoBanXinXiByChePaiHao(string VehicleNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_BaoBanGuanLi/SelectBaoBanXinXiByChePaiHao", ReplyAction="http://tempuri.org/FRM_BaoBanGuanLi/SelectBaoBanXinXiByChePaiHaoResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectBaoBanXinXiByChePaiHaoAsync(string VehicleNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_BaoBanGuanLi/SelectJiaShiYuanXianPian", ReplyAction="http://tempuri.org/FRM_BaoBanGuanLi/SelectJiaShiYuanXianPianResponse")]
        byte[] SelectJiaShiYuanXianPian(int DriverID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_BaoBanGuanLi/SelectJiaShiYuanXianPian", ReplyAction="http://tempuri.org/FRM_BaoBanGuanLi/SelectJiaShiYuanXianPianResponse")]
        System.Threading.Tasks.Task<byte[]> SelectJiaShiYuanXianPianAsync(int DriverID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_BaoBanGuanLi/SelectFuJiaShiYuanXianPian", ReplyAction="http://tempuri.org/FRM_BaoBanGuanLi/SelectFuJiaShiYuanXianPianResponse")]
        byte[] SelectFuJiaShiYuanXianPian(int DriverID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_BaoBanGuanLi/SelectFuJiaShiYuanXianPian", ReplyAction="http://tempuri.org/FRM_BaoBanGuanLi/SelectFuJiaShiYuanXianPianResponse")]
        System.Threading.Tasks.Task<byte[]> SelectFuJiaShiYuanXianPianAsync(int DriverID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_BaoBanGuanLi/InsertBaoBanXinXi", ReplyAction="http://tempuri.org/FRM_BaoBanGuanLi/InsertBaoBanXinXiResponse")]
        int InsertBaoBanXinXi(int FrequencyID, bool WhetherNnSchedule, bool WhetherLate, bool StayClassVehicleNo, string Comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_BaoBanGuanLi/InsertBaoBanXinXi", ReplyAction="http://tempuri.org/FRM_BaoBanGuanLi/InsertBaoBanXinXiResponse")]
        System.Threading.Tasks.Task<int> InsertBaoBanXinXiAsync(int FrequencyID, bool WhetherNnSchedule, bool WhetherLate, bool StayClassVehicleNo, string Comment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_BaoBanGuanLi/UpdateVehicleState", ReplyAction="http://tempuri.org/FRM_BaoBanGuanLi/UpdateVehicleStateResponse")]
        int UpdateVehicleState(int VehicleID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_BaoBanGuanLi/UpdateVehicleState", ReplyAction="http://tempuri.org/FRM_BaoBanGuanLi/UpdateVehicleStateResponse")]
        System.Threading.Tasks.Task<int> UpdateVehicleStateAsync(int VehicleID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FRM_BaoBanGuanLiChannel : 集团客运综合管理系统.BLL集团客运综合管理.ClassesManage.FRM_BaoBanGuanLi.FRM_BaoBanGuanLi, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FRM_BaoBanGuanLiClient : System.ServiceModel.ClientBase<集团客运综合管理系统.BLL集团客运综合管理.ClassesManage.FRM_BaoBanGuanLi.FRM_BaoBanGuanLi>, 集团客运综合管理系统.BLL集团客运综合管理.ClassesManage.FRM_BaoBanGuanLi.FRM_BaoBanGuanLi {
        
        public FRM_BaoBanGuanLiClient() {
        }
        
        public FRM_BaoBanGuanLiClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FRM_BaoBanGuanLiClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_BaoBanGuanLiClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_BaoBanGuanLiClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet SelectCheLiangBianHao() {
            return base.Channel.SelectCheLiangBianHao();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectCheLiangBianHaoAsync() {
            return base.Channel.SelectCheLiangBianHaoAsync();
        }
        
        public System.Data.DataSet SelectBaoBanXinXiByChePaiHao(string VehicleNumber) {
            return base.Channel.SelectBaoBanXinXiByChePaiHao(VehicleNumber);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectBaoBanXinXiByChePaiHaoAsync(string VehicleNumber) {
            return base.Channel.SelectBaoBanXinXiByChePaiHaoAsync(VehicleNumber);
        }
        
        public byte[] SelectJiaShiYuanXianPian(int DriverID) {
            return base.Channel.SelectJiaShiYuanXianPian(DriverID);
        }
        
        public System.Threading.Tasks.Task<byte[]> SelectJiaShiYuanXianPianAsync(int DriverID) {
            return base.Channel.SelectJiaShiYuanXianPianAsync(DriverID);
        }
        
        public byte[] SelectFuJiaShiYuanXianPian(int DriverID) {
            return base.Channel.SelectFuJiaShiYuanXianPian(DriverID);
        }
        
        public System.Threading.Tasks.Task<byte[]> SelectFuJiaShiYuanXianPianAsync(int DriverID) {
            return base.Channel.SelectFuJiaShiYuanXianPianAsync(DriverID);
        }
        
        public int InsertBaoBanXinXi(int FrequencyID, bool WhetherNnSchedule, bool WhetherLate, bool StayClassVehicleNo, string Comment) {
            return base.Channel.InsertBaoBanXinXi(FrequencyID, WhetherNnSchedule, WhetherLate, StayClassVehicleNo, Comment);
        }
        
        public System.Threading.Tasks.Task<int> InsertBaoBanXinXiAsync(int FrequencyID, bool WhetherNnSchedule, bool WhetherLate, bool StayClassVehicleNo, string Comment) {
            return base.Channel.InsertBaoBanXinXiAsync(FrequencyID, WhetherNnSchedule, WhetherLate, StayClassVehicleNo, Comment);
        }
        
        public int UpdateVehicleState(int VehicleID) {
            return base.Channel.UpdateVehicleState(VehicleID);
        }
        
        public System.Threading.Tasks.Task<int> UpdateVehicleStateAsync(int VehicleID) {
            return base.Channel.UpdateVehicleStateAsync(VehicleID);
        }
    }
}
