<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" 
     Inherits="gameStore.Pages.Admin.Orders"
     MasterPageFile="~/Pages/Admin/Admin.Master" EnableViewState="false" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="outerContainer">
        <table id="ordersTable">
            <tr>
                <th>Имя заказчика: </th>
                <th>Email заказчика: </th>
                <th>Заказов: </th>
                <th>Сумма: </th>
                <th></th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server" SelectMethod="GetOrders"
                ItemType="gameStore.Models.Repository.Orders">
                <ItemTemplate>
                    <tr>
                        <td><%#: Item.Name %></td>
                        <td><%#: Item.Email %></td>
                        <td><%# Item.OrderLines.Sum(ol => ol.Quantity) %></td>
                        <td><%# Totals(Item.OrderLines).ToString("C") %> </td>
                        <td>
                            <asp:PlaceHolder ID="PlaceHolder1" Visible="<%# !Item.Dispatched %>" runat="server">
                                <button type="submit" name="dispatch"
                                    value="<%# Item.OrderID %>">
                                    Отправить в службу поддержки</button>
                            </asp:PlaceHolder>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>

    <div id="ordersCheck">
        <asp:CheckBox ID="showDispatched" runat="server" Checked="false" AutoPostBack="true" />
        Показать отправленные в службу поддержки заказы?
    </div>
</asp:Content>