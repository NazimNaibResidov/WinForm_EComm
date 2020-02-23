<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ecomm.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   

    <div class="row">
        <div class="col-md-8">
          <div class="form-group">
             <input type="text" name="Name" class="form-control" />
          </div>
             <div class="form-group">
             <input type="text" name="UserName" class="form-control" />
          </div>
             <div class="form-group">
             <input type="email" name="Email" class="form-control" />
          </div>
             <div class="form-group">
             <input type="password" name="Password" class="form-control" />
          </div>
            <input type="submit" class="btn btn-success" value="Save" />
    </div>  
    </div>

</asp:Content>
