<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Bootstrap_Test._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div ID="boardImage" runat="server" class="jumbotron" style="background-image:url(Images/banner-test.jpg); 
            background-position:center; background-size:contain">
        <center>
            <div id="textArea" runat="server" style="max-width :50%;overflow-wrap :break-word">
                        <asp:Label ID="Label1" runat="server" Text="Label used for testing" Font-Size="X-Large" style="text-shadow:5px 5px 5px black"></asp:Label>

            </div>
            
        </center>    
    </div>

    <div class="row">
        <div class="col-md-12">
            <center>
            <h2>Welcome to the quiz game.  We hope you enjoy your new favorite addiction</h2>
            <p>
                Click the bright green button below to start showing off how smart you really are... hopefully.
           </p>
          
            <p>
                <asp:Button ID="Button1" runat="server" Text="Click here to start the game!" Width="90%" 
                    style="background-color:greenyellow;border-radius:10px;text-shadow:5px 5px 5px black" OnClick="Button1_Click" Height="50px"/>
            </p>
            </center>
        </div>


    </div>

</asp:Content>
