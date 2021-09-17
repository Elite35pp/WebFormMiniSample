<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="Project.SystemAdmin.ProductDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
        <tr>
            <td colspan="2">
                <h1>服飾訂購系統後台</h1>
            </td>
        </tr>
        <tr>
            <td>
                <a href="UserInfo.aspx">使用者資訊</a><br />
                <a href="ProductList.aspx">庫存管理</a>
            </td>
            <td>
               商品名稱 <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br /><br />
               商品描述  <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox><br /><br />
               商品分類編號 <asp:TextBox ID="txtCategoryID" runat="server"></asp:TextBox><br /><br />
               商品價格 <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox><br /><br />
               商品狀態 <asp:CheckBox ID="cblStatus" runat="server" /><br /><br />
               商品預設圖片編號 <asp:TextBox ID="txtImageID" runat="server"></asp:TextBox><br /><br />
               商品庫存量 <asp:TextBox ID="txtQuantity" runat="server" TextMode="Number"></asp:TextBox><br /><br />
                <asp:Button ID="btnSave" runat="server" Text="儲存" OnClick="btnSave_Click" /><br /><br />
                <asp:Literal ID="ltlMsg" runat="server"></asp:Literal>
            </td>
        </tr>
    </table>
</asp:Content>
