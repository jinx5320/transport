Imports System.Data


Namespace indiandeals



    Partial Class Buyerlogin
        Inherits System.Web.UI.Page
        Public con As New System.Data.OleDb.OleDbConnection(ConfigurationManager.AppSettings("con"))
        Public cmd As New System.Data.OleDb.OleDbCommand
        Public reader As System.Data.OleDb.OleDbDataReader

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Put user code to initialize the page here
            connection()
            Dim n As Integer = 0
            Dim brow As DataRow
            While n < b2dt.Rows.Count
                brow = b2dt.Rows(n)
                Me.DropDownList1.Items.Add(brow.Item(0) & "," & brow.Item(2))
                n = n + 1
            End While
        End Sub

        Protected Sub cmdlogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
            Dim id As String
            Dim pwd As String
            id = Me.DropDownList1.SelectedValue
            id = id.Substring(0, id.IndexOf(","))
            pwd = Me.TextBox1.Text
            id = id.Trim()
            pwd = pwd.Trim()
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select bid,bpassword from buyer where bid='" & id & "' and bpassword='" & pwd & "'"
            reader = cmd.ExecuteReader
            If reader.Read() Then
                Session.Add("uid", id)
                Response.Redirect("buyerhome.aspx")
            Else
                lbldisplay.Text = "Invalid Password"
            End If


        End Sub

        Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
            closeconnection()
        End Sub
    End Class
End Namespace

