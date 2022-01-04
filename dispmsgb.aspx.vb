Imports System.Data
Namespace indiandeals

    Partial Class dispmsgb
        Inherits System.Web.UI.Page
        Dim reader As System.Data.OleDb.OleDbDataReader
        Dim cmd As New System.Data.OleDb.OleDbCommand
        Public con As New System.Data.OleDb.OleDbConnection(ConfigurationManager.AppSettings("con"))

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            Dim fromid As String
            Dim subject As String
            Dim msg As String
            Dim time2 As String
            Dim toid As String
            toid = Session("uid")
            fromid = Request.Params.Get("fromid")
            time2 = Request.Params.Get("time2")
            time2 = time2.Replace("_", " ")
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select * from messages where toid='" & toid.ToLower & "' and fromid='" & fromid & "' and sdate='" & time2 & "'"
            reader = cmd.ExecuteReader()
            If reader.Read() Then
                subject = Convert.ToString(reader.GetValue(2))
                msg = Convert.ToString(reader.GetValue(3))
            End If
            Me.TextBox1.Text = fromid
            Me.subject.Text = subject
            Me.msg.Text = msg
            Me.TextBox2.Text = time2
            con.Close()
        End Sub

        Protected Sub cmdclose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdclose.Click
            Response.Redirect("buyerinbox.aspx")
        End Sub
    End Class
End Namespace
