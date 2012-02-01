Imports System.Data.SqlClient
Public Class colSubmission
    Inherits Collections.CollectionBase
    Default Public ReadOnly Property Item(ByVal Index As Integer) As clsSubmission
        Get
            Return CType(List(Index), clsSubmission)
        End Get
    End Property

    Public Function LoadSubmissionsForImaging(ByRef conn As SqlConnection) As Integer
        Dim comm As New SqlCommand("select * from siu_v_listneedsimaging", conn)
        Dim rs As SqlDataReader

        With comm
            .CommandType = CommandType.Text
            rs = .ExecuteReader
            .Dispose()
        End With

        Do While rs.Read
            Dim mySub As New clsSubmission
            With mySub
                .ActionID = rs("actionid")
                .AgentID = rs("agentid")
                .Insured = rs("dbaname")
                .NewOrRenewal = rs("NewOrRenewal")
                .PreviousPolicyID = rs("PreviousPolicyID")
                If .PreviousPolicyID = "" Then .PreviousPolicyID = "TBA"
                .SubmissionID = rs("submissionid")
                .TeamID = rs("teamid")
                .Underwriter = rs("underwriter")
            End With
            List.Add(mySub)
        Loop
        rs.Close()
        Return List.Count
    End Function
    Public Function ImageSubmissions(ByRef conn As SqlConnection) As String
        Try
            Dim sMessage As String = ""
            Dim mysub As clsSubmission
            For Each mysub In List
                sMessage = mysub.Image(conn)
                If Len(Trim(sMessage)) > 0 Then Return sMessage
            Next
            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

End Class
