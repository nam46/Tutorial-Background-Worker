<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.start = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Proses = New System.Windows.Forms.Label()
        Me.LoadingText = New System.Windows.Forms.Label()
        Me.salah1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Background worker"
        '
        'start
        '
        Me.start.ForeColor = System.Drawing.Color.Blue
        Me.start.Location = New System.Drawing.Point(144, 168)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(75, 23)
        Me.start.TabIndex = 1
        Me.start.Text = "START"
        Me.start.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(312, 168)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Proses
        '
        Me.Proses.AutoSize = True
        Me.Proses.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proses.ForeColor = System.Drawing.Color.Red
        Me.Proses.Location = New System.Drawing.Point(142, 72)
        Me.Proses.Name = "Proses"
        Me.Proses.Size = New System.Drawing.Size(77, 18)
        Me.Proses.TabIndex = 4
        Me.Proses.Text = "Progress"
        '
        'LoadingText
        '
        Me.LoadingText.AutoSize = True
        Me.LoadingText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadingText.ForeColor = System.Drawing.Color.Red
        Me.LoadingText.Location = New System.Drawing.Point(280, 72)
        Me.LoadingText.Name = "LoadingText"
        Me.LoadingText.Size = New System.Drawing.Size(34, 20)
        Me.LoadingText.TabIndex = 5
        Me.LoadingText.Text = "0%"
        '
        'salah1
        '
        Me.salah1.Location = New System.Drawing.Point(91, 107)
        Me.salah1.Name = "salah1"
        Me.salah1.Size = New System.Drawing.Size(336, 23)
        Me.salah1.TabIndex = 6
        '
        'BackgroundWorker1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 234)
        Me.Controls.Add(Me.salah1)
        Me.Controls.Add(Me.LoadingText)
        Me.Controls.Add(Me.Proses)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents start As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Proses As Label
    Friend WithEvents LoadingText As Label
    Friend WithEvents salah1 As ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
