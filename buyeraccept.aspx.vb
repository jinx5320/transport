Imports System.Data
Namespace indiandeals



    Partial Class suprequests
        Inherits System.Web.UI.Page
        Dim cmd As New System.Data.OleDb.OleDbCommand
        Dim brow As DataRow
        Public con As New System.Data.OleDb.OleDbConnection(ConfigurationManager.AppSettings("con"))

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            If Not Page.IsPostBack Then
                Dim brow As DataRow
                Dim n As Integer = 0
                Dim i As Integer
                Dim dt As Date
                Dim count As Integer = 0
                connection()
                count = b1dt.Rows.Count
                If count <= 0 Then
                    Response.Redirect("noreq.aspx")
                Else
                    lbldisplay.Text += "<br/><table style='border:solid 0px #000000;background-color:#000000' cellspacing='1' cellpadding='0'><tr bgcolor='#ffffff'>"
                    lbldisplay.Text += "<td width='30'>Bid</td><td width='80'>Name</td><td width='80'>Specialised</td><td width='80'>Email</td><td width='80'>Website</td><td width='80'>Dt Of Est.</td><td width='60'>Turn Over</td><td width='60'>Credit No.</td><td width='60'>Valid Upto</td><td></td>"
                    lbldisplay.Text += "</tr>"
                    While n < count
                        brow = b1dt.Rows(n)
                        lbldisplay.Text += "<tr>"
                        For i = 0 To 11
                            If i <> 1 And i <> 3 And i <> 11 And i <> 9 Then
                                If i = 7 Or i = 10 Then
                                    dt = Convert.ToDateTime(brow.Item(i))
                                    lbldisplay.Text += "<td style=font-size:12pt>" & Format(dt, "dd-MMM-yy") & "</td>"
                                Else
                                    lbldisplay.Text += "<td style=font-size:12pt>" & brow.Item(i) & "</td>"
                                End If
                            End If
                        Next i
                        lbldisplay.Text += "<td><a href=buyrequestsproces.aspx?bid=" & brow.Item(0) & " >Accept</a></td>"
                        lbldisplay.Text += "</tr>"
                        n = n + 1
                    End While
                    lbldisplay.Text += "</table><br/>"
                End If
            End If
        End Sub

        Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
            closeconnection()
        End Sub

       
    End Class
End Namespace