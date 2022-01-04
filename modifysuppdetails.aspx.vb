Imports System.Data
Namespace indiandeals
   


    Partial Class modifysuppdetails
        Inherits System.Web.UI.Page
        Public con As New System.Data.OleDb.OleDbConnection(ConfigurationManager.AppSettings("con"))
        Dim cmd As System.Data.OleDb.OleDbCommand

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            If Not Page.IsPostBack Then
                connection()
                Dim sid2 As String = Session("uid")
                Dim spwd2 As String
                Dim cname2 As String
                Dim address2 As String
                Dim pioneer2 As String
                Dim email2 As String
                Dim website2 As String
                Dim doe2 As DateTime
                Dim turnover2 As String
                Dim creditno2 As String
                Dim status2 As String
                Dim valdate2 As DateTime
                Dim date1 As String
                Dim date2 As String
                Dim n As Integer = 0
                Dim srow As DataRow
                n = 0
                While n < cdt.Rows.Count
                    srow = cdt.Rows(n)
                    Me.spioneer.Items.Add(srow.Item(0))
                    n = n + 1
                End While
                n = 0
                While n < s2dt.Rows.Count
                    srow = s2dt.Rows(n)
                    If sid2 = srow.Item(0) Then
                        spwd2 = srow.Item(1)
                        cname2 = srow.Item(2)
                        address2 = srow.Item(3)
                        pioneer2 = srow.Item(4)
                        email2 = srow.Item(5)
                        website2 = srow.Item(6)
                        doe2 = Convert.ToDateTime(srow.Item(7))
                        date1 = Format(doe2, "yy-MMM-dd")
                        turnover2 = srow.Item(8)
                        creditno2 = Convert.ToString(srow.Item(10))
                        valdate2 = Convert.ToDateTime(srow.Item(12))
                        date2 = Format(valdate2, "yy-MMM-dd")
                        Me.sid.Text = Session("uid")
                        Me.spwd.Text = spwd2
                        Me.cname.Text = cname2
                        Me.saddress.Text = address2
                        Me.spioneer.SelectedValue = pioneer2
                        Me.email.Text = email2
                        Me.website.Text = website2
                        Me.doe.Text = date1
                        Me.tover.Text = turnover2
                        Me.ccno.Text = creditno2
                        Me.ccvu.Text = date2
                        Exit Sub
                    End If
                    n = n + 1
                End While
            End If
        End Sub

        Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
            closeconnection()
        End Sub

        Protected Sub cmdadd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdadd.Click
            Try
                Dim sid1 As String
                Dim spwd1 As String
                Dim cname1 As String
                Dim address1 As String
                Dim pioneer1 As String
                Dim email1 As String
                Dim website1 As String
                Dim doe1 As String
                Dim turnover1 As Decimal
                Dim creditno1 As Decimal
                Dim status1 As String
                Dim valdate1 As String
                sid1 = Session("uid")
                spwd1 = Me.spwd.Text
                cname1 = Me.cname.Text
                address1 = Me.saddress.Text
                pioneer1 = Me.spioneer.SelectedValue
                email1 = Me.email.Text
                website1 = Me.website.Text
                doe1 = Me.doe.Text
                turnover1 = Convert.ToDecimal(Me.tover.Text)
                creditno1 = Convert.ToDecimal(Me.ccno.Text)
                valdate1 = Me.ccvu.Text
                con.Open()
                cmd = New System.Data.OleDb.OleDbCommand("update supplier set spassword='" & spwd1 & "',cname='" & cname1 & "',address='" & address1 & "',pioneer='" & pioneer1 & "',email='" & email1 & "',website='" & website1 & "',doe='" & doe1 & "',turnover=" & turnover1 & ",creditno=" & creditno1 & ",valdate='" & valdate1 & "' where sid='" & sid1 & "'", con)
                Dim count As Integer = 0
                count = cmd.ExecuteNonQuery()
                con.Close()
                If count > 0 Then
                    Response.Redirect("supsuccess.aspx")
                Else
                    Response.Redirect("error.aspx")

                End If

            Catch e1 As Exception
                Response.Write("please enter proper values" & e1.ToString)
            End Try
        End Sub
    End Class
End Namespace