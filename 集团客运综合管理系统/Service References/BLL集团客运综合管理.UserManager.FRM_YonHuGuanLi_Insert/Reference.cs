﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 集团客运综合管理系统.BLL集团客运综合管理.UserManager.FRM_YonHuGuanLi_Insert {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLL集团客运综合管理.UserManager.FRM_YonHuGuanLi_Insert.FRM_YonHuGuanLi_Insert")]
    public interface FRM_YonHuGuanLi_Insert {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_YonHuGuanLi_Insert/SelectUserType", ReplyAction="http://tempuri.org/FRM_YonHuGuanLi_Insert/SelectUserTypeResponse")]
        System.Data.DataSet SelectUserType();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_YonHuGuanLi_Insert/SelectUserType", ReplyAction="http://tempuri.org/FRM_YonHuGuanLi_Insert/SelectUserTypeResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectUserTypeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_YonHuGuanLi_Insert/SelectCarStand", ReplyAction="http://tempuri.org/FRM_YonHuGuanLi_Insert/SelectCarStandResponse")]
        System.Data.DataSet SelectCarStand();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_YonHuGuanLi_Insert/SelectCarStand", ReplyAction="http://tempuri.org/FRM_YonHuGuanLi_Insert/SelectCarStandResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectCarStandAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_YonHuGuanLi_Insert/SelectCheZhanByCarStandMC", ReplyAction="http://tempuri.org/FRM_YonHuGuanLi_Insert/SelectCheZhanByCarStandMCResponse")]
        System.Data.DataSet SelectCheZhanByCarStandMC(string CarStandMC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_YonHuGuanLi_Insert/SelectCheZhanByCarStandMC", ReplyAction="http://tempuri.org/FRM_YonHuGuanLi_Insert/SelectCheZhanByCarStandMCResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectCheZhanByCarStandMCAsync(string CarStandMC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_YonHuGuanLi_Insert/SelectUserTypeByUserTypeMC", ReplyAction="http://tempuri.org/FRM_YonHuGuanLi_Insert/SelectUserTypeByUserTypeMCResponse")]
        System.Data.DataSet SelectUserTypeByUserTypeMC(string UserTypeMC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_YonHuGuanLi_Insert/SelectUserTypeByUserTypeMC", ReplyAction="http://tempuri.org/FRM_YonHuGuanLi_Insert/SelectUserTypeByUserTypeMCResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectUserTypeByUserTypeMCAsync(string UserTypeMC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_YonHuGuanLi_Insert/InsertCarStandXinXi", ReplyAction="http://tempuri.org/FRM_YonHuGuanLi_Insert/InsertCarStandXinXiResponse")]
        int InsertCarStandXinXi(string CarStandMC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_YonHuGuanLi_Insert/InsertCarStandXinXi", ReplyAction="http://tempuri.org/FRM_YonHuGuanLi_Insert/InsertCarStandXinXiResponse")]
        System.Threading.Tasks.Task<int> InsertCarStandXinXiAsync(string CarStandMC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_YonHuGuanLi_Insert/InsertUserTypeXinXi", ReplyAction="http://tempuri.org/FRM_YonHuGuanLi_Insert/InsertUserTypeXinXiResponse")]
        int InsertUserTypeXinXi(string UserTypeMC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_YonHuGuanLi_Insert/InsertUserTypeXinXi", ReplyAction="http://tempuri.org/FRM_YonHuGuanLi_Insert/InsertUserTypeXinXiResponse")]
        System.Threading.Tasks.Task<int> InsertUserTypeXinXiAsync(string UserTypeMC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_YonHuGuanLi_Insert/InsertUser", ReplyAction="http://tempuri.org/FRM_YonHuGuanLi_Insert/InsertUserResponse")]
        int InsertUser(int UserTypeID, int AuthorityTypeID, int CarStandID, string UserMC, string UserCoding, string Password, string Comments);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_YonHuGuanLi_Insert/InsertUser", ReplyAction="http://tempuri.org/FRM_YonHuGuanLi_Insert/InsertUserResponse")]
        System.Threading.Tasks.Task<int> InsertUserAsync(int UserTypeID, int AuthorityTypeID, int CarStandID, string UserMC, string UserCoding, string Password, string Comments);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FRM_YonHuGuanLi_InsertChannel : 集团客运综合管理系统.BLL集团客运综合管理.UserManager.FRM_YonHuGuanLi_Insert.FRM_YonHuGuanLi_Insert, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FRM_YonHuGuanLi_InsertClient : System.ServiceModel.ClientBase<集团客运综合管理系统.BLL集团客运综合管理.UserManager.FRM_YonHuGuanLi_Insert.FRM_YonHuGuanLi_Insert>, 集团客运综合管理系统.BLL集团客运综合管理.UserManager.FRM_YonHuGuanLi_Insert.FRM_YonHuGuanLi_Insert {
        
        public FRM_YonHuGuanLi_InsertClient() {
        }
        
        public FRM_YonHuGuanLi_InsertClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FRM_YonHuGuanLi_InsertClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_YonHuGuanLi_InsertClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_YonHuGuanLi_InsertClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet SelectUserType() {
            return base.Channel.SelectUserType();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectUserTypeAsync() {
            return base.Channel.SelectUserTypeAsync();
        }
        
        public System.Data.DataSet SelectCarStand() {
            return base.Channel.SelectCarStand();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectCarStandAsync() {
            return base.Channel.SelectCarStandAsync();
        }
        
        public System.Data.DataSet SelectCheZhanByCarStandMC(string CarStandMC) {
            return base.Channel.SelectCheZhanByCarStandMC(CarStandMC);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectCheZhanByCarStandMCAsync(string CarStandMC) {
            return base.Channel.SelectCheZhanByCarStandMCAsync(CarStandMC);
        }
        
        public System.Data.DataSet SelectUserTypeByUserTypeMC(string UserTypeMC) {
            return base.Channel.SelectUserTypeByUserTypeMC(UserTypeMC);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectUserTypeByUserTypeMCAsync(string UserTypeMC) {
            return base.Channel.SelectUserTypeByUserTypeMCAsync(UserTypeMC);
        }
        
        public int InsertCarStandXinXi(string CarStandMC) {
            return base.Channel.InsertCarStandXinXi(CarStandMC);
        }
        
        public System.Threading.Tasks.Task<int> InsertCarStandXinXiAsync(string CarStandMC) {
            return base.Channel.InsertCarStandXinXiAsync(CarStandMC);
        }
        
        public int InsertUserTypeXinXi(string UserTypeMC) {
            return base.Channel.InsertUserTypeXinXi(UserTypeMC);
        }
        
        public System.Threading.Tasks.Task<int> InsertUserTypeXinXiAsync(string UserTypeMC) {
            return base.Channel.InsertUserTypeXinXiAsync(UserTypeMC);
        }
        
        public int InsertUser(int UserTypeID, int AuthorityTypeID, int CarStandID, string UserMC, string UserCoding, string Password, string Comments) {
            return base.Channel.InsertUser(UserTypeID, AuthorityTypeID, CarStandID, UserMC, UserCoding, Password, Comments);
        }
        
        public System.Threading.Tasks.Task<int> InsertUserAsync(int UserTypeID, int AuthorityTypeID, int CarStandID, string UserMC, string UserCoding, string Password, string Comments) {
            return base.Channel.InsertUserAsync(UserTypeID, AuthorityTypeID, CarStandID, UserMC, UserCoding, Password, Comments);
        }
    }
}
