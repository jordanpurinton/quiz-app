<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Board.aspx.cs" Inherits="Bootstrap_Test.Board" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div ID="boardImage" runat="server" class="jumbotron" style="background-image:url(Images/banner-test.jpg); 
                background-position:center center; background-repeat:no-repeat; background-size:auto ;height:auto">
        <center>
            <div id="textArea" runat="server" style="max-width:75%;overflow-wrap :break-word">
        <asp:Label ID="Label1" runat="server" Text="Label used for testing" Font-Size="X-Large" style="text-shadow:5px 5px 5px black"></asp:Label>
            </div>
        </center>    
    </div>

    <div class="row">
        <div class="col-md-12">
            <center>
            <asp:Label runat="server" ID="questionString"></asp:Label>  
            <p>
                <asp:Button ID="Button1" runat="server" Text="Button 1" Height="50px" Width="90%" 
                    style="background-color:greenyellow;border-radius:10px;text-shadow:5px 5px 5px black" OnClick="Button1_Click"/>
            </p>
                <p>
                <asp:Button ID="Button2" runat="server" Text="Button 2" Height="50px" Width="90%" 
                    style="background-color:greenyellow;border-radius:10px;text-shadow:5px 5px 5px black" OnClick="Button1_Click"/>
            </p>
                <p>
                <asp:Button ID="Button3" runat="server" Text="Button 3" Height="50px" Width="90%" 
                    style="background-color:greenyellow;border-radius:10px;text-shadow:5px 5px 5px black" OnClick="Button1_Click"/>
            </p>
                <p>
                <asp:Button ID="Button4" runat="server" Text="Button 4" Height="50px" Width="90%" 
                    style="background-color:greenyellow;border-radius:10px;text-shadow:5px 5px 5px black" OnClick="Button1_Click"/>
            </p>
            </center>
        </div>


    </div>
</asp:Content>
