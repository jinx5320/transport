Imports System.Data
Namespace indiandeals



    Partial Class admincompose
        Inherits System.Web.UI.Page
        Public con As New System.Data.OleDb.OleDbConnection(ConfigurationManager.AppSettings("con"))
        Dim cmd As New System.Data.OleDb.OleDbCommand

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            Dim uid As String
            uid = Session("uid")
            If Not Page.IsPostBack Then
                connection()
                Dim n As Integer = 0
                Dim flag As Integer = 0
                Dim row As DataRow
                Dim value As Integer
                If uid.ToLower = "Admin".ToLower Then
                    value = 1
                End If
                If uid.Chars(0) = "S" Then
                    value = 2
                End If
                If uid.Chars(0) = "B" Then
                    value = 3
                End If
                Me.toid.Items.Clear()
                If value = 1 Then
                    n = 0
                    While n < s2dt.Rows.Count
                        row = s2dt.Rows(n)
                        Me.toid.Items.Add(row.Item(0) & "," & row.Item(2))
                        n = n + 1
                    End While
                    n = 0
                    While n < b2dt.Rows.Count
                        row = b2dt.Rows(n)
                        Me.toid.Items.Add(row.Item(0) & "," & row.Item(2))
                        n = n + 1
                    End While
                End If
                If value = 2 Then
                    Me.toid.Items.Add("Admin, Adminstrator")
                    n = 0
                    While n < b2dt.Rows.Count
                        row = b2dt.Rows(n)
                        Me.toid.Items.Add(row.Item(0) & "," & row.Item(2))
                        n = n + 1
                    End While
                End If
                If value = 3 Then
                    Me.toid.Items.Add("Admin, Adminstrator")
                    n = 0
                    While n < s2dt.Rows.Count
                        row = s2dt.Rows(n)
                        Me.toid.Items.Add(row.Item(0) & "," & row.Item(2))
                        n = n + 1
                    End While
                End If
            End If
        End Sub

        Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
            closeconnection()
        End Sub

        Protected Sub cmdsubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdsubmit.Click
            Dim toid As String
            toid = Me.toid.SelectedValue
            toid = toid.Substring(0, toid.IndexOf(","))
            toid = toid.Trim()
            toid = toid.ToLower()
            Dim fromid As String
            fromid = Session("uid")
            Dim subject As String
            subject = Me.subject.Text
            Dim msg As String
            msg = Me.msg.Text
            Dim dt As DateTime
            Dim n As Integer
            dt = Now
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "insert into messages values('" & fromid & "','" & toid & "','" & subject & "','" & msg & "','" & dt.ToString() & "')"
            n = cmd.ExecuteNonQuery
            If n > 0 Then
                Response.Redirect("msgsuccess.aspx?dt=" & dt.ToString())
            Else
                Response.Redirect("admincompose.aspx")
            End If
            con.Close()
        End Sub
    End Class
End Namespace