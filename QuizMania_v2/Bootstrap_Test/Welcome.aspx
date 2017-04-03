<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="Bootstrap_Test.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" >

    <div ID="WelcomeImage" runat="server" style="background-image:url(Images/banner-test.jpg); height:100%; width:auto; 
            background-position:center center; background-repeat:no-repeat ">
        <center>
            <div id="textArea" runat="server" style="max-width :50%;overflow-wrap :break-word">
                        <asp:Label ID="Label1" runat="server" Text="Label used for testing" Font-Size="X-Large" style="text-shadow:5px 5px 5px black"></asp:Label>
            </div>            
        </center>    
    </div><br />
    <div id="ButtonBox" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Login Here!" Width="90%" 
                        style="background-color:greenyellow;border-radius:10px;text-shadow:2px 2px 2px green" OnClick="Button1_Click" Height="50px"/>

        <asp:Button ID="Button2" runat="server" Text="Register Here!" Width="90%" 
                        style="background-color:greenyellow;border-radius:10px;text-shadow:2px 2px 2px green" OnClick="Button2_Click" Height="50px"/>
    </div>
</asp:Content>
