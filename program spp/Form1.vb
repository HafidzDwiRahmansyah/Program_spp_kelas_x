Imports System.Data.Odbc
Public Class Form1
    Public conn As OdbcConnection
    Public dr As OdbcDataReader
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public cmd As OdbcCommand
    Public sql1 As String

    Sub koneksi()
        sql1 = "Driver={mysql Odbc 5.1 Driver};server=localhost;uid=root;database=db_spp_Hafidz;port=3306"
        conn = New OdbcConnection(sql1)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Sub aktifkan()
        t1.Enabled = True
        t2.Enabled = True
        t3.Enabled = True
        t4.Enabled = True

        B1.Enabled = True
        B2.Enabled = True
        B3.Enabled = True
        B4.Enabled = True
        B5.Enabled = True
        B6.Enabled = True

    End Sub

    Sub noaktif()
        t1.Enabled = False
        t2.Enabled = False
        t3.Enabled = False
        t4.Enabled = False

        B1.Enabled = False
        B2.Enabled = False
        B3.Enabled = False
        B4.Enabled = False
    End Sub

    Sub tampilkanDGV()
        koneksi()
        da = New OdbcDataAdapter("Select * From tbladm ", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbladm")
        Me.DGV.DataSource = (ds.Tables("tbladm"))

    End Sub

    Sub kosongkan()
        T1.Clear()
        T2.Clear()
        T3.Clear()
        T4.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilDGV()
        noaktif()
        kosongkan()
    End Sub
End Class
