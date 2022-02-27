Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim n, i, fac, acum As Integer


        Try
            n = Val(tbxNum.Text)
            acum = 0

            If (n > 0) Then
                fac = 1
                For i = 1 To n Step 1
                    fac = fac * i
                Next
                tbxFact.Text = (fac.ToString)
                For i = 0 To n Step 1
                    lvw.Items.Add(i)
                    If (i Mod 4 = 0) Then
                        acum = acum + 1
                    End If
                Next
                tbxMult.Text = (acum.ToString)
            Else
                MsgBox("El número ingresado debe ser positivo", MsgBoxStyle.Information, "ADVERTENCIA")
            End If
        Catch ex As Exception

        End Try



    End Sub
End Class
