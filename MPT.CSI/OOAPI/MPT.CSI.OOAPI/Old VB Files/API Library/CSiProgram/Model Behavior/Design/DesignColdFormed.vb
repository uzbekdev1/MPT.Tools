﻿Option Strict On
Option Explicit On

Imports CSiApiTester.CSiEnumConverter

Public Class DesignColdFormed
    Inherits DesignFrameMetal

#Region "Initialization"
    Public Sub New()
        _codeType = CodeType.ColdFormedSteelFrame
    End Sub
#End Region

#Region "Methods: Interface"
    Public Overrides Function DeleteResults() As Boolean
        ret = SapModel.DesignColdFormed.DeleteResults
        Return retCheck(ret, "SapModel.DesignColdFormed.DeleteResults")
    End Function

    Public Overrides Function StartDesign() As Boolean
        ret = SapModel.DesignColdFormed.StartDesign
        Return retCheck(ret, "SapModel.DesignColdFormed.StartDesign")
    End Function

    Public Overrides Function ResetOverwrites() As Boolean
        ret = SapModel.DesignColdFormed.ResetOverwrites
        Return retCheck(ret, "SapModel.DesignColdFormed.ResetOverwrites")
    End Function

    Public Overrides Function VerifyPassed(ByRef framesFailed As FramesNotPassed) As Boolean
        Dim frameNames() As String = framesFailed.NamesNotPassed.ToArray
        With framesFailed
            ret = SapModel.DesignColdFormed.VerifyPassed(.NumberNotPassed, .NumberFailed, .NumberNotChecked, frameNames)
        End With
        framesFailed.NamesNotPassed = frameNames.ToList()
        retCheck(ret, "SapModel.DesignColdFormed.VerifyPassed")

        Return (framesFailed.NumberNotPassed = 0)
    End Function

    Public Overrides Function VerifySections(ByRef namesDifferentSections As List(Of String)) As Boolean
        Dim numberItems As Integer
        Dim nameSections() As String = namesDifferentSections.ToArray

        ret = SapModel.DesignColdFormed.VerifySections(numberItems, nameSections)

        namesDifferentSections = nameSections.ToList
        retCheck(ret, "SapModel.DesignColdFormed.VerifySections")

        Return (namesDifferentSections.Count = 0)
    End Function

    Public Overrides Function SummaryResults() As DesignResultsMetal
        Dim designResults As New DesignResultsMetal
        With designResults
            Dim numberItems As Integer = .ItemResults.Count
            Dim frameNames() As String = .FrameNames.ToArray
            Dim ratios() As Double = .Ratios.ToArray
            Dim ratiosType() As Integer = .RatiosType.ToArray
            Dim locations() As Double = .Locations.ToArray
            Dim comboNames() As String = .ComboNames.ToArray
            Dim errorSummaries() As String = .ErrorSummaries.ToArray
            Dim warningSummaries() As String = .WarningSummaries.ToArray

            GetSummaryResults(.ItemName, numberItems,
                              frameNames,
                              ratios, ratiosType,
                              locations,
                              comboNames,
                              errorSummaries, warningSummaries,
                              .ItemType)

            For index = 0 To UBound(frameNames)
                designResults.ItemResults.Add(New DesignResultMetal() With {.ComboName = comboNames(index),
                                                                           .ErrorSummary = errorSummaries(index),
                                                                           .FrameName = frameNames(index),
                                                                           .Location = locations(index),
                                                                           .Ratio = ratios(index),
                                                                           .RatioType = CType(ratiosType(index), RatioType),
                                                                           .WarningSummary = warningSummaries(index)
                                                                          }
                                                                      )
            Next
        End With

        Return designResults
    End Function

    ' Set Methods
    Public Overrides Function SetComboStrength(nameLoadCombination As String,
                                     selectLoadCombination As Boolean) As Boolean
        ret = SapModel.DesignColdFormed.SetComboStrength(nameLoadCombination, selectLoadCombination)
        Return retCheck(ret, "SapModel.DesignColdFormed.SetComboStrength")
    End Function

    Public Overrides Function SetAutoSelectNull(itemName As String,
                                      Optional itemType As eItemType = eItemType.Object) As Boolean
        ret = SapModel.DesignColdFormed.SetAutoSelectNull(itemName, ToCSi(itemType))
        Return retCheck(ret, "SapModel.DesignColdFormed.SetAutoSelectNull")
    End Function

    Public Overrides Function SetComboDeflection(nameLoadCombination As String,
                                       selectLoadCombination As Boolean) As Boolean
        ret = SapModel.DesignColdFormed.SetComboDeflection(nameLoadCombination, selectLoadCombination)
        Return retCheck(ret, "SapModel.DesignColdFormed.SetComboDeflection")
    End Function

    Public Overrides Function SetDesignSection(itemName As String,
                                     nameFrame As String,
                                     resetToLastAnalysisSection As Boolean,
                                     Optional itemType As eItemType = eItemType.Object) As Boolean
        ret = SapModel.DesignColdFormed.SetDesignSection(itemName, nameFrame, resetToLastAnalysisSection, ToCSi(itemType))
        Return retCheck(ret, "SapModel.DesignColdFormed.SetDesignSection")
    End Function

    Public Overrides Function SetGroup(nameGroup As String,
                             selectForDesign As Boolean) As Boolean
        ret = SapModel.DesignColdFormed.SetGroup(nameGroup, selectForDesign)
        Return retCheck(ret, "SapModel.DesignColdFormed.SetGroup")
    End Function
#End Region

#Region "Methods: Private"
    ' Interface
    ''' <summary>
    ''' Retrieves the design section for a specified frame object.
    ''' </summary>
    ''' <param name="nameFrame">Name of a frame object with a frame design procedure.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Overrides Function GetDesignSection(nameFrame As String) As String
        Dim nameSection As String = ""

        ret = SapModel.DesignColdFormed.GetDesignSection(nameFrame, nameSection)
        retCheck(ret, "SapModel.DesignColdFormed.GetDesignSection")

        Return nameSection
    End Function

    ' Local
    ''' <summary>
    ''' Retrieves summary results for steel design.
    ''' </summary>
    ''' <param name="Name"></param>
    ''' <param name="NumberItems"></param>
    ''' <param name="FrameName"></param>
    ''' <param name="Ratio"></param>
    ''' <param name="RatioType"></param>
    ''' <param name="Location"></param>
    ''' <param name="ComboName"></param>
    ''' <param name="ErrorSummary"></param>
    ''' <param name="WarningSummary"></param>
    ''' <param name="ItemType"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetSummaryResults(ByVal Name As String,
                                       ByRef NumberItems As Integer,
                                       ByRef FrameName() As String,
                                       ByRef Ratio() As Double,
                                       ByRef RatioType() As Integer,
                                       ByRef Location() As Double,
                                       ByRef ComboName() As String,
                                       ByRef ErrorSummary() As String,
                                       ByRef WarningSummary() As String,
                                       Optional ByVal ItemType As eItemType = eItemType.Object) As Boolean
        ret = SapModel.DesignColdFormed.GetSummaryResults(Name, NumberItems, FrameName, Ratio, RatioType, Location, ComboName, ErrorSummary, WarningSummary, ToCSi(ItemType))
        retCheck(ret, "SapModel.DesignColdFormed.GetSummaryResults")
    End Function

#End Region

End Class
