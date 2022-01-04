Imports System.Data
Imports System.Data.OleDb

Namespace indiandeals



    Partial Class delmsg
        Inherits System.Web.UI.Page
        Dim cmd As New System.Data.OleDb.OleDbCommand
        Public con As New System.Data.OleDb.OleDbConnection(ConfigurationManager.AppSettings("con"))

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            Dim fromid As String
            Dim time2 As String
            Dim toid As String
            Dim n As Integer
            toid = Session("uid")
            fromid = Request.Params.Get("fromid")
            time2 = Request.Params.Get("time2")
            time2 = time2.Replace("_", " ")
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "delete from messages where toid='" & toid.ToLower & "'and fromid='" & fromid & "' and sdate='" & time2 & "'"
            n = cmd.ExecuteNonQuery
            If n > 0 Then
                Response.Redirect("admininbox.aspx")
            Else
                Response.Redirect("admininbox.aspx")
            End If
            con.Close()
        End Sub
    End Class
End Namespace