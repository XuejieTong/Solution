﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TonglBin.Web.CommonServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://192.168.1.109:8000/", ConfigurationName="CommonServiceReference.ICommonService")]
    public interface ICommonService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://192.168.1.109:8000/ICommonService/GetUsers", ReplyAction="http://192.168.1.109:8000/ICommonService/GetUsersResponse")]
        TonglBin.Model.Users[] GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://192.168.1.109:8000/ICommonService/GetUsers", ReplyAction="http://192.168.1.109:8000/ICommonService/GetUsersResponse")]
        System.Threading.Tasks.Task<TonglBin.Model.Users[]> GetUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://192.168.1.109:8000/ICommonService/InserTest", ReplyAction="http://192.168.1.109:8000/ICommonService/InserTestResponse")]
        int InserTest(TonglBin.Model.Users user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://192.168.1.109:8000/ICommonService/InserTest", ReplyAction="http://192.168.1.109:8000/ICommonService/InserTestResponse")]
        System.Threading.Tasks.Task<int> InserTestAsync(TonglBin.Model.Users user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICommonServiceChannel : TonglBin.Web.CommonServiceReference.ICommonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CommonServiceClient : System.ServiceModel.ClientBase<TonglBin.Web.CommonServiceReference.ICommonService>, TonglBin.Web.CommonServiceReference.ICommonService {
        
        public CommonServiceClient() {
        }
        
        public CommonServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CommonServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommonServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TonglBin.Model.Users[] GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public System.Threading.Tasks.Task<TonglBin.Model.Users[]> GetUsersAsync() {
            return base.Channel.GetUsersAsync();
        }
        
        public int InserTest(TonglBin.Model.Users user) {
            return base.Channel.InserTest(user);
        }
        
        public System.Threading.Tasks.Task<int> InserTestAsync(TonglBin.Model.Users user) {
            return base.Channel.InserTestAsync(user);
        }
    }
}
