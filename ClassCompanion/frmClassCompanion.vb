' Author: Christina Hitz
' Purpose: Application to manage classes and assignments, saves to and retrieve from a database.
'This is the splash screen, initial visual GUI.
' Date: 2/25/2012   Appended to include btnAssignment_Click for Assignment Reporting on 5/6/2012

Option Strict On
Option Explicit On


Public Class frmClassCompanion

    Private Sub btnClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClass.Click
        'instantiates the flass form
        Dim newForm As frmClass
        newForm = New frmClass()
        newForm.Show()

        'hides this screen
        Me.Hide()


    End Sub

    Private Sub btnClassMainExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClassMainExit.Click
        Me.Close()
    End Sub

    Private Sub btnAssignment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignment.Click
        'Instantiate a new clsReport
        Dim objReport As New clsReport
        'Start default browser with a HTML file created in clsReport
        Process.Start(objReport.mstrFileName)
    End Sub


End Class
