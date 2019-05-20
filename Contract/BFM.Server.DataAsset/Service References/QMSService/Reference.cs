﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BFM.Server.DataAsset.QMSService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://fanuc.com.cn/", ConfigurationName="QMSService.IQMSService")]
    public interface IQMSService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsTestByPage", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsTestByPageResponse")]
        System.Collections.Generic.List<BFM.ContractModel.QmsTest> GetQmsTestByPage(int pageSize, int pageIndex, bool isAsc, string orderField, string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsTestByPage", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsTestByPageResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BFM.ContractModel.QmsTest>> GetQmsTestByPageAsync(int pageSize, int pageIndex, bool isAsc, string orderField, string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsTestCount", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsTestCountResponse")]
        int GetQmsTestCount(string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsTestCount", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsTestCountResponse")]
        System.Threading.Tasks.Task<int> GetQmsTestCountAsync(string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/AddQmsTest", ReplyAction="http://fanuc.com.cn/IQMSService/AddQmsTestResponse")]
        bool AddQmsTest(BFM.ContractModel.QmsTest mQmsTest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/AddQmsTest", ReplyAction="http://fanuc.com.cn/IQMSService/AddQmsTestResponse")]
        System.Threading.Tasks.Task<bool> AddQmsTestAsync(BFM.ContractModel.QmsTest mQmsTest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/UpdateQmsTest", ReplyAction="http://fanuc.com.cn/IQMSService/UpdateQmsTestResponse")]
        bool UpdateQmsTest(BFM.ContractModel.QmsTest mQmsTest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/UpdateQmsTest", ReplyAction="http://fanuc.com.cn/IQMSService/UpdateQmsTestResponse")]
        System.Threading.Tasks.Task<bool> UpdateQmsTestAsync(BFM.ContractModel.QmsTest mQmsTest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/DelQmsTests", ReplyAction="http://fanuc.com.cn/IQMSService/DelQmsTestsResponse")]
        bool DelQmsTests(System.Collections.Generic.List<string> Ids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/DelQmsTests", ReplyAction="http://fanuc.com.cn/IQMSService/DelQmsTestsResponse")]
        System.Threading.Tasks.Task<bool> DelQmsTestsAsync(System.Collections.Generic.List<string> Ids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/DelQmsTest", ReplyAction="http://fanuc.com.cn/IQMSService/DelQmsTestResponse")]
        bool DelQmsTest(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/DelQmsTest", ReplyAction="http://fanuc.com.cn/IQMSService/DelQmsTestResponse")]
        System.Threading.Tasks.Task<bool> DelQmsTestAsync(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsTests", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsTestsResponse")]
        System.Collections.Generic.List<BFM.ContractModel.QmsTest> GetQmsTests(string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsTests", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsTestsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BFM.ContractModel.QmsTest>> GetQmsTestsAsync(string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsTestById", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsTestByIdResponse")]
        BFM.ContractModel.QmsTest GetQmsTestById(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsTestById", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsTestByIdResponse")]
        System.Threading.Tasks.Task<BFM.ContractModel.QmsTest> GetQmsTestByIdAsync(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsCheckParamByPage", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsCheckParamByPageResponse")]
        System.Collections.Generic.List<BFM.ContractModel.QmsCheckParam> GetQmsCheckParamByPage(int pageSize, int pageIndex, bool isAsc, string orderField, string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsCheckParamByPage", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsCheckParamByPageResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BFM.ContractModel.QmsCheckParam>> GetQmsCheckParamByPageAsync(int pageSize, int pageIndex, bool isAsc, string orderField, string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsCheckParamCount", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsCheckParamCountResponse")]
        int GetQmsCheckParamCount(string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsCheckParamCount", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsCheckParamCountResponse")]
        System.Threading.Tasks.Task<int> GetQmsCheckParamCountAsync(string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/AddQmsCheckParam", ReplyAction="http://fanuc.com.cn/IQMSService/AddQmsCheckParamResponse")]
        bool AddQmsCheckParam(BFM.ContractModel.QmsCheckParam mQmsCheckParam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/AddQmsCheckParam", ReplyAction="http://fanuc.com.cn/IQMSService/AddQmsCheckParamResponse")]
        System.Threading.Tasks.Task<bool> AddQmsCheckParamAsync(BFM.ContractModel.QmsCheckParam mQmsCheckParam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/UpdateQmsCheckParam", ReplyAction="http://fanuc.com.cn/IQMSService/UpdateQmsCheckParamResponse")]
        bool UpdateQmsCheckParam(BFM.ContractModel.QmsCheckParam mQmsCheckParam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/UpdateQmsCheckParam", ReplyAction="http://fanuc.com.cn/IQMSService/UpdateQmsCheckParamResponse")]
        System.Threading.Tasks.Task<bool> UpdateQmsCheckParamAsync(BFM.ContractModel.QmsCheckParam mQmsCheckParam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/DelQmsCheckParams", ReplyAction="http://fanuc.com.cn/IQMSService/DelQmsCheckParamsResponse")]
        bool DelQmsCheckParams(System.Collections.Generic.List<string> Ids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/DelQmsCheckParams", ReplyAction="http://fanuc.com.cn/IQMSService/DelQmsCheckParamsResponse")]
        System.Threading.Tasks.Task<bool> DelQmsCheckParamsAsync(System.Collections.Generic.List<string> Ids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/DelQmsCheckParam", ReplyAction="http://fanuc.com.cn/IQMSService/DelQmsCheckParamResponse")]
        bool DelQmsCheckParam(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/DelQmsCheckParam", ReplyAction="http://fanuc.com.cn/IQMSService/DelQmsCheckParamResponse")]
        System.Threading.Tasks.Task<bool> DelQmsCheckParamAsync(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsCheckParams", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsCheckParamsResponse")]
        System.Collections.Generic.List<BFM.ContractModel.QmsCheckParam> GetQmsCheckParams(string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsCheckParams", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsCheckParamsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BFM.ContractModel.QmsCheckParam>> GetQmsCheckParamsAsync(string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsCheckParamById", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsCheckParamByIdResponse")]
        BFM.ContractModel.QmsCheckParam GetQmsCheckParamById(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsCheckParamById", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsCheckParamByIdResponse")]
        System.Threading.Tasks.Task<BFM.ContractModel.QmsCheckParam> GetQmsCheckParamByIdAsync(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsRoutingCheckByPage", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsRoutingCheckByPageResponse")]
        System.Collections.Generic.List<BFM.ContractModel.QmsRoutingCheck> GetQmsRoutingCheckByPage(int pageSize, int pageIndex, bool isAsc, string orderField, string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsRoutingCheckByPage", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsRoutingCheckByPageResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BFM.ContractModel.QmsRoutingCheck>> GetQmsRoutingCheckByPageAsync(int pageSize, int pageIndex, bool isAsc, string orderField, string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsRoutingCheckCount", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsRoutingCheckCountResponse")]
        int GetQmsRoutingCheckCount(string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsRoutingCheckCount", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsRoutingCheckCountResponse")]
        System.Threading.Tasks.Task<int> GetQmsRoutingCheckCountAsync(string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/AddQmsRoutingCheck", ReplyAction="http://fanuc.com.cn/IQMSService/AddQmsRoutingCheckResponse")]
        bool AddQmsRoutingCheck(BFM.ContractModel.QmsRoutingCheck mQmsRoutingCheck);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/AddQmsRoutingCheck", ReplyAction="http://fanuc.com.cn/IQMSService/AddQmsRoutingCheckResponse")]
        System.Threading.Tasks.Task<bool> AddQmsRoutingCheckAsync(BFM.ContractModel.QmsRoutingCheck mQmsRoutingCheck);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/UpdateQmsRoutingCheck", ReplyAction="http://fanuc.com.cn/IQMSService/UpdateQmsRoutingCheckResponse")]
        bool UpdateQmsRoutingCheck(BFM.ContractModel.QmsRoutingCheck mQmsRoutingCheck);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/UpdateQmsRoutingCheck", ReplyAction="http://fanuc.com.cn/IQMSService/UpdateQmsRoutingCheckResponse")]
        System.Threading.Tasks.Task<bool> UpdateQmsRoutingCheckAsync(BFM.ContractModel.QmsRoutingCheck mQmsRoutingCheck);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/DelQmsRoutingChecks", ReplyAction="http://fanuc.com.cn/IQMSService/DelQmsRoutingChecksResponse")]
        bool DelQmsRoutingChecks(System.Collections.Generic.List<string> Ids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/DelQmsRoutingChecks", ReplyAction="http://fanuc.com.cn/IQMSService/DelQmsRoutingChecksResponse")]
        System.Threading.Tasks.Task<bool> DelQmsRoutingChecksAsync(System.Collections.Generic.List<string> Ids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/DelQmsRoutingCheck", ReplyAction="http://fanuc.com.cn/IQMSService/DelQmsRoutingCheckResponse")]
        bool DelQmsRoutingCheck(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/DelQmsRoutingCheck", ReplyAction="http://fanuc.com.cn/IQMSService/DelQmsRoutingCheckResponse")]
        System.Threading.Tasks.Task<bool> DelQmsRoutingCheckAsync(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsRoutingChecks", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsRoutingChecksResponse")]
        System.Collections.Generic.List<BFM.ContractModel.QmsRoutingCheck> GetQmsRoutingChecks(string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsRoutingChecks", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsRoutingChecksResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BFM.ContractModel.QmsRoutingCheck>> GetQmsRoutingChecksAsync(string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsRoutingCheckById", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsRoutingCheckByIdResponse")]
        BFM.ContractModel.QmsRoutingCheck GetQmsRoutingCheckById(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsRoutingCheckById", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsRoutingCheckByIdResponse")]
        System.Threading.Tasks.Task<BFM.ContractModel.QmsRoutingCheck> GetQmsRoutingCheckByIdAsync(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsCheckMasterByPage", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsCheckMasterByPageResponse")]
        System.Collections.Generic.List<BFM.ContractModel.QmsCheckMaster> GetQmsCheckMasterByPage(int pageSize, int pageIndex, bool isAsc, string orderField, string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsCheckMasterByPage", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsCheckMasterByPageResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BFM.ContractModel.QmsCheckMaster>> GetQmsCheckMasterByPageAsync(int pageSize, int pageIndex, bool isAsc, string orderField, string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsCheckMasterCount", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsCheckMasterCountResponse")]
        int GetQmsCheckMasterCount(string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsCheckMasterCount", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsCheckMasterCountResponse")]
        System.Threading.Tasks.Task<int> GetQmsCheckMasterCountAsync(string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/AddQmsCheckMaster", ReplyAction="http://fanuc.com.cn/IQMSService/AddQmsCheckMasterResponse")]
        bool AddQmsCheckMaster(BFM.ContractModel.QmsCheckMaster mQmsCheckMaster);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/AddQmsCheckMaster", ReplyAction="http://fanuc.com.cn/IQMSService/AddQmsCheckMasterResponse")]
        System.Threading.Tasks.Task<bool> AddQmsCheckMasterAsync(BFM.ContractModel.QmsCheckMaster mQmsCheckMaster);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/UpdateQmsCheckMaster", ReplyAction="http://fanuc.com.cn/IQMSService/UpdateQmsCheckMasterResponse")]
        bool UpdateQmsCheckMaster(BFM.ContractModel.QmsCheckMaster mQmsCheckMaster);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/UpdateQmsCheckMaster", ReplyAction="http://fanuc.com.cn/IQMSService/UpdateQmsCheckMasterResponse")]
        System.Threading.Tasks.Task<bool> UpdateQmsCheckMasterAsync(BFM.ContractModel.QmsCheckMaster mQmsCheckMaster);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/DelQmsCheckMasters", ReplyAction="http://fanuc.com.cn/IQMSService/DelQmsCheckMastersResponse")]
        bool DelQmsCheckMasters(System.Collections.Generic.List<string> Ids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/DelQmsCheckMasters", ReplyAction="http://fanuc.com.cn/IQMSService/DelQmsCheckMastersResponse")]
        System.Threading.Tasks.Task<bool> DelQmsCheckMastersAsync(System.Collections.Generic.List<string> Ids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/DelQmsCheckMaster", ReplyAction="http://fanuc.com.cn/IQMSService/DelQmsCheckMasterResponse")]
        bool DelQmsCheckMaster(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/DelQmsCheckMaster", ReplyAction="http://fanuc.com.cn/IQMSService/DelQmsCheckMasterResponse")]
        System.Threading.Tasks.Task<bool> DelQmsCheckMasterAsync(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsCheckMasters", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsCheckMastersResponse")]
        System.Collections.Generic.List<BFM.ContractModel.QmsCheckMaster> GetQmsCheckMasters(string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsCheckMasters", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsCheckMastersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BFM.ContractModel.QmsCheckMaster>> GetQmsCheckMastersAsync(string sWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsCheckMasterById", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsCheckMasterByIdResponse")]
        BFM.ContractModel.QmsCheckMaster GetQmsCheckMasterById(string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/IQMSService/GetQmsCheckMasterById", ReplyAction="http://fanuc.com.cn/IQMSService/GetQmsCheckMasterByIdResponse")]
        System.Threading.Tasks.Task<BFM.ContractModel.QmsCheckMaster> GetQmsCheckMasterByIdAsync(string Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IQMSServiceChannel : BFM.Server.DataAsset.QMSService.IQMSService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QMSServiceClient : System.ServiceModel.ClientBase<BFM.Server.DataAsset.QMSService.IQMSService>, BFM.Server.DataAsset.QMSService.IQMSService {
        
        public QMSServiceClient() {
        }
        
        public QMSServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public QMSServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QMSServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QMSServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<BFM.ContractModel.QmsTest> GetQmsTestByPage(int pageSize, int pageIndex, bool isAsc, string orderField, string sWhere) {
            return base.Channel.GetQmsTestByPage(pageSize, pageIndex, isAsc, orderField, sWhere);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BFM.ContractModel.QmsTest>> GetQmsTestByPageAsync(int pageSize, int pageIndex, bool isAsc, string orderField, string sWhere) {
            return base.Channel.GetQmsTestByPageAsync(pageSize, pageIndex, isAsc, orderField, sWhere);
        }
        
        public int GetQmsTestCount(string sWhere) {
            return base.Channel.GetQmsTestCount(sWhere);
        }
        
        public System.Threading.Tasks.Task<int> GetQmsTestCountAsync(string sWhere) {
            return base.Channel.GetQmsTestCountAsync(sWhere);
        }
        
        public bool AddQmsTest(BFM.ContractModel.QmsTest mQmsTest) {
            return base.Channel.AddQmsTest(mQmsTest);
        }
        
        public System.Threading.Tasks.Task<bool> AddQmsTestAsync(BFM.ContractModel.QmsTest mQmsTest) {
            return base.Channel.AddQmsTestAsync(mQmsTest);
        }
        
        public bool UpdateQmsTest(BFM.ContractModel.QmsTest mQmsTest) {
            return base.Channel.UpdateQmsTest(mQmsTest);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateQmsTestAsync(BFM.ContractModel.QmsTest mQmsTest) {
            return base.Channel.UpdateQmsTestAsync(mQmsTest);
        }
        
        public bool DelQmsTests(System.Collections.Generic.List<string> Ids) {
            return base.Channel.DelQmsTests(Ids);
        }
        
        public System.Threading.Tasks.Task<bool> DelQmsTestsAsync(System.Collections.Generic.List<string> Ids) {
            return base.Channel.DelQmsTestsAsync(Ids);
        }
        
        public bool DelQmsTest(string Id) {
            return base.Channel.DelQmsTest(Id);
        }
        
        public System.Threading.Tasks.Task<bool> DelQmsTestAsync(string Id) {
            return base.Channel.DelQmsTestAsync(Id);
        }
        
        public System.Collections.Generic.List<BFM.ContractModel.QmsTest> GetQmsTests(string sWhere) {
            return base.Channel.GetQmsTests(sWhere);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BFM.ContractModel.QmsTest>> GetQmsTestsAsync(string sWhere) {
            return base.Channel.GetQmsTestsAsync(sWhere);
        }
        
        public BFM.ContractModel.QmsTest GetQmsTestById(string Id) {
            return base.Channel.GetQmsTestById(Id);
        }
        
        public System.Threading.Tasks.Task<BFM.ContractModel.QmsTest> GetQmsTestByIdAsync(string Id) {
            return base.Channel.GetQmsTestByIdAsync(Id);
        }
        
        public System.Collections.Generic.List<BFM.ContractModel.QmsCheckParam> GetQmsCheckParamByPage(int pageSize, int pageIndex, bool isAsc, string orderField, string sWhere) {
            return base.Channel.GetQmsCheckParamByPage(pageSize, pageIndex, isAsc, orderField, sWhere);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BFM.ContractModel.QmsCheckParam>> GetQmsCheckParamByPageAsync(int pageSize, int pageIndex, bool isAsc, string orderField, string sWhere) {
            return base.Channel.GetQmsCheckParamByPageAsync(pageSize, pageIndex, isAsc, orderField, sWhere);
        }
        
        public int GetQmsCheckParamCount(string sWhere) {
            return base.Channel.GetQmsCheckParamCount(sWhere);
        }
        
        public System.Threading.Tasks.Task<int> GetQmsCheckParamCountAsync(string sWhere) {
            return base.Channel.GetQmsCheckParamCountAsync(sWhere);
        }
        
        public bool AddQmsCheckParam(BFM.ContractModel.QmsCheckParam mQmsCheckParam) {
            return base.Channel.AddQmsCheckParam(mQmsCheckParam);
        }
        
        public System.Threading.Tasks.Task<bool> AddQmsCheckParamAsync(BFM.ContractModel.QmsCheckParam mQmsCheckParam) {
            return base.Channel.AddQmsCheckParamAsync(mQmsCheckParam);
        }
        
        public bool UpdateQmsCheckParam(BFM.ContractModel.QmsCheckParam mQmsCheckParam) {
            return base.Channel.UpdateQmsCheckParam(mQmsCheckParam);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateQmsCheckParamAsync(BFM.ContractModel.QmsCheckParam mQmsCheckParam) {
            return base.Channel.UpdateQmsCheckParamAsync(mQmsCheckParam);
        }
        
        public bool DelQmsCheckParams(System.Collections.Generic.List<string> Ids) {
            return base.Channel.DelQmsCheckParams(Ids);
        }
        
        public System.Threading.Tasks.Task<bool> DelQmsCheckParamsAsync(System.Collections.Generic.List<string> Ids) {
            return base.Channel.DelQmsCheckParamsAsync(Ids);
        }
        
        public bool DelQmsCheckParam(string Id) {
            return base.Channel.DelQmsCheckParam(Id);
        }
        
        public System.Threading.Tasks.Task<bool> DelQmsCheckParamAsync(string Id) {
            return base.Channel.DelQmsCheckParamAsync(Id);
        }
        
        public System.Collections.Generic.List<BFM.ContractModel.QmsCheckParam> GetQmsCheckParams(string sWhere) {
            return base.Channel.GetQmsCheckParams(sWhere);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BFM.ContractModel.QmsCheckParam>> GetQmsCheckParamsAsync(string sWhere) {
            return base.Channel.GetQmsCheckParamsAsync(sWhere);
        }
        
        public BFM.ContractModel.QmsCheckParam GetQmsCheckParamById(string Id) {
            return base.Channel.GetQmsCheckParamById(Id);
        }
        
        public System.Threading.Tasks.Task<BFM.ContractModel.QmsCheckParam> GetQmsCheckParamByIdAsync(string Id) {
            return base.Channel.GetQmsCheckParamByIdAsync(Id);
        }
        
        public System.Collections.Generic.List<BFM.ContractModel.QmsRoutingCheck> GetQmsRoutingCheckByPage(int pageSize, int pageIndex, bool isAsc, string orderField, string sWhere) {
            return base.Channel.GetQmsRoutingCheckByPage(pageSize, pageIndex, isAsc, orderField, sWhere);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BFM.ContractModel.QmsRoutingCheck>> GetQmsRoutingCheckByPageAsync(int pageSize, int pageIndex, bool isAsc, string orderField, string sWhere) {
            return base.Channel.GetQmsRoutingCheckByPageAsync(pageSize, pageIndex, isAsc, orderField, sWhere);
        }
        
        public int GetQmsRoutingCheckCount(string sWhere) {
            return base.Channel.GetQmsRoutingCheckCount(sWhere);
        }
        
        public System.Threading.Tasks.Task<int> GetQmsRoutingCheckCountAsync(string sWhere) {
            return base.Channel.GetQmsRoutingCheckCountAsync(sWhere);
        }
        
        public bool AddQmsRoutingCheck(BFM.ContractModel.QmsRoutingCheck mQmsRoutingCheck) {
            return base.Channel.AddQmsRoutingCheck(mQmsRoutingCheck);
        }
        
        public System.Threading.Tasks.Task<bool> AddQmsRoutingCheckAsync(BFM.ContractModel.QmsRoutingCheck mQmsRoutingCheck) {
            return base.Channel.AddQmsRoutingCheckAsync(mQmsRoutingCheck);
        }
        
        public bool UpdateQmsRoutingCheck(BFM.ContractModel.QmsRoutingCheck mQmsRoutingCheck) {
            return base.Channel.UpdateQmsRoutingCheck(mQmsRoutingCheck);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateQmsRoutingCheckAsync(BFM.ContractModel.QmsRoutingCheck mQmsRoutingCheck) {
            return base.Channel.UpdateQmsRoutingCheckAsync(mQmsRoutingCheck);
        }
        
        public bool DelQmsRoutingChecks(System.Collections.Generic.List<string> Ids) {
            return base.Channel.DelQmsRoutingChecks(Ids);
        }
        
        public System.Threading.Tasks.Task<bool> DelQmsRoutingChecksAsync(System.Collections.Generic.List<string> Ids) {
            return base.Channel.DelQmsRoutingChecksAsync(Ids);
        }
        
        public bool DelQmsRoutingCheck(string Id) {
            return base.Channel.DelQmsRoutingCheck(Id);
        }
        
        public System.Threading.Tasks.Task<bool> DelQmsRoutingCheckAsync(string Id) {
            return base.Channel.DelQmsRoutingCheckAsync(Id);
        }
        
        public System.Collections.Generic.List<BFM.ContractModel.QmsRoutingCheck> GetQmsRoutingChecks(string sWhere) {
            return base.Channel.GetQmsRoutingChecks(sWhere);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BFM.ContractModel.QmsRoutingCheck>> GetQmsRoutingChecksAsync(string sWhere) {
            return base.Channel.GetQmsRoutingChecksAsync(sWhere);
        }
        
        public BFM.ContractModel.QmsRoutingCheck GetQmsRoutingCheckById(string Id) {
            return base.Channel.GetQmsRoutingCheckById(Id);
        }
        
        public System.Threading.Tasks.Task<BFM.ContractModel.QmsRoutingCheck> GetQmsRoutingCheckByIdAsync(string Id) {
            return base.Channel.GetQmsRoutingCheckByIdAsync(Id);
        }
        
        public System.Collections.Generic.List<BFM.ContractModel.QmsCheckMaster> GetQmsCheckMasterByPage(int pageSize, int pageIndex, bool isAsc, string orderField, string sWhere) {
            return base.Channel.GetQmsCheckMasterByPage(pageSize, pageIndex, isAsc, orderField, sWhere);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BFM.ContractModel.QmsCheckMaster>> GetQmsCheckMasterByPageAsync(int pageSize, int pageIndex, bool isAsc, string orderField, string sWhere) {
            return base.Channel.GetQmsCheckMasterByPageAsync(pageSize, pageIndex, isAsc, orderField, sWhere);
        }
        
        public int GetQmsCheckMasterCount(string sWhere) {
            return base.Channel.GetQmsCheckMasterCount(sWhere);
        }
        
        public System.Threading.Tasks.Task<int> GetQmsCheckMasterCountAsync(string sWhere) {
            return base.Channel.GetQmsCheckMasterCountAsync(sWhere);
        }
        
        public bool AddQmsCheckMaster(BFM.ContractModel.QmsCheckMaster mQmsCheckMaster) {
            return base.Channel.AddQmsCheckMaster(mQmsCheckMaster);
        }
        
        public System.Threading.Tasks.Task<bool> AddQmsCheckMasterAsync(BFM.ContractModel.QmsCheckMaster mQmsCheckMaster) {
            return base.Channel.AddQmsCheckMasterAsync(mQmsCheckMaster);
        }
        
        public bool UpdateQmsCheckMaster(BFM.ContractModel.QmsCheckMaster mQmsCheckMaster) {
            return base.Channel.UpdateQmsCheckMaster(mQmsCheckMaster);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateQmsCheckMasterAsync(BFM.ContractModel.QmsCheckMaster mQmsCheckMaster) {
            return base.Channel.UpdateQmsCheckMasterAsync(mQmsCheckMaster);
        }
        
        public bool DelQmsCheckMasters(System.Collections.Generic.List<string> Ids) {
            return base.Channel.DelQmsCheckMasters(Ids);
        }
        
        public System.Threading.Tasks.Task<bool> DelQmsCheckMastersAsync(System.Collections.Generic.List<string> Ids) {
            return base.Channel.DelQmsCheckMastersAsync(Ids);
        }
        
        public bool DelQmsCheckMaster(string Id) {
            return base.Channel.DelQmsCheckMaster(Id);
        }
        
        public System.Threading.Tasks.Task<bool> DelQmsCheckMasterAsync(string Id) {
            return base.Channel.DelQmsCheckMasterAsync(Id);
        }
        
        public System.Collections.Generic.List<BFM.ContractModel.QmsCheckMaster> GetQmsCheckMasters(string sWhere) {
            return base.Channel.GetQmsCheckMasters(sWhere);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BFM.ContractModel.QmsCheckMaster>> GetQmsCheckMastersAsync(string sWhere) {
            return base.Channel.GetQmsCheckMastersAsync(sWhere);
        }
        
        public BFM.ContractModel.QmsCheckMaster GetQmsCheckMasterById(string Id) {
            return base.Channel.GetQmsCheckMasterById(Id);
        }
        
        public System.Threading.Tasks.Task<BFM.ContractModel.QmsCheckMaster> GetQmsCheckMasterByIdAsync(string Id) {
            return base.Channel.GetQmsCheckMasterByIdAsync(Id);
        }
    }
}
