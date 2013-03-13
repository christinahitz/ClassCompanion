'Author: Christina Hitz
'Date: 5/2/2012
'Purpose: For debugging purposes....writes and appends to file ClassCompanion.txt
'Appended on 5/6/2012 by CHitz to use pretty append to output to HTML file for assignment reporting.

Option Strict On
Option Explicit On


Public Class clsLogger

    Public mStreamWriter As System.IO.StreamWriter
    Public mstrFileName As String



    Dim mdtmNow As Date



    Public Sub Log(ByVal mstrLog As String)
        mdtmNow = DateTime.Now

        '.....Free VB2010 Source Code from www.freevb2010code.com
        '.....Note that MyFileName should include the path
        mstrFileName = "ClassCompanion.txt"
        '.....Open the file
        '.....Note that the second parameter specifies the Append Mode - ie True = Append, False = Overwrite
        mStreamWriter = My.Computer.FileSystem.OpenTextFileWriter(mstrFileName, True)
        '.....Now create the line(s) of text to be written to the TEXT file (ASSIGN TEXT)

        '.....Write the line of data (WRITE TEXT)
        mStreamWriter.WriteLine(mdtmNow.ToString + " " + mstrLog)
        '.....Repeat the two lines of code above (assign text and write text) as many times as needed or loop etc.
        '.....Close the file
        mStreamWriter.Close()

    End Sub
End Class
