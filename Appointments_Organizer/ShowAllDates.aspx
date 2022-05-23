<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAllDates.aspx.cs" Inherits="Appointments_Organizer.ShowAllDates" %>

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
    <title>Show all dates</title>
    <link rel="stylesheet" href="stylesheet.css" />
</head>
<body style="text-align:center;background-color:cornflowerblue;">
    <form id="form1" runat="server">
        <div style="text-align:right;">

            <asp:Button ID="Button2" runat="server" Text="Home" OnClick="Button2_Click" />

        </div>
        <div>
            <h1><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h1>
            <br /><br />
        </div>
        <div style="margin-left:auto;margin-right:auto;">

            <asp:Table ID="Table1" runat="server" HorizontalAlign="Center" >
               <asp:TableRow><asp:TableCell><b>Doctor's Name </b>&nbsp&nbsp</asp:TableCell><asp:TableCell><b>Doctor's Specialty</b>&nbsp&nbsp</asp:TableCell>
                   <asp:TableCell><b>Doctor's Location</b>&nbsp&nbsp</asp:TableCell>
                   <asp:TableCell><b>Date</b>&nbsp&nbsp</asp:TableCell><asp:TableCell><b>Time</b>&nbsp&nbsp</asp:TableCell>
               </asp:TableRow>
            </asp:Table>

        </div>
    </form>
</body>
</html>
