<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Highscores.aspx.cs" Inherits="QuizMania.Highscores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblHighScores" runat="server"></asp:Label>
    <br />
                <asp:Button ID="btnLoadMore" runat="server" Text="Load 100 More" Height="50px" Width="90%" 
                    style="background-color:greenyellow;border-radius:10px;text-shadow:1px 1px 1px green" OnClick="btnLoadMore_Click"/>
            </asp:Content>
