<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="Project.SystemAdmin.ProductList" %>

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
                <asp:Button ID="btnCreate" runat="server" Text="新增商品" OnClick="btnCreate_Click" />
                <asp:GridView ID="gvProductList" runat="server" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField HeaderText="編號" DataField="CategoryID" />
                        <asp:BoundField HeaderText="名稱" DataField="Name" />
                        <asp:BoundField HeaderText="描述" DataField="Description" />
                        <asp:BoundField HeaderText="價格" DataField="Price" />
                        <asp:BoundField HeaderText="建日日期" DataField="PublishDate" DataFormatString="{0:yyyy-MM-dd}" />
                        <asp:BoundField HeaderText="庫存" DataField="Quantity" />
                        <asp:TemplateField HeaderText="管理">
                            <ItemTemplate>
                                <a href="/SystemAdmin/ProductDetail.aspx?ID=<%#Eval("ID") %>刪除"></a>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>

                <asp:PlaceHolder ID="plcNoData" runat="server">
                    <p>
                        清單內目前無商品
                    </p>
                </asp:PlaceHolder>

            </td>
        </tr>
    </table>
</asp:Content>

