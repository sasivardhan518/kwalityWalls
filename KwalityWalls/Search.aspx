<%@ Page Title="Search Client" Language="C#" MasterPageFile="~/Site.Master" EnableEventValidation="false" AutoEventWireup="false"  Inherits="KwalityWalls.Search" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
   <div class="jumbotron jumbotron3">
    <form  method="post" style="margin: 5% 0 0">
        <table border="0" bordercolor="red">
              <tr>
                <td style="width: 300px;">Enter Client ID to find!</td>
                 <td> <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                </td>
            </tr>
         </table>
        </form><br />
            <asp:Button ID="btnsearchID" runat="server" Text="Search" OnClick="buttonSearch"/>
         <br /><br />
        </div>
     <div class="pull-left">
         <br /> <br />
         <div class="jumbotron jumbotron2">
         <asp:GridView ID="IDSEARCH" runat="server"></asp:GridView>
        </div>
   </div>

</asp:Content>
