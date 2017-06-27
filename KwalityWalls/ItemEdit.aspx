<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="ItemEdit.aspx.cs" Inherits="KwalityWalls.ItemEdit" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
<!DOCTYPE html>
    <html>
<body>

 <form  method="post" style="margin: 5% 0 0">
        <table border="0" bordercolor="red">
            <tr>
                <td style="width: 300px;">Client ID</td>
                <td style="width: 300px">
                    <asp:TextBox ID="txtClientID" runat="server"></asp:TextBox>
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
         <asp:Button ID="btnSubmit" runat="server" Text="Save" OnClick="btnSubmit_Click" />
     </form>
    </body>
</html>

     </asp:Content>

