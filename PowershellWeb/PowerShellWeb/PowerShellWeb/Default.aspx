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
                <tr><td>&nbsp;</td><td><h1 align="center">PowerShell Console Web</h1></td></tr>
                <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
                <tr><td>&nbsp;</td><td>PowerShell Console</td></tr>
                <tr>
                   <td>
                       <br />
                   </td>
                   <td>
                       <asp:TextBox ID="tbInput" runat="server" TextMode="MultiLine" Width="433px" Height="73px"></asp:TextBox>
                   </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        <asp:Button ID="btnExecuteCode" runat="server" Text="Execute" Width="200px" OnClick="btnExecuteCode_Click" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <h3>Result</h3>

                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:TextBox ID="tbResultBox" TextMode="MultiLine" Width="700px" Height="200px" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
