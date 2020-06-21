Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles start.Click
        If (BackgroundWorker1.IsBusy = False) Then
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (BackgroundWorker1.IsBusy = False) Then
            BackgroundWorker1.CancelAsync()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.WorkerSupportsCancellation = True
        BackgroundWorker1.WorkerReportsProgress = True
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        For a As Integer = 0 To 100
            Dim label As String = ""
            If (a >= 1 And a < 25) Then
                label = "Loading"
            ElseIf (a >= 25 And a < 50) Then
                label = "Tunggu Sebentar"
            ElseIf (a >= 50 And a < 75) Then
                label = "Memulai"
            ElseIf (a >= 75 And a < 100) Then
                label = "SUCCESFULL"
            End If

            BackgroundWorker1.ReportProgress(a, label)
            System.Threading.Thread.Sleep(100)

            If (BackgroundWorker1.CancellationPending) Then
                e.Cancel = True
                Exit Sub
            End If
        Next
    End Sub
    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        salah1.Value = Convert.ToDouble(e.ProgressPercentage)
        LoadingText.Text = e.ProgressPercentage.ToString() & "%"
        Proses.Text = DirectCast(e.UserState, String)
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If (e.Cancelled = True) Then
            MessageBox.Show("Cancel Procces")
        ElseIf (e.Error IsNot Nothing) Then
            MessageBox.Show(e.Error.Message)
        Else
            MessageBox.Show("Progress Selesai berjalan")
        End If
    End Sub

    Private Sub Proses_Click(sender As Object, e As EventArgs) Handles Proses.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
