Imports System.Data.OleDb
Imports System.Data



Namespace indiandeals


    Partial Class launchcategory
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            Dim con As New OleDbConnection(ConfigurationManager.AppSettings("con"))
            con.Open()
            Dim cmd As New OleDbCommand("select * from catg order by name", con)
            Dim cmd1 As New OleDbCommand("select * from catg order by name", con)
            Dim reader As OleDbDataReader
            Dim kadapter As OleDbDataAdapter
            Dim ds As New DataSet
            Dim dt As DataTable
            Dim dc0, dc1 As DataColumn
            Dim dr As DataRow
            kadapter = New OleDbDataAdapter(cmd1)
            kadapter.Fill(ds)
            reader = cmd.ExecuteReader
            dt = New DataTable
            dc1 = New DataColumn("Cname")
            dt.Columns.Add(dc1)
            While (reader.Read())
                dr = dt.NewRow()
                dr.Item(0) = Convert.ToString(reader.GetValue(0))
                dt.Rows.Add(dr)
            End While
            'Put user code to initialize the page here
            Dim j, count, i As Integer
            Dim s As String
            Dim k As String
            count = dt.Rows.Count

            If count = 0 Then

            Else
                For i = 0 To count - 1
                    Response.Write("<tr>")
                    dr = dt.Rows(i)
                    k = Convert.ToString(dr.Item(0))

                    'Response.Write("<td class= ArticlesDataTD  height= 20>" & k & "</td>")
                Next
                'Response.Write("</tr>")
            End If
            'Response.Write("</div>")
            'Response.Write("</table>")
        End Sub

        'Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '    'Put user code to initialize the page here
        '    Dim con As New OleDbConnection("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=indiandeals;Data Source=.")
        '    con.Open()
        '    Dim cmd As New OleDbCommand("select * from catg order by name", con)
        '    Dim cmd1 As New OleDbCommand("select * from catg order by name", con)
        '    Dim reader As OleDbDataReader
        '    Dim kadapter As OleDbDataAdapter
        '    Dim ds As New DataSet
        '    Dim dt As DataTable
        '    Dim dc0, dc1 As DataColumn
        '    Dim dr As DataRow
        '    kadapter = New OleDbDataAdapter(cmd1)
        '    kadapter.Fill(ds)
        '    reader = cmd.ExecuteReader
        '    dt = New DataTable
        '    dc1 = New DataColumn("Cname")
        '    dt.Columns.Add(dc1)
        '    While (reader.Read())
        '        dr = dt.NewRow()
        '        dr.Item(0) = Convert.ToString(reader.GetValue(0))
        '        dt.Rows.Add(dr)
        '    End While
        '    'Put user code to initialize the page here
        '    Dim j, count, i As Integer
        '    Dim s As String
        '    Dim k As String
        '    count = dt.Rows.Count
        '    'Response.Write("<div align=left><table width=100%>")
        '    'Response.Write("<tr>")
        '    'Response.Write("<td vAlign=top >")
        '    'Response.Write("<table class=LinkCategories id=Link_Holder runat=  Server>")
        '    'Response.Write("<TBODY>")
        '    'Response.Write("<tr>")
        '    'Response.Write("</tr>")
        '    If count = 0 Then
        '        'Response.Write("<tr><td class=ArticlesDataTD colSpan=4><font class=ArticlesDataFONT>No Categories</font></td></tr>")
        '    Else
        '        For i = 0 To count - 1
        '            Response.Write("<tr>")
        '            dr = dt.Rows(i)
        '            k = Convert.ToString(dr.Item(0))
        '            'Response.Write("<td class= ArticlesDataTD  height= 20>" & k & "</td>")
        '        Next
        '        Response.Write("</tr>")
        '    End If
        '    'Response.Write("</div>")
        '    'Response.Write("</table>")
        'End Sub

        Protected Sub cmdadd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdadd.Click
            Dim con As New OleDbConnection(ConfigurationManager.AppSettings("con"))
            con.Open()
            Dim value As String
            Dim n As Integer
            value = catgid.Text
            Dim cmd1 As New OleDbCommand("insert into catg values('" & value & "')", con)
            n = cmd1.ExecuteNonQuery
            If n > 0 Then
                Response.Redirect("launchcategory.aspx")
            Else
                Response.Redirect("Please check the values")
            End If
            con.Close()
        End Sub

    End Class
End Namespace