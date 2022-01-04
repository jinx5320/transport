Imports System.Data
Namespace indiandeals


    Partial Class buyerCompose
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            connection()
            Dim n As Integer
            Dim row As DataRow
            While n < cdt.Rows.Count
                row = cdt.Rows(n)
                Me.pioneer.Items.Add(row.Item(0))
                n = n + 1
            End While
        End Sub

        Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
            closeconnection()
        End Sub

        Protected Sub cmdNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNext.Click
            Dim id As String
            id = Me.pioneer.SelectedValue
            Session.Add("catg", id)
            Response.Redirect("buyerCompose1.aspx?catg=" & id)
        End Sub
    End Class
End Namespace