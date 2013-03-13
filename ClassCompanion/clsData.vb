'Author: Christina Hitz
'Date: 5/2/2012
'Purpose: Handles all database interactions, returns collections

Option Strict On
Option Explicit On


Imports System.Data.OleDb

Public Class clsData

    ' -ADO Objects
    Private mstrCN As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ClassCompanionDB.accdb; Persist Security Info=False;"
    Private mstrSQL As String
    Private mblnIsConnected As Boolean

    'Debugging variables
    Dim mobjLogger As New clsLogger
    Dim mstrLog As String = ("for data write")

    'Table fields for Assignments
    Private mstrAssignmentID As Integer
    Private mstrClassID As Integer
    Private mstrAName As String
    Private mstrNotes As String
    Private mdtmADueDate As Date
    Private mintIsDone As Integer


    'Table fields for Classes
    Private mstrClassNameID As Integer
    Private mstrClassName As String
    Private mstrClassStartTime As String
    Private mstrDateMeets As String

    'Collection of class beans
    Private mClassCollection As Collection
    Private mAssignmentCollection As Collection

    'Assignment Public Properties
    Public Property AssignmentID As Integer
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

    Public Property AName As String
        Get
            Return mstrAName
        End Get
        Set(ByVal value As String)
            mstrAName = value
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



    ' Classes Public properties
    Public Property ClassNameID As Integer
        Get
            Return mstrClassNameID
        End Get
        Set(ByVal value As Integer)
            mstrClassNameID = value
        End Set
    End Property
    Public Property ClassNameClasses As String
        Get
            Return mstrClassName
        End Get
        Set(ByVal value As String)
            mstrClassName = value
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


    'Default constructor
    Public Sub New()

    End Sub

    'Retrieves all classes
    Public Function getClasses() As Collection
        mClassCollection = New Collection


        'Instantiate Connection Class
        Dim objConnection As New OleDbConnection(mstrCN)

        'Create SQL Statement
        mstrSQL = "Select * from Classes"

        'Instantiate Command Class
        Dim objCommand As New OleDbCommand(mstrSQL, objConnection)

        'Open Database
        objCommand.Connection.Open()

        'Instantiate DataReader Class
        Dim objDataReader As OleDbDataReader

        'Execute SQL
        objDataReader = objCommand.ExecuteReader
        'mobjLogger.Log("In classes field count" + objDataReader.FieldCount.ToString)


        'Read SQL results from the DataReader
        Do While (objDataReader.Read)
            ClassNameID = CInt(objDataReader.Item("ClassID"))
            ClassNameClasses = objDataReader.Item("ClassName").ToString
            ClassStartTime = objDataReader.Item("ClassStartTime").ToString
            DateMeets = objDataReader.Item("DateMeets").ToString

            'mobjLogger.Log(ClassNameID.ToString)
            'mobjLogger.Log(ClassNameClasses)
            'mobjLogger.Log(ClassStartTime)
            'mobjLogger.Log(DateMeets)
            Dim classBean As New clsClassBean(ClassNameID, ClassNameClasses, ClassStartTime, DateMeets)
            mClassCollection.Add(classBean)
            'mobjLogger.Log(classBean.dump)


        Loop

        'Close Objects
        objCommand.Dispose()
        objDataReader.Close()
        objConnection.Close()
        objConnection.Dispose()

        Return mClassCollection


    End Function

    'Insert a class to the classes table of the database
    Public Function insertClass(ByVal cBean As clsClassBean) As Boolean

        Dim objConnection As New OleDbConnection(mstrCN)
        objConnection.Open()

        'Define SQL
        mstrSQL = "Insert into Classes ([ClassName], [ClassStartTime], [DateMeets]) values ('" _
        & cBean.ClassName & "','" & cBean.ClassStartTime & "','" & cBean.DateMeets _
         & "');"

        'Instantiate Command
        Dim objCommand As New OleDbCommand(mstrSQL, objConnection)

        'Execute Command Method
        objCommand.ExecuteNonQuery()


        'Close Objects
        objConnection.Close()
        objCommand.Dispose()
        objConnection.Dispose()


        Return True


    End Function


    'Deletes a class from the classes table of the database
    Public Function deleteClass(ByVal cBean As clsClassBean) As Boolean
        ' Enforced referential integrity with cascade delete related records between Class and Assignment tables, based on ClassID
        Dim objConnection As New OleDbConnection(mstrCN)
        objConnection.Open()

        'Define SQL
        mstrSQL = "Delete from Classes where ClassID = " & cBean.ClassNameID

        'Instantiate Command
        Dim objCommand As New OleDbCommand(mstrSQL, objConnection)

        'Execute Command Method
        objCommand.ExecuteNonQuery()

        'Close Objects
        objConnection.Close()
        objCommand.Dispose()
        objConnection.Dispose()


        Return True


    End Function

    'Retrieves all assignments
    Public Function getAssignments() As Collection
        mAssignmentCollection = New Collection
        Dim objConnection As New OleDbConnection(mstrCN)
        'mstrSQL = "Select * from Assignments"
        mstrSQL = "Select AssignmentID, ClassID, AName, Notes, IsDone, ADueDate from Assignments"
        'Instantiate Command Class
        Dim objCommand As New OleDbCommand(mstrSQL, objConnection)
        'Open Database
        objCommand.Connection.Open()

        'Instantiate DataReader Class
        Dim objDataReader As OleDbDataReader

        'Execute SQL
        objDataReader = objCommand.ExecuteReader
        'mobjLogger.Log("In assignments field count" + objDataReader.FieldCount.ToString)


        'Read SQL results from the DataReader
        Do While (objDataReader.Read)

            AssignmentID = CInt(objDataReader.Item("AssignmentID"))
            ClassID = CInt(objDataReader.Item("ClassID"))
            AName = objDataReader.Item("AName").ToString
            Notes = objDataReader.Item("Notes").ToString
            IsDone = CInt((objDataReader.Item("IsDone")))
            ADueDate = CDate(objDataReader.Item("ADueDate"))

            'mobjLogger.Log(AssignmentID.ToString)
            'mobjLogger.Log(ClassID.ToString)
            'mobjLogger.Log(AName)
            'mobjLogger.Log(DueDate)
            'mobjLogger.Log(Notes)

            Dim assignBean As New clsAssignmentBean(AssignmentID, ClassID, AName, Notes, IsDone, ADueDate)
            'mobjLogger.Log(assignBean.dump)

            'appends each assignment to the collection
            mAssignmentCollection.Add(assignBean)

        Loop

        'Close Objects
        objCommand.Dispose()
        objDataReader.Close()
        objConnection.Close()
        objConnection.Dispose()


        Return mAssignmentCollection

    End Function

    'Gets assignments for this classID
    Public Function getAssignmentsForClass(ByVal intClassID As Integer) As Collection
        mAssignmentCollection = New Collection
        Dim objConnection As New OleDbConnection(mstrCN)
        mstrSQL = "Select * from Assignments where Assignments.ClassID =" & intClassID.ToString

        'Instantiate Command Class
        Dim objCommand As New OleDbCommand(mstrSQL, objConnection)
        'Open Database
        objCommand.Connection.Open()

        'Instantiate DataReader Class
        Dim objDataReader As OleDbDataReader

        'Execute SQL
        objDataReader = objCommand.ExecuteReader
        'mobjLogger.Log("In assignments field count" + objDataReader.FieldCount.ToString)


        'Read SQL results from the DataReader
        Do While (objDataReader.Read)

            AssignmentID = CInt(objDataReader.Item("AssignmentID"))
            ClassID = CInt(objDataReader.Item("ClassID"))
            AName = objDataReader.Item("AName").ToString
            Notes = objDataReader.Item("Notes").ToString
            IsDone = CInt(objDataReader.Item("IsDone"))
            ADueDate = CDate(objDataReader.Item("ADueDate"))

            'mobjLogger.Log(AssignmentID.ToString)
            'mobjLogger.Log(ClassID.ToString)
            'mobjLogger.Log(AName)
            'mobjLogger.Log(DueDate)
            'mobjLogger.Log(Notes)

            Dim assignBean As New clsAssignmentBean(AssignmentID, ClassID, AName, Notes, IsDone, ADueDate)
            ' mobjLogger.Log("getAssignmentsForClass " + assignBean.dump)
            mAssignmentCollection.Add(assignBean)

        Loop

        'Close Objects
        objCommand.Dispose()
        objDataReader.Close()
        objConnection.Close()
        objConnection.Dispose()

        Return mAssignmentCollection

    End Function

    'Insert new assignment to database
    Public Function insertAssignment(ByVal cBean As clsAssignmentBean) As Boolean

        'Instantiate Connection
        Dim objConnection As New OleDbConnection(mstrCN)
        objConnection.Open()

        'Create SQL statement
        mstrSQL = "Insert into Assignments ([ClassID], [AName], [Notes], [IsDone], [ADueDate]) values ('" & cBean.ClassID & "','" & cBean.AssignName & "','" &
           cBean.Notes & "','" & cBean.IsDone & "','" & cBean.ADueDate & "')"

        'Instantiate Command
        Dim objCommand As New OleDbCommand(mstrSQL, objConnection)

        'Execute Command Method
        objCommand.ExecuteNonQuery()

        'Close Objects
        objConnection.Close()
        objCommand.Dispose()
        objConnection.Dispose()

        Return True

    End Function

    'Updates an existing assignment in the database
    Public Function updateAssignment(ByVal cBean As clsAssignmentBean) As Boolean

        'Instantiate Connection
        Dim objConnection As New OleDbConnection(mstrCN)
        objConnection.Open()

        'Create SQL statement
        mstrSQL = "Update Assignments Set [ClassID] = '" & cBean.ClassID & "', [AName] = '" & cBean.AssignName & "', [Notes] = '" & cBean.Notes & "', [IsDone] = '" & cBean.IsDone & "', [ADueDate] = '" & cBean.ADueDate & "' Where AssignmentID = " & cBean.AssignID

        'Instantiate Command
        Dim objCommand As New OleDbCommand(mstrSQL, objConnection)

        'Execute Command Method
        objCommand.ExecuteNonQuery()

        'Close Objects
        objConnection.Close()
        objCommand.Dispose()
        objConnection.Dispose()

        Return True

    End Function

    'Delete assignment from database
    Public Function deleteAssignment(ByVal cBean As clsAssignmentBean) As Boolean

        'Instantiate Connection
        Dim objConnection As New OleDbConnection(mstrCN)
        objConnection.Open()

        'Define SQL
        mstrSQL = "Delete from Assignments where AssignmentID = " & cBean.AssignID

        'Instantiate Command
        Dim objCommand As New OleDbCommand(mstrSQL, objConnection)

        'Execute Command Method
        objCommand.ExecuteNonQuery()

        'Close Objects
        objConnection.Close()
        objCommand.Dispose()
        objConnection.Dispose()

        Return True

    End Function

End Class
