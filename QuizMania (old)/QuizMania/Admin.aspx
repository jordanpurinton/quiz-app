<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="QuizMania.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <center>
    <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="UserId" DataSourceID="sds_users" AllowPaging="True" AllowSorting="True" ForeColor="#333333" CellPadding="4" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="UserId" HeaderText="UserId" ReadOnly="True" SortExpression="UserId" />
        <asp:BoundField DataField="ScoreId" HeaderText="ScoreId" SortExpression="ScoreId" />
        <asp:BoundField DataField="AchievementId" HeaderText="AchievementId" SortExpression="AchievementId" />
        <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
        <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
        <asp:BoundField DataField="Level" HeaderText="Level" SortExpression="Level" />
    </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
</asp:GridView>
<asp:SqlDataSource ID="sds_users" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * FROM [User]" DeleteCommand="DELETE FROM [User] WHERE [UserId] = @UserId" InsertCommand="INSERT INTO [User] ([UserId], [ScoreId], [AchievementId], [Username], [Password], [Email], [Level]) VALUES (@UserId, @ScoreId, @AchievementId, @Username, @Password, @Email, @Level)" UpdateCommand="UPDATE [User] SET [ScoreId] = @ScoreId, [AchievementId] = @AchievementId, [Username] = @Username, [Password] = @Password, [Email] = @Email, [Level] = @Level WHERE [UserId] = @UserId">
    <DeleteParameters>
        <asp:Parameter Name="UserId" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="UserId" Type="Int32" />
        <asp:Parameter Name="ScoreId" Type="Int32" />
        <asp:Parameter Name="AchievementId" Type="Int32" />
        <asp:Parameter Name="Username" Type="String" />
        <asp:Parameter Name="Password" Type="String" />
        <asp:Parameter Name="Email" Type="String" />
        <asp:Parameter Name="Level" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ScoreId" Type="Int32" />
        <asp:Parameter Name="AchievementId" Type="Int32" />
        <asp:Parameter Name="Username" Type="String" />
        <asp:Parameter Name="Password" Type="String" />
        <asp:Parameter Name="Email" Type="String" />
        <asp:Parameter Name="Level" Type="Int32" />
        <asp:Parameter Name="UserId" Type="Int32" />
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
