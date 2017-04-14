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
           </p><br />
          
                <div>
                <asp:DropDownList ID="QuestionNumberList" runat="server" ForeColor="Black">
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
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                    <asp:ListItem>21</asp:ListItem>
                    <asp:ListItem>22</asp:ListItem>
                    <asp:ListItem>23</asp:ListItem>
                    <asp:ListItem>24</asp:ListItem>
                    <asp:ListItem>25</asp:ListItem>
                    <asp:ListItem>26</asp:ListItem>
                    <asp:ListItem>27</asp:ListItem>
                    <asp:ListItem>28</asp:ListItem>
                    <asp:ListItem>29</asp:ListItem>
                    <asp:ListItem>30</asp:ListItem>
                </asp:DropDownList>
                    <br />
                    <asp:DropDownList ID="CategoryList" runat="server" ForeColor="Black">
                        <asp:ListItem>Random</asp:ListItem>
                        <asp:ListItem>Sports</asp:ListItem>
                        <asp:ListItem>General Knowledge</asp:ListItem>
                        <asp:ListItem>Music</asp:ListItem>
                        <asp:ListItem>Video Games</asp:ListItem>
                        <asp:ListItem>Film</asp:ListItem>
                        <asp:ListItem>Television</asp:ListItem>
                        <asp:ListItem>History</asp:ListItem>
                    </asp:DropDownList>
                </div>
                            <p>

                <asp:Button ID="SubmitButton" runat="server" Text="Submit" Width="90%" 
                    style="background-color:greenyellow;border-radius:10px;text-shadow:1px 1px 1px green" OnClick="SubmitButton_Click" Height="50px"/>

                <asp:Button ID="Button2" runat="server" Text="Get Random Quiz" Width="90%" 
                    style="background-color:greenyellow;border-radius:10px;text-shadow:1px 1px 1px green" OnClick="Button2_Click" Height="50px"/>
            </p>
            </center>
        </div>


    </div>

</asp:Content>
