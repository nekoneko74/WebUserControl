<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebUserControl.WebForm1" %>
<!-- ユーザーコントロール「WebUserControl1」の利用を宣言する -->
<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc" TagName="UserControl" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Webユーザーコントロール</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- ユーザーコントロールをフォームに貼り付ける -->
            <uc:UserControl ID="UserControl1" runat="server"></uc:UserControl>
        </div>
        <asp:Label ID="Label1" runat="server" Text="フォーム上のテキスト："></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="821px"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="フォーム上のボタン" OnClick="Button1_Click" />
    </form>
</body>
</html>