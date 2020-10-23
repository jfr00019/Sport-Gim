Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Sport_GimDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.Sport_GimDataSet.Clientes)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClientesBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ClientesBindingSource.MoveNext()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClientesBindingSource.MoveFirst()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ClientesBindingSource.MoveLast()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClientesBindingSource.AddNew()
        txtcodigo.Hide()
        txtnombre.Hide()
        txttelefono.Hide()
        txtinicio.Hide()
        txttermina.Hide()
        lblcodigo.Hide()
        lblnombre.Hide()
        lbltelefono.Hide()
        lblinicio.Hide()
        lbltermina.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClientesTableAdapter.DeleteQuery(txtcodigo.Text)
        Me.ClientesTableAdapter.Fill(Me.Sport_GimDataSet.Clientes)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        On Error GoTo SaveErr
        ClientesBindingSource.EndEdit()
        ClientesTableAdapter.Update(Sport_GimDataSet.Clientes)
        MessageBox.Show("Datos Guardados")
SaveErr:
        txtcodigo.Show()
        txtnombre.Show()
        txttelefono.Show()
        txtinicio.Show()
        txttermina.Show()
        lblcodigo.Show()
        lblnombre.Show()
        lbltelefono.Show()
        lblinicio.Show()
        lbltermina.Show()
        Exit Sub
        
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        If txtcodigob.Text = "" Then
            MsgBox("Ingrese Codigo")
        Else
            Me.ClientesTableAdapter.FillBy(Me.Sport_GimDataSet.Clientes, txtcodigob.Text)
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.ClientesTableAdapter.Fill(Me.Sport_GimDataSet.Clientes)
        txtcodigob.Clear()
    End Sub

    
End Class
