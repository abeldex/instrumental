<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OpenAuthProviders.ascx.cs" Inherits="instrumental_wbforrms.Account.OpenAuthProviders" %>
<style type="text/css">
.blueButton{
    background:#4f6aa3 url(../images/btt-bg.png) no-repeat 0px -48px;
    border:1px solid #29447e;
    border-bottom-color:#1a356e;
    box-shadow:0 1px 0 rgba(0, 0, 0, .1);
    cursor:pointer;
    display:-moz-inline-box;
    display:inline-block;
    font-size: 18px;
    font-weight:bold;
    line-height:normal !important;
    padding:2px 6px;
    text-align:center;
    text-decoration:none;
    vertical-align:top;
    white-space:nowrap;
    color:#fff; 
}
.blueButton:active{
    background:#4f6aa3;
    border-bottom-color:#999;
}
.blueButton .blueButtonText,.blueButton input{
    background:none;
    border:0;
    color:#fff;
    cursor:pointer;
    display:-moz-inline-box;
    display:inline-block;
    font-family:'Lucida Grande', Tahoma, Verdana, Arial, sans-serif;
    font-size: 13px;
    font-weight:bold;
    margin:0;
    outline:none;
    padding:1px 0 2px;
    white-space:nowrap
}</style>

<fieldset class="open-auth-providers">
    <legend>Iniciar sesión con otro servicio</legend>
    
    <asp:ListView runat="server" ID="providerDetails" ItemType="Microsoft.AspNet.Membership.OpenAuth.ProviderDetails"
        SelectMethod="GetProviderNames" ViewStateMode="Disabled">
        <ItemTemplate>
                <button class="blueButton" type="submit" name="provider" value="<%#: Item.ProviderName %>"
                title="Iniciar sesión con su <%#: Item.ProviderDisplayName %> cuenta.">
                <span class="blueButtonText">Iniciar con <%#: Item.ProviderDisplayName %></span> 
                </button>
        </ItemTemplate>
    
        <EmptyDataTemplate>
            <div class="message-info">
                <p>No hay ningún servicio de autenticación externa configurado. Consulte <a href="http://go.microsoft.com/fwlink/?LinkId=252803">este artículo</a> para obtener más detalles sobre la configuración de esta aplicación ASP.NET para que admita el inicio de sesión a través de servicios externos.</p>
            </div>
        </EmptyDataTemplate>
    </asp:ListView>
</fieldset>