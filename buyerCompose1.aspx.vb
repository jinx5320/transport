Imports System.Data
Namespace indiandeals



    Partial Class buyerCompose1
        Inherits System.Web.UI.Page
        Public con As New System.Data.OleDb.OleDbConnection(ConfigurationManager.AppSettings("con"))
        Public adapt As New System.Data.OleDb.OleDbDataAdapter
        Public reader As System.Data.OleDb.OleDbDataReader

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Dim id As String
            id = Request.Params.Get("catg")
            con.Open()
            adapt = New System.Data.OleDb.OleDbDataAdapter("select pid,pname,price,category,sid,cname,tax,dom,batchno from product where category='" & id & "'  order by pid", con)
            Dim dt As DataTable
            Dim ds As New DataSet
            Dim dr As DataRow
            ds.Clear()
            adapt.Fill(ds)
            dt = ds.Tables(0)
            Dim n As Integer = 0
            Dim count2 As Integer = dt.Rows.Count
            If count2 <= 0 Then
                Response.Redirect("noorder1b.aspx")
            Else
                lbldisplay.Text += "<table border=1><tr style=bgcolor:brown>"
                lbldisplay.Text += "<td>PID</td><td>PNAME</td><td>PRICE</td><td>CATEGORY</td><td>SNAME</td><td>TAX</td><td>DOM</td>"
                lbldisplay.Text += "</tr>"
                n = 0
                Dim i As Integer
                While n < dt.Rows.Count
                    dr = dt.Rows(n)
                    lbldisplay.Text += "<tr>"
                    For i = 0 To 8
                        If i <> 4 And i <> 8 Then
                            'If i = 7 Then
                            'Response.Write("<td>" & Format(dr.Item(i), "yy-MMM-dd") & "(</td>")
                            ' Else
                            lbldisplay.Text += "<td style=font-size:12pt>" & dr.Item(i) & "</td>"
                            'End If
                        End If
                    Next i
                    lbldisplay.Text += "<td><a href=buyerCompose2.aspx?id=" & dr.Item(0) & "&sid=" & dr.Item(4) & ">Select </a></td>"
                    lbldisplay.Text += "</tr>"
                    n = n + 1
                End While
                lbldisplay.Text += "</table>"
            End If

            con.Close()
        End Sub

        Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload

        End Sub
    End Class
End Namespace