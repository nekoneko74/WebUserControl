<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="WebUserControl.WebUserControl1" %>
<asp:Label ID="Label1" runat="server" Text="ユーザーコントロール上のテキスト："></asp:Label>
<asp:TextBox ID="TextBox1" runat="server" Width="836px"></asp:TextBox>
<br />
<asp:Button ID="Button1" runat="server" Text="ユーザーコントロール上のボタン" OnClick="Button1_Click" />