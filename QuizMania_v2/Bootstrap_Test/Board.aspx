﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Board.aspx.cs" Inherits="Bootstrap_Test.Board" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <script src="Scripts/toast-script.js" type="text/javascript"></script>
     <div ID="boardImage" runat="server" class="jumbotron" style="background-image:url(Images/banner-test.jpg); 
                background-position:center center; background-repeat:no-repeat; background-size:auto ;height:auto">
        <center>
            <div id="textArea" runat="server" style="max-width:75%;overflow-wrap :break-word">
            <p style="background-color:rgba(0,0,0,0.7); border-radius:10px"> 
                <asp:Label ID="questionLabel" runat="server" Font-Size="X-Large" style="text-shadow:5px 5px 5px black">
                    
                </asp:Label>
            </p> 
            </div>
        </center>    
    </div>
                <div>
            </div>

    <div class="row">
        <div class="col-md-12">
            <center>
            <p><br />
                <asp:Button ID="Button1" runat="server" Text="Button 1" Height="50px" Width="90%" 
                    style="background-color:greenyellow;border-radius:10px;text-shadow:1px 1px 1px green" CommandArgument='0' OnCommand="Button1_Click"/>
            </p>
                <p>
                <asp:Button ID="Button2" runat="server" Text="Button 2" Height="50px" Width="90%" 
                    style="background-color:greenyellow;border-radius:10px;text-shadow:1px 1px 1px green" CommandArgument='1' OnCommand="Button1_Click"/>
            </p>
                <p>
                <asp:Button ID="Button3" runat="server" Text="Button 3" Height="50px" Width="90%" 
                    style="background-color:greenyellow;border-radius:10px;text-shadow:1px 1px 1px green" CommandArgument='2' OnCommand="Button1_Click"/>
            </p>
                <p>
                <asp:Button ID="Button4" runat="server" Text="Button 4" Height="50px" Width="90%" 
                    style="background-color:greenyellow;border-radius:10px;text-shadow:1px 1px 1px green" CommandArgument='3' OnCommand="Button1_Click"/>
            </p>
            </center>
        </div>


    </div>
</asp:Content>
