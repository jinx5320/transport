Imports System.Data
Namespace indiandeals
    Partial Class buyerinbox
        Inherits System.Web.UI.Page
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            Dim srow As DataRow
            Dim timevalue As String
            Dim n As Integer = 0
            Dim i As Integer
            Dim dt As Date
            Dim count As Integer
            Dim uid As String
            uid = Session("uid")
            uid = uid.ToLower
            connection()
            count = 0
            Dim count2 As Integer = 0
            While count < mdt.Rows.Count
                srow = mdt.Rows(count)
                If Convert.ToString(srow.Item(1)).ToLower = uid.ToLower Then
                    count2 = count2 + 1
                End If
                count = count + 1
            End While
            If count2 <= 0 Then
                Response.Redirect("nomsgb.aspx")
            Else
                lbldisplay.Text += "<table border=1><tr style=bgcolor:brown>"
                lbldisplay.Text += "<td>FROM</td><td>SUBJECT</td><td>SEND DATE</td>"
                lbldisplay.Text += "</tr>"
                n = 0
                While n < mdt.Rows.Count
                    srow = mdt.Rows(n)
                    If Convert.ToString(srow.Item(1)).ToLower = uid.ToLower Then
                        lbldisplay.Text += "<tr>"
                        For i = 0 To 4
                            timevalue = Convert.ToString(srow.Item(4))
                            timevalue = timevalue.Replace(" ", "_")
                            If i <> 3 And i <> 1 Then

                                If i = 2 Then
                                    lbldisplay.Text += "<td><a href=dispmsgb.aspx?fromid=" & srow.Item(0) & "&time2=" & timevalue & "> " & srow.Item(i) & "</a></td>"
                                Else
                                    lbldisplay.Text += "<td style=font-size:12pt>" & srow.Item(i) & "</td>"
                                End If
                            End If
                        Next i
                        lbldisplay.Text += "<td><a href=delmsgb.aspx?fromid=" & srow.Item(0) & "&time2=" & timevalue & ">Delete </a></td>"
                        lbldisplay.Text += "</tr>"
                    End If
                    n = n + 1
                End While
                lbldisplay.Text += "</table>"
            End If
        End Sub

        Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
            closeconnection()
        End Sub
    End Class
End Namespace
