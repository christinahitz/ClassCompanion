' Author: Christina Hitz
' Purpose: Create a new class or access an existing class
' Date: 2/25/2012


Option Strict On
Option Explicit On

Imports System
Imports System.IO
Imports System.Text
Imports System.Data.Common
Imports System.Data.OleDb


Public Class frmClass
    Inherits System.Windows.Forms.Form


    'Module level variables 
    Dim mcolAssignmentCollection As Collection
    Dim mcolClassCollection As Collection
    Dim mobjClassbean As New clsClassBean
    Dim mobjLogger As New clsLogger
    Dim mstrLog As String = ("for data write")
    Dim mobjdata As New clsData
    Dim mstrClassName As String
    Dim mstrTimeClassStarts As String
    Dim mstrDateMeets As String
    Dim mstrClassID As String
    Dim mButtonArrayList As New ArrayList
    Dim mI As Integer = 0
    Dim mobjNewPanel As Panel
    Dim mstrButtonName As String
    Dim mblnDoExit As Boolean


    ' Public Properites
    Public Property ClassName() As String
        Get
            Return mstrClassName
        End Get
        Set(ByVal value As String)
            mstrClassName = value
        End Set
    End Property

    Public Property ClassID() As String
        Get
            Return mstrClassID
        End Get
        Set(ByVal value As String)
            mstrClassID = value
        End Set
    End Property

    Public Property TimeClassStarts() As String
        Get
            Return mstrTimeClassStarts
        End Get
        Set(ByVal value As String)
            mstrTimeClassStarts = value
        End Set
    End Property

    Public Property DateMeets() As String
        Get
            Return mstrDateMeets
        End Get
        Set(ByVal value As String)
            mstrDateMeets = value
        End Set
    End Property



    Private Sub btnNewClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewClass.Click
        'Sets visibility of controls when button new class is clicked
        txtClassName.Visible = True
        txtClassName.Focus()
        btnAddClass.Visible = True
        lblDateMeet.Visible = True
        lblNewClass.Visible = True
        txtDayMeet.Visible = True
        txtTimeClassStarts.Visible = True
        lblTimeClassStarts.Visible = True
        cboDeleteClass.Visible = False
        btnDelete.Visible = False

    End Sub

    Private Sub btnAddClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddClass.Click

        ' assemble mClassbean
        mobjClassbean.ClassName = txtClassName.Text
        mobjClassbean.ClassStartTime = txtTimeClassStarts.Text
        mobjClassbean.DateMeets = txtDayMeet.Text

        'writes to the database
        mobjdata.insertClass(mobjClassbean)

        'set visibility to lables and textboxes
        txtClassName.Visible = False
        txtClassName.Clear()
        btnAddClass.Visible = False
        lblDateMeet.Visible = False
        lblNewClass.Visible = False
        txtDayMeet.Visible = False
        txtDayMeet.Clear()
        txtTimeClassStarts.Visible = False
        txtTimeClassStarts.Clear()
        lblTimeClassStarts.Visible = False


        'Update screen to show the new class that is added
        Call frmClass_Load(Nothing, Nothing)

    End Sub


    Private Sub btnClassExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClassExit.Click
        Me.Close()

    End Sub

    Private Sub btnClass1_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        'Get name of control clicked
        Dim btnClass As Button = DirectCast(sender, Button)

        'Attempt to find in the mClassCollection the class that matches the clicked button text
        For Each classBean As clsClassBean In mcolClassCollection
            'If matches, pull all the classes assignments
            If classBean.ClassName = btnClass.Text.ToString Then
                'mobjLogger.Log("found className  " + classBean.dump)

                'If matches, pull all the classes assignments
                Me.mcolAssignmentCollection = Me.mobjdata.getAssignmentsForClass(classBean.ClassNameID)

                'Create the assignment form and feed it the data class and the current class reference
                Dim newAssign As frmAssignment
                newAssign = New frmAssignment(mobjdata, classBean)
                'get ready to close this form
                mblnDoExit = False
                newAssign.Show()

            End If

        Next

        'mobjLogger.Log("for this class assignments before closing here ")
        'Close this form
        Me.Close()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'In database relationship between Assignments and Classes exists that enforces referential integrity and cascades delete related records
        'Pull the referenced mClassbean
        'collections start at one, selected index starts at zero
        mobjClassbean = CType(mcolClassCollection.Item(cboDeleteClass.SelectedIndex + 1), clsClassBean)

        'delete from database
        mobjdata.deleteClass(mobjClassbean)

        'Remove current selection item from the combo box
        cboDeleteClass.Items.Remove(cboDeleteClass.SelectedIndex)

        'set visibility to labels and textboxes
        txtClassName.Visible = False
        txtClassName.Clear()
        btnAddClass.Visible = False
        lblDateMeet.Visible = False
        lblNewClass.Visible = False
        txtDayMeet.Visible = False
        txtDayMeet.Clear()
        txtTimeClassStarts.Visible = False
        txtTimeClassStarts.Clear()
        lblTimeClassStarts.Visible = False
        cboDeleteClass.Visible = False
        btnDelete.Visible = False

        'Update screen 
        Call frmClass_Load(Nothing, Nothing)

    End Sub

    Private Sub frmClass_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'This form will close in two ways: opening frmAssignments from a button click and clicking the red x.
        'Application is terminated on the click of the red x
        'see btnClass1_Click for doExit equals false, see frmClass_Load for reset to true
        If mblnDoExit = True Then
            Application.Exit()
        End If

    End Sub

    Public Sub frmClass_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mblnDoExit = True
        'get all classes
        Me.mcolClassCollection = mobjdata.getClasses()
        'mobjLogger.Log("class collection logger " + mClassCollection.Count.ToString)

        'clear combo box
        cboDeleteClass.Items.Clear()

        For Each classBean As clsClassBean In mcolClassCollection
            'Walk through class collection and create button collection
            Dim newButton As New Button
            mI = Me.mButtonArrayList.Count

            'assign class name to the button name, used to populate combo box
            mstrButtonName = classBean.ClassName
            'assign button name to the button text
            newButton.Text = mstrButtonName
            'add button to button collection
            mButtonArrayList.Add(newButton)
            mI += 1

            'Populate combo box
            cboDeleteClass.Items.Add(mstrButtonName)
            cboDeleteClass.DisplayMember = mstrButtonName

        Next
        CreateButtons()
        'DoubleBuffered = True
        mButtonArrayList.Clear()
    End Sub



    Private Sub CreateButtons()
        'remove panel to repaint buttons
        Controls.Remove(mobjNewPanel)
        mobjNewPanel = New System.Windows.Forms.Panel()

        ' Offsets
        Dim y As Integer = 10
        Dim x As Integer = 50

        mI = 0

        'Walk through the button collection which contains the button objects
        For Each newButton As Button In mButtonArrayList
            'set height and width of each button
            newButton.Width = 150
            newButton.Height = 40

            'every other button position on panel

            If mI Mod 2 = 0 Then
                y += newButton.Height + 25
                x = 0
            End If
            newButton.Top = y
            newButton.Left = 25 + (x * (newButton.Width + 25))
            x += 1

            'set button appearance
            newButton.BackgroundImage = My.Resources.buttonBG
            newButton.FlatStyle = FlatStyle.Popup
            newButton.ForeColor = Color.White
            newButton.Font = New Font("Lucida Bright", 14.25)
            newButton.BackgroundImageLayout = ImageLayout.Stretch

            'add a click handler to the newly created button
            AddHandler newButton.Click, AddressOf btnClass1_Click

            'add button to panel
            mobjNewPanel.Controls.Add(newButton)

            'increment counter
            mI += 1
        Next

        'set up anchor
        Me.mobjNewPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
         Or System.Windows.Forms.AnchorStyles.Right Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)

        'panel appearance
        Me.mobjNewPanel.BackColor = System.Drawing.Color.Transparent
        Me.mobjNewPanel.Location = New System.Drawing.Point(74, 59)
        Me.mobjNewPanel.Name = "NewPanel"
        Me.mobjNewPanel.Size = New System.Drawing.Size(1000, 400)
        Me.mobjNewPanel.TabIndex = 33
        'attach the panel to the form
        Me.Controls.Add(Me.mobjNewPanel)


    End Sub
    
  
    Private Sub btnDeleteClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteClass.Click
        'set visibility to lables and textboxes
        txtClassName.Visible = False
        txtClassName.Clear()
        btnAddClass.Visible = False
        lblDateMeet.Visible = False
        lblNewClass.Visible = False
        txtDayMeet.Visible = False
        txtDayMeet.Clear()
        txtTimeClassStarts.Visible = False
        txtTimeClassStarts.Clear()
        lblTimeClassStarts.Visible = False
        cboDeleteClass.Visible = True
        btnDelete.Visible = True
    End Sub
End Class



