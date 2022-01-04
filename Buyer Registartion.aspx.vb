Imports System.Data


Namespace indiandeals



    Partial Class Buyer_Registartion
        Inherits System.Web.UI.Page
        Public con As New System.Data.OleDb.OleDbConnection(ConfigurationManager.AppSettings("con"))
        Dim cmd As New System.Data.OleDb.OleDbCommand


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
                Dim turnover As String
                Dim rdate As String
                Dim dolt As String
                bid = Me.bid.Text
                bpwd = Me.bpwd.Text
                cname = Me.cname.Text
                address = Me.baddr.Text
                pioneer = Me.bpioneer.SelectedValue.ToString
                email = Me.email.Text
                website = Me.website.Text
                doe = Me.doe.Text
                turnover = Me.tover.Text
                rdate = Me.rdate.Text
                dolt = Me.dolt.Text
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "insert into buyer values('" & bid & "','" & bpwd & "','" & cname & "','" & address & "','" & pioneer & "','" & email & "','" & website & "','" & doe & "'," & Convert.ToDouble(turnover) & ",0,'" & rdate & "','" & dolt & "')"
                Dim count As Integer
                count = cmd.ExecuteNonQuery()
                If count > 0 Then
                    Response.Redirect("Buyer Registartion.aspx")
                Else
                    lbldisplay.Text = "Problem for Buyer Registration"
                End If
            Catch e1 As Exception
                lbldisplay.Text = "please enter proper values"
            End Try
        End Sub

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            connection()
            Dim brow As DataRow
            Dim n As Integer = 0
            Dim fid As String = "B0000"
            Dim bid1 As String
            While n < bdt.Rows.Count
                brow = bdt.Rows(n)
                fid = Convert.ToString(brow.Item(0))
                n = n + 1
            End While
            fid = fid.Substring(1, fid.Length - 1)
            n = Convert.ToInt32(fid)
            n = n + 1
            If n < 10 Then
                bid1 = "B000" & n
            Else
                If n < 100 Then
                    bid1 = "B00" & n
                Else
                    If n < 1000 Then
                        bid1 = "B0" & n
                    Else
                        bid1 = "B" & n
                    End If
                End If
            End If
            Me.bid.Text = bid1
            n = 0
            While n < cdt.Rows.Count
                brow = cdt.Rows(n)
                Me.bpioneer.Items.Add(brow.Item(0))
                n = n + 1
            End While
        End Sub




        Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
            closeconnection()
        End Sub
    End Class
End Namespace