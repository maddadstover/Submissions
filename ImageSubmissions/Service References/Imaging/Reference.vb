﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.239
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace Imaging
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="Imaging.ServiceSoap")>  _
    Public Interface ServiceSoap
        
        'CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/HelloWorld", ReplyAction:="*")>  _
        Function HelloWorld(ByVal request As Imaging.HelloWorldRequest) As Imaging.HelloWorldResponse
        
        'CODEGEN: Generating message contract since element name strIDXFileName from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/BuildIdx", ReplyAction:="*")>  _
        Function BuildIdx(ByVal request As Imaging.BuildIdxRequest) As Imaging.BuildIdxResponse
        
        'CODEGEN: Generating message contract since element name sFilePath from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/copyFileToImageRight", ReplyAction:="*")>  _
        Function copyFileToImageRight(ByVal request As Imaging.copyFileToImageRightRequest) As Imaging.copyFileToImageRightResponse
        
        'CODEGEN: Generating message contract since element name sFilePath from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/copyImageFilesToImageRight", ReplyAction:="*")>  _
        Function copyImageFilesToImageRight(ByVal request As Imaging.copyImageFilesToImageRightRequest) As Imaging.copyImageFilesToImageRightResponse
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class HelloWorldRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="HelloWorld", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As Imaging.HelloWorldRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As Imaging.HelloWorldRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute()>  _
    Partial Public Class HelloWorldRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class HelloWorldResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="HelloWorldResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As Imaging.HelloWorldResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As Imaging.HelloWorldResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class HelloWorldResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public HelloWorldResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal HelloWorldResult As String)
            MyBase.New
            Me.HelloWorldResult = HelloWorldResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class BuildIdxRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="BuildIdx", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As Imaging.BuildIdxRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As Imaging.BuildIdxRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class BuildIdxRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public strIDXFileName As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public sPolicyNbr As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=2)>  _
        Public sInsured As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=3)>  _
        Public AppType As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=4)>  _
        Public sFolderType As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=5)>  _
        Public sFlowId As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=6)>  _
        Public sStepId As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=7)>  _
        Public sRefNbr As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=8)>  _
        Public sDocNum As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=9)>  _
        Public sFolder As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=10)>  _
        Public sDrawer As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=11)>  _
        Public sPageDesc As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=12)>  _
        Public sJPEG As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=13)>  _
        Public sXM As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal strIDXFileName As String, ByVal sPolicyNbr As String, ByVal sInsured As String, ByVal AppType As String, ByVal sFolderType As String, ByVal sFlowId As String, ByVal sStepId As String, ByVal sRefNbr As String, ByVal sDocNum As String, ByVal sFolder As String, ByVal sDrawer As String, ByVal sPageDesc As String, ByVal sJPEG As String, ByVal sXM As String)
            MyBase.New
            Me.strIDXFileName = strIDXFileName
            Me.sPolicyNbr = sPolicyNbr
            Me.sInsured = sInsured
            Me.AppType = AppType
            Me.sFolderType = sFolderType
            Me.sFlowId = sFlowId
            Me.sStepId = sStepId
            Me.sRefNbr = sRefNbr
            Me.sDocNum = sDocNum
            Me.sFolder = sFolder
            Me.sDrawer = sDrawer
            Me.sPageDesc = sPageDesc
            Me.sJPEG = sJPEG
            Me.sXM = sXM
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class BuildIdxResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="BuildIdxResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As Imaging.BuildIdxResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As Imaging.BuildIdxResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class BuildIdxResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public BuildIdxResult As Boolean
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal BuildIdxResult As Boolean)
            MyBase.New
            Me.BuildIdxResult = BuildIdxResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class copyFileToImageRightRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="copyFileToImageRight", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As Imaging.copyFileToImageRightRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As Imaging.copyFileToImageRightRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class copyFileToImageRightRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public sFilePath As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public sFileName As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=2)>  _
        Public sPathTo As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=3)>  _
        Public sPDFName As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal sFilePath As String, ByVal sFileName As String, ByVal sPathTo As String, ByVal sPDFName As String)
            MyBase.New
            Me.sFilePath = sFilePath
            Me.sFileName = sFileName
            Me.sPathTo = sPathTo
            Me.sPDFName = sPDFName
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class copyFileToImageRightResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="copyFileToImageRightResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As Imaging.copyFileToImageRightResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As Imaging.copyFileToImageRightResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute()>  _
    Partial Public Class copyFileToImageRightResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class copyImageFilesToImageRightRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="copyImageFilesToImageRight", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As Imaging.copyImageFilesToImageRightRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As Imaging.copyImageFilesToImageRightRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class copyImageFilesToImageRightRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public sFilePath As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public sIdxFileName As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=2)>  _
        Public sPathTo As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=3)>  _
        Public sPDFName As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal sFilePath As String, ByVal sIdxFileName As String, ByVal sPathTo As String, ByVal sPDFName As String)
            MyBase.New
            Me.sFilePath = sFilePath
            Me.sIdxFileName = sIdxFileName
            Me.sPathTo = sPathTo
            Me.sPDFName = sPDFName
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class copyImageFilesToImageRightResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="copyImageFilesToImageRightResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As Imaging.copyImageFilesToImageRightResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As Imaging.copyImageFilesToImageRightResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class copyImageFilesToImageRightResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public copyImageFilesToImageRightResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal copyImageFilesToImageRightResult As String)
            MyBase.New
            Me.copyImageFilesToImageRightResult = copyImageFilesToImageRightResult
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ServiceSoapChannel
        Inherits Imaging.ServiceSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ServiceSoapClient
        Inherits System.ServiceModel.ClientBase(Of Imaging.ServiceSoap)
        Implements Imaging.ServiceSoap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function Imaging_ServiceSoap_HelloWorld(ByVal request As Imaging.HelloWorldRequest) As Imaging.HelloWorldResponse Implements Imaging.ServiceSoap.HelloWorld
            Return MyBase.Channel.HelloWorld(request)
        End Function
        
        Public Function HelloWorld() As String
            Dim inValue As Imaging.HelloWorldRequest = New Imaging.HelloWorldRequest()
            inValue.Body = New Imaging.HelloWorldRequestBody()
            Dim retVal As Imaging.HelloWorldResponse = CType(Me,Imaging.ServiceSoap).HelloWorld(inValue)
            Return retVal.Body.HelloWorldResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function Imaging_ServiceSoap_BuildIdx(ByVal request As Imaging.BuildIdxRequest) As Imaging.BuildIdxResponse Implements Imaging.ServiceSoap.BuildIdx
            Return MyBase.Channel.BuildIdx(request)
        End Function
        
        Public Function BuildIdx(ByVal strIDXFileName As String, ByVal sPolicyNbr As String, ByVal sInsured As String, ByVal AppType As String, ByVal sFolderType As String, ByVal sFlowId As String, ByVal sStepId As String, ByVal sRefNbr As String, ByVal sDocNum As String, ByVal sFolder As String, ByVal sDrawer As String, ByVal sPageDesc As String, ByVal sJPEG As String, ByVal sXM As String) As Boolean
            Dim inValue As Imaging.BuildIdxRequest = New Imaging.BuildIdxRequest()
            inValue.Body = New Imaging.BuildIdxRequestBody()
            inValue.Body.strIDXFileName = strIDXFileName
            inValue.Body.sPolicyNbr = sPolicyNbr
            inValue.Body.sInsured = sInsured
            inValue.Body.AppType = AppType
            inValue.Body.sFolderType = sFolderType
            inValue.Body.sFlowId = sFlowId
            inValue.Body.sStepId = sStepId
            inValue.Body.sRefNbr = sRefNbr
            inValue.Body.sDocNum = sDocNum
            inValue.Body.sFolder = sFolder
            inValue.Body.sDrawer = sDrawer
            inValue.Body.sPageDesc = sPageDesc
            inValue.Body.sJPEG = sJPEG
            inValue.Body.sXM = sXM
            Dim retVal As Imaging.BuildIdxResponse = CType(Me,Imaging.ServiceSoap).BuildIdx(inValue)
            Return retVal.Body.BuildIdxResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function Imaging_ServiceSoap_copyFileToImageRight(ByVal request As Imaging.copyFileToImageRightRequest) As Imaging.copyFileToImageRightResponse Implements Imaging.ServiceSoap.copyFileToImageRight
            Return MyBase.Channel.copyFileToImageRight(request)
        End Function
        
        Public Sub copyFileToImageRight(ByVal sFilePath As String, ByVal sFileName As String, ByVal sPathTo As String, ByVal sPDFName As String)
            Dim inValue As Imaging.copyFileToImageRightRequest = New Imaging.copyFileToImageRightRequest()
            inValue.Body = New Imaging.copyFileToImageRightRequestBody()
            inValue.Body.sFilePath = sFilePath
            inValue.Body.sFileName = sFileName
            inValue.Body.sPathTo = sPathTo
            inValue.Body.sPDFName = sPDFName
            Dim retVal As Imaging.copyFileToImageRightResponse = CType(Me,Imaging.ServiceSoap).copyFileToImageRight(inValue)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function Imaging_ServiceSoap_copyImageFilesToImageRight(ByVal request As Imaging.copyImageFilesToImageRightRequest) As Imaging.copyImageFilesToImageRightResponse Implements Imaging.ServiceSoap.copyImageFilesToImageRight
            Return MyBase.Channel.copyImageFilesToImageRight(request)
        End Function
        
        Public Function copyImageFilesToImageRight(ByVal sFilePath As String, ByVal sIdxFileName As String, ByVal sPathTo As String, ByVal sPDFName As String) As String
            Dim inValue As Imaging.copyImageFilesToImageRightRequest = New Imaging.copyImageFilesToImageRightRequest()
            inValue.Body = New Imaging.copyImageFilesToImageRightRequestBody()
            inValue.Body.sFilePath = sFilePath
            inValue.Body.sIdxFileName = sIdxFileName
            inValue.Body.sPathTo = sPathTo
            inValue.Body.sPDFName = sPDFName
            Dim retVal As Imaging.copyImageFilesToImageRightResponse = CType(Me,Imaging.ServiceSoap).copyImageFilesToImageRight(inValue)
            Return retVal.Body.copyImageFilesToImageRightResult
        End Function
    End Class
End Namespace
