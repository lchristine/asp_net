<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Specialties.aspx.cs" Inherits="Appointments_Organizer.Specialties" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        #box {
            border: 2px solid black;
            padding: 10px;
            margin: 50px;
            background-color:#424454    ;
        }
        body {
            background-image: url('kk.jpg');
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: cover;
            }
    </style>
    <title>Specialty Selection</title>
    <link rel="stylesheet" href="stylesheet.css" />
</head>
<body style="text-align:center;background-color:cornflowerblue;">
    <form id="form1" runat="server">
        <div style="text-align:right;">

            <asp:Button ID="Button2" runat="server" Text="Home" OnClick="Button2_Click" />

        </div>
        <div>
            <h1>PLEASE SELECT SPECIALTY OF DOCTOR </h1>
            <br /><br /><br />
        </div>
        <div><br />
            <label for="ListBox1">Specialty</label> 
            <asp:ListBox ID="ListBox1" runat="server" Height="90px" Width="200px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
            &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
            <br /><br /></div>
    <div>
        <br /><br /><br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Proceed to select location" />
        <br />
    </div>
    </form>
</body>
</html>
