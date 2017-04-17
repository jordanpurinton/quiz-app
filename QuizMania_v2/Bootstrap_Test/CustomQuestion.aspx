<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomQuestion.aspx.cs" Inherits="Bootstrap_Test.CustomQuestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Category</h4>
    
    <asp:DropDownList ID="dListCat" runat="server" DataSourceID="sds_cat" DataTextField="Category" DataValueField="Category">
    </asp:DropDownList>
    <asp:SqlDataSource ID="sds_cat" runat="server" ConnectionString="<%$ ConnectionStrings:JordanString %>" SelectCommand="SELECT DISTINCT [Category] FROM [Question]"></asp:SqlDataSource>
    <br />
    <h4>Type</h4>
   
    <asp:DropDownList ID="dListType" runat="server" DataSourceID="sds_type" DataTextField="Type" DataValueField="Type">
    </asp:DropDownList>
    <asp:SqlDataSource ID="sds_type" runat="server" ConnectionString="<%$ ConnectionStrings:JordanString %>" SelectCommand="SELECT DISTINCT [Type] FROM [Question]"></asp:SqlDataSource>
    <br />
    <h4>Difficulty</h4>
    
    <asp:DropDownList ID="dListDiff" runat="server" DataSourceID="sds_diff" DataTextField="Difficulty" DataValueField="Difficulty" >
    </asp:DropDownList>

    
    <asp:SqlDataSource ID="sds_diff" runat="server" ConnectionString="<%$ ConnectionStrings:JordanString %>" SelectCommand="SELECT DISTINCT [Difficulty] FROM [Question]"></asp:SqlDataSource>
    <br />
    <h4>Question</h4>
    
    <asp:TextBox ID="txtQuestion" runat="server"  Width ="80%" TextMode="MultiLine"></asp:TextBox>
    <br />
    <h4>Correct Answer</h4>
    
    <asp:TextBox ID="txtCAnswer" runat="server"  Width ="80%" TextMode="MultiLine" ></asp:TextBox>
    <br />
    <h4>Wrong Answer #1</h4>
    
    <asp:TextBox ID="txtW1" runat="server"  Width ="80%" TextMode="MultiLine"></asp:TextBox>
    <br />
    <h4>Wrong Answer #2</h4>
    
    <asp:TextBox ID="txtW2" runat="server"  Width ="80%" TextMode="MultiLine"></asp:TextBox>
    <br />
    <h4>Wrong Answer #3</h4>
    
    <asp:TextBox ID="txtW3" runat="server"  Width ="80%" TextMode="MultiLine"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="SubmitButton" runat="server" Text="Submit" Width="80%" 
                    style="background-color:greenyellow;border-radius:10px;text-shadow:1px 1px 1px green" OnClick="SubmitButton_Click" Height="50px"/>

</asp:Content>
