<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sofigma
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
        Me.btnReset = New System.Windows.Forms.Button()
        Me.rotor1 = New System.Windows.Forms.TextBox()
        Me.rotor2 = New System.Windows.Forms.TextBox()
        Me.rotor3 = New System.Windows.Forms.TextBox()
        Me.input = New System.Windows.Forms.TextBox()
        Me.output = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.copycode = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReset.Location = New System.Drawing.Point(365, 8)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 31)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'rotor1
        '
        Me.rotor1.Location = New System.Drawing.Point(78, 10)
        Me.rotor1.MaxLength = 2
        Me.rotor1.Name = "rotor1"
        Me.rotor1.Size = New System.Drawing.Size(28, 20)
        Me.rotor1.TabIndex = 3
        '
        'rotor2
        '
        Me.rotor2.Location = New System.Drawing.Point(112, 10)
        Me.rotor2.MaxLength = 2
        Me.rotor2.Name = "rotor2"
        Me.rotor2.Size = New System.Drawing.Size(28, 20)
        Me.rotor2.TabIndex = 4
        '
        'rotor3
        '
        Me.rotor3.Location = New System.Drawing.Point(146, 10)
        Me.rotor3.MaxLength = 2
        Me.rotor3.Name = "rotor3"
        Me.rotor3.Size = New System.Drawing.Size(28, 20)
        Me.rotor3.TabIndex = 5
        '
        'input
        '
        Me.input.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.input.Location = New System.Drawing.Point(9, 59)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(431, 20)
        Me.input.TabIndex = 6
        '
        'output
        '
        Me.output.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.output.Location = New System.Drawing.Point(9, 146)
        Me.output.Name = "output"
        Me.output.ReadOnly = True
        Me.output.Size = New System.Drawing.Size(431, 20)
        Me.output.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Ivory
        Me.Label1.Location = New System.Drawing.Point(6, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Input"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Ivory
        Me.Label2.Location = New System.Drawing.Point(6, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Output"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(6, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Set Key"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Ivory
        Me.Label4.Location = New System.Drawing.Point(6, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Copy input code here"
        '
        'copycode
        '
        Me.copycode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.copycode.Location = New System.Drawing.Point(9, 107)
        Me.copycode.Name = "copycode"
        Me.copycode.Size = New System.Drawing.Size(273, 20)
        Me.copycode.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(288, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 36)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Decode input code"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Sofigma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.ClientSize = New System.Drawing.Size(452, 177)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.copycode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.rotor3)
        Me.Controls.Add(Me.rotor2)
        Me.Controls.Add(Me.rotor1)
        Me.Controls.Add(Me.btnReset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Sofigma"
        Me.Text = "Sofigma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReset As Button
    Friend WithEvents rotor1 As TextBox
    Friend WithEvents rotor2 As TextBox
    Friend WithEvents rotor3 As TextBox
    Friend WithEvents input As TextBox
    Friend WithEvents output As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents copycode As TextBox
    Friend WithEvents Button1 As Button
End Class
