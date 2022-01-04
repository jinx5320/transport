Imports System.Data
Namespace indiandeals


    Partial Class modifybuyer
        Inherits System.Web.UI.Page
        Public con As New System.Data.OleDb.OleDbConnection(ConfigurationManager.AppSettings("con"))
        Dim cmd As New System.Data.OleDb.OleDbCommand

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            If Not Page.IsPostBack Then
                connection()
                Dim bid As String = Session("uid")
                Dim bpwd As String
                Dim cname As String
                Dim address As String
                Dim pioneer As String
                Dim email As String
                Dim website As String
                Dim doe As DateTime
                Dim turnover As String
                Dim date1 As String
                Dim n As Integer = 0
                Dim brow As DataRow
                n = 0
                While n < cdt.Rows.Count
                    brow = cdt.Rows(n)
                    Me.bpioneer.Items.Add(brow.Item(0))
                    n = n + 1
                End While
                n = 0
                While n < b2dt.Rows.Count
                    brow = b2dt.Rows(n)
                    If bid = brow.Item(0) Then
                        bpwd = brow.Item(1)
                        cname = brow.Item(2)
                        address = brow.Item(3)
                        pioneer = brow.Item(4)
                        email = brow.Item(5)
                        website = brow.Item(6)
                        doe = Convert.ToDateTime(brow.Item(7))
                        date1 = Format(doe, "yy-MMM-dd")
                        turnover = brow.Item(8)
                        Me.bid.Text = Session("uid")
                        Me.bpwd.Text = bpwd
                        Me.cname.Text = cname
                        Me.baddress.Text = address
                        Me.bpioneer.SelectedValue = pioneer
                        Me.email.Text = email
                        Me.website.Text = website
                        Me.doe.Text = date1
                        Me.tover.Text = turnover
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
                Dim bid As String
                Dim bpwd As String
                Dim cname As String
                Dim address As String
                Dim pioneer As String
                Dim email As String
                Dim website As String
                Dim doe As String
                Dim turnover As Decimal
                bid = Session("uid")
                bpwd = Me.bpwd.Text
                cname = Me.cname.Text
                address = Me.baddress.Text
                pioneer = Me.bpioneer.SelectedValue
                email = Me.email.Text
                website = Me.website.Text
                doe = Me.doe.Text
                turnover = Convert.ToDecimal(Me.tover.Text)
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "update buyer set bpassword='" & bpwd & "',cname='" & cname & "',address='" & address & "',pioneer='" & pioneer & "',email='" & email & "',website='" & website & "',doe='" & doe & "',turnover=" & turnover & " where bid='" & bid & "'"
                Dim count As Integer
                count = cmd.ExecuteNonQuery()
                If count > 0 Then
                    Response.Redirect("buysuccess.aspx")
                Else
                    Response.Redirect("errorb.aspx")
                End If
            Catch e1 As Exception
                Response.Write("please enter proper values" & e1.ToString)

            End Try
            con.Close()
        End Sub
    End Class
End Namespace