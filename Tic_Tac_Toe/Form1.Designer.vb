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
        Panel1 = New Panel()
        Label5 = New Label()
        Panel2 = New Panel()
        Panel4 = New Panel()
        lblPlayerO = New Label()
        Label2 = New Label()
        lblPlayerX = New Label()
        Label1 = New Label()
        Button12 = New Button()
        Button11 = New Button()
        Button10 = New Button()
        Panel3 = New Panel()
        Button9 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(12, 24)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1344, 125)
        Panel1.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 30.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(22, 25)
        Label5.Name = "Label5"
        Label5.Size = New Size(607, 67)
        Label5.TabIndex = 1
        Label5.Text = "VB Advanced Tic Tac Toe"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(12, 173)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1344, 556)
        Panel2.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(lblPlayerO)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(lblPlayerX)
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(Button12)
        Panel4.Controls.Add(Button11)
        Panel4.Controls.Add(Button10)
        Panel4.Location = New Point(758, 18)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(563, 518)
        Panel4.TabIndex = 0
        ' 
        ' lblPlayerO
        ' 
        lblPlayerO.BackColor = Color.White
        lblPlayerO.BorderStyle = BorderStyle.Fixed3D
        lblPlayerO.Font = New Font("Segoe UI", 30.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlayerO.Location = New Point(275, 148)
        lblPlayerO.Name = "lblPlayerO"
        lblPlayerO.Size = New Size(244, 89)
        lblPlayerO.TabIndex = 1
        lblPlayerO.Text = "0"
        lblPlayerO.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 30.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(255, 67)
        Label2.TabIndex = 1
        Label2.Text = "Player O :"
        ' 
        ' lblPlayerX
        ' 
        lblPlayerX.BackColor = Color.White
        lblPlayerX.BorderStyle = BorderStyle.Fixed3D
        lblPlayerX.Font = New Font("Segoe UI", 30.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPlayerX.Location = New Point(275, 18)
        lblPlayerX.Name = "lblPlayerX"
        lblPlayerX.Size = New Size(244, 89)
        lblPlayerX.TabIndex = 1
        lblPlayerX.Text = "0"
        lblPlayerX.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(264, 67)
        Label1.TabIndex = 1
        Label1.Text = "Player X : "
        ' 
        ' Button12
        ' 
        Button12.BackColor = SystemColors.HighlightText
        Button12.Font = New Font("Segoe UI", 30.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button12.Location = New Point(33, 324)
        Button12.Name = "Button12"
        Button12.Size = New Size(478, 87)
        Button12.TabIndex = 0
        Button12.Text = "NEW GAME"
        Button12.UseVisualStyleBackColor = False
        ' 
        ' Button11
        ' 
        Button11.BackColor = SystemColors.HighlightText
        Button11.Font = New Font("Segoe UI", 30.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button11.Location = New Point(275, 417)
        Button11.Name = "Button11"
        Button11.Size = New Size(236, 87)
        Button11.TabIndex = 0
        Button11.Text = "EXIT"
        Button11.UseVisualStyleBackColor = False
        ' 
        ' Button10
        ' 
        Button10.BackColor = SystemColors.HighlightText
        Button10.Font = New Font("Segoe UI", 30.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button10.Location = New Point(33, 417)
        Button10.Name = "Button10"
        Button10.Size = New Size(236, 87)
        Button10.TabIndex = 0
        Button10.Text = "RESET"
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Button9)
        Panel3.Controls.Add(Button8)
        Panel3.Controls.Add(Button7)
        Panel3.Controls.Add(Button5)
        Panel3.Controls.Add(Button6)
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Button1)
        Panel3.Location = New Point(22, 18)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(730, 518)
        Panel3.TabIndex = 0
        ' 
        ' Button9
        ' 
        Button9.BackColor = SystemColors.HighlightText
        Button9.Font = New Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button9.Location = New Point(436, 346)
        Button9.Name = "Button9"
        Button9.Size = New Size(200, 158)
        Button9.TabIndex = 0
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = SystemColors.HighlightText
        Button8.Font = New Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.Location = New Point(230, 346)
        Button8.Name = "Button8"
        Button8.Size = New Size(200, 158)
        Button8.TabIndex = 0
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = SystemColors.HighlightText
        Button7.Font = New Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button7.Location = New Point(24, 346)
        Button7.Name = "Button7"
        Button7.Size = New Size(200, 158)
        Button7.TabIndex = 0
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.HighlightText
        Button5.Font = New Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(230, 182)
        Button5.Name = "Button5"
        Button5.Size = New Size(200, 158)
        Button5.TabIndex = 0
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.HighlightText
        Button6.Font = New Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(436, 182)
        Button6.Name = "Button6"
        Button6.Size = New Size(200, 158)
        Button6.TabIndex = 0
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.HighlightText
        Button4.Font = New Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(24, 182)
        Button4.Name = "Button4"
        Button4.Size = New Size(200, 158)
        Button4.TabIndex = 0
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.HighlightText
        Button3.Font = New Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(436, 18)
        Button3.Name = "Button3"
        Button3.Size = New Size(200, 158)
        Button3.TabIndex = 0
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.HighlightText
        Button2.Font = New Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(230, 18)
        Button2.Name = "Button2"
        Button2.Size = New Size(200, 158)
        Button2.TabIndex = 0
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.HighlightText
        Button1.Font = New Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(24, 18)
        Button1.Name = "Button1"
        Button1.Size = New Size(200, 158)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HotTrack
        ClientSize = New Size(1368, 741)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents lblPlayerO As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPlayerX As Label

End Class
