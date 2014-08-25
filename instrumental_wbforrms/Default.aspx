<%@ Page Title="" Language="C#" MasterPageFile="~/flat.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="instrumental_wbforrms.Defaultt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <form runat="server">
            <asp:LoginStatus ID="LoginStatus1" runat="server" />
            </form>
        </div>
                  <div class="col-lg-3">
                      <!--widget start-->
                      <aside class="profile-nav alt green-border">
                          <section class="panel">
                              <div class="user-heading alt green-bg">
                                  <a href="#">
                                      <img alt="" src="Content/themes/flat/img/pacad.png">
                                  </a>
                                  <h1>Prácticas Académicas</h1>
                                  <p>Módulo</p>
                              </div>
                              <ul class="nav nav-pills nav-stacked">
                                  <li><a href="SolicitudPA.aspx"> <i class="icon-time"></i> Solicitar Equipo <span class="label label-success pull-right r-activity"><i class="icon-expand"></i></span></a></li>       
                              </ul>
                          </section>
                      </aside>
                      <!--widget end-->
                      </div>


         <div class="col-lg-3">
                      <!--widget start-->
                      <aside class="profile-nav alt yellow-border">
                          <section class="panel">
                              <div class="user-heading alt yellow-bg">
                                  <a href="#">
                                      <img alt="" src="Content/themes/flat/img/pp.png">
                                  </a>
                                  <h1>Servicio Social</h1>
                                  <p>Módulo</p>
                              </div>

                              <ul class="nav nav-pills nav-stacked">
                                  <li><a href="SolicitudSS.aspx"> <i class="icon-time"></i> Solicitar Equipo <span class="label label-warning pull-right r-activity"><i class="icon-expand"></i></span></a></li>       
                              </ul>

                          </section>
                      </aside>
                      <!--widget end-->
                      </div>

         <div class="col-lg-3">
                      <!--widget start-->
                      <aside class="profile-nav alt blue-border">
                          <section class="panel">
                              <div class="user-heading alt blue-bg">
                                  <a href="#">
                                      <img alt="" src="Content/themes/flat/img/practpro.png">
                                  </a>
                                  <h1>Prácticas Profesionales</h1>
                                  <p>Módulo</p>
                              </div>

                              <ul class="nav nav-pills nav-stacked">
                                  <li><a href="SolicitudPP.aspx"> <i class="icon-time"></i> Solicitar Equipo <span class="label label-primary pull-right r-activity"><i class="icon-expand"></i></span></a></li>       
                              </ul>

                          </section>
                      </aside>
                      <!--widget end-->
                      </div>


          <div class="col-lg-3">
                      <!--widget start-->
                      <aside class="profile-nav alt gray-border">
                          <section class="panel">
                              <div class="user-heading alt gray-bg">
                                  <a href="#">
                                      <img alt="" src="Content/themes/flat/img/proy.png">
                                  </a>
                                  <h1>Proyectos</h1>
                                  <p>Módulo</p>
                              </div>

                              <ul class="nav nav-pills nav-stacked">
                                  <li><a href="javascript:;"> <i class="icon-time"></i> Solicitar Equipo <span class="label label-gray pull-right r-activity"><i class="icon-expand"></i></span></a></li>       
                              </ul>

                          </section>
                      </aside>
                      <!--widget end-->
                      </div>
        </div>
     <!--external css-->
    <link href="Content/themes/flat/assets/font-awesome/css/font-awesome.css" rel="stylesheet" />
    <!-- Custom styles for this template -->
    <link href="Content/themes/flat/css/style.css" rel="stylesheet">
    <link href="Content/themes/flat/css/style-responsive.css" rel="stylesheet" />
</asp:Content>
