Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand
Public Class FrmLogin


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim coneccion As New SqlClient.SqlConnection("Data Source=(localdb)\Servidor;Initial Catalog=proyecto2018;Integrated Security=True")

        Dim DR As SqlDataReader
        ' Dim DA As SqlDataAdapter
        Dim DS As New DataSet
        'Dim DT As DataTable

        Try

            coneccion.Open()
            Dim CMD As New SqlCommand(" Select * from TBL_USUARIO where USUARIO = '" & Me.TextBox1.Text & "'" & " and Clave 
='" & Me.TextBox2.Text & " ' ", coneccion)
            DR = CMD.ExecuteReader
            If (DR.HasRows = True) Then
                MessageBox.Show("Bienvenido a Economic-Cars")
                Me.Hide()
                FrmMenu.Show()

            ElseIf (DR.HasRows = False) Then
                MessageBox.Show("El usuario o la contraseña son incorrectos")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox1.Focus()

            End If
        Catch exoledb As Exception
        Finally
            coneccion.Close()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cancel As Integer

        If (MsgBox("¿Esta seguro de salir de Login?", vbCritical + vbYesNo) = vbYes) Then
            End
        Else
            cancel = 1
        End If
    End Sub
End Class

