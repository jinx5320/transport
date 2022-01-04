Imports System.Data
Namespace indiandeals



    Partial Class buyrequestsproces
        Inherits System.Web.UI.Page
        Dim cmd As New System.Data.OleDb.OleDbCommand
        Public con As New System.Data.OleDb.OleDbConnection(ConfigurationManager.AppSettings("con"))

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            Try
                Dim bid As String
                Dim n As String
                bid = Request.Params.Get("bid")
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "update buyer set status=1 where bid='" & bid & "'"
                Response.Write(cmd.CommandText)
                n = cmd.ExecuteNonQuery()
                If n > 0 Then
                    Response.Redirect("buyeraccept.aspx")
                Else
                    Response.Write(cmd.CommandText)
                End If
            Catch e2 As Exception
                Response.Write(e2.ToString() & "" & cmd.CommandText)
            End Try
        End Sub
    End Class
End Namespace