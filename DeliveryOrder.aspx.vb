Imports System.Data
Namespace indiandeals


    Partial Class DeliveryOrder
        Inherits System.Web.UI.Page
        Public con As New System.Data.OleDb.OleDbConnection(ConfigurationManager.AppSettings("con"))
        Public reader As System.Data.OleDb.OleDbDataReader
        Public cmd As New System.Data.OleDb.OleDbCommand
        Dim adapter As System.Data.OleDb.OleDbDataAdapter


        Protected Sub cmdorder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdorder.Click
            Dim sid As String
            sid = Session("uid")
            Dim poid As String
            poid = Me.poid.SelectedValue
            con.Open()
            Dim cmd2 As New System.Data.OleDb.OleDbCommand
            cmd2.Connection = con
            cmd2.CommandText = "update porder set status=3 where poid='" & poid & "' and status=2 and sid='" & sid & "'"
            Dim n As Integer
            n = cmd2.ExecuteNonQuery
            If n > 0 Then
                Response.Redirect("posuccess.aspx")
            Else
                Response.Redirect("error.aspx")
            End If
            con.Close()
        End Sub

        Protected Sub poid_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles poid.SelectedIndexChanged
            Dim poid As String
            poid = Me.poid.SelectedValue
            con.Open()
            adapter = New System.Data.OleDb.OleDbDataAdapter(" select poid,sid,pid,qty,ddate,bid,rqty,cdate,total from porder where poid='" & poid & "' and status=2", con)
            Dim dt As DataTable
            Dim ds As New DataSet
            Dim dr As DataRow
            ds.Clear()
            adapter.Fill(ds)
            dt = ds.Tables(0)
            Dim cmd3 As New System.Data.OleDb.OleDbCommand
            Dim n As Integer = 0
            If n < dt.Rows.Count Then
                dr = dt.Rows(n)
                Me.pid.Text = dr.Item(2)
                Me.qty.Text = dr.Item(3)
                Me.ddate.Text = dr.Item(4)
                Me.bid.Text = dr.Item(5)
                Me.rqty.Text = dr.Item(6)
                Me.condate.Text = dr.Item(7)
                Me.total.Text = dr.Item(8)
            End If
            con.Close()
        End Sub

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            If Not Page.IsPostBack Then
                con.Open()
                Dim sid As String
                sid = Session("uid")
                cmd.Connection = con
                cmd.CommandText = " select poid,sid,pid,qty,ddate,bid from porder where sid='" & sid & "' and status=2"
                reader = cmd.ExecuteReader
                Me.poid.Items.Add("Select Order")
                While reader.Read()
                    Me.poid.Items.Add(reader.GetValue(0))
                End While
                con.Close()
            End If

        End Sub
    End Class
End Namespace