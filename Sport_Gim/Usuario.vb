Public Class Usuario
    Dim intentos As Integer = 0
    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        If txtusuario.Text = "Jerson Romero" And txtcontra.Text = "1234" Then
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("Datos Incorectos")
            txtusuario.Clear()
            txtcontra.Clear()
            intentos = intentos + 1
            If intentos = 3 Then
                MsgBox("Sistema Bloqueado")
                End
            End If
        End If
    End Sub

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class