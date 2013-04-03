Public Class Bienvenida
    Dim contador As Byte = 4
    Private Sub Bienvenida_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Me.Opacity -= 0.07
            If Me.Opacity = 0.0 Then
                Me.Hide()
                Inicioform.Show()
                Timer1.Enabled = False
            End If
        Else
            ProgressBar1.Value += 2
            If ProgressBar1.Value = contador Then
                Label1.Text = "INICIANDO ......."
            Else
                If ProgressBar1.Value = contador + 16 Then
                    Label1.Text = ""
                    contador += 20
                End If
            End If
            End If
    End Sub
End Class