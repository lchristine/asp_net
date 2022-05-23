<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteDate.aspx.cs" Inherits="Appointments_Organizer.WebForm4" %>

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
    <title>Delete Date</title>
    <link rel="stylesheet" href="stylesheet.css" />
</head>
<body style="background-color:cornflowerblue;text-align:center;">
    <form id="form1" runat="server">
        <br/><br /><br /><br />
    <div id="box">
        <div style="text-align:right;">

            <asp:Button ID="Button2" runat="server" Text="Home" OnClick="Button2_Click" />

        </div>
        <div>
            <h1>DELETE EXISTING DATE</h1>
            <br /><br />
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br /><br />
        </div>
        <div>

            <asp:ListBox ID="ListBox1" runat="server" Height="200px" Width="400px"></asp:ListBox>
            <br /><br /><br />

        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Delete" Height="30px" OnClick="Button1_Click" Width="80px" />
        </div>
        </div>
    </form>
</body>
</html>
