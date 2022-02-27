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
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.tbxNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxFact = New System.Windows.Forms.TextBox()
        Me.tbxMult = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvw = New System.Windows.Forms.ListView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(214, 174)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(132, 46)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'tbxNum
        '
        Me.tbxNum.Location = New System.Drawing.Point(237, 125)
        Me.tbxNum.Name = "tbxNum"
        Me.tbxNum.Size = New System.Drawing.Size(87, 27)
        Me.tbxNum.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(198, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "INGRESE UN NÚMERO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FACTORIAL"
        '
        'tbxFact
        '
        Me.tbxFact.Location = New System.Drawing.Point(71, 289)
        Me.tbxFact.Name = "tbxFact"
        Me.tbxFact.Size = New System.Drawing.Size(125, 27)
        Me.tbxFact.TabIndex = 4
        '
        'tbxMult
        '
        Me.tbxMult.Location = New System.Drawing.Point(375, 289)
        Me.tbxMult.Name = "tbxMult"
        Me.tbxMult.Size = New System.Drawing.Size(125, 27)
        Me.tbxMult.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(405, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "MULTIPLOS"
        '
        'lvw
        '
        Me.lvw.Location = New System.Drawing.Point(237, 289)
        Me.lvw.Name = "lvw"
        Me.lvw.Size = New System.Drawing.Size(98, 121)
        Me.lvw.TabIndex = 7
        Me.lvw.UseCompatibleStateImageBehavior = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(263, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CICLO"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 494)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lvw)
        Me.Controls.Add(Me.tbxMult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxFact)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxNum)
        Me.Controls.Add(Me.btnCalcular)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents tbxNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxFact As TextBox
    Friend WithEvents tbxMult As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lvw As ListView
    Friend WithEvents Label4 As Label
End Class
