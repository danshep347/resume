<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResults
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblFinalResult = New System.Windows.Forms.Label()
        Me.btnRetakeTest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFinalResult
        '
        Me.lblFinalResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFinalResult.Location = New System.Drawing.Point(30, 25)
        Me.lblFinalResult.Name = "lblFinalResult"
        Me.lblFinalResult.Size = New System.Drawing.Size(293, 248)
        Me.lblFinalResult.TabIndex = 42
        '
        'btnRetakeTest
        '
        Me.btnRetakeTest.Location = New System.Drawing.Point(116, 308)
        Me.btnRetakeTest.Name = "btnRetakeTest"
        Me.btnRetakeTest.Size = New System.Drawing.Size(110, 48)
        Me.btnRetakeTest.TabIndex = 43
        Me.btnRetakeTest.Text = "Retake Test"
        Me.btnRetakeTest.UseVisualStyleBackColor = True
        '
        'frmResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 455)
        Me.Controls.Add(Me.btnRetakeTest)
        Me.Controls.Add(Me.lblFinalResult)
        Me.Name = "frmResults"
        Me.Text = "Results"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFinalResult As System.Windows.Forms.Label
    Friend WithEvents btnRetakeTest As System.Windows.Forms.Button
End Class
