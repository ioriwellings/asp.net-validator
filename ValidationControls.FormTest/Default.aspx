<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ValidationControls.FormTest.Default" %>
<%@ Register TagPrefix="vc" Namespace="ValidationControls.Controls" Assembly="ValidationControls" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.8.2.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery.validate.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <vc:JsRegisterer ID="JsRegisterer1" runat="server">
            <Content>
            <table>
                <tr>
                    <td>letter: </td>
                    <td><vc:ValidationLetter ID="ValidationLetter1" Key="LetterField" Required="True" runat="server"/></td>
                </tr>
                <tr>
                    <td>digit: </td>
                    <td><vc:ValidationDigit ID="ValidationDigit1" MaxLength="7" Key="DigitField" runat="server"/></td>
                </tr>
                <tr>
                    <td>float: </td>
                    <td><vc:ValidationFloat ID="ValidationFloat1" MaxLength="7" Key="FloatField" runat="server"/></td>
                </tr>
                <tr>
                    <td>alphanumeric: </td>
                    <td><vc:ValidationAlphanumeric ID="ValidationAlphanumeric1" MinLength="6" Key="AlphanumericField" runat="server"/></td>
                </tr>
                <tr>
                    <td>notag: </td>
                    <td><vc:ValidationNoTag ID="ValidationNoTag1" Key="NoTagField" runat="server"/></td>
                </tr>
                <tr>
                    <td>phone: </td>
                    <td><vc:ValidationPhone ID="ValidationPhone1" Key="PhoneField" runat="server"/></td>
                </tr>
                <tr>
                    <td>email: </td>
                    <td><vc:ValidationEmail ID="ValidationEmail1" Key="EmailField" runat="server"/></td>
                </tr>
                <tr>
                    <td>date: </td>
                    <td><vc:ValidationDate ID="ValidationDate1" Key="DateField" runat="server"/></td>
                </tr>
                <tr>
                    <td>url: </td>
                    <td><vc:ValidationUrl ID="ValidationUrl1" Key="UrlField" runat="server"/></td>
                </tr>
                <tr>
                    <td>url friendly: </td>
                    <td><vc:ValidationUrlFriendly ID="ValidationUrlFriendly1" Key="UrlFriendlyField" runat="server"/></td>
                </tr>
                <tr>
                    <td>custom: </td>
                    <td><vc:ValidationCustom ID="ValidationCustom1" Key="CustomField" runat="server"/></td>
                </tr>
                <tr>
                    <td>free: </td>
                    <td><vc:ValidationFree ID="ValidationFree1" Key="FreeField" runat="server"/></td>
                </tr>
            </table>
            </Content>
        </vc:JsRegisterer>
        <asp:Button ID="submit" Text="Validate!" runat="server" onclick="submit_Click"/>
        <br>
        <br>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </form>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#form1').validate();
        });
    </script>
</body>
</html>
