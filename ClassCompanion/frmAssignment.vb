'Author: Christina Hitz
'Date: 5/2/2012
'Purpose: Show assignments information for specified class

Option Strict On
Option Explicit On


Public Class frmAssignment
    'Module level variables
    Dim mobjdata As clsData
    Dim mobjClassbean As clsClassBean
    Dim mobjAssignbean As clsAssignmentBean
    Dim mcolAssignmentCollection As Collection

    'Used during debugging to write to a file
    Dim mobjLogger As New clsLogger

    'Used to go to latest record(assignment) after a deletion
    Dim mintApointer As New Integer

    'Used to determine if saving assignment as an update or as a new record
    Dim mblnAddMode As Boolean

    'Handle form closing, goes back to class form, overloads standard form closing
    Private Sub frmAssignment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim newForm As frmClass
        newForm = New frmClass()
        newForm.Show()

    End Sub


    Private Sub frmAssignment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        mblnAddMode = False
        mobjAssignbean = New clsAssignmentBean
        'Populate Class name label
        lblClassName.Text = mobjClassbean.ClassName + " meets on " + mobjClassbean.DateMeets + " at " + mobjClassbean.ClassStartTime
        'objAssign.Assignements(mstrClassName)
        Me.mcolAssignmentCollection = Me.mobjdata.getAssignmentsForClass(mobjClassbean.ClassNameID)

        'Check for no assignments
        If mcolAssignmentCollection.Count = 0 Then
            'go to add mode
            mblnAddMode = True
        End If
        mintApointer = 1

        'Call DrawBean sub
        DrawBean()
        'For Each assignBean As clsAssignmentBean In mAssignmentCollection
        '    'mobjLogger.Log("draw assignments " + assignBean.dump)
        '    i += 10
        'Next
    End Sub
    'Gathers data to be written to the database
    Public Sub GatherBean()
        mobjAssignbean.AssignName = txtAssignName.Text
        mobjAssignbean.Notes = txtNotes.Text
        mobjAssignbean.ADueDate = dtpADueDate.Value
        'check button already set the assignbean.IsDone
        mobjAssignbean.ClassID = mobjClassbean.ClassNameID


    End Sub

    'Writes data into the visual controls and determines which controls should be visible
    Public Sub DrawBean()
        If mcolAssignmentCollection.Count = 0 Then
            txtAssignName.Text = String.Empty
            txtNotes.Text = String.Empty
            lblPointerView.Text = "no assignments"
            chkAssignDone.Checked = False
            btnNext.Visible = False
            btnPrior.Visible = False
            btnDelete.Visible = False
        Else
            ' Extract this bean at intApointer
            mobjAssignbean = CType(mcolAssignmentCollection.Item(mintApointer), clsAssignmentBean)
            'mobjLogger.Log("DrawBean " + assignbean.dump)
            txtAssignName.Text = mobjAssignbean.AssignName
            txtNotes.Text = mobjAssignbean.Notes
            dtpADueDate.Value = mobjAssignbean.ADueDate

            If mobjAssignbean.IsDone = 0 Then
                chkAssignDone.Checked = False
            Else
                chkAssignDone.Checked = True
            End If

            'shows which assignment record currently on
            lblPointerView.Text = mintApointer.ToString + " of " + mcolAssignmentCollection.Count.ToString
            'Disables next and prior if not enough records to make them needed
            If mcolAssignmentCollection.Count = 1 Then
                btnNext.Visible = False
                btnPrior.Visible = False
            Else
                btnNext.Visible = True
                btnPrior.Visible = True
            End If
            btnDelete.Visible = True

        End If




    End Sub
    'Passing in data, access object and current class
    Public Sub New(ByVal data As clsData, ByVal classBean As clsClassBean)
        'Windows needs this to paint the form since we are handling the form creation
        InitializeComponent()
        Me.mobjdata = data
        Me.mobjClassbean = classBean

    End Sub

    'Handles the next button click so the user can scroll through all assignments for the class
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        mintApointer += 1
        btnAdd.Visible = True

        If mintApointer > mcolAssignmentCollection.Count Then
            mintApointer = mcolAssignmentCollection.Count
        End If
        mblnAddMode = False
        lblAction.Text = String.Empty
        DrawBean()
    End Sub

    'Handles the prior button click so user can scroll through all assignments for the class
    Private Sub btnPrior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrior.Click
        mintApointer -= 1

        btnAdd.Visible = True
        If mintApointer = 0 Then
            mintApointer = 1
        End If
        mblnAddMode = False
        lblAction.Text = String.Empty
        DrawBean()
    End Sub

    'Handles the add button click
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        mblnAddMode = True
        'hide buttons for adding and deleting
        btnAdd.Visible = False
        btnDelete.Visible = False
        'Clears input fields to make them ready for a new assignment to be added
        txtAssignName.Text = String.Empty
        txtNotes.Text = String.Empty
        lblAction.Text = String.Empty
        chkAssignDone.Checked = False
        dtpADueDate.Value = CDate(DateString)
        'Give focus to the assignment name textbox
        txtAssignName.Focus()
    End Sub



    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Declare variables
        Dim intLen As Integer
        Dim strTrim As String
        'strTrim is the trimmed assignment name to ensure valid entry
        strTrim = txtAssignName.Text.Trim
        'intLen is the length of that trimmed string
        intLen = strTrim.Length
        If intLen = 0 Then
            lblAction.Text = "Must have assignment name"
            txtAssignName.Text = String.Empty
            txtAssignName.Focus()

        Else
            GatherBean()
            'Determines whether to update or add new assignment
            If mblnAddMode = True Then
                'add new assignment
                mobjdata.insertAssignment(mobjAssignbean)
                Me.mcolAssignmentCollection = Me.mobjdata.getAssignmentsForClass(mobjClassbean.ClassNameID)
                'Point to new row
                mintApointer = mcolAssignmentCollection.Count
                lblAction.Text = "Assignment added"
                DrawBean()
                mblnAddMode = False
            Else
                'update assignment
                mobjdata.updateAssignment(mobjAssignbean)
                lblAction.Text = "Assignment updated"
            End If
            btnDelete.Visible = True
            btnAdd.Visible = True
        End If

        'mobjLogger.Log("length of txtAssignName is " + intLen.ToString)

    End Sub

    'Go back to classes, see frmAssignment_FormClosing
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    'Handles deletion of assignments
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim iResult As Integer
        lblAction.Text = String.Empty

        iResult = MsgBox("Do you wish to delete " + mobjAssignbean.AssignName + "?", CType(1, MsgBoxStyle), "Confirm Delete")

        If iResult = 1 Then
            'Pressed ok
            Dim iPreserve = mintApointer
            mobjdata.deleteAssignment(mobjAssignbean)

            'Retrieve remaining assignments
            Me.mcolAssignmentCollection = Me.mobjdata.getAssignmentsForClass(mobjClassbean.ClassNameID)

            If mcolAssignmentCollection.Count >= iPreserve Then
                'fine, nothing to do here
            Else
                If mcolAssignmentCollection.Count = 0 Then
                Else
                    'Sets to the last assignment bean
                    mintApointer = mcolAssignmentCollection.Count
                End If
            End If
            DrawBean()

        End If
    End Sub

    'Sets 1 if checkbox is checked, sets 0 if checkbox is not selected
    Private Sub chkAssignDone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAssignDone.CheckedChanged
        If chkAssignDone.Checked = True Then
            mobjAssignbean.IsDone = 1
        Else
            mobjAssignbean.IsDone = 0
        End If

    End Sub

End Class