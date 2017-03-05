<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="QuizMania.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <center>
    <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="sds_users" AllowPaging="True" AllowSorting="True" ForeColor="Black">
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
        <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
        <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
        <asp:BoundField DataField="score" HeaderText="score" SortExpression="score" />
        <asp:BoundField DataField="achievements" HeaderText="achievements" SortExpression="achievements" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="sds_users" runat="server" ConnectionString="<%$ ConnectionStrings:QuizConnection %>" SelectCommand="SELECT * FROM [Users]" DeleteCommand="DELETE FROM [Users] WHERE [id] = @id" InsertCommand="INSERT INTO [Users] ([name], [password], [email], [score], [achievements]) VALUES (@name, @password, @email, @score, @achievements)" UpdateCommand="UPDATE [Users] SET [name] = @name, [password] = @password, [email] = @email, [score] = @score, [achievements] = @achievements WHERE [id] = @id">
    <DeleteParameters>
        <asp:Parameter Name="id" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="name" Type="String" />
        <asp:Parameter Name="password" Type="String" />
        <asp:Parameter Name="email" Type="String" />
        <asp:Parameter Name="score" Type="Int32" />
        <asp:Parameter Name="achievements" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="name" Type="String" />
        <asp:Parameter Name="password" Type="String" />
        <asp:Parameter Name="email" Type="String" />
        <asp:Parameter Name="score" Type="Int32" />
        <asp:Parameter Name="achievements" Type="String" />
        <asp:Parameter Name="id" Type="Int32" />
    </UpdateParameters>
    </asp:SqlDataSource>
    <br />
    <asp:Label ID="lblAddNew" runat="server" Text="Add a new user:" ForeColor="Black"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblName" runat="server" Text="Name:" ForeColor="Black"></asp:Label>
    <br />
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblPass" runat="server" Text="Password:" ForeColor="Black"></asp:Label>
    <br />
    <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Label ID="lblConfirm" runat="server" Text="Confirm Password:" ForeColor="Black"></asp:Label>
    <br />
    <asp:TextBox ID="txtConfirm" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Label ID="lblEmail" runat="server" Text="Name:" ForeColor="Black"></asp:Label>
    <br />
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <br />
<asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        <br />
        <asp:Label ID="Label1" runat="server" ForeColor="Black" Text="Success!"></asp:Label>
    <br />
</center>
</asp:Content>
