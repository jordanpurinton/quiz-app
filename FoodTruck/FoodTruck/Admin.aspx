<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="FoodTruck.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h2>Current Menu:</h2>
<p>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/AddFood.aspx">Add New Item</asp:LinkButton>
</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" CellSpacing="5" DataKeyNames="id" DataSourceID="sds_admin" ForeColor="Black" GridLines="Vertical" Width="100%">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
                <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                <asp:BoundField DataField="image" HeaderText="image" SortExpression="image" />
                <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
        <asp:SqlDataSource ID="sds_admin" runat="server" ConnectionString="<%$ ConnectionStrings:TruckConnection %>" DeleteCommand="DELETE FROM [Product] WHERE [id] = @id" InsertCommand="INSERT INTO [Product] ([name], [description], [price], [image], [type]) VALUES (@name, @description, @price, @image, @type)" SelectCommand="SELECT * FROM [Product] ORDER BY [id]" UpdateCommand="UPDATE [Product] SET [name] = @name, [description] = @description, [price] = @price, [image] = @image, [type] = @type WHERE [id] = @id">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="description" Type="String" />
                <asp:Parameter Name="price" Type="Int32" />
                <asp:Parameter Name="image" Type="String" />
                <asp:Parameter Name="type" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="description" Type="String" />
                <asp:Parameter Name="price" Type="Int32" />
                <asp:Parameter Name="image" Type="String" />
                <asp:Parameter Name="type" Type="String" />
                <asp:Parameter Name="id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
</p>
</asp:Content>
