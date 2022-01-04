Imports System.Data
Namespace indiandeals


    Partial Class cancelbuyer
        Inherits System.Web.UI.Page
        Public con As New System.Data.OleDb.OleDbConnection(ConfigurationManager.AppSettings("con"))

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            connection()
            Dim n As Integer = 0
            Dim s As String
            Dim brow As DataRow
            DropDownList1.Items.Insert(0, "Select")
            While n < bdt.Rows.Count
                brow = bdt.Rows(n)
                s = Convert.ToString(brow.Item(0))
                Me.DropDownList1.Items.Add(s)
                n = n + 1
            End While
        End Sub

        Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
            closeconnection()
            con.Close()
        End Sub

        Protected Sub cmddelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmddelete.Click
            Dim id As String
            Dim n As Integer
            id = Convert.ToString(Me.DropDownList1.SelectedValue)
            con.Open()
            Dim cmd As New System.Data.OleDb.OleDbCommand("delete from buyer where bid='" & id & "'", con)
            n = cmd.ExecuteNonQuery
            If n > 0 Then
                Response.Redirect("cancelbuyer.aspx")
            Else
                Response.Write("problem while Buyer Deletion")
            End If
        End Sub
    End Class
End Namespace