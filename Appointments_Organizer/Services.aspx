<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Services.aspx.cs" Inherits="Appointments_Organizer.WebForm3" %>

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
    <title>Services</title>
    <style type="text/css">
        .auto-style1 {
            width: 288px;
        }
    </style>
    <link rel="stylesheet" href="stylesheet.css" />
</head>
<body style="text-align:center;background-color:cornflowerblue;">
    <form id="form1" runat="server">
        <br/><br /><br /><br />
    <div id="box">
        <div style="text-align:right;">

            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Sign out" />

        </div>
        <div>
            <h1>SERVICE SELECTION</h1>
        </div>
        <div>
            <table style="color:lightgrey; background-color:#72758c;border:1px solid black;margin-left:auto;margin-right:auto;">
                <tr><td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" Text="Create new Date" Width="399px" OnClick="Button1_Click1"/>
                    <br /><br /></td></tr>
                <tr><td class="auto-style1">
                    <asp:Button ID="Button2" runat="server" Text="Cancel an existing Date" Width="400px" OnClick="Button2_Click"/>
                    <br /><br /></td></tr>
                <tr><td class="auto-style1">
                    <asp:Button ID="Button3" runat="server" Text="Show all appointments" Width="400px" OnClick="Button3_Click"/>
                    <br /><br /></td></tr>
            </table>
            <br /><br />
            </div>
        </div>
    </form>
</body>
</html>
