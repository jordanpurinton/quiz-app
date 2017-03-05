<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Play.aspx.cs" Inherits="QuizMania.Play" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <br />
<center>
<asp:Label ID="Label1" runat="server" Text="How much wood would a wood chuck chuck if a wood chuck could chuck wood?" Font-Size="XX-Large" ForeColor="Black" ></asp:Label>
   </center>
<br />
<asp:Button ID="Button1" runat="server" Text="All of it" Width="40%" Height="150px"  Style="float:left" CssClass="wrap"/>
<asp:Button ID="Button2" runat="server" Text="Some of it" Width="40%" Height="150px" Style="float:right" CssClass="wrap"/>
<br />
<asp:Button ID="Button3" runat="server" Text="The square root of -1" Width="40%" Height="150px"  Style="float:left" CssClass="wrap"/>
<asp:Button ID="Button4" runat="server" Text="He'd chuck all the wood that a wood chuck could chuck if a wood chuck could chuck wood." Width="40%" Height="150px" Style="float:right" CssClass="wrap" OnClick="Button4_Click"/>

</asp:Content>
