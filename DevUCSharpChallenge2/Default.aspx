<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DevUCSharpChallenge2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            First Value&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="firstValueTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Second Value&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="secondValueTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="additionButton" runat="server" OnClick="additionButton_Click" Text="+" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="subtractionButton" runat="server" OnClick="subtractionButton_Click" style="margin-left: 0px" Text="-" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="multiplicationButton" runat="server" OnClick="multiplicationButton_Click" Text="*" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="divisionButton" runat="server" OnClick="divisionButton_Click" Text="/" />
            <br />
            <br />
        </div>
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
