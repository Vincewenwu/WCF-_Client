﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 集团客运综合管理系统.BLL集团客运综合管理.BiIIEnterlibraryManager.FRM_PiaoJuChuKu_Insert {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLL集团客运综合管理.BiIIEnterlibraryManager.FRM_PiaoJuChuKu_Insert.FRM_PiaoJuChuKu_Insert" +
        "")]
    public interface FRM_PiaoJuChuKu_Insert {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_PiaoJuChuKu_Insert/SelectShiYonZhuangTai", ReplyAction="http://tempuri.org/FRM_PiaoJuChuKu_Insert/SelectShiYonZhuangTaiResponse")]
        System.Data.DataSet SelectShiYonZhuangTai();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_PiaoJuChuKu_Insert/SelectShiYonZhuangTai", ReplyAction="http://tempuri.org/FRM_PiaoJuChuKu_Insert/SelectShiYonZhuangTaiResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectShiYonZhuangTaiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_PiaoJuChuKu_Insert/SelectYonHuBianHao", ReplyAction="http://tempuri.org/FRM_PiaoJuChuKu_Insert/SelectYonHuBianHaoResponse")]
        System.Data.DataSet SelectYonHuBianHao();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_PiaoJuChuKu_Insert/SelectYonHuBianHao", ReplyAction="http://tempuri.org/FRM_PiaoJuChuKu_Insert/SelectYonHuBianHaoResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectYonHuBianHaoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_PiaoJuChuKu_Insert/SelectYonHuByYonHuBianHao", ReplyAction="http://tempuri.org/FRM_PiaoJuChuKu_Insert/SelectYonHuByYonHuBianHaoResponse")]
        System.Data.DataSet SelectYonHuByYonHuBianHao(string UserCoding);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_PiaoJuChuKu_Insert/SelectYonHuByYonHuBianHao", ReplyAction="http://tempuri.org/FRM_PiaoJuChuKu_Insert/SelectYonHuByYonHuBianHaoResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectYonHuByYonHuBianHaoAsync(string UserCoding);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_PiaoJuChuKu_Insert/SelectPiaoJuKuCunXinXi", ReplyAction="http://tempuri.org/FRM_PiaoJuChuKu_Insert/SelectPiaoJuKuCunXinXiResponse")]
        System.Data.DataSet SelectPiaoJuKuCunXinXi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_PiaoJuChuKu_Insert/SelectPiaoJuKuCunXinXi", ReplyAction="http://tempuri.org/FRM_PiaoJuChuKu_Insert/SelectPiaoJuKuCunXinXiResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectPiaoJuKuCunXinXiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_PiaoJuChuKu_Insert/InsertPiaoJuChuKu", ReplyAction="http://tempuri.org/FRM_PiaoJuChuKu_Insert/InsertPiaoJuChuKuResponse")]
        int InsertPiaoJuChuKu(int BiIITypeID, int ReceiveUserID, int UseStateID, int CreateUserID, int DeleteUserID, int BeginTicketMark, int FinishTicketMark, int CurrentTicketMark, int SurplusQuantity, System.DateTime RemovaDate, string Comment, System.DateTime CreateTime, System.DateTime LogicalDeleteTime, int NeckUseQuantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_PiaoJuChuKu_Insert/InsertPiaoJuChuKu", ReplyAction="http://tempuri.org/FRM_PiaoJuChuKu_Insert/InsertPiaoJuChuKuResponse")]
        System.Threading.Tasks.Task<int> InsertPiaoJuChuKuAsync(int BiIITypeID, int ReceiveUserID, int UseStateID, int CreateUserID, int DeleteUserID, int BeginTicketMark, int FinishTicketMark, int CurrentTicketMark, int SurplusQuantity, System.DateTime RemovaDate, string Comment, System.DateTime CreateTime, System.DateTime LogicalDeleteTime, int NeckUseQuantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_PiaoJuChuKu_Insert/UpdatePiaoJuChuKu", ReplyAction="http://tempuri.org/FRM_PiaoJuChuKu_Insert/UpdatePiaoJuChuKuResponse")]
        int UpdatePiaoJuChuKu(int CurrentTicketMark, int Inventory, int BiIIEnterlibraryID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_PiaoJuChuKu_Insert/UpdatePiaoJuChuKu", ReplyAction="http://tempuri.org/FRM_PiaoJuChuKu_Insert/UpdatePiaoJuChuKuResponse")]
        System.Threading.Tasks.Task<int> UpdatePiaoJuChuKuAsync(int CurrentTicketMark, int Inventory, int BiIIEnterlibraryID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FRM_PiaoJuChuKu_InsertChannel : 集团客运综合管理系统.BLL集团客运综合管理.BiIIEnterlibraryManager.FRM_PiaoJuChuKu_Insert.FRM_PiaoJuChuKu_Insert, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FRM_PiaoJuChuKu_InsertClient : System.ServiceModel.ClientBase<集团客运综合管理系统.BLL集团客运综合管理.BiIIEnterlibraryManager.FRM_PiaoJuChuKu_Insert.FRM_PiaoJuChuKu_Insert>, 集团客运综合管理系统.BLL集团客运综合管理.BiIIEnterlibraryManager.FRM_PiaoJuChuKu_Insert.FRM_PiaoJuChuKu_Insert {
        
        public FRM_PiaoJuChuKu_InsertClient() {
        }
        
        public FRM_PiaoJuChuKu_InsertClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FRM_PiaoJuChuKu_InsertClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_PiaoJuChuKu_InsertClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_PiaoJuChuKu_InsertClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet SelectShiYonZhuangTai() {
            return base.Channel.SelectShiYonZhuangTai();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectShiYonZhuangTaiAsync() {
            return base.Channel.SelectShiYonZhuangTaiAsync();
        }
        
        public System.Data.DataSet SelectYonHuBianHao() {
            return base.Channel.SelectYonHuBianHao();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectYonHuBianHaoAsync() {
            return base.Channel.SelectYonHuBianHaoAsync();
        }
        
        public System.Data.DataSet SelectYonHuByYonHuBianHao(string UserCoding) {
            return base.Channel.SelectYonHuByYonHuBianHao(UserCoding);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectYonHuByYonHuBianHaoAsync(string UserCoding) {
            return base.Channel.SelectYonHuByYonHuBianHaoAsync(UserCoding);
        }
        
        public System.Data.DataSet SelectPiaoJuKuCunXinXi() {
            return base.Channel.SelectPiaoJuKuCunXinXi();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectPiaoJuKuCunXinXiAsync() {
            return base.Channel.SelectPiaoJuKuCunXinXiAsync();
        }
        
        public int InsertPiaoJuChuKu(int BiIITypeID, int ReceiveUserID, int UseStateID, int CreateUserID, int DeleteUserID, int BeginTicketMark, int FinishTicketMark, int CurrentTicketMark, int SurplusQuantity, System.DateTime RemovaDate, string Comment, System.DateTime CreateTime, System.DateTime LogicalDeleteTime, int NeckUseQuantity) {
            return base.Channel.InsertPiaoJuChuKu(BiIITypeID, ReceiveUserID, UseStateID, CreateUserID, DeleteUserID, BeginTicketMark, FinishTicketMark, CurrentTicketMark, SurplusQuantity, RemovaDate, Comment, CreateTime, LogicalDeleteTime, NeckUseQuantity);
        }
        
        public System.Threading.Tasks.Task<int> InsertPiaoJuChuKuAsync(int BiIITypeID, int ReceiveUserID, int UseStateID, int CreateUserID, int DeleteUserID, int BeginTicketMark, int FinishTicketMark, int CurrentTicketMark, int SurplusQuantity, System.DateTime RemovaDate, string Comment, System.DateTime CreateTime, System.DateTime LogicalDeleteTime, int NeckUseQuantity) {
            return base.Channel.InsertPiaoJuChuKuAsync(BiIITypeID, ReceiveUserID, UseStateID, CreateUserID, DeleteUserID, BeginTicketMark, FinishTicketMark, CurrentTicketMark, SurplusQuantity, RemovaDate, Comment, CreateTime, LogicalDeleteTime, NeckUseQuantity);
        }
        
        public int UpdatePiaoJuChuKu(int CurrentTicketMark, int Inventory, int BiIIEnterlibraryID) {
            return base.Channel.UpdatePiaoJuChuKu(CurrentTicketMark, Inventory, BiIIEnterlibraryID);
        }
        
        public System.Threading.Tasks.Task<int> UpdatePiaoJuChuKuAsync(int CurrentTicketMark, int Inventory, int BiIIEnterlibraryID) {
            return base.Channel.UpdatePiaoJuChuKuAsync(CurrentTicketMark, Inventory, BiIIEnterlibraryID);
        }
    }
}
