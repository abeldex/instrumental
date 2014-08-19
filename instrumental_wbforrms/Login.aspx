<%@ Page Title="Iniciar sesión" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="instrumental_wbforrms.Account.Login" %>
<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="menu">
  </asp:Content>
    <asp:Content runat="server" ID="Content1" ContentPlaceHolderID="MainContent">   
        <link href="Content/themes/AdminTemplate/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
<link href="Content/themes/AdminTemplate/css/bootstrap-responsive.min.css" rel="stylesheet" type="text/css" />

<link href="Content/themes/AdminTemplate/css/font-awesome.css" rel="stylesheet"/>
    <link href="http://fonts.googleapis.com/css?family=Open+Sans:400italic,600italic,400,600" rel="stylesheet"/>
    
<link href="Content/themes/AdminTemplate/css/style.css" rel="stylesheet" type="text/css"/>
<link href="Content/themes/AdminTemplate/css/pages/signin.css" rel="stylesheet" type="text/css"/> 
        <div class="account-container">
	        <div class="content clearfix">
        <asp:Login runat="server" ViewStateMode="Disabled" RenderOuterTable="false">
            <LayoutTemplate>   
                <fieldset>
                    <legend></legend>
                    <h1>Acceso a Miembros</h1>
                    <div class="login-fields">
				
				            <p>Por favor ingresa tus datos</p>
                        	        <div class="field">
					                    <label for="UserName">Usuario</label>
                                        <asp:TextBox runat="server" ID="UserName" CssClass="login username-field" ToolTip="Usuario" ></asp:TextBox>
					                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName" CssClass="field-validation-error" ErrorMessage="El campo de nombre de usuario es obligatorio." ></asp:RequiredFieldValidator>       
				        </div> <!-- /field -->
                        <div class="field">
					        <label for="Password">Password:</label>
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="login password-field" ToolTip="Contraseña" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Password" CssClass="field-validation-error" ErrorMessage="El campo de contraseña es obligatorio." ></asp:RequiredFieldValidator>
					    </div> <!-- /password -->
                    </div><!-- /login-fields -->
                            <div class="login-actions">
				
				<span class="login-checkbox">
                    <asp:CheckBox runat="server" ID="RememberMe"/>
					<asp:Label runat="server" AssociatedControlID="RememberMe" CssClass="choice">¿Recordar cuenta?</asp:Label>
				</span>
				<asp:Button runat="server" CommandName="Login" Text="Iniciar sesión" CssClass="button btn btn-success btn-large"/> 
			</div> <!-- .actions --> 		        
                </fieldset>   
            </LayoutTemplate>
        </asp:Login>
          <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled" >Registrarse</asp:HyperLink>
            si no tiene una cuenta.
</div>  
            <asp:validationsummary runat="server" ForeColor="#CC3300"></asp:validationsummary>
</div>



</asp:Content>
