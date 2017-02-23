<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddFood.aspx.cs" Inherits="FoodTruck.AddFood" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        Add New Item:</p>
   <table class="foodTable">
       <tr>
           <td style="width: 200px">Name:</td>
           <td>
               <asp:TextBox ID="txtName" runat="server" Width="100%"></asp:TextBox>
           </td>
       </tr>
       <tr>
           <td style="width: 200px">Description:</td>
           <td>
               <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Width="100%" Wrap="False"></asp:TextBox>
           </td>
       </tr>
       <tr>
           <td style="width: 200px">Price:</td>
           <td>
               <asp:TextBox ID="txtPrice" runat="server" Width="100%"></asp:TextBox>
           </td>
       </tr>
       <tr>
           <td style="width: 200px; height: 43px;">Image:</td>
           <td style="height: 43px">
               <asp:DropDownList ID="DropDownList1" runat="server" Width="100%">
               </asp:DropDownList>
               <br />
               <asp:FileUpload ID="FileUpload1" runat="server" />
               <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click" />
           </td>
       </tr>
       <tr>
           <td style="width: 200px">Type:</td>
           <td>
               <asp:TextBox ID="txtType" runat="server" Width="100%"></asp:TextBox>
           </td>
       </tr>
    </table>
    <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="btnSave" runat="server" Text="Submit" OnClick="btnSave_Click" />
</asp:Content>
