﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 集团客运综合管理系统.BLL集团客运综合管理.VehicleManage.FRM_CheLiangGuangLi_Insert {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLL集团客运综合管理.VehicleManage.FRM_CheLiangGuangLi_Insert.FRM_CheLiangGuangLi_Insert")]
    public interface FRM_CheLiangGuangLi_Insert {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectDriverNumber", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectDriverNumberResponse")]
        System.Data.DataSet SelectDriverNumber();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectDriverNumber", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectDriverNumberResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectDriverNumberAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectJiaShiYuanByDriverNumber", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectJiaShiYuanByDriverNumberRespo" +
            "nse")]
        System.Data.DataSet SelectJiaShiYuanByDriverNumber(string DriverNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectJiaShiYuanByDriverNumber", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectJiaShiYuanByDriverNumberRespo" +
            "nse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectJiaShiYuanByDriverNumberAsync(string DriverNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectChengBaoGonSi", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectChengBaoGonSiResponse")]
        System.Data.DataSet SelectChengBaoGonSi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectChengBaoGonSi", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectChengBaoGonSiResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectChengBaoGonSiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectCheShuDangWei", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectCheShuDangWeiResponse")]
        System.Data.DataSet SelectCheShuDangWei();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectCheShuDangWei", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectCheShuDangWeiResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectCheShuDangWeiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectCheLiangLeiXing", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectCheLiangLeiXingResponse")]
        System.Data.DataSet SelectCheLiangLeiXing();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectCheLiangLeiXing", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectCheLiangLeiXingResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectCheLiangLeiXingAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/InsertCheLiangXinXi", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/InsertCheLiangXinXiResponse")]
        int InsertCheLiangXinXi(
                    int VehicleHostID, 
                    int VehicleTypeID, 
                    int CarBelongToTheUnitID, 
                    int VehicleStateID, 
                    int PolicyOfInsuranceID, 
                    int VehicleLicenseID, 
                    int DriverID, 
                    int DriverAssistantID, 
                    int CreateUserID, 
                    int DeleteUserID, 
                    string VehicleNumber, 
                    string VehiclePaiNumber, 
                    System.DateTime RegisterDate, 
                    string Seating, 
                    string Loadheaver, 
                    bool SafeInspectNo, 
                    bool EverySkySafeInspect, 
                    bool OneSkySafeInspectOneNext, 
                    string Comment, 
                    System.DateTime CreateTime, 
                    System.DateTime LogicalDeleteTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/InsertCheLiangXinXi", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/InsertCheLiangXinXiResponse")]
        System.Threading.Tasks.Task<int> InsertCheLiangXinXiAsync(
                    int VehicleHostID, 
                    int VehicleTypeID, 
                    int CarBelongToTheUnitID, 
                    int VehicleStateID, 
                    int PolicyOfInsuranceID, 
                    int VehicleLicenseID, 
                    int DriverID, 
                    int DriverAssistantID, 
                    int CreateUserID, 
                    int DeleteUserID, 
                    string VehicleNumber, 
                    string VehiclePaiNumber, 
                    System.DateTime RegisterDate, 
                    string Seating, 
                    string Loadheaver, 
                    bool SafeInspectNo, 
                    bool EverySkySafeInspect, 
                    bool OneSkySafeInspectOneNext, 
                    string Comment, 
                    System.DateTime CreateTime, 
                    System.DateTime LogicalDeleteTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/InsertBaoXian", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/InsertBaoXianResponse")]
        int InsertBaoXian(int UnderwriteCompanyID, int CreateUserID, int DeleteUserID, string PolicyOfInsuranceMC, System.DateTime BookbuildingDate, System.DateTime Drivenvehicle, System.DateTime CommercialUnderwritingExecutive, System.DateTime Bearingonetransportrisk, System.DateTime CreateTime, System.DateTime LogicalDeleteTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/InsertBaoXian", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/InsertBaoXianResponse")]
        System.Threading.Tasks.Task<int> InsertBaoXianAsync(int UnderwriteCompanyID, int CreateUserID, int DeleteUserID, string PolicyOfInsuranceMC, System.DateTime BookbuildingDate, System.DateTime Drivenvehicle, System.DateTime CommercialUnderwritingExecutive, System.DateTime Bearingonetransportrisk, System.DateTime CreateTime, System.DateTime LogicalDeleteTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/InsertCheLiangZhengJianXingXi", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/InsertCheLiangZhengJianXingXiRespon" +
            "se")]
        int InsertCheLiangZhengJianXingXi(
                    int CreateUserID, 
                    int DeleteUserID, 
                    string BusinessLine, 
                    string LineNumber, 
                    string AttachedCardNumber, 
                    string OperationOfTheNumber, 
                    System.DateTime Validity, 
                    System.DateTime SpringRecords, 
                    System.DateTime InspectionRecords, 
                    System.DateTime CompleteMaintenance, 
                    System.DateTime Rating, 
                    System.DateTime TravelCard, 
                    System.DateTime MonthMaintainSun, 
                    System.DateTime LiquefiedPetroleumGasCard, 
                    System.DateTime CreateTime, 
                    System.DateTime LogicalDeleteTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/InsertCheLiangZhengJianXingXi", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/InsertCheLiangZhengJianXingXiRespon" +
            "se")]
        System.Threading.Tasks.Task<int> InsertCheLiangZhengJianXingXiAsync(
                    int CreateUserID, 
                    int DeleteUserID, 
                    string BusinessLine, 
                    string LineNumber, 
                    string AttachedCardNumber, 
                    string OperationOfTheNumber, 
                    System.DateTime Validity, 
                    System.DateTime SpringRecords, 
                    System.DateTime InspectionRecords, 
                    System.DateTime CompleteMaintenance, 
                    System.DateTime Rating, 
                    System.DateTime TravelCard, 
                    System.DateTime MonthMaintainSun, 
                    System.DateTime LiquefiedPetroleumGasCard, 
                    System.DateTime CreateTime, 
                    System.DateTime LogicalDeleteTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/InsertCheZhu", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/InsertCheZhuResponse")]
        int InsertCheZhu(int CreateUserID, int DeleteUserID, string VehicleHostMC, string Address, string ContactPhone, string Identification, System.DateTime CreateTime, System.DateTime LogicalDeleteTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/InsertCheZhu", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/InsertCheZhuResponse")]
        System.Threading.Tasks.Task<int> InsertCheZhuAsync(int CreateUserID, int DeleteUserID, string VehicleHostMC, string Address, string ContactPhone, string Identification, System.DateTime CreateTime, System.DateTime LogicalDeleteTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/InsertXiWei", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/InsertXiWeiResponse")]
        int InsertXiWei(int VehicleID, int SeatsTypeID, int SeatsStateID, int SeatNoMC, bool UseNo, int CreateUserID, int DeleteUserID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/InsertXiWei", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/InsertXiWeiResponse")]
        System.Threading.Tasks.Task<int> InsertXiWeiAsync(int VehicleID, int SeatsTypeID, int SeatsStateID, int SeatNoMC, bool UseNo, int CreateUserID, int DeleteUserID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectXiweigeshu", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectXiweigeshuResponse")]
        System.Data.DataSet SelectXiweigeshu(int VehicleID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectXiweigeshu", ReplyAction="http://tempuri.org/FRM_CheLiangGuangLi_Insert/SelectXiweigeshuResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectXiweigeshuAsync(int VehicleID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FRM_CheLiangGuangLi_InsertChannel : 集团客运综合管理系统.BLL集团客运综合管理.VehicleManage.FRM_CheLiangGuangLi_Insert.FRM_CheLiangGuangLi_Insert, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FRM_CheLiangGuangLi_InsertClient : System.ServiceModel.ClientBase<集团客运综合管理系统.BLL集团客运综合管理.VehicleManage.FRM_CheLiangGuangLi_Insert.FRM_CheLiangGuangLi_Insert>, 集团客运综合管理系统.BLL集团客运综合管理.VehicleManage.FRM_CheLiangGuangLi_Insert.FRM_CheLiangGuangLi_Insert {
        
        public FRM_CheLiangGuangLi_InsertClient() {
        }
        
        public FRM_CheLiangGuangLi_InsertClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FRM_CheLiangGuangLi_InsertClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_CheLiangGuangLi_InsertClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FRM_CheLiangGuangLi_InsertClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet SelectDriverNumber() {
            return base.Channel.SelectDriverNumber();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectDriverNumberAsync() {
            return base.Channel.SelectDriverNumberAsync();
        }
        
        public System.Data.DataSet SelectJiaShiYuanByDriverNumber(string DriverNumber) {
            return base.Channel.SelectJiaShiYuanByDriverNumber(DriverNumber);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectJiaShiYuanByDriverNumberAsync(string DriverNumber) {
            return base.Channel.SelectJiaShiYuanByDriverNumberAsync(DriverNumber);
        }
        
        public System.Data.DataSet SelectChengBaoGonSi() {
            return base.Channel.SelectChengBaoGonSi();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectChengBaoGonSiAsync() {
            return base.Channel.SelectChengBaoGonSiAsync();
        }
        
        public System.Data.DataSet SelectCheShuDangWei() {
            return base.Channel.SelectCheShuDangWei();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectCheShuDangWeiAsync() {
            return base.Channel.SelectCheShuDangWeiAsync();
        }
        
        public System.Data.DataSet SelectCheLiangLeiXing() {
            return base.Channel.SelectCheLiangLeiXing();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectCheLiangLeiXingAsync() {
            return base.Channel.SelectCheLiangLeiXingAsync();
        }
        
        public int InsertCheLiangXinXi(
                    int VehicleHostID, 
                    int VehicleTypeID, 
                    int CarBelongToTheUnitID, 
                    int VehicleStateID, 
                    int PolicyOfInsuranceID, 
                    int VehicleLicenseID, 
                    int DriverID, 
                    int DriverAssistantID, 
                    int CreateUserID, 
                    int DeleteUserID, 
                    string VehicleNumber, 
                    string VehiclePaiNumber, 
                    System.DateTime RegisterDate, 
                    string Seating, 
                    string Loadheaver, 
                    bool SafeInspectNo, 
                    bool EverySkySafeInspect, 
                    bool OneSkySafeInspectOneNext, 
                    string Comment, 
                    System.DateTime CreateTime, 
                    System.DateTime LogicalDeleteTime) {
            return base.Channel.InsertCheLiangXinXi(VehicleHostID, VehicleTypeID, CarBelongToTheUnitID, VehicleStateID, PolicyOfInsuranceID, VehicleLicenseID, DriverID, DriverAssistantID, CreateUserID, DeleteUserID, VehicleNumber, VehiclePaiNumber, RegisterDate, Seating, Loadheaver, SafeInspectNo, EverySkySafeInspect, OneSkySafeInspectOneNext, Comment, CreateTime, LogicalDeleteTime);
        }
        
        public System.Threading.Tasks.Task<int> InsertCheLiangXinXiAsync(
                    int VehicleHostID, 
                    int VehicleTypeID, 
                    int CarBelongToTheUnitID, 
                    int VehicleStateID, 
                    int PolicyOfInsuranceID, 
                    int VehicleLicenseID, 
                    int DriverID, 
                    int DriverAssistantID, 
                    int CreateUserID, 
                    int DeleteUserID, 
                    string VehicleNumber, 
                    string VehiclePaiNumber, 
                    System.DateTime RegisterDate, 
                    string Seating, 
                    string Loadheaver, 
                    bool SafeInspectNo, 
                    bool EverySkySafeInspect, 
                    bool OneSkySafeInspectOneNext, 
                    string Comment, 
                    System.DateTime CreateTime, 
                    System.DateTime LogicalDeleteTime) {
            return base.Channel.InsertCheLiangXinXiAsync(VehicleHostID, VehicleTypeID, CarBelongToTheUnitID, VehicleStateID, PolicyOfInsuranceID, VehicleLicenseID, DriverID, DriverAssistantID, CreateUserID, DeleteUserID, VehicleNumber, VehiclePaiNumber, RegisterDate, Seating, Loadheaver, SafeInspectNo, EverySkySafeInspect, OneSkySafeInspectOneNext, Comment, CreateTime, LogicalDeleteTime);
        }
        
        public int InsertBaoXian(int UnderwriteCompanyID, int CreateUserID, int DeleteUserID, string PolicyOfInsuranceMC, System.DateTime BookbuildingDate, System.DateTime Drivenvehicle, System.DateTime CommercialUnderwritingExecutive, System.DateTime Bearingonetransportrisk, System.DateTime CreateTime, System.DateTime LogicalDeleteTime) {
            return base.Channel.InsertBaoXian(UnderwriteCompanyID, CreateUserID, DeleteUserID, PolicyOfInsuranceMC, BookbuildingDate, Drivenvehicle, CommercialUnderwritingExecutive, Bearingonetransportrisk, CreateTime, LogicalDeleteTime);
        }
        
        public System.Threading.Tasks.Task<int> InsertBaoXianAsync(int UnderwriteCompanyID, int CreateUserID, int DeleteUserID, string PolicyOfInsuranceMC, System.DateTime BookbuildingDate, System.DateTime Drivenvehicle, System.DateTime CommercialUnderwritingExecutive, System.DateTime Bearingonetransportrisk, System.DateTime CreateTime, System.DateTime LogicalDeleteTime) {
            return base.Channel.InsertBaoXianAsync(UnderwriteCompanyID, CreateUserID, DeleteUserID, PolicyOfInsuranceMC, BookbuildingDate, Drivenvehicle, CommercialUnderwritingExecutive, Bearingonetransportrisk, CreateTime, LogicalDeleteTime);
        }
        
        public int InsertCheLiangZhengJianXingXi(
                    int CreateUserID, 
                    int DeleteUserID, 
                    string BusinessLine, 
                    string LineNumber, 
                    string AttachedCardNumber, 
                    string OperationOfTheNumber, 
                    System.DateTime Validity, 
                    System.DateTime SpringRecords, 
                    System.DateTime InspectionRecords, 
                    System.DateTime CompleteMaintenance, 
                    System.DateTime Rating, 
                    System.DateTime TravelCard, 
                    System.DateTime MonthMaintainSun, 
                    System.DateTime LiquefiedPetroleumGasCard, 
                    System.DateTime CreateTime, 
                    System.DateTime LogicalDeleteTime) {
            return base.Channel.InsertCheLiangZhengJianXingXi(CreateUserID, DeleteUserID, BusinessLine, LineNumber, AttachedCardNumber, OperationOfTheNumber, Validity, SpringRecords, InspectionRecords, CompleteMaintenance, Rating, TravelCard, MonthMaintainSun, LiquefiedPetroleumGasCard, CreateTime, LogicalDeleteTime);
        }
        
        public System.Threading.Tasks.Task<int> InsertCheLiangZhengJianXingXiAsync(
                    int CreateUserID, 
                    int DeleteUserID, 
                    string BusinessLine, 
                    string LineNumber, 
                    string AttachedCardNumber, 
                    string OperationOfTheNumber, 
                    System.DateTime Validity, 
                    System.DateTime SpringRecords, 
                    System.DateTime InspectionRecords, 
                    System.DateTime CompleteMaintenance, 
                    System.DateTime Rating, 
                    System.DateTime TravelCard, 
                    System.DateTime MonthMaintainSun, 
                    System.DateTime LiquefiedPetroleumGasCard, 
                    System.DateTime CreateTime, 
                    System.DateTime LogicalDeleteTime) {
            return base.Channel.InsertCheLiangZhengJianXingXiAsync(CreateUserID, DeleteUserID, BusinessLine, LineNumber, AttachedCardNumber, OperationOfTheNumber, Validity, SpringRecords, InspectionRecords, CompleteMaintenance, Rating, TravelCard, MonthMaintainSun, LiquefiedPetroleumGasCard, CreateTime, LogicalDeleteTime);
        }
        
        public int InsertCheZhu(int CreateUserID, int DeleteUserID, string VehicleHostMC, string Address, string ContactPhone, string Identification, System.DateTime CreateTime, System.DateTime LogicalDeleteTime) {
            return base.Channel.InsertCheZhu(CreateUserID, DeleteUserID, VehicleHostMC, Address, ContactPhone, Identification, CreateTime, LogicalDeleteTime);
        }
        
        public System.Threading.Tasks.Task<int> InsertCheZhuAsync(int CreateUserID, int DeleteUserID, string VehicleHostMC, string Address, string ContactPhone, string Identification, System.DateTime CreateTime, System.DateTime LogicalDeleteTime) {
            return base.Channel.InsertCheZhuAsync(CreateUserID, DeleteUserID, VehicleHostMC, Address, ContactPhone, Identification, CreateTime, LogicalDeleteTime);
        }
        
        public int InsertXiWei(int VehicleID, int SeatsTypeID, int SeatsStateID, int SeatNoMC, bool UseNo, int CreateUserID, int DeleteUserID) {
            return base.Channel.InsertXiWei(VehicleID, SeatsTypeID, SeatsStateID, SeatNoMC, UseNo, CreateUserID, DeleteUserID);
        }
        
        public System.Threading.Tasks.Task<int> InsertXiWeiAsync(int VehicleID, int SeatsTypeID, int SeatsStateID, int SeatNoMC, bool UseNo, int CreateUserID, int DeleteUserID) {
            return base.Channel.InsertXiWeiAsync(VehicleID, SeatsTypeID, SeatsStateID, SeatNoMC, UseNo, CreateUserID, DeleteUserID);
        }
        
        public System.Data.DataSet SelectXiweigeshu(int VehicleID) {
            return base.Channel.SelectXiweigeshu(VehicleID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectXiweigeshuAsync(int VehicleID) {
            return base.Channel.SelectXiweigeshuAsync(VehicleID);
        }
    }
}
