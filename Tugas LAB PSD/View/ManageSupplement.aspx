<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavBar.Master" AutoEventWireup="true" CodeBehind="ManageSupplement.aspx.cs" Inherits="Tugas_LAB_PSD.View.ManageSupplement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Manage Supplement</h1>

    <asp:GridView ID="SupplementGV" runat="server" AutoGenerateColumns="False" OnRowDeleting="SupplementGV_RowDeleting" OnRowEditing="SupplementGV_RowEditing">
        <Columns>
            <asp:BoundField DataField="SupplementName" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="SupplementExpiryDate" HeaderText="Expiry Date" SortExpression="Expiry Date" />
            <asp:BoundField DataField="SupplementPrice" HeaderText="Price" SortExpression="Price" />
            <asp:BoundField DataField="SupplementTypeID" HeaderText="TypeID" SortExpression="TypeID" />
            <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
        </Columns>
    </asp:GridView>
    <h3>Insert New Supplement</h3>
    <asp:Button ID="InsertSupplement" runat="server" Text="Insert Supplement" OnClick="InsertSupplement_Click"/>
</asp:Content>
