<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" 
    Inherits="gameStore.Pages.Checkout"
    MasterPageFile="/Pages/Store.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContent" runat="server">
    <div id="content">

        <div id="checkoutForm" class="checkout" runat="server">
            <h2>Оформить заказ</h2>
            Пожалуйста, введите свои данные!

        <div id="errors" data-valmsg-summary="true">
            <ul>
                <li style="display:none"></li>
            </ul>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </div>
            <div>
                <label for="name">Имя:</label>
                <input id="name" name="name" runat="server" />
            </div>
            <div>
                <label for="email">Email:</label>
                <input id="email" name="email" runat="server" />
            </div>
        
        <p class="actionButtons">
            <button class="actionButtons" type="submit">Обработать заказ</button>
        </p>
        </div>
        <div id="checkoutMessage" runat="server">
            <h2>Спасибо за выбор нашего магазина! Мы ценим ваше внимание!!</h2>
        </div>
    </div>
</asp:Content>