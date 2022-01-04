Imports System.Data
Namespace indiandeals

    Partial Class Buyerlist
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            Dim s As String
            s = Request.Params.Get("id")
            If s.ToLower = "buyers" Then
                Me.DataGrid1.DataSource = bdt
                Me.DataGrid1.DataBind()
            Else
                Me.DataGrid1.DataSource = sdt
                Me.DataGrid1.DataBind()
            End If
        End Sub
    End Class
End Namespace
