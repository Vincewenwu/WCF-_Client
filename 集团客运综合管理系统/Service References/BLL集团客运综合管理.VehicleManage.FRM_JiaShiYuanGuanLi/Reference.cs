﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 集团客运综合管理系统.BLL集团客运综合管理.VehicleManage.FRM_JiaShiYuanGuanLi {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLL集团客运综合管理.VehicleManage.FRM_JiaShiYuanGuanLi.FRM_JiaShiYuanGuanLi")]
    public interface FRM_JiaShiYuanGuanLi {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanBianHao", ReplyAction="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanBianHaoResponse")]
        System.Data.DataSet SelectJiaShiYuanBianHao();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanBianHao", ReplyAction="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanBianHaoResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectJiaShiYuanBianHaoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanMingCheng", ReplyAction="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanMingChengResponse")]
        System.Data.DataSet SelectJiaShiYuanMingCheng();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanMingCheng", ReplyAction="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanMingChengResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectJiaShiYuanMingChengAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanXinXi", ReplyAction="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanXinXiResponse")]
        System.Data.DataSet SelectJiaShiYuanXinXi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanXinXi", ReplyAction="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanXinXiResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectJiaShiYuanXinXiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanXinXiByJiaShiYuanBianHao", ReplyAction="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanXinXiByJiaShiYuanBianHaoR" +
            "esponse")]
        System.Data.DataSet SelectJiaShiYuanXinXiByJiaShiYuanBianHao(string DriverNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanXinXiByJiaShiYuanBianHao", ReplyAction="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanXinXiByJiaShiYuanBianHaoR" +
            "esponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectJiaShiYuanXinXiByJiaShiYuanBianHaoAsync(string DriverNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanXinXiByJiaShiYuanID", ReplyAction="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanXinXiByJiaShiYuanIDRespon" +
            "se")]
        System.Data.DataSet SelectJiaShiYuanXinXiByJiaShiYuanID(int DriverID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanXinXiByJiaShiYuanID", ReplyAction="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanXinXiByJiaShiYuanIDRespon" +
            "se")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectJiaShiYuanXinXiByJiaShiYuanIDAsync(int DriverID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanXiangXiXinXiByJiaShiYuanI" +
            "D", ReplyAction="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanXiangXiXinXiByJiaShiYuanI" +
            "DResponse")]
        System.Data.DataSet SelectJiaShiYuanXiangXiXinXiByJiaShiYuanID(int DriverID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanXiangXiXinXiByJiaShiYuanI" +
            "D", ReplyAction="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanXiangXiXinXiByJiaShiYuanI" +
            "DResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectJiaShiYuanXiangXiXinXiByJiaShiYuanIDAsync(int DriverID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanTuPian", ReplyAction="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanTuPianResponse")]
        byte[] SelectJiaShiYuanTuPian(int DriverID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanTuPian", ReplyAction="http://tempuri.org/FRM_JiaShiYuanGuanLi/SelectJiaShiYuanTuPianResponse")]
        System.Threading.Tasks.Task<byte[]> SelectJiaShiYuanTuPianAsync(int DriverID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaShiYuanGuanLi/DeleteJiaShiYuanXinXi", ReplyAction="http://tempuri.org/FRM_JiaShiYuanGuanLi/DeleteJiaShiYuanXinXiResponse")]
        int DeleteJiaShiYuanXinXi(int DriverID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_JiaShiYuanGuanLi/DeleteJiaShiYuanXinXi", ReplyAction="http://tempuri.org/FRM_JiaShiYuanGuanLi/DeleteJiaShiYuanXinXiResponse")]
        System.Threading.Tasks.Task<int> DeleteJiaShiYuanXinXiAsync(int DriverID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FRM_JiaShiYuanGuanLiChannel : 集团客运综合管理系统.BLL集团客运综合管理.VehicleManage.FRM_JiaShiYuanGuanLi.FRM_JiaShiYuanGuanLi, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FRM_JiaShiYuanGuanLiClient : System.ServiceModel.ClientBase<集团客运综合管理系统.BLL集团客运综合管理.VehicleManage.FRM_JiaShiYuanGuanLi.FRM_JiaShiYuanGuanLi>, 集团客运综合管理系统.BLL集团客运综合管理.VehicleManage.FRM_JiaShiYuanGuanLi.FRM_JiaShiYuanGuanLi {
        
        public FRM_JiaShiYuanGuanLiClient() {
        }
        
        public FRM_JiaShiYuanGuanLiClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FRM_JiaShiYuanGuanLiClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_JiaShiYuanGuanLiClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_JiaShiYuanGuanLiClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet SelectJiaShiYuanBianHao() {
            return base.Channel.SelectJiaShiYuanBianHao();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectJiaShiYuanBianHaoAsync() {
            return base.Channel.SelectJiaShiYuanBianHaoAsync();
        }
        
        public System.Data.DataSet SelectJiaShiYuanMingCheng() {
            return base.Channel.SelectJiaShiYuanMingCheng();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectJiaShiYuanMingChengAsync() {
            return base.Channel.SelectJiaShiYuanMingChengAsync();
        }
        
        public System.Data.DataSet SelectJiaShiYuanXinXi() {
            return base.Channel.SelectJiaShiYuanXinXi();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectJiaShiYuanXinXiAsync() {
            return base.Channel.SelectJiaShiYuanXinXiAsync();
        }
        
        public System.Data.DataSet SelectJiaShiYuanXinXiByJiaShiYuanBianHao(string DriverNumber) {
            return base.Channel.SelectJiaShiYuanXinXiByJiaShiYuanBianHao(DriverNumber);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectJiaShiYuanXinXiByJiaShiYuanBianHaoAsync(string DriverNumber) {
            return base.Channel.SelectJiaShiYuanXinXiByJiaShiYuanBianHaoAsync(DriverNumber);
        }
        
        public System.Data.DataSet SelectJiaShiYuanXinXiByJiaShiYuanID(int DriverID) {
            return base.Channel.SelectJiaShiYuanXinXiByJiaShiYuanID(DriverID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectJiaShiYuanXinXiByJiaShiYuanIDAsync(int DriverID) {
            return base.Channel.SelectJiaShiYuanXinXiByJiaShiYuanIDAsync(DriverID);
        }
        
        public System.Data.DataSet SelectJiaShiYuanXiangXiXinXiByJiaShiYuanID(int DriverID) {
            return base.Channel.SelectJiaShiYuanXiangXiXinXiByJiaShiYuanID(DriverID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectJiaShiYuanXiangXiXinXiByJiaShiYuanIDAsync(int DriverID) {
            return base.Channel.SelectJiaShiYuanXiangXiXinXiByJiaShiYuanIDAsync(DriverID);
        }
        
        public byte[] SelectJiaShiYuanTuPian(int DriverID) {
            return base.Channel.SelectJiaShiYuanTuPian(DriverID);
        }
        
        public System.Threading.Tasks.Task<byte[]> SelectJiaShiYuanTuPianAsync(int DriverID) {
            return base.Channel.SelectJiaShiYuanTuPianAsync(DriverID);
        }
        
        public int DeleteJiaShiYuanXinXi(int DriverID) {
            return base.Channel.DeleteJiaShiYuanXinXi(DriverID);
        }
        
        public System.Threading.Tasks.Task<int> DeleteJiaShiYuanXinXiAsync(int DriverID) {
            return base.Channel.DeleteJiaShiYuanXinXiAsync(DriverID);
        }
    }
}
