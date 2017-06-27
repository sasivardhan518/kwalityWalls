<%@ Page Title="ALL CLIENTS" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="KwalityWalls.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>

    <div class="jumbotron jumbotron2">


        <asp:GridView ID="gvice" runat="server" AutoGenerateColumns="False">
            <Columns>

                <asp:BoundField DataField="ClientID" HeaderText="ClintID" />
                <asp:BoundField DataField="ClientName" HeaderText="Name" />
                <asp:BoundField DataField="Chocolate" HeaderText="Chocolate" />
                <asp:BoundField DataField="Vanilla" HeaderText="Vanilla" />

                <asp:HyperLinkField DataNavigateUrlFields="ClientID,ClientName,Chocolate,Vanilla" HeaderText="Action Required" DataNavigateUrlFormatString="ItemEdit.aspx?keyid={0}&keyName={1}&keyChoco={2}&keyVani={3}" Text="update" />
                <asp:HyperLinkField DataNavigateUrlFields="ClientID,ClientName,Chocolate,Vanilla" HeaderText="Action Required" DataNavigateUrlFormatString="ItemDelete.aspx?keyid={0}&keyName={1}&keyChoco={2}&keyVani={3}" Text="Delete" />



            </Columns>

        </asp:GridView>
        <asp:GridView ID="gviceView" runat="server" AutoGenerateColumns="False">
            <Columns>

                <asp:BoundField DataField="ClientID" HeaderText="ClintID" />
                <asp:BoundField DataField="ClientName" HeaderText="Name" />
                <asp:BoundField DataField="Chocolate" HeaderText="Chocolate" />
                <asp:BoundField DataField="Vanilla" HeaderText="Vanilla" />

            </Columns>

        </asp:GridView>
    </div>
</asp:Content>
