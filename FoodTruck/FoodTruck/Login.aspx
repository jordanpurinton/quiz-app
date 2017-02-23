<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FoodTruck.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table>
        <tr>
            <td>

                Login:</td>
            <td>

                <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>

                Password:</td>
            <td>

                <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>

                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <br />
                <asp:Label ID="lblOutput" runat="server" Text=" "></asp:Label>
                <br />
                <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Registration.aspx">Register</asp:LinkButton>
                <br />


            </td>
        </tr>
    </table>
</asp:Content>
