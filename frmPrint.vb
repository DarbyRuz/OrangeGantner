'Public Class frmPrint

'    Public printer As String
'        Public copies As Integer
'    Private Sub frmPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        'TODO: This line of code loads data into the 'DataSet1.ClipFrm' table. You can move, or remove it, as needed.
'        ' Me.ClipFrmTableAdapter.Fill(Me.DataSet1.ClipFrm)
'        'TODO: This line of code loads data into the 'DataSet1.ClipFrm' table. You can move, or remove it, as needed.
'        ' Me.ClipFrmTableAdapter.Fill(Me.DataSet1.ClipFrm)
'    End Sub
'    Private Sub cmdPrint_Click(ByVal sender As System.Object,
'    ByVal e As System.EventArgs) Handles cmdPrint.Click
'        Dim Print As New myPrinter
'        Dim myprintdialog As New PrintDialog
'        With myprintdialog
'            If .ShowDialog = Windows.Forms.DialogResult.OK Then
'                printer = .PrinterSettings.PrinterName
'                copies = .PrinterSettings.Copies
'                Print.prt(lv.Text.Trim)
'            End If
'        End With
'    End Sub
'End Class

'    Public Class myPrinter
'        Friend TextToBePrinted As String
'        Public Sub prt(ByVal text As String)
'            TextToBePrinted = text
'            Dim prn As New Printing.PrintDocument
'            Using (prn)
'            prn.PrinterSettings.PrinterName = frmPrint.printer
'            prn.PrinterSettings.Copies = frmPrint.copies
'            AddHandler prn.PrintPage,
'               AddressOf Me.PrintPageHandler
'                prn.Print()
'                RemoveHandler prn.PrintPage,
'               AddressOf Me.PrintPageHandler
'            End Using
'        End Sub
'        Private Sub PrintPageHandler(ByVal sender As Object,
'       ByVal args As Printing.PrintPageEventArgs)
'            Dim myFont As New Font("Microsoft San Serif", 10)
'            args.Graphics.DrawString(TextToBePrinted,
'           New Font(myFont, FontStyle.Regular),
'           Brushes.Black, 50, 50)
'        End Sub
'    End Class

