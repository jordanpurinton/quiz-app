<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="FoodTruck.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <asp:Label ID="lblOutput" runat="server" Visible="False"></asp:Label>
<br />
<asp:Button ID="btnConfirm" runat="server" Text="Confirm" Visible="False" OnClick="btnConfirm_Click" />
<asp:Button ID="btnCancel" runat="server" Text="Cancel" Visible="False" OnClick="btnCancel_Click" />
<br />
<asp:Button ID="btnOrder" runat="server" Text="Order" OnClick="btnOrder_Click" />
<br />
<asp:Panel ID="pnl_Out" runat="server">
</asp:Panel>
<br />

</asp:Content>
