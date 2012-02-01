Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Public Class clsSubmission
#Region "Local Variables"

#End Region
#Region "Properties"
    Public Property ActionID As Integer
    Public Property PreviousPolicyID As String
    Public Property SubmissionID As Integer
    Public Property Insured As String
    Public Property AgentID As String
    Public Property NewOrRenewal As String
    Public Property TeamID As String
    Public Property Underwriter As String

 
#End Region
#Region "Methods"
    Public Function Image(ByRef conn As SqlConnection) As String
        Try
            Dim FlowID As String = ""
            Dim StepID As String = ""
            Select Case TeamID
                Case "903"
                    FlowID = "49"
                    StepID = "4"
                Case "922"
                    FlowID = "42"
                    StepID = "15"
                Case "923"
                    FlowID = "44"
                    StepID = "118"
                Case "947"
                    FlowID = "46"
                    StepID = "3"
                Case "909"
                    FlowID = "44"
                    StepID = "66"
            End Select

            Dim sFilePath As String = "\\spartacus\sys1\temp"
            Dim sFileName As String = CStr(SubmissionID) & ".idx"
            Dim sWholePath As String = sFilePath & "\" & sFileName

            If File.Exists(sWholePath) Then File.Delete(sWholePath)

            Dim s As New Imaging.ServiceSoapClient


            Dim strExportPath As String = "c:\temp\"
            Dim ImagePathTo As String = "r:\submissions\"

            Dim _strFileName As String = "r:\submissions\" & TeamID & ".pdf"

            Dim strIDXFileName As String = PreviousPolicyID & ".pdf"

            s.copyFileToImageRight(strExportPath, strIDXFileName, ImagePathTo, _strFileName)

            If s.BuildIdx(strIDXFileName, PreviousPolicyID, Insured, "QUS", "2", FlowID, StepID, "", "", "", TeamID, "", "", "M") = False Then
                Return "Nope"
            End If

            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    
#End Region
End Class

