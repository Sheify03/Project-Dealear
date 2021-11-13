Imports System.Data.SqlClient
Public Class FrmCuentas_pagar
    Private Sub FrmCuentas_pagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim conecion As New SqlConnection("Data Source=(localdb)\Servidor;Initial Catalog=proyecto2018_;Integrated Security=True")
    Dim imagen As String

    Sub MOSTRAR()
        Dim cmd As New SqlClient.SqlCommand("Select *  FROM TBL_CuentasApagar where cedula='" & TextBox3.Text & "'", conecion)
        Dim DA As New SqlDataAdapter(cmd)
        Dim DR As SqlClient.SqlDataReader
        Dim ds As New DataSet
        DA.Fill(ds, "TBL_CuentasApagar")
        DataGridView1.DataSource = ds.Tables("TBL_CuentasApagar")
        conecion.Open()
        DR = cmd.ExecuteReader
        If DR.Read Then

            TextBox1.Clear()
            TextBox1.Focus()

        Else
            MsgBox("ESTA DEUDA NO ESTA REGISTRADA EN EL SISTEMA ")
        End If
        conecion.Close()
    End Sub
    Sub nuevo()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        MaskedTextBox1.Clear()
        DataGridView1.DataSource = CloseReason.UserClosing
        PictureBox1.Dispose()
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New SqlClient.SqlCommand("Insert Into TBL_CuentasApagar (nombre,apellido,cedula,Descripcion,telefono,direccion,imagen)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & MaskedTextBox1.Text & "','" & TextBox5.Text & "','" & imagen & "')", conecion)
        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Or (MaskedTextBox1.Text = "") Or (imagen = "") Or (TextBox3.Text = "") Then
            MsgBox("DEBE LLENAR TODOS LOS CAMPOS PARA REGISTRAR")

        Else
            conecion.Open()
            cmd.ExecuteNonQuery()
            conecion.Close()
            MsgBox("REGISTRO GUARDADO")
            nuevo()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MOSTRAR()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        nuevo()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cmd As New SqlClient.SqlCommand("delete from TBL_CuentasApagar Where cedula='" & TextBox3.Text & "'", conecion)
        If TextBox3.Text = "" Then
            MsgBox("DEBE INGRESAR LA CEDULA DEL PRESTAMISTA PARA BORRAR EL REGISTRO")

        Else
            conecion.Open()
            cmd.ExecuteNonQuery()
            conecion.Close()
            nuevo()
            MsgBox("EL REGISTRO DEL PRESTAMISTA SE HA ELIMINADO EXITOSAMENTE")

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Me.OpenFileDialog1.ShowDialog()
            If Me.OpenFileDialog1.FileName <> "" Then
                imagen = OpenFileDialog1.FileName
                Dim largo As Integer = imagen.Length()
                Dim imagen2 As String
                imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(imagen), largo - 2, largo))
                If imagen2 <> "gif" And imagen2 <> "bmp" And imagen2 <> "jpg" And imagen2 <> "jpeg" And imagen2 <> "gif" And imagen2 <> "bmp" And imagen2 <> "jpeg" Then
                    imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(imagen), largo - 3, largo))
                    If imagen2 <> "jpeg" And imagen2 <> "JPEG" And imagen2 <> "log1" Then MsgBox("formato de imagen no es valido,seleccione otra") : Exit Sub
                    If imagen2 <> "log1" Then Exit Sub
                End If
                PictureBox1.Load(imagen)
            End If
        Catch ex As Exception
            PictureBox1.Load(Application.StartupPath & "\Signo-de-interrogacion.jpg")
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            Me.OpenFileDialog1.ShowDialog()
            If Me.OpenFileDialog1.FileName <> "" Then
                imagen = OpenFileDialog1.FileName
                Dim largo As Integer = imagen.Length()
                Dim imagen2 As String
                imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(imagen), largo - 2, largo))
                If imagen2 <> "gif" And imagen2 <> "bmp" And imagen2 <> "jpg" And imagen2 <> "jpeg" And imagen2 <> "gif" And imagen2 <> "bmp" And imagen2 <> "jpeg" Then
                    imagen = CStr(Microsoft.VisualBasic.Mid(RTrim(imagen), largo - 3, largo))
                    If imagen2 <> "jpeg" And imagen2 <> "JPEG" And imagen2 <> "log1" Then MsgBox("formato de imagen no es valido,seleccione otra") : Exit Sub
                    If imagen2 <> "log1" Then Exit Sub
                End If
                PictureBox1.Load(imagen)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class