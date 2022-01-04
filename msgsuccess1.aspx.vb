Imports System.Data
Namespace indiandeals




    Partial Class msgsuccess1
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            Me.Label1.Text = "Message Successfully Send At : " & Request.Params.Get("dt")

        End Sub
    End Class
End Namespace