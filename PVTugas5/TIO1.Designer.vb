<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TIO1
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
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btn2Buttons = New System.Windows.Forms.Button()
        Me.btn3Buttons = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SubarrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubenumerationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubconstantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(35, 233)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(91, 15)
        Me.lblResults.TabIndex = 0
        Me.lblResults.Text = "Nothing clicked"
        '
        'btn2Buttons
        '
        Me.btn2Buttons.Location = New System.Drawing.Point(35, 106)
        Me.btn2Buttons.Name = "btn2Buttons"
        Me.btn2Buttons.Size = New System.Drawing.Size(146, 23)
        Me.btn2Buttons.TabIndex = 1
        Me.btn2Buttons.Text = "2 Buttons"
        Me.btn2Buttons.UseVisualStyleBackColor = True
        '
        'btn3Buttons
        '
        Me.btn3Buttons.Location = New System.Drawing.Point(35, 185)
        Me.btn3Buttons.Name = "btn3Buttons"
        Me.btn3Buttons.Size = New System.Drawing.Size(146, 23)
        Me.btn3Buttons.TabIndex = 2
        Me.btn3Buttons.Text = "3 Buttons"
        Me.btn3Buttons.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(35, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(447, 30)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "TIO 1 :  Creating a Two-Button Message Box"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(35, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(442, 30)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "TIO 2 :  Testing a Three-Button MessageBox"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubarrayToolStripMenuItem, Me.SubenumerationsToolStripMenuItem, Me.SubconstantsToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.FolderBrowserDialogToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(725, 24)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SubarrayToolStripMenuItem
        '
        Me.SubarrayToolStripMenuItem.Name = "SubarrayToolStripMenuItem"
        Me.SubarrayToolStripMenuItem.Size = New System.Drawing.Size(132, 20)
        Me.SubarrayToolStripMenuItem.Text = "Message Box Buttons"
        '
        'SubenumerationsToolStripMenuItem
        '
        Me.SubenumerationsToolStripMenuItem.Name = "SubenumerationsToolStripMenuItem"
        Me.SubenumerationsToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.SubenumerationsToolStripMenuItem.Text = "OpenDialogs"
        '
        'SubconstantsToolStripMenuItem
        '
        Me.SubconstantsToolStripMenuItem.Name = "SubconstantsToolStripMenuItem"
        Me.SubconstantsToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.SubconstantsToolStripMenuItem.Text = "SaveFileDialog"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(80, 20)
        Me.ToolStripMenuItem1.Text = "Font Dialog"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(85, 20)
        Me.ToolStripMenuItem2.Text = "Color Dialog"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(81, 20)
        Me.ToolStripMenuItem3.Text = "Print Dialog"
        '
        'FolderBrowserDialogToolStripMenuItem
        '
        Me.FolderBrowserDialogToolStripMenuItem.Name = "FolderBrowserDialogToolStripMenuItem"
        Me.FolderBrowserDialogToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.FolderBrowserDialogToolStripMenuItem.Text = "FolderBrowserDialog"
        '
        'TIO1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 296)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn3Buttons)
        Me.Controls.Add(Me.btn2Buttons)
        Me.Controls.Add(Me.lblResults)
        Me.Name = "TIO1"
        Me.Text = "Message Box Buttons"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblResults As Label
    Friend WithEvents btn2Buttons As Button
    Friend WithEvents btn3Buttons As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SubarrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubenumerationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubconstantsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents FolderBrowserDialogToolStripMenuItem As ToolStripMenuItem
End Class
