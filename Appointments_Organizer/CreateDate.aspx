<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateDate.aspx.cs" Inherits="Appointments_Organizer.CreateDate" %>

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
    <title>Create a Date</title>
    <link rel="stylesheet" href="stylesheet.css" />
</head>
<body style="text-align:center;background-color:cornflowerblue;">
    <form id="form1" runat="server">
        <br/><br /><br /><br />
    <div id="box">
        <div style="text-align:right;">

            <asp:Button ID="Button2" runat="server" Text="Home" OnClick="Button2_Click" />

        </div>
        <div><h1>SELECT THE DOCTOR OF YOUR CHOICE
             </h1>
        </div>
        <div >
            <asp:ListBox ID="ListBox1" runat="server" Height="200px" Width="600px"></asp:ListBox></div>
        <div>
            <br /><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Proceed to create date" Height="30px" OnClick="Button1_Click" Width="155px" />
        </div>
        </div>
    </form>
</body>
</html>
