<%@ Page Title="Enter Details" Language="C#" MasterPageFile="~/Site1.Master" EnableEventValidation="false" AutoEventWireup="false" CodeBehind="About.aspx.cs" Inherits="KwalityWalls.About" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
 <div class="jumbotron jumbotron1">
    <form  method="post" style="margin: 5% 0 0">
       
        <table border="0" bordercolor="red">
            <tr>
                <td style="width: 300px;">Client ID</td>
                <td style="width: 300px">
                    <asp:TextBox ID="txtClientId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Client Name&nbsp;</td>
                <td>
                    <asp:TextBox ID="txtClientName" runat="server"></asp:TextBox>

                </td>
            </tr>

          <tr>
              
                <td>Chocolate Sold</td>
                <td>
                    <asp:TextBox ID="txtChoclateSoldCount" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>Vanilla Sold </td>
                
                <td>
                    <asp:TextBox ID="txtVanilaSoldCount" runat="server"></asp:TextBox></td>
            </tr>
        </table>
      
        <br />
        <br />
        <br />
        <div class="pull-left">
            <asp:Button ID="btnSubmit" runat="server" Text="ADD CLIENT" OnClick="btnSubmit_Click"/>
             <asp:Button ID="btnLogout" runat="server" Text="Log Out" OnClick="btnLogout_Click"/>
        </div> <br /><br />
        
  </form>
    
          </div>


</asp:Content>
