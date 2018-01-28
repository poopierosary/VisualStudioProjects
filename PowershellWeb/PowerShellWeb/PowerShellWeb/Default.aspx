<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr><td><h1>PowerShell Console Web</h1></td></tr>
                <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
                <tr><td>&nbsp;</td><td>PowerShell Console</td></tr>
                <tr>
                   <td>
                       <br />
                   </td>
                   <td>
                       <asp:TextBox ID="Input" runat="server" TextMode="MultiLine" Width="433px" Height="73px"></asp:TextBox>
                   </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        <asp:Button ID="btnExecuteCode" runat="server" Text="Execute" Width="200" OnClick="btnExecuteCode" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
