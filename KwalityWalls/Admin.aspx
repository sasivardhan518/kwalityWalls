<%@ Page Title="Strictly For ADMIN Creation" Language="C#" MasterPageFile="~/Site.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="KwalityWalls.Admin" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    
  <form  method="post" style="margin: 5% 0 0">
       
        <table border="0" bordercolor="red">
            <tr>
                <td style="width: 300px;">Admin Name</td>
                <td style="width: 300px">
                    <asp:TextBox ID="txtAdminName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Email ID</td>
                <td>
                    <asp:TextBox ID="txtAdminEmailID" runat="server"></asp:TextBox>

                </td>
            </tr>

          <tr>
              
                <td>Password</td>
                <td>
                    <asp:TextBox ID="txtAdminPass" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>User Type </td>
                
                <td>
                    <asp:TextBox ID="txtAdminType" runat="server"></asp:TextBox></td>
            </tr>
              <tr>
                <td>Full Name </td>
                
                <td>
                    <asp:TextBox ID="txtAdminFullName" runat="server"></asp:TextBox></td>
            </tr>
              <tr>
                <td>Designation</td>
                  <td>
                <asp:DropDownList ID="Designation" runat="server" >
                <asp:ListItem Text="Select your Designation" Value="0"></asp:ListItem>
                <asp:ListItem Text="M" Value="1"></asp:ListItem>
                <asp:ListItem Text="L" Value="2"></asp:ListItem>
            </asp:DropDownList>
                </td>
                
            </tr>
            <tr>
                <td>Verification Code</td>
                
                <td>
                    <asp:TextBox ID="Verify" runat="server"></asp:TextBox></td>
            </tr>
        </table>
      
        <br />
        <br />
        <br />
        <div class="pull-left">
            <asp:Button ID="btnSubmit" runat="server" Text="ADD Admin" OnClick="btnSubmit_ADD" />
             
        </div> 
        
  </form>
</asp:Content>
