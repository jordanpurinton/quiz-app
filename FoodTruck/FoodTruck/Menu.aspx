<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="FoodTruck.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
    Select a type</p>
<p>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="sds_type" DataTextField="type" DataValueField="type" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:SqlDataSource ID="sds_type" runat="server" ConnectionString="<%$ ConnectionStrings:TruckConnection %>" SelectCommand="SELECT [type] FROM [Product] ORDER BY [type]"></asp:SqlDataSource>
</p>
<p>
    <asp:Label ID="Label1" runat="server">Type</asp:Label>
</p>
</asp:Content>
