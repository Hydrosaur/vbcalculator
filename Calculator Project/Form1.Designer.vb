<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.plusButton = New System.Windows.Forms.Button()
        Me.minusButton = New System.Windows.Forms.Button()
        Me.divideButton = New System.Windows.Forms.Button()
        Me.multiplyButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNumber1
        '
        Me.txtNumber1.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber1.Location = New System.Drawing.Point(26, 42)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(62, 33)
        Me.txtNumber1.TabIndex = 0
        '
        'txtNumber2
        '
        Me.txtNumber2.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber2.Location = New System.Drawing.Point(140, 42)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(62, 33)
        Me.txtNumber2.TabIndex = 1
        '
        'plusButton
        '
        Me.plusButton.Location = New System.Drawing.Point(244, 31)
        Me.plusButton.Name = "plusButton"
        Me.plusButton.Size = New System.Drawing.Size(61, 60)
        Me.plusButton.TabIndex = 2
        Me.plusButton.Text = "+"
        Me.plusButton.UseVisualStyleBackColor = True
        '
        'minusButton
        '
        Me.minusButton.Location = New System.Drawing.Point(303, 31)
        Me.minusButton.Name = "minusButton"
        Me.minusButton.Size = New System.Drawing.Size(61, 60)
        Me.minusButton.TabIndex = 3
        Me.minusButton.Text = "-"
        Me.minusButton.UseVisualStyleBackColor = True
        '
        'divideButton
        '
        Me.divideButton.Location = New System.Drawing.Point(244, 89)
        Me.divideButton.Name = "divideButton"
        Me.divideButton.Size = New System.Drawing.Size(61, 60)
        Me.divideButton.TabIndex = 4
        Me.divideButton.Text = "/"
        Me.divideButton.UseVisualStyleBackColor = True
        '
        'multiplyButton
        '
        Me.multiplyButton.Location = New System.Drawing.Point(303, 89)
        Me.multiplyButton.Name = "multiplyButton"
        Me.multiplyButton.Size = New System.Drawing.Size(61, 60)
        Me.multiplyButton.TabIndex = 5
        Me.multiplyButton.Text = "*"
        Me.multiplyButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(253, 272)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(121, 58)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 7
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(253, 203)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(121, 53)
        Me.clearButton.TabIndex = 8
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Location = New System.Drawing.Point(49, 223)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(45, 13)
        Me.lblDisplay.TabIndex = 9
        Me.lblDisplay.Text = "Answer:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 342)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.multiplyButton)
        Me.Controls.Add(Me.divideButton)
        Me.Controls.Add(Me.minusButton)
        Me.Controls.Add(Me.plusButton)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtNumber1)
        Me.Name = "frmMain"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents plusButton As Button
    Friend WithEvents minusButton As Button
    Friend WithEvents divideButton As Button
    Friend WithEvents multiplyButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents clearButton As Button
    Friend WithEvents lblDisplay As Label
End Class
