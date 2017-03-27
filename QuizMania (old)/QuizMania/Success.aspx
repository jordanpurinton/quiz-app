<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Success.aspx.cs" Inherits="QuizMania.Success" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <center>
    <h1 style="align-content:center;color:black">SUCCESS!!!!!</h1>
    
        <img src="https://media.giphy.com/media/TH6HNQcrSGKzu/giphy.gif" />
    
    <br /><br />
    <h1 style="align-content:center; color:black">Would you like to go again?</h1>
     </center>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Yes" Width="40%" style="float:left"/>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="No" Width="40%" style="float:right"/>
    

</asp:Content>
