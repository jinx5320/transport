Imports System.Data
Namespace indiandeals



    Partial Class adminchangepwd
        Inherits System.Web.UI.Page
        Public con As New System.Data.OleDb.OleDbConnection(ConfigurationManager.AppSettings("con"))

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            connection()        
        End Sub

        Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
            closeconnection()
            con.Close()
        End Sub

        Protected Sub cmdsubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdsubmit.Click
            Dim p1, p2 As String
            p1 = Text1.Text
            p2 = Text2.Text
            Dim n As Integer = 0
            con.Open()
            Dim acmd As New System.Data.OleDb.OleDbCommand("update admin set password='" & p2 & "'where password='" & p1 & "'", con)
            n = acmd.ExecuteNonQuery
            If n > 0 Then

                Response.Redirect("result.aspx")

                'Response.Write("<HTML>")
                'Response.Write("<TITLE>Welcome To OnLine Tradeing System </TITLE>")
                'Response.Write("<frameset rows=10%,*,10% border=0 noscrolling>")
                'Response.Write("<frame src=name.html scrolling=no>")
                'Response.Write("<frameset cols=20%,*,20%* name=f1>")
                'Response.Write("<frame name=links src=adminoptions.html scrolling=no>")
                'Response.Write("<frame name=details src=adminok.htm>")
                'Response.Write("<frame name=third src=img.html scrolling=no>")
                'Response.Write("</frameset>")
                'Response.Write("<frame name=footer src=footer.html scrolling=no>")
                'Response.Write("</frameset>")
                'Response.Write("</HTML>")
            Else

                Response.Redirect("result1.aspx")
                'Response.Write("<HTML>")
                'Response.Write("<TITLE>Welcome To OnLine Tradeing System </TITLE>")
                'Response.Write("<frameset rows=10%,*,10% border=0 noscrolling>")
                'Response.Write("<frame src=name.html scrolling=no>")
                'Response.Write("<frameset cols=20%,*,20%* name=f1>")
                'Response.Write("<frame name=links src=adminoptions.html scrolling=no>")
                'Response.Write("<frame name=details src=adminnotok.htm>")
                'Response.Write("<frame name=third src=img.html scrolling=no>")
                'Response.Write("</frameset>")
                'Response.Write("<frame name=footer src=footer.html scrolling=no>")
                'Response.Write("</frameset>")
                'Response.Write("</HTML>")
            End If
            con.Close()
        End Sub
    End Class
End Namespace