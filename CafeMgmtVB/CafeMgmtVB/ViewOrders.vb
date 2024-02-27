Imports System.Data.SqlClient

Public Class ViewOrders
    Dim Con = New SqlConnection("Data Source=DUZCE-ERP-1;Initial Catalog=CafeVbDb;Integrated Security=True;Encrypt=False")
    Private Sub DisplayBill()
        Con.Open()
        Dim query = "select * from OrderTbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        OrdersDGV.DataSource = ds.Tables(0)
        Con.Close()

    End Sub

    Private Sub ViewOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBill()
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim Obj = New Orders
        Obj.Show()
        Me.Hide()
    End Sub
End Class