﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NorthwindClient.ProductServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductServiceRef.IProducts")]
    public interface IProducts {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/GetProductName", ReplyAction="http://tempuri.org/IProducts/GetProductNameResponse")]
        string GetProductName(int productID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/GetProductQty", ReplyAction="http://tempuri.org/IProducts/GetProductQtyResponse")]
        int GetProductQty(int productID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProducts/GetCategoryName", ReplyAction="http://tempuri.org/IProducts/GetCategoryNameResponse")]
        string GetCategoryName(int productID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductsChannel : NorthwindClient.ProductServiceRef.IProducts, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductsClient : System.ServiceModel.ClientBase<NorthwindClient.ProductServiceRef.IProducts>, NorthwindClient.ProductServiceRef.IProducts {
        
        public ProductsClient() {
        }
        
        public ProductsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetProductName(int productID) {
            return base.Channel.GetProductName(productID);
        }
        
        public int GetProductQty(int productID) {
            return base.Channel.GetProductQty(productID);
        }
        
        public string GetCategoryName(int productID) {
            return base.Channel.GetCategoryName(productID);
        }
    }
}
