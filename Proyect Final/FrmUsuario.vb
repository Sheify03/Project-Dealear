Imports System.Data.SqlClient
Public Class FrmUsuario
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim conecion As New SqlClient.SqlConnection("Data Source=(localdb)\Servidor;Initial Catalog=proyecto2018;Integrated Security=True")
    Sub MOSTRAR()
        Dim cmd As New SqlClient.SqlCommand("Select *  FROM TBL_USUARIO where codigo='" & TextBox1.Text & "'", conecion)
        Dim DA As New SqlDataAdapter(cmd)
        Dim DR As SqlClient.SqlDataReader
        Dim ds As New DataSet
        DA.Fill(ds, "TBL_USUARIO")
        DataGridView1.DataSource = ds.Tables("TBL_USUARIO")
        conecion.Open()
        DR = cmd.ExecuteReader
        If DR.Read Then
            TextBox1.Clear()
            TextBox1.Focus()

        Else
            MsgBox("Este codigo no esta en el sistema ")

        End If
        conecion.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MOSTRAR()
    End Sub

    Sub nuevo()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        DataGridView1.DataSource = CloseReason.UserClosing
        TextBox1.Focus()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New SqlClient.SqlCommand("Insert Into TBL_USUARIO (codigo,usuario,CLAVE)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')", conecion)
        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Then
            MsgBox("DEBE LLENAR TODOS LOS CAMPOS PARA REGISTRAR")
        Else
            conecion.Open()
            cmd.ExecuteNonQuery()
            conecion.Close()
            MsgBox("REGISTRO GUARDADO")
            nuevo()

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cmd As New SqlClient.SqlCommand("delete from TBL_usuario Where codigo='" & TextBox1.Text & "'", conecion)
        If TextBox1.Text = "" Then
            MsgBox("DEBE INGRESAR EL ID PARA BORRAR EL REGISTRO")

        Else
            conecion.Open()
            cmd.ExecuteNonQuery()
            conecion.Close()
            nuevo()
            MsgBox("EL REGISTRO SE HA ELIMINADO EXITOSAMENTE")

        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        DataGridView1.DataSource = CloseReason.UserClosing
    End Sub
End Class