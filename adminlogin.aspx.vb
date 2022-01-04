Imports System.Data
Namespace indiandeals



    Partial Class _Default
        Inherits System.Web.UI.Page
        Public con As New System.Data.OleDb.OleDbConnection(ConfigurationManager.AppSettings("con"))
        Public con2 As New System.Data.OleDb.OleDbConnection(ConfigurationManager.AppSettings("con"))
        Dim cmd As New System.Data.OleDb.OleDbCommand
        Dim cmd2 As New System.Data.OleDb.OleDbCommand
        Dim reader As System.Data.OleDb.OleDbDataReader


        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            Dim diff As Integer
            If Not Page.IsPostBack Then
                connection()
            End If
            cmdlogin.Attributes.Add("onclick", "javascript:return validate();")
        End Sub

        Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
            closeconnection()
        End Sub

        Protected Sub cmdlogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
            Dim sid As String
            Dim dt1 As DateTime
            Dim dt2 As DateTime
            Dim p1, p2 As String
            p1 = txtusr.Text
            p2 = TextBox1.Text
            Dim n As Integer = 0
            Dim uid, pwd As String
            Dim flag As Integer

            flag = 0
            dt1 = Now
            Dim drow As DataRow
            If n < adt.Rows.Count Then
                drow = adt.Rows(n)
                uid = Convert.ToString(drow.Item(0))
                pwd = Convert.ToString(drow.Item(1))
                If uid.ToLower = p1.ToLower And pwd.ToLower = p2.ToLower Then
                    'con.Open()
                    'cmd.Connection = con
                    'cmd.CommandText = "select sid,floor(months_between(sysdate,to_date(rdate))) from supplier where status=1 "
                    'reader = cmd.ExecuteReader
                    'con2.Open()
                    'While reader.Read()
                    'sid = reader.GetValue(0)
                    'Response.Write(reader.GetValue(1))
                    'Exit Sub
                    'diff = reader.GetValue(1)
                    'Dim count As Integer = 0
                    'Response.Write("diff is " & diff)
                    'Exit Sub
                    'If diff <= 11 And diff >= 8 Then
                    'cmd2.Connection = con2
                    'cmd2.CommandText = "insert into messages values('Admin','" & sid & "','renual alert','Dear Supplier ! your id " & sid & " will expires soon.please renual your account with in 15 days!)"
                    'count = cmd2.ExecuteNonQuery()
                    'con2.Close()
                    '   Else
                    '      If diff >= 12 Then
                    '     cmd2.Connection = con2
                    '    cmd2.CommandText = "delete from supplier where sid='" & sid & "'"
                    '   count = cmd2.ExecuteNonQuery()
                    '  con2.Close()
                    'End If
                    'End If
                    '       End While
                    'con.Close()

                    Session.Add("uid", txtusr.Text)
                    Response.Write("<HTML>")
                    Response.Write("<TITLE>Welcome To OnLine Tradeing System </TITLE>")
                    Response.Write("<frameset rows=10%,*,10% border=0 noscrolling>")
                    Response.Write("<frame src=name.html scrolling=no>")
                    Response.Write("<frameset cols=20%,*,20%* name=f1>")
                    Response.Write("<frame name=links src=adminoptions.html scrolling=no>")
                    Response.Write("<frame name=details src=aboutus.html>")
                    Response.Write("<frame name=third src=img.html scrolling=no>")
                    Response.Write("</frameset>")
                    Response.Write("<frame name=footer src=footer.html scrolling=no>")
                    Response.Write("</frameset>")
                    Response.Write("</HTML>")
                    flag = 1
                    Response.Redirect("adminhome.aspx")
                End If
            End If
            
            If flag = 0 Then
                lbldisplay.Text = "Enter Valid ID/Password"
            End If

        End Sub

        Protected Sub cmdreset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdreset.Click
            Response.Redirect("home.aspx")

        End Sub
    End Class
End Namespace