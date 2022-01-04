Imports System.Data
Namespace indiandeals



    Partial Class cancelsupp
        Inherits System.Web.UI.Page
        Public con As New System.Data.OleDb.OleDbConnection(ConfigurationManager.AppSettings("con"))

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            If Not Page.IsPostBack Then
                Me.DropDownList1.Items.Clear()
                connection()
                Dim n As Integer = 0
                Dim s As String
                Dim srow As DataRow
                DropDownList1.Items.Insert(0, "Select")
                While n < sdt.Rows.Count
                    srow = sdt.Rows(n)
                    s = Convert.ToString(srow.Item(0))
                    Me.DropDownList1.Items.Add(s)
                    n = n + 1
                End While
            End If
        End Sub

        Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
            closeconnection()
            con.Close()
        End Sub

        Protected Sub cmddelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmddelete.Click
            Dim id1 As String
            Dim n As Integer
            id1 = Convert.ToString(Me.DropDownList1.SelectedValue)
            con.Open()
            Dim cmd As New System.Data.OleDb.OleDbCommand("delete from supplier where sid='" & id1 & "'", con)
            n = cmd.ExecuteNonQuery
            If n > 0 Then
                Response.Redirect("cancelsupp.aspx")
            Else
                Response.Write("problem while Supplier Deletion")
            End If
        End Sub
    End Class
End Namespace