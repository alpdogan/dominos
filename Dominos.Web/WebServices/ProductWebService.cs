﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.6.81.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IProductWebService", Namespace="http://tempuri.org/")]
public partial class ProductWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback GetProductsOperationCompleted;
    
    private System.Threading.SendOrPostCallback GetProductByIdOperationCompleted;
    
    private System.Threading.SendOrPostCallback GetShoppingCartItemsOperationCompleted;
    
    private System.Threading.SendOrPostCallback AddShoppingCartOperationCompleted;
    
    private System.Threading.SendOrPostCallback SetShoppingCartQuantityOperationCompleted;
    
    private System.Threading.SendOrPostCallback SetShoppingCartQuantityByIdOperationCompleted;
    
    private System.Threading.SendOrPostCallback GetProductImageByIdOperationCompleted;
    
    private System.Threading.SendOrPostCallback GetProductImageWithoutBinaryOperationCompleted;
    
    private System.Threading.SendOrPostCallback LoginOperationCompleted;
    
    /// <remarks/>
    public ProductWebService() {
        this.Url = "http://localhost:53565/ProductWebService.svc";
    }
    
    /// <remarks/>
    public event GetProductsCompletedEventHandler GetProductsCompleted;
    
    /// <remarks/>
    public event GetProductByIdCompletedEventHandler GetProductByIdCompleted;
    
    /// <remarks/>
    public event GetShoppingCartItemsCompletedEventHandler GetShoppingCartItemsCompleted;
    
    /// <remarks/>
    public event AddShoppingCartCompletedEventHandler AddShoppingCartCompleted;
    
    /// <remarks/>
    public event SetShoppingCartQuantityCompletedEventHandler SetShoppingCartQuantityCompleted;
    
    /// <remarks/>
    public event SetShoppingCartQuantityByIdCompletedEventHandler SetShoppingCartQuantityByIdCompleted;
    
    /// <remarks/>
    public event GetProductImageByIdCompletedEventHandler GetProductImageByIdCompleted;
    
    /// <remarks/>
    public event GetProductImageWithoutBinaryCompletedEventHandler GetProductImageWithoutBinaryCompleted;
    
    /// <remarks/>
    public event LoginCompletedEventHandler LoginCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IProductWebService/GetProducts", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public ProductDTO[] GetProducts() {
        object[] results = this.Invoke("GetProducts", new object[0]);
        return ((ProductDTO[])(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginGetProducts(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("GetProducts", new object[0], callback, asyncState);
    }
    
    /// <remarks/>
    public ProductDTO[] EndGetProducts(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((ProductDTO[])(results[0]));
    }
    
    /// <remarks/>
    public void GetProductsAsync() {
        this.GetProductsAsync(null);
    }
    
    /// <remarks/>
    public void GetProductsAsync(object userState) {
        if ((this.GetProductsOperationCompleted == null)) {
            this.GetProductsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductsOperationCompleted);
        }
        this.InvokeAsync("GetProducts", new object[0], this.GetProductsOperationCompleted, userState);
    }
    
    private void OnGetProductsOperationCompleted(object arg) {
        if ((this.GetProductsCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.GetProductsCompleted(this, new GetProductsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IProductWebService/GetProductById", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public ProductDTO GetProductById(int id) {
        object[] results = this.Invoke("GetProductById", new object[] {
                    id});
        return ((ProductDTO)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginGetProductById(int id, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("GetProductById", new object[] {
                    id}, callback, asyncState);
    }
    
    /// <remarks/>
    public ProductDTO EndGetProductById(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((ProductDTO)(results[0]));
    }
    
    /// <remarks/>
    public void GetProductByIdAsync(int id) {
        this.GetProductByIdAsync(id, null);
    }
    
    /// <remarks/>
    public void GetProductByIdAsync(int id, object userState) {
        if ((this.GetProductByIdOperationCompleted == null)) {
            this.GetProductByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductByIdOperationCompleted);
        }
        this.InvokeAsync("GetProductById", new object[] {
                    id}, this.GetProductByIdOperationCompleted, userState);
    }
    
    private void OnGetProductByIdOperationCompleted(object arg) {
        if ((this.GetProductByIdCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.GetProductByIdCompleted(this, new GetProductByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IProductWebService/GetShoppingCartItems", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public ShoppingCartDTO[] GetShoppingCartItems(int userId) {
        object[] results = this.Invoke("GetShoppingCartItems", new object[] {
                    userId});
        return ((ShoppingCartDTO[])(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginGetShoppingCartItems(int userId, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("GetShoppingCartItems", new object[] {
                    userId}, callback, asyncState);
    }
    
    /// <remarks/>
    public ShoppingCartDTO[] EndGetShoppingCartItems(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((ShoppingCartDTO[])(results[0]));
    }
    
    /// <remarks/>
    public void GetShoppingCartItemsAsync(int userId) {
        this.GetShoppingCartItemsAsync(userId, null);
    }
    
    /// <remarks/>
    public void GetShoppingCartItemsAsync(int userId, object userState) {
        if ((this.GetShoppingCartItemsOperationCompleted == null)) {
            this.GetShoppingCartItemsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetShoppingCartItemsOperationCompleted);
        }
        this.InvokeAsync("GetShoppingCartItems", new object[] {
                    userId}, this.GetShoppingCartItemsOperationCompleted, userState);
    }
    
    private void OnGetShoppingCartItemsOperationCompleted(object arg) {
        if ((this.GetShoppingCartItemsCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.GetShoppingCartItemsCompleted(this, new GetShoppingCartItemsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IProductWebService/AddShoppingCart", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public bool AddShoppingCart(int productId, int userId, int quantity) {
        object[] results = this.Invoke("AddShoppingCart", new object[] {
                    productId,
                    userId,
                    quantity});
        return ((bool)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginAddShoppingCart(int productId, int userId, int quantity, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("AddShoppingCart", new object[] {
                    productId,
                    userId,
                    quantity}, callback, asyncState);
    }
    
    /// <remarks/>
    public bool EndAddShoppingCart(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    /// <remarks/>
    public void AddShoppingCartAsync(int productId, int userId, int quantity) {
        this.AddShoppingCartAsync(productId, userId, quantity, null);
    }
    
    /// <remarks/>
    public void AddShoppingCartAsync(int productId, int userId, int quantity, object userState) {
        if ((this.AddShoppingCartOperationCompleted == null)) {
            this.AddShoppingCartOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddShoppingCartOperationCompleted);
        }
        this.InvokeAsync("AddShoppingCart", new object[] {
                    productId,
                    userId,
                    quantity}, this.AddShoppingCartOperationCompleted, userState);
    }
    
    private void OnAddShoppingCartOperationCompleted(object arg) {
        if ((this.AddShoppingCartCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.AddShoppingCartCompleted(this, new AddShoppingCartCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IProductWebService/SetShoppingCartQuantity", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public bool SetShoppingCartQuantity(int productId, int userId, int quantity) {
        object[] results = this.Invoke("SetShoppingCartQuantity", new object[] {
                    productId,
                    userId,
                    quantity});
        return ((bool)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginSetShoppingCartQuantity(int productId, int userId, int quantity, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("SetShoppingCartQuantity", new object[] {
                    productId,
                    userId,
                    quantity}, callback, asyncState);
    }
    
    /// <remarks/>
    public bool EndSetShoppingCartQuantity(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    /// <remarks/>
    public void SetShoppingCartQuantityAsync(int productId, int userId, int quantity) {
        this.SetShoppingCartQuantityAsync(productId, userId, quantity, null);
    }
    
    /// <remarks/>
    public void SetShoppingCartQuantityAsync(int productId, int userId, int quantity, object userState) {
        if ((this.SetShoppingCartQuantityOperationCompleted == null)) {
            this.SetShoppingCartQuantityOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetShoppingCartQuantityOperationCompleted);
        }
        this.InvokeAsync("SetShoppingCartQuantity", new object[] {
                    productId,
                    userId,
                    quantity}, this.SetShoppingCartQuantityOperationCompleted, userState);
    }
    
    private void OnSetShoppingCartQuantityOperationCompleted(object arg) {
        if ((this.SetShoppingCartQuantityCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.SetShoppingCartQuantityCompleted(this, new SetShoppingCartQuantityCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IProductWebService/SetShoppingCartQuantityById", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public bool SetShoppingCartQuantityById(int shoppingCartItemId, int quantity) {
        object[] results = this.Invoke("SetShoppingCartQuantityById", new object[] {
                    shoppingCartItemId,
                    quantity});
        return ((bool)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginSetShoppingCartQuantityById(int shoppingCartItemId, int quantity, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("SetShoppingCartQuantityById", new object[] {
                    shoppingCartItemId,
                    quantity}, callback, asyncState);
    }
    
    /// <remarks/>
    public bool EndSetShoppingCartQuantityById(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    /// <remarks/>
    public void SetShoppingCartQuantityByIdAsync(int shoppingCartItemId, int quantity) {
        this.SetShoppingCartQuantityByIdAsync(shoppingCartItemId, quantity, null);
    }
    
    /// <remarks/>
    public void SetShoppingCartQuantityByIdAsync(int shoppingCartItemId, int quantity, object userState) {
        if ((this.SetShoppingCartQuantityByIdOperationCompleted == null)) {
            this.SetShoppingCartQuantityByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetShoppingCartQuantityByIdOperationCompleted);
        }
        this.InvokeAsync("SetShoppingCartQuantityById", new object[] {
                    shoppingCartItemId,
                    quantity}, this.SetShoppingCartQuantityByIdOperationCompleted, userState);
    }
    
    private void OnSetShoppingCartQuantityByIdOperationCompleted(object arg) {
        if ((this.SetShoppingCartQuantityByIdCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.SetShoppingCartQuantityByIdCompleted(this, new SetShoppingCartQuantityByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IProductWebService/GetProductImageById", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public MediaDTO GetProductImageById(int imageId) {
        object[] results = this.Invoke("GetProductImageById", new object[] {
                    imageId});
        return ((MediaDTO)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginGetProductImageById(int imageId, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("GetProductImageById", new object[] {
                    imageId}, callback, asyncState);
    }
    
    /// <remarks/>
    public MediaDTO EndGetProductImageById(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((MediaDTO)(results[0]));
    }
    
    /// <remarks/>
    public void GetProductImageByIdAsync(int imageId) {
        this.GetProductImageByIdAsync(imageId, null);
    }
    
    /// <remarks/>
    public void GetProductImageByIdAsync(int imageId, object userState) {
        if ((this.GetProductImageByIdOperationCompleted == null)) {
            this.GetProductImageByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductImageByIdOperationCompleted);
        }
        this.InvokeAsync("GetProductImageById", new object[] {
                    imageId}, this.GetProductImageByIdOperationCompleted, userState);
    }
    
    private void OnGetProductImageByIdOperationCompleted(object arg) {
        if ((this.GetProductImageByIdCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.GetProductImageByIdCompleted(this, new GetProductImageByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IProductWebService/GetProductImageWithoutBinary", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public MediaDTO GetProductImageWithoutBinary(int imageId) {
        object[] results = this.Invoke("GetProductImageWithoutBinary", new object[] {
                    imageId});
        return ((MediaDTO)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginGetProductImageWithoutBinary(int imageId, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("GetProductImageWithoutBinary", new object[] {
                    imageId}, callback, asyncState);
    }
    
    /// <remarks/>
    public MediaDTO EndGetProductImageWithoutBinary(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((MediaDTO)(results[0]));
    }
    
    /// <remarks/>
    public void GetProductImageWithoutBinaryAsync(int imageId) {
        this.GetProductImageWithoutBinaryAsync(imageId, null);
    }
    
    /// <remarks/>
    public void GetProductImageWithoutBinaryAsync(int imageId, object userState) {
        if ((this.GetProductImageWithoutBinaryOperationCompleted == null)) {
            this.GetProductImageWithoutBinaryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductImageWithoutBinaryOperationCompleted);
        }
        this.InvokeAsync("GetProductImageWithoutBinary", new object[] {
                    imageId}, this.GetProductImageWithoutBinaryOperationCompleted, userState);
    }
    
    private void OnGetProductImageWithoutBinaryOperationCompleted(object arg) {
        if ((this.GetProductImageWithoutBinaryCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.GetProductImageWithoutBinaryCompleted(this, new GetProductImageWithoutBinaryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IProductWebService/Login", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public UserDTO Login(string email, string password) {
        object[] results = this.Invoke("Login", new object[] {
                    email,
                    password});
        return ((UserDTO)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginLogin(string email, string password, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("Login", new object[] {
                    email,
                    password}, callback, asyncState);
    }
    
    /// <remarks/>
    public UserDTO EndLogin(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((UserDTO)(results[0]));
    }
    
    /// <remarks/>
    public void LoginAsync(string email, string password) {
        this.LoginAsync(email, password, null);
    }
    
    /// <remarks/>
    public void LoginAsync(string email, string password, object userState) {
        if ((this.LoginOperationCompleted == null)) {
            this.LoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginOperationCompleted);
        }
        this.InvokeAsync("Login", new object[] {
                    email,
                    password}, this.LoginOperationCompleted, userState);
    }
    
    private void OnLoginOperationCompleted(object arg) {
        if ((this.LoginCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.LoginCompleted(this, new LoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
public partial class ProductDTO {
    
    private int idField;
    
    private string titleField;
    
    private decimal priceField;
    
    private System.Nullable<int> imageIdField;
    
    private string imageUrlField;
    
    /// <remarks/>
    public int Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public string Title {
        get {
            return this.titleField;
        }
        set {
            this.titleField = value;
        }
    }
    
    /// <remarks/>
    public decimal Price {
        get {
            return this.priceField;
        }
        set {
            this.priceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public System.Nullable<int> ImageId {
        get {
            return this.imageIdField;
        }
        set {
            this.imageIdField = value;
        }
    }
    
    /// <remarks/>
    public string ImageUrl {
        get {
            return this.imageUrlField;
        }
        set {
            this.imageUrlField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
public partial class UserDTO {
    
    private int userIdField;
    
    private string emailField;
    
    private bool successField;
    
    /// <remarks/>
    public int UserId {
        get {
            return this.userIdField;
        }
        set {
            this.userIdField = value;
        }
    }
    
    /// <remarks/>
    public string Email {
        get {
            return this.emailField;
        }
        set {
            this.emailField = value;
        }
    }
    
    /// <remarks/>
    public bool Success {
        get {
            return this.successField;
        }
        set {
            this.successField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
public partial class MediaDTO {
    
    private int idField;
    
    private byte[] fileBinaryField;
    
    private string fileNameField;
    
    private string fileExtensionField;
    
    private int fileSizeField;
    
    private string fileContentTypeField;
    
    /// <remarks/>
    public int Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] FileBinary {
        get {
            return this.fileBinaryField;
        }
        set {
            this.fileBinaryField = value;
        }
    }
    
    /// <remarks/>
    public string FileName {
        get {
            return this.fileNameField;
        }
        set {
            this.fileNameField = value;
        }
    }
    
    /// <remarks/>
    public string FileExtension {
        get {
            return this.fileExtensionField;
        }
        set {
            this.fileExtensionField = value;
        }
    }
    
    /// <remarks/>
    public int FileSize {
        get {
            return this.fileSizeField;
        }
        set {
            this.fileSizeField = value;
        }
    }
    
    /// <remarks/>
    public string FileContentType {
        get {
            return this.fileContentTypeField;
        }
        set {
            this.fileContentTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
public partial class ShoppingCartDTO {
    
    private int idField;
    
    private int userIdField;
    
    private int productIdField;
    
    private int quantityField;
    
    private string productTitleField;
    
    private System.Nullable<int> productImageIdField;
    
    private decimal productPriceField;
    
    /// <remarks/>
    public int Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public int UserId {
        get {
            return this.userIdField;
        }
        set {
            this.userIdField = value;
        }
    }
    
    /// <remarks/>
    public int ProductId {
        get {
            return this.productIdField;
        }
        set {
            this.productIdField = value;
        }
    }
    
    /// <remarks/>
    public int Quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
    
    /// <remarks/>
    public string ProductTitle {
        get {
            return this.productTitleField;
        }
        set {
            this.productTitleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public System.Nullable<int> ProductImageId {
        get {
            return this.productImageIdField;
        }
        set {
            this.productImageIdField = value;
        }
    }
    
    /// <remarks/>
    public decimal ProductPrice {
        get {
            return this.productPriceField;
        }
        set {
            this.productPriceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
public delegate void GetProductsCompletedEventHandler(object sender, GetProductsCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GetProductsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal GetProductsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public ProductDTO[] Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((ProductDTO[])(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
public delegate void GetProductByIdCompletedEventHandler(object sender, GetProductByIdCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GetProductByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal GetProductByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public ProductDTO Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((ProductDTO)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
public delegate void GetShoppingCartItemsCompletedEventHandler(object sender, GetShoppingCartItemsCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GetShoppingCartItemsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal GetShoppingCartItemsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public ShoppingCartDTO[] Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((ShoppingCartDTO[])(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
public delegate void AddShoppingCartCompletedEventHandler(object sender, AddShoppingCartCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AddShoppingCartCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal AddShoppingCartCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
public delegate void SetShoppingCartQuantityCompletedEventHandler(object sender, SetShoppingCartQuantityCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class SetShoppingCartQuantityCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal SetShoppingCartQuantityCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
public delegate void SetShoppingCartQuantityByIdCompletedEventHandler(object sender, SetShoppingCartQuantityByIdCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class SetShoppingCartQuantityByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal SetShoppingCartQuantityByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
public delegate void GetProductImageByIdCompletedEventHandler(object sender, GetProductImageByIdCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GetProductImageByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal GetProductImageByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public MediaDTO Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((MediaDTO)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
public delegate void GetProductImageWithoutBinaryCompletedEventHandler(object sender, GetProductImageWithoutBinaryCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GetProductImageWithoutBinaryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal GetProductImageWithoutBinaryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public MediaDTO Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((MediaDTO)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
public delegate void LoginCompletedEventHandler(object sender, LoginCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.81.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class LoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal LoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public UserDTO Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((UserDTO)(this.results[0]));
        }
    }
}
