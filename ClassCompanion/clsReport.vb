'Author: Christina Hitz
'Date: 5/6/2012
'Purpose: Generates an assignments report. Outputs in HTML to the users default browser.
'<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
'<html>
'  <head>
'    <meta content="text/html; charset=ISO-8859-1"
'      http-equiv="Content-Type">
'    <title>Class Companion Report Dummy</title>
'  </head>
'  <body>
'    <h1>Class Companion Report</h1>
'    <h2>Inject Date here</h2>
'    <h2>Class 1 ClassID ClassName ClassStartTime DateMeets</h2>
'    <p>Assignments AssignmentID ClassID AName Notes IsDone ADueDate<br>
'    </p>
'    <p><br>
'    </p>
'    <h2>Class 2 ClassID ClassName ClassStartTime DateMeets</h2>
'    <p>Assignments AssignmentID ClassID AName Notes IsDone ADueDate</p>
'    <p><br>
'      <br>
'    </p>
'  </body>
'</html>

Option Strict On
Option Explicit On


Public Class clsReport

    'Module level varialbes
    Public mStreamWriter As System.IO.StreamWriter
    Public mstrFileName As String
    Dim mdtmNow As Date
    Dim mcolAssignmentCollection As Collection
    Dim mcolClassCollection As Collection
    Dim mobjClassbean As New clsClassBean
    Dim mobjAssignbean As clsAssignmentBean
    Dim mobjLogger As New clsLogger
    Dim mstrLog As String = ("for data write")
    Dim mobjdata As New clsData

    'Default Constructor
    Public Sub New()

        Me.mcolClassCollection = mobjdata.getClasses()

        'get system date/time
        mdtmNow = DateTime.Now

        '.....Free VB2010 Source Code from www.freevb2010code.com
        '.....Note that mstrFileName should include the path
        mstrFileName = "ClassCompanionReport.html"
        '.....Open the file
        '.....Note that the second parameter specifies the Append Mode - ie True = Append, False = Overwrite
        mStreamWriter = My.Computer.FileSystem.OpenTextFileWriter(mstrFileName, False)
        '.....Now create the line(s) of text to be written to the TEXT file (ASSIGN TEXT)--changed for use to write HTML to file
        WriteHeader("Header")
        WriteBody("Body")
        WriteFooter("Footer")
        '.....Close the file
        mStreamWriter.Close()
    End Sub
    'Write HTML header info to file
    Public Sub WriteHeader(ByVal strTitle As String)
        Say("<!DOCTYPE HTML PUBLIC ""-//W3C//DTD HTML 4.01 Transitional//EN"">")
        Say("<html>")
        Say("  <head>")
        Say("    <meta content=""text/html; charset=ISO-8859-1""")
        Say("      http-equiv=""Content-Type"">")
        Say("    <title>Class Companion Report Dummy</title>")
        Say("  </head>")
    End Sub
    'Close html tag written to file
    Public Sub WriteFooter(ByVal strFooter As String)
        Say("</html>")
    End Sub
    'Write to file the body of the HTML
    Public Sub WriteBody(ByVal strBody As String)
        Say("  <body>")
        Say("    <h1>Class Companion Report " + mdtmNow.ToString + "</h1>")
        For Each classBean As clsClassBean In mcolClassCollection
            WriteH2(classBean.dump)
            Me.mcolAssignmentCollection = Me.mobjdata.getAssignmentsForClass(classBean.ClassNameID)
            For Each assignBean As clsAssignmentBean In mcolAssignmentCollection
                WriteP(assignBean.prettyPrint)

            Next

        Next


        Say("  </body>")
    End Sub
    'writes paragraphs within body to HTML file
    Public Sub WriteP(ByVal strP As String)
        Say("<p>" + strP + "</p>")
    End Sub
    'Writes h2 within body to HTML file
    Public Sub WriteH2(ByVal strH2 As String)
        Say("<h2>" + strH2 + "</h2>")
    End Sub
    'Method for writing
    Public Sub Say(ByVal strSay As String)
        mStreamWriter.WriteLine(strSay)
    End Sub

End Class
