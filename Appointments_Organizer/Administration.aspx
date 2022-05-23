<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administration.aspx.cs" Inherits="Appointments_Organizer.Administration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        #box {
            border: 2px solid black;
            padding: 10px;
            margin: 50px;
            background-color:#424454;
        }
        body {
            background-image: url('kk.jpg');
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: cover;
            }
    </style>
    <title>Administration page</title>
    <link rel="stylesheet" href="stylesheet.css" />
</head>
<body style="text-align:center;">
    <form id="form1" runat="server">
         <br/><br />
    <div id="box">
        <div style="text-align:right;">
            <asp:Button ID="Button3" runat="server" Text="Home" OnClick="Button3_Click1" />
        </div>
        <div>
            <h1>ADMINISTRATION PAGE</h1>
            <br />
        </div>
        <div>
        <table style="color:lightgrey; background-color:#72758c;margin-left:auto;margin-right:auto;width=100%"><tr><td>
            <asp:Button ID="Button1" runat="server" Text="Create New Doctor" OnClick="Button1_Click" /><br /><br /></td></tr><tr><td>
                <asp:Button ID="Button2" runat="server" Text="Delete Doctor" OnClick="Button2_Click" /><br /><br /></td></tr></table>
        <br/><br />
        </div>
        </div>
    </form>
</body>
</html>
