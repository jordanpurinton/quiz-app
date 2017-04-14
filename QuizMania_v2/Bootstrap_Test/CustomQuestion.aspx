<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomQuestion.aspx.cs" Inherits="Bootstrap_Test.CustomQuestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Category</h4>
    
    <asp:TextBox ID="TextBox1" runat="server"  Width="80%" TextMode="MultiLine"></asp:TextBox>
    <br />
    <h4>Type</h4>
   
    <asp:TextBox ID="TextBox2" runat="server"  Width ="80%" TextMode="MultiLine"></asp:TextBox>
    <br />
    <h4>Difficulty</h4>
    
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="sds_diff" DataTextField="Difficulty" DataValueField="Difficulty" >
    </asp:DropDownList>

    <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataSourceID="sds_diff" DataTextField="Difficulty" DataValueField="Difficulty"></asp:RadioButtonList>
    <asp:SqlDataSource ID="sds_diff" runat="server" ConnectionString="<%$ ConnectionStrings:JordanString %>" SelectCommand="SELECT DISTINCT [Difficulty] FROM [Question]"></asp:SqlDataSource>
    <br />
    <h4>Question</h4>
    
    <asp:TextBox ID="TextBox4" runat="server"  Width ="80%" TextMode="MultiLine"></asp:TextBox>
    <br />
    <h4>Correct Answer</h4>
    
    <asp:TextBox ID="TextBox3" runat="server"  Width ="80%" TextMode="MultiLine" ></asp:TextBox>
    <br />
    <h4>Wrong Answer #1</h4>
    
    <asp:TextBox ID="TextBox5" runat="server"  Width ="80%" TextMode="MultiLine"></asp:TextBox>
    <br />
    <h4>Wrong Answer #2</h4>
    
    <asp:TextBox ID="TextBox6" runat="server"  Width ="80%" TextMode="MultiLine"></asp:TextBox>
    <br />
    <h4>Wrong Answer #3</h4>
    
    <asp:TextBox ID="TextBox7" runat="server"  Width ="80%" TextMode="MultiLine"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="SubmitButton" runat="server" Text="Submit" Width="80%" 
                    style="background-color:greenyellow;border-radius:10px;text-shadow:1px 1px 1px green" OnClick="SubmitButton_Click" Height="50px"/>

</asp:Content>
