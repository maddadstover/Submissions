Imports System.Data.SqlClient
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conn As New SqlConnection("uid=sa;pwd=bambi;data source=el-cid;initial catalog=submissions")
        conn.Open()

        Dim sublist As New colSubmission

        MsgBox(sublist.LoadSubmissionsForImaging(conn))

        MsgBox(sublist.ImageSubmissions(conn))

        conn.Close()
        End
    End Sub
End Class
