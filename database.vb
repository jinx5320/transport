Imports System.Data
Imports System.Data.OleDb


Namespace indiandeals

    Public Module database
        Public ucon As New OleDbConnection(ConfigurationManager.AppSettings("con"))
        Public aadapter As OleDbDataAdapter
        Public madapter As OleDbDataAdapter
        Public sadapter As OleDbDataAdapter
        Public badapter As OleDbDataAdapter
        Public cadapter As OleDbDataAdapter
        Public padapter As OleDbDataAdapter
        Public s1adapter As OleDbDataAdapter
        Public b1adapter As OleDbDataAdapter
        Public s2adapter As OleDbDataAdapter
        Public b2adapter As OleDbDataAdapter
        Public ads As New DataSet
        Public mds As New DataSet
        Public sds As New DataSet
        Public s1ds As New DataSet
        Public b1ds As New DataSet
        Public s2ds As New DataSet
        Public b2ds As New DataSet
        Public bds As New DataSet
        Public cds As New DataSet
        Public pds As New DataSet
        Public adt As DataTable
        Public mdt As DataTable
        Public sdt As DataTable
        Public s1dt As DataTable
        Public b1dt As DataTable
        Public s2dt As DataTable
        Public b2dt As DataTable
        Public bdt As DataTable
        Public cdt As DataTable
        Public pdt As DataTable
        Public message As String
        Public Sub connection()
            ucon.Open()
            aadapter = New OleDbDataAdapter("select * from admin", ucon)
            madapter = New OleDbDataAdapter("select * from messages", ucon)
            sadapter = New OleDbDataAdapter("select sid,spassword,cname,address,pioneer,email,website,doe,turnover,rdate,creditno,status,valdate from supplier order by sid", ucon)
            s1adapter = New OleDbDataAdapter("select sid,spassword,cname,address,pioneer,email,website,doe,turnover,rdate,creditno,status,valdate from supplier where status=0 order by sid", ucon)
            badapter = New OleDbDataAdapter("select bid,bpassword,cname,address,pioneer,email,website,doe,turnover,status,rdate,dolt from buyer order by bid", ucon)
            b1adapter = New OleDbDataAdapter("select bid,bpassword,cname,address,pioneer,email,website,doe,turnover,status,rdate,dolt from buyer where status=0 order by bid", ucon)
            cadapter = New OleDbDataAdapter("select * from catg order by name", ucon)
            s2adapter = New OleDbDataAdapter("select sid,spassword,cname,address,pioneer,email,website,doe,turnover,rdate,creditno,status,valdate from supplier where status=1 order by sid", ucon)
            b2adapter = New OleDbDataAdapter("select bid,bpassword,cname,address,pioneer,email,website,doe,turnover,status,rdate,dolt from buyer where status=1 order by bid", ucon)
            padapter = New OleDbDataAdapter("select pid,pname,price,category,sid,cname,tax,dom,batchno from product order by pid", ucon)
            ads.Clear()
            mds.Clear()
            sds.Clear()
            bds.Clear()
            s1ds.Clear()
            b1ds.Clear()
            s2ds.Clear()
            b2ds.Clear()
            cds.Clear()
            pds.Clear()
            aadapter.Fill(ads)
            madapter.Fill(mds)
            sadapter.Fill(sds)
            badapter.Fill(bds)
            s1adapter.Fill(s1ds)
            b1adapter.Fill(b1ds)
            s2adapter.Fill(s2ds)
            b2adapter.Fill(b2ds)
            cadapter.Fill(cds)
            padapter.Fill(pds)
            adt = ads.Tables(0)
            mdt = mds.Tables(0)
            sdt = sds.Tables(0)
            bdt = bds.Tables(0)
            s1dt = s1ds.Tables(0)
            b1dt = b1ds.Tables(0)
            s2dt = s2ds.Tables(0)
            b2dt = b2ds.Tables(0)
            cdt = cds.Tables(0)
            pdt = pds.Tables(0)
            ucon.Close()
        End Sub
        Public Sub closeconnection()
            ucon.Close()
        End Sub
    End Module
End Namespace
