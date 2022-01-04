Imports System.Data
Namespace indiandeals




    Partial Class modifyproduct
        Inherits System.Web.UI.Page
        Public con As New System.Data.OleDb.OleDbConnection(ConfigurationManager.AppSettings("con"))
        Public cmd As New System.Data.OleDb.OleDbCommand
        Public reader As System.Data.OleDb.OleDbDataReader

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            Dim sid As String
            sid = Session.Item("uid")
            connection()
            Dim n As Integer
            Dim prow As DataRow
            If Not Page.IsPostBack Then
                pid.Items.Add("Select Product Id")
                While n < pdt.Rows.Count
                    prow = pdt.Rows(n)
                    If sid = Convert.ToString(prow.Item(4)) Then
                        pid.Items.Add(prow.Item(0))
                    End If
                    n = n + 1
                End While
                n = 0
                While n < cdt.Rows.Count
                    prow = cdt.Rows(n)
                    Me.catg.Items.Add(prow.Item(0))
                    n = n + 1
                End While
            End If
        End Sub

        Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
            closeconnection()
        End Sub

      

        Protected Sub pid_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles pid.SelectedIndexChanged
            Dim pid As String
            pid = Me.pid.SelectedValue
            Dim sid As String
            sid = Session.Item("uid")
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select pid,pname,price,category,sid,cname,tax,dom,batchno from product where pid='" & pid & "'and sid='" & sid & "' order by pid"
            reader = cmd.ExecuteReader
            If reader.Read() Then
                Me.name.Text = Convert.ToString(reader.GetValue(1))
                Me.price.Text = Convert.ToString(reader.GetValue(2))
                Me.catg.SelectedValue = Convert.ToString(reader.GetValue(3))
                Me.Tax.Text = Convert.ToString(reader.GetValue(6))
                Me.dom.Text = reader.GetValue(7)
                Me.batchno.Text = reader.GetValue(8)
            End If
            con.Close()
        End Sub

        Protected Sub cmdmodify_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdmodify.Click
            Try
                Dim pid As String
                Dim pname As String
                Dim price As Double
                Dim category As String
                Dim sname As String
                Dim tax As Double
                Dim dom As Date
                Dim batchno As Integer
                Dim count As Integer
                con.Open()
                Dim sid As String
                sid = Session.Item("uid")
                pid = Me.pid.SelectedValue
                pname = Me.name.Text
                price = Convert.ToDouble(Me.price.Text)
                category = Me.catg.SelectedValue
                tax = Convert.ToDouble(Me.Tax.Text)
                dom = Convert.ToDateTime(Me.dom.Text)
                batchno = Convert.ToInt32(Me.batchno.Text)
                Dim date1 As String
                date1 = Format(dom, "yy-MMM-dd")
                cmd.Connection = con
                cmd.CommandText = "update product set pname='" & pname & "',price=" & price & ",category='" & category & "',tax=" & tax & ",dom='" & date1 & "',batchno=" & batchno & " where pid='" & pid & "'and sid='" & sid & "'"
                Response.Write(cmd.CommandText)
                count = cmd.ExecuteNonQuery()
                If count > 0 Then
                    Response.Redirect("modifyproduct.aspx")
                Else
                    Response.Redirect("error.aspx")
                End If
                con.Close()
            Catch e2 As Exception
                Response.Write(cmd.CommandText)
            End Try
        End Sub
    End Class
End Namespace