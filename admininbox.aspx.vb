Imports System.Data
Namespace indiandeals


    Partial Class admininbox
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
                Response.Redirect("nomsgs.aspx")
            Else
                lbldisplay.Text += "<table width='330' height='100%' cellspacing='1' cellpadding='0' style='border:solid 0px #000000;background-color:#000000;' align='center'><tr bgcolor='#ffffff'>"
                lbldisplay.Text += "<td width='50'>FROM</td><td width='80'>SUBJECT</td><td width='150'>SEND DATE</td><td width='50'></td>"
                lbldisplay.text += "</tr>"
                n = 0
                While n < mdt.Rows.Count
                    srow = mdt.Rows(n)
                    If Convert.ToString(srow.Item(1)).ToLower = uid.ToLower Then
                        lbldisplay.Text += "<tr bgcolor='#ffffff'>"
                        For i = 0 To 4
                            timevalue = Convert.ToString(srow.Item(4))
                            timevalue = timevalue.Replace(" ", "_")
                            If i <> 3 And i <> 1 Then

                                If i = 2 Then
                                    lbldisplay.text += "<td><a href=dispmsg.aspx?fromid=" & srow.Item(0) & "&time2=" & timevalue & "> " & srow.Item(i) & "</a></td>"
                                Else
                                    lbldisplay.text += "<td style=font-size:12pt>" & srow.Item(i) & "</td>"
                                End If
                            End If
                        Next i
                        lbldisplay.Text += "<td><a href=delmsg.aspx?fromid=" & srow.Item(0) & "&time2=" & timevalue & ">Delete </a></td>"
                        lbldisplay.text += "</tr>"
                    End If
                    n = n + 1
                End While
                lbldisplay.text += "</table>"
            End If
        End Sub

        Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
            closeconnection()
        End Sub
    End Class
End Namespace