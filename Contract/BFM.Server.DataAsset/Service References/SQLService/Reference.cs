﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BFM.Server.DataAsset.SQLService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://fanuc.com.cn/", ConfigurationName="SQLService.ISQLService")]
    public interface ISQLService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetServerTime", ReplyAction="http://fanuc.com.cn/ISQLService/GetServerTimeResponse")]
        System.DateTime GetServerTime();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetServerTime", ReplyAction="http://fanuc.com.cn/ISQLService/GetServerTimeResponse")]
        System.Threading.Tasks.Task<System.DateTime> GetServerTimeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetDataBaseTime", ReplyAction="http://fanuc.com.cn/ISQLService/GetDataBaseTimeResponse")]
        System.DateTime GetDataBaseTime();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetDataBaseTime", ReplyAction="http://fanuc.com.cn/ISQLService/GetDataBaseTimeResponse")]
        System.Threading.Tasks.Task<System.DateTime> GetDataBaseTimeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/RowCountWithEF", ReplyAction="http://fanuc.com.cn/ISQLService/RowCountWithEFResponse")]
        int RowCountWithEF(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/RowCountWithEF", ReplyAction="http://fanuc.com.cn/ISQLService/RowCountWithEFResponse")]
        System.Threading.Tasks.Task<int> RowCountWithEFAsync(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetScalarWithEF", ReplyAction="http://fanuc.com.cn/ISQLService/GetScalarWithEFResponse")]
        string GetScalarWithEF(string type, string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetScalarWithEF", ReplyAction="http://fanuc.com.cn/ISQLService/GetScalarWithEFResponse")]
        System.Threading.Tasks.Task<string> GetScalarWithEFAsync(string type, string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetFirstRowWithEF", ReplyAction="http://fanuc.com.cn/ISQLService/GetFirstRowWithEFResponse")]
        System.Collections.Generic.List<string> GetFirstRowWithEF(string type, string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetFirstRowWithEF", ReplyAction="http://fanuc.com.cn/ISQLService/GetFirstRowWithEFResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetFirstRowWithEFAsync(string type, string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetJsonDataWithEF", ReplyAction="http://fanuc.com.cn/ISQLService/GetJsonDataWithEFResponse")]
        string GetJsonDataWithEF(string type, string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetJsonDataWithEF", ReplyAction="http://fanuc.com.cn/ISQLService/GetJsonDataWithEFResponse")]
        System.Threading.Tasks.Task<string> GetJsonDataWithEFAsync(string type, string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetDataTableWithEF", ReplyAction="http://fanuc.com.cn/ISQLService/GetDataTableWithEFResponse")]
        System.Data.DataTable GetDataTableWithEF(string type, string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetDataTableWithEF", ReplyAction="http://fanuc.com.cn/ISQLService/GetDataTableWithEFResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetDataTableWithEFAsync(string type, string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/ExecuteSqlWithEF", ReplyAction="http://fanuc.com.cn/ISQLService/ExecuteSqlWithEFResponse")]
        bool ExecuteSqlWithEF(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/ExecuteSqlWithEF", ReplyAction="http://fanuc.com.cn/ISQLService/ExecuteSqlWithEFResponse")]
        System.Threading.Tasks.Task<bool> ExecuteSqlWithEFAsync(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/ExecuteSqlsWithEF", ReplyAction="http://fanuc.com.cn/ISQLService/ExecuteSqlsWithEFResponse")]
        bool ExecuteSqlsWithEF(System.Collections.Generic.List<string> strSqls);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/ExecuteSqlsWithEF", ReplyAction="http://fanuc.com.cn/ISQLService/ExecuteSqlsWithEFResponse")]
        System.Threading.Tasks.Task<bool> ExecuteSqlsWithEFAsync(System.Collections.Generic.List<string> strSqls);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetScalar", ReplyAction="http://fanuc.com.cn/ISQLService/GetScalarResponse")]
        string GetScalar(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetScalar", ReplyAction="http://fanuc.com.cn/ISQLService/GetScalarResponse")]
        System.Threading.Tasks.Task<string> GetScalarAsync(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetFirstRow", ReplyAction="http://fanuc.com.cn/ISQLService/GetFirstRowResponse")]
        System.Collections.Generic.List<string> GetFirstRow(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetFirstRow", ReplyAction="http://fanuc.com.cn/ISQLService/GetFirstRowResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetFirstRowAsync(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetJsonData", ReplyAction="http://fanuc.com.cn/ISQLService/GetJsonDataResponse")]
        string GetJsonData(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetJsonData", ReplyAction="http://fanuc.com.cn/ISQLService/GetJsonDataResponse")]
        System.Threading.Tasks.Task<string> GetJsonDataAsync(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetDataSet", ReplyAction="http://fanuc.com.cn/ISQLService/GetDataSetResponse")]
        System.Data.DataSet GetDataSet(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetDataSet", ReplyAction="http://fanuc.com.cn/ISQLService/GetDataSetResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetDataSetAsync(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetDataTable", ReplyAction="http://fanuc.com.cn/ISQLService/GetDataTableResponse")]
        System.Data.DataTable GetDataTable(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/GetDataTable", ReplyAction="http://fanuc.com.cn/ISQLService/GetDataTableResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetDataTableAsync(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/ExecuteSqlByParam", ReplyAction="http://fanuc.com.cn/ISQLService/ExecuteSqlByParamResponse")]
        bool ExecuteSqlByParam(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/ExecuteSqlByParam", ReplyAction="http://fanuc.com.cn/ISQLService/ExecuteSqlByParamResponse")]
        System.Threading.Tasks.Task<bool> ExecuteSqlByParamAsync(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/ExecuteSql", ReplyAction="http://fanuc.com.cn/ISQLService/ExecuteSqlResponse")]
        bool ExecuteSql(string strSql);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/ExecuteSql", ReplyAction="http://fanuc.com.cn/ISQLService/ExecuteSqlResponse")]
        System.Threading.Tasks.Task<bool> ExecuteSqlAsync(string strSql);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/ExecuteSqls", ReplyAction="http://fanuc.com.cn/ISQLService/ExecuteSqlsResponse")]
        bool ExecuteSqls(System.Collections.Generic.List<string> strSqLs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fanuc.com.cn/ISQLService/ExecuteSqls", ReplyAction="http://fanuc.com.cn/ISQLService/ExecuteSqlsResponse")]
        System.Threading.Tasks.Task<bool> ExecuteSqlsAsync(System.Collections.Generic.List<string> strSqLs);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISQLServiceChannel : BFM.Server.DataAsset.SQLService.ISQLService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SQLServiceClient : System.ServiceModel.ClientBase<BFM.Server.DataAsset.SQLService.ISQLService>, BFM.Server.DataAsset.SQLService.ISQLService {
        
        public SQLServiceClient() {
        }
        
        public SQLServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SQLServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SQLServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SQLServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.DateTime GetServerTime() {
            return base.Channel.GetServerTime();
        }
        
        public System.Threading.Tasks.Task<System.DateTime> GetServerTimeAsync() {
            return base.Channel.GetServerTimeAsync();
        }
        
        public System.DateTime GetDataBaseTime() {
            return base.Channel.GetDataBaseTime();
        }
        
        public System.Threading.Tasks.Task<System.DateTime> GetDataBaseTimeAsync() {
            return base.Channel.GetDataBaseTimeAsync();
        }
        
        public int RowCountWithEF(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.RowCountWithEF(strSql, parameterNames, parameterValues);
        }
        
        public System.Threading.Tasks.Task<int> RowCountWithEFAsync(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.RowCountWithEFAsync(strSql, parameterNames, parameterValues);
        }
        
        public string GetScalarWithEF(string type, string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.GetScalarWithEF(type, strSql, parameterNames, parameterValues);
        }
        
        public System.Threading.Tasks.Task<string> GetScalarWithEFAsync(string type, string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.GetScalarWithEFAsync(type, strSql, parameterNames, parameterValues);
        }
        
        public System.Collections.Generic.List<string> GetFirstRowWithEF(string type, string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.GetFirstRowWithEF(type, strSql, parameterNames, parameterValues);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetFirstRowWithEFAsync(string type, string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.GetFirstRowWithEFAsync(type, strSql, parameterNames, parameterValues);
        }
        
        public string GetJsonDataWithEF(string type, string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.GetJsonDataWithEF(type, strSql, parameterNames, parameterValues);
        }
        
        public System.Threading.Tasks.Task<string> GetJsonDataWithEFAsync(string type, string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.GetJsonDataWithEFAsync(type, strSql, parameterNames, parameterValues);
        }
        
        public System.Data.DataTable GetDataTableWithEF(string type, string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.GetDataTableWithEF(type, strSql, parameterNames, parameterValues);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetDataTableWithEFAsync(string type, string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.GetDataTableWithEFAsync(type, strSql, parameterNames, parameterValues);
        }
        
        public bool ExecuteSqlWithEF(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.ExecuteSqlWithEF(strSql, parameterNames, parameterValues);
        }
        
        public System.Threading.Tasks.Task<bool> ExecuteSqlWithEFAsync(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.ExecuteSqlWithEFAsync(strSql, parameterNames, parameterValues);
        }
        
        public bool ExecuteSqlsWithEF(System.Collections.Generic.List<string> strSqls) {
            return base.Channel.ExecuteSqlsWithEF(strSqls);
        }
        
        public System.Threading.Tasks.Task<bool> ExecuteSqlsWithEFAsync(System.Collections.Generic.List<string> strSqls) {
            return base.Channel.ExecuteSqlsWithEFAsync(strSqls);
        }
        
        public string GetScalar(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.GetScalar(strSql, parameterNames, parameterValues);
        }
        
        public System.Threading.Tasks.Task<string> GetScalarAsync(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.GetScalarAsync(strSql, parameterNames, parameterValues);
        }
        
        public System.Collections.Generic.List<string> GetFirstRow(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.GetFirstRow(strSql, parameterNames, parameterValues);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> GetFirstRowAsync(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.GetFirstRowAsync(strSql, parameterNames, parameterValues);
        }
        
        public string GetJsonData(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.GetJsonData(strSql, parameterNames, parameterValues);
        }
        
        public System.Threading.Tasks.Task<string> GetJsonDataAsync(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.GetJsonDataAsync(strSql, parameterNames, parameterValues);
        }
        
        public System.Data.DataSet GetDataSet(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.GetDataSet(strSql, parameterNames, parameterValues);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetDataSetAsync(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.GetDataSetAsync(strSql, parameterNames, parameterValues);
        }
        
        public System.Data.DataTable GetDataTable(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.GetDataTable(strSql, parameterNames, parameterValues);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetDataTableAsync(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.GetDataTableAsync(strSql, parameterNames, parameterValues);
        }
        
        public bool ExecuteSqlByParam(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.ExecuteSqlByParam(strSql, parameterNames, parameterValues);
        }
        
        public System.Threading.Tasks.Task<bool> ExecuteSqlByParamAsync(string strSql, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<string> parameterValues) {
            return base.Channel.ExecuteSqlByParamAsync(strSql, parameterNames, parameterValues);
        }
        
        public bool ExecuteSql(string strSql) {
            return base.Channel.ExecuteSql(strSql);
        }
        
        public System.Threading.Tasks.Task<bool> ExecuteSqlAsync(string strSql) {
            return base.Channel.ExecuteSqlAsync(strSql);
        }
        
        public bool ExecuteSqls(System.Collections.Generic.List<string> strSqLs) {
            return base.Channel.ExecuteSqls(strSqLs);
        }
        
        public System.Threading.Tasks.Task<bool> ExecuteSqlsAsync(System.Collections.Generic.List<string> strSqLs) {
            return base.Channel.ExecuteSqlsAsync(strSqLs);
        }
    }
}
