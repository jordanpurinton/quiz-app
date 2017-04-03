<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Bootstrap_Test._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div ID="boardImage" runat="server" class="jumbotron" style="background-image:url(Images/banner-test.jpg); 
            background-position:center center; background-size:auto; background-repeat:no-repeat ">
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
          
                <div>
                <asp:DropDownList ID="QuestionNumberList" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                </asp:DropDownList>
                    <br />
                    <asp:DropDownList ID="CategoryList" runat="server">
                        <asp:ListItem>Entertainment: Video Games</asp:ListItem>
                        <asp:ListItem>Entertainment: Film</asp:ListItem>
                        <asp:ListItem>Entertainment: TV</asp:ListItem>
                        <asp:ListItem>History</asp:ListItem>
                        <asp:ListItem>Sports</asp:ListItem>
                        <asp:ListItem>General Knowledge</asp:ListItem>
                        <asp:ListItem>Entertainment: Music</asp:ListItem>
                    </asp:DropDownList>
                </div>
                            <p>

                <asp:Button ID="Button1" runat="server" Text="Submit" Width="90%" 
                    style="background-color:greenyellow;border-radius:10px;text-shadow:5px 5px 5px black" OnClick="Button1_Click" Height="50px"/>

                <asp:Button ID="Button2" runat="server" Text="Get Random Quiz" Width="90%" 
                    style="background-color:greenyellow;border-radius:10px;text-shadow:5px 5px 5px black" OnClick="Button2_Click" Height="50px"/>
            </p>
            </center>
        </div>


    </div>

</asp:Content>
