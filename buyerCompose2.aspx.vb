Imports System.Data
Namespace indiandeals



    Partial Class buyerCompose2
        Inherits System.Web.UI.Page
        Public con As New System.Data.OleDb.OleDbConnection(ConfigurationManager.AppSettings("con"))
        Public adapter As New System.Data.OleDb.OleDbDataAdapter
        Public reader As System.Data.OleDb.OleDbDataReader
        Dim pid2 As String
        Dim sid2 As String
        Dim cmd As New System.Data.OleDb.OleDbCommand

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            adapter = New Data.OleDb.OleDbDataAdapter("select * from porder order by poid", con)
            Dim dt1 As DataTable
            Dim dr1 As DataRow
            Dim ds1 As New DataSet
            ds1 = New DataSet
            ds1.Clear()
            adapter.Fill(ds1)
            dt1 = ds1.Tables(0)
            Dim drow As DataRow
            Dim n As Integer = 0
            Dim fid As String = "R0000"
            Dim rid1 As String
            While n < dt1.Rows.Count
                drow = dt1.Rows(n)
                fid = Convert.ToString(drow.Item(0))
                n = n + 1
            End While
            fid = fid.Substring(1, fid.Length - 1)
            n = Convert.ToInt32(fid)
            n = n + 1
            If n < 10 Then
                rid1 = "R000" & n
            Else
                If n < 100 Then
                    rid1 = "R00" & n
                Else
                    If n < 1000 Then
                        rid1 = "R0" & n
                    Else
                        rid1 = "R" & n
                    End If
                End If
            End If
            Me.porder.Text = rid1
            pid2 = Request.Params.Get("id")
            sid2 = Request.Params.Get("sid")
            Dim dt As DataTable
            Dim dr As DataRow
            Dim ds As New DataSet
            con.Open()
            adapter = New System.Data.OleDb.OleDbDataAdapter("select pid,pname,price,category,sid,cname,tax,dom,batchno from product where pid='" & pid2 & "' and sid='" & sid2 & "'  order by pid", con)
            ds.Clear()
            adapter.Fill(ds)
            dt = ds.Tables(0)
            n = 0
            If n < dt.Rows.Count Then
                dr = dt.Rows(n)
                Me.pid.Items.Add(dr.Item(0))
                Me.name.Text = dr.Item(1)
                Me.price.Text = Convert.ToString(dr.Item(2))
            End If
            con.Close()
        End Sub

        Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload

        End Sub

        Protected Sub cmdorder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdorder.Click
            Dim pid As String
            Dim pname As String
            Dim sid As String
            Dim poid As String
            Dim qty As Integer
            Dim ddate As String
            Dim bid As String
            poid = Me.porder.Text
            pid = Me.pid.SelectedValue
            sid = sid2
            qty = Convert.ToInt32(Me.qty.Text)
            ddate = Me.ddate.Text
            bid = Session("uid")
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "insert into porder(poid,sid,pid,qty,ddate,bid,status) values('" & poid & "','" & sid & "','" & pid & "'," & qty & "," & ddate & ",'" & bid & "',0)"
            Dim count As Integer
            count = cmd.ExecuteNonQuery()
            If count > 0 Then
                Response.Redirect("buyerCompose1.aspx?catg=" & Session("catg"))
            Else
                Response.Redirect("error1.aspx")
            End If
            con.Close()
        End Sub
    End Class
End Namespace