<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DateTime.aspx.cs" Inherits="Appointments_Organizer.DateTime" %>

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
    <title>Select date and time</title>
    <link rel="stylesheet" href="stylesheet.css" />
</head>
<body style="text-align:center;background-color:cornflowerblue;">
    <form id="form1" runat="server">
      
        <div style="text-align:right;">

            <asp:Button ID="Button2" runat="server" Text="Home" OnClick="Button2_Click" />

        </div>
        <div><h1>SELECT DATE AND TIME</h1>
        </div>
        <div>
            <br /><br /><br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br /><br /><br /><br /><br /><br /></div>
        <div style="width:100%; margin: 0 auto;">
            <label for="Calendar1">Date</label>
            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" Width="100%"></asp:Calendar>
        </div>
        <div>
            <br /><br />
            <label for="DropDownList1">Time</label>
            <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="130px"></asp:DropDownList>
        </div>
        <br /><br /><br /><br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Create Date" Width="153px" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
