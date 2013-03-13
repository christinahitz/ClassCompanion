'Author: Christina Hitz
'Date: 5/2/2012
'Purpose: A single place to hold an class in an Object, so it can be used by the rest of the application
'Represents a database row.
Option Strict On
Option Explicit On


Public Class clsClassBean
    'Table fields for Classes
    Private mstrClassNameID As Integer
    Private mstrClassName As String
    Private mstrClassStartTime As String
    Private mstrDateMeets As String

    'Public Properties
    Public Property ClassName As String
        Get
            Return mstrClassName
        End Get
        Set(ByVal value As String)
            mstrClassName = value
        End Set
    End Property
    Public Property ClassNameID As Integer
        Get
            Return mstrClassNameID
        End Get
        Set(ByVal value As Integer)
            mstrClassNameID = value
        End Set
    End Property

    Public Property ClassStartTime As String
        Get
            Return mstrClassStartTime
        End Get
        Set(ByVal value As String)
            mstrClassStartTime = value
        End Set
    End Property

    Public Property DateMeets As String
        Get
            Return mstrDateMeets
        End Get
        Set(ByVal value As String)
            mstrDateMeets = value
        End Set
    End Property

    'Default Constructor
    Public Sub New()
        mstrClassName = String.Empty
        mstrClassStartTime = String.Empty
        mstrDateMeets = String.Empty
        mstrClassNameID = Nothing
    End Sub


    'Overloaded Constructor
    Public Sub New(ByVal intClassId As Integer, ByVal strClassName As String, ByVal strClassStart As String, ByVal strDateMeets As String)
        mstrClassName = strClassName
        mstrClassStartTime = strClassStart
        mstrDateMeets = strDateMeets
        mstrClassNameID = intClassId
    End Sub

    'for debugging
    Public Function dump() As String
        Return ("Classes " + ClassNameID.ToString + " " + ClassName + " " + ClassStartTime + " " + DateMeets)
    End Function

End Class
