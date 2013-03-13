'Author: Christina Hitz
'Date: 5/2/2012
'Purpose: A single place to hold an assignment in an Object, so it can be used by the rest of the application

Option Strict On
Option Explicit On


Public Class clsAssignmentBean

    'Table fields for Assignments
    Private mstrAssignmentID As Integer
    Private mstrClassID As Integer
    Private mstrAName As String
    Private mstrNotes As String
    Private mintIsDone As Integer
    Private mdtmADueDate As Date

    'Public Properties
    Public Property AssignName As String
        Get
            Return mstrAName
        End Get
        Set(ByVal value As String)
            mstrAName = value
        End Set
    End Property

    Public Property AssignID As Integer
        Get
            Return mstrAssignmentID
        End Get
        Set(ByVal value As Integer)
            mstrAssignmentID = value
        End Set
    End Property

    Public Property ClassID As Integer
        Get
            Return mstrClassID
        End Get
        Set(ByVal value As Integer)
            mstrClassID = value
        End Set
    End Property

    Public Property Notes As String
        Get
            Return mstrNotes
        End Get
        Set(ByVal value As String)
            mstrNotes = value
        End Set
    End Property

    Public Property IsDone As Integer
        Get
            Return mintIsDone
        End Get
        Set(ByVal value As Integer)
            mintIsDone = value
        End Set
    End Property

    Public Property ADueDate As Date
        Get
            Return mdtmADueDate
        End Get
        Set(ByVal value As Date)
            mdtmADueDate = value
        End Set
    End Property

    'Default Constructor

    Public Sub New()
        mstrAssignmentID = Nothing
        mstrClassID = Nothing
        mstrAName = String.Empty
        mstrNotes = String.Empty
        mdtmADueDate = CDate(DateString)

    End Sub

    'Overloaded Constructor accepts assignment name and class name
    Public Sub New(ByVal intAssignID As Integer, ByVal intClassID As Integer, ByVal strAName As String, ByVal strNotes As String, ByVal intIsDone As Integer, ByVal dtmADueDate As Date)
        mstrAssignmentID = intAssignID
        mstrClassID = intClassID
        mstrAName = strAName
        mstrNotes = strNotes
        mintIsDone = intIsDone
        mdtmADueDate = dtmADueDate

    End Sub

    'Used for debugging
    Public Function dump() As String
        Return ("Assignment Bean " + AssignID.ToString + " " + ClassID.ToString + " " + AssignName + " " + Notes + " Is done " + IsDone.ToString + " Date Due with date picker is " + CStr(ADueDate))
    End Function

    'Used for debugging / adapted for HTML assignment reporting
    Public Function prettyPrint() As String

        Dim yesNo As String
        If IsDone = 1 Then
            yesNo = "Yes"
        Else
            yesNo = "No"
        End If
        Return ("Assignment " + AssignName + " is due on  " + CStr(ADueDate) + " &nbsp&nbsp Assignment notes: " + Notes + "  &nbsp&nbsp Assignment is done: " + yesNo)

    End Function
End Class
