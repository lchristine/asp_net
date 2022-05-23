<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewDoctor.aspx.cs" Inherits="Appointments_Organizer.NewDoctor" %>

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
    <title></title>
    <link rel="stylesheet" href="stylesheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <br/><br /><br />
    <div id="box">
        <div>
            <h1>CREATE NEW DOCTOR</h1>
        </div>
        <div>
            <table style="color:lightgrey; background-color:#72758c;margin-left:auto;margin-right:auto;">
                <tr><td>AMKA<br /><br /></td><td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="250px"></asp:TextBox></td></tr>
                <tr><td>Full name<br /><br /></td><td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="250px"></asp:TextBox></td></tr>
                <tr><td>Specialty<br /><br /></td><td>
                    <asp:TextBox ID="TextBox3" runat="server" Width="250px"></asp:TextBox></td></tr>
                <tr><td>Phone<br /><br /></td><td>
                    <asp:TextBox ID="TextBox4" runat="server" Width="250px"></asp:TextBox></td></tr>
                <tr><td>Location<br /><br /></td><td>
                    <asp:TextBox ID="TextBox5" runat="server" Width="250px"></asp:TextBox></td></tr>
                <tr><td>Submit<br /><br /></td><td>
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" Width="150px" /></td></tr>
            </table>
            <br /><br />
            </div>
        </div>
    </form>
</body>
</html>
