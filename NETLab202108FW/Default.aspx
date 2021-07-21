<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NETLab202108FW._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>DBからSQLで検索</h1>
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="検索" OnClick="Button1_Click" /><br />
    <br />
    <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-condensed table-hover"></asp:GridView>

</asp:Content>
