﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teacher_register
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
        backtoclass3 = New Button()
        regnowteacher = New Button()
        Label7 = New Label()
        teachdepartment = New ComboBox()
        Label6 = New Label()
        teachmajor = New TextBox()
        Label5 = New Label()
        teachid = New TextBox()
        teachgender = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        teachage = New TextBox()
        Label1 = New Label()
        teachname = New TextBox()
        SuspendLayout()
        ' 
        ' backtoclass3
        ' 
        backtoclass3.BackColor = Color.Red
        backtoclass3.FlatAppearance.BorderColor = Color.White
        backtoclass3.FlatAppearance.BorderSize = 0
        backtoclass3.FlatStyle = FlatStyle.Flat
        backtoclass3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backtoclass3.ForeColor = SystemColors.ControlLightLight
        backtoclass3.Location = New Point(148, 453)
        backtoclass3.Name = "backtoclass3"
        backtoclass3.RightToLeft = RightToLeft.No
        backtoclass3.Size = New Size(180, 35)
        backtoclass3.TabIndex = 29
        backtoclass3.Text = "Back"
        backtoclass3.UseVisualStyleBackColor = False
        ' 
        ' regnowteacher
        ' 
        regnowteacher.BackColor = SystemColors.ActiveCaptionText
        regnowteacher.FlatAppearance.BorderColor = Color.White
        regnowteacher.FlatAppearance.BorderSize = 0
        regnowteacher.FlatStyle = FlatStyle.Flat
        regnowteacher.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        regnowteacher.ForeColor = SystemColors.ControlLightLight
        regnowteacher.Location = New Point(148, 399)
        regnowteacher.Name = "regnowteacher"
        regnowteacher.RightToLeft = RightToLeft.No
        regnowteacher.Size = New Size(180, 35)
        regnowteacher.TabIndex = 28
        regnowteacher.Text = "Register Now"
        regnowteacher.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(45, 326)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 15)
        Label7.TabIndex = 27
        Label7.Text = "Department:"
        ' 
        ' teachdepartment
        ' 
        teachdepartment.FormattingEnabled = True
        teachdepartment.Location = New Point(124, 323)
        teachdepartment.Name = "teachdepartment"
        teachdepartment.Size = New Size(121, 23)
        teachdepartment.TabIndex = 26
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(35, 266)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 15)
        Label6.TabIndex = 25
        Label6.Text = "Major Subject:"
        ' 
        ' teachmajor
        ' 
        teachmajor.Location = New Point(124, 263)
        teachmajor.Name = "teachmajor"
        teachmajor.Size = New Size(240, 23)
        teachmajor.TabIndex = 24
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(53, 214)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 15)
        Label5.TabIndex = 23
        Label5.Text = "Teacher ID:"
        ' 
        ' teachid
        ' 
        teachid.Location = New Point(124, 211)
        teachid.Name = "teachid"
        teachid.Size = New Size(240, 23)
        teachid.TabIndex = 22
        ' 
        ' teachgender
        ' 
        teachgender.Location = New Point(281, 165)
        teachgender.Name = "teachgender"
        teachgender.Size = New Size(83, 23)
        teachgender.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(227, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 15)
        Label4.TabIndex = 20
        Label4.Text = "Gender:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(87, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 19
        Label3.Text = "Age:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(59, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 18
        Label2.Text = "Fullname:"
        ' 
        ' teachage
        ' 
        teachage.Location = New Point(124, 165)
        teachage.Name = "teachage"
        teachage.Size = New Size(87, 23)
        teachage.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(148, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 30)
        Label1.TabIndex = 16
        Label1.Text = "Teacher Register"
        ' 
        ' teachname
        ' 
        teachname.Location = New Point(124, 115)
        teachname.Name = "teachname"
        teachname.Size = New Size(240, 23)
        teachname.TabIndex = 15
        ' 
        ' Teacher_register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(439, 525)
        Controls.Add(backtoclass3)
        Controls.Add(regnowteacher)
        Controls.Add(Label7)
        Controls.Add(teachdepartment)
        Controls.Add(Label6)
        Controls.Add(teachmajor)
        Controls.Add(Label5)
        Controls.Add(teachid)
        Controls.Add(teachgender)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(teachage)
        Controls.Add(Label1)
        Controls.Add(teachname)
        ForeColor = SystemColors.ActiveCaptionText
        FormBorderStyle = FormBorderStyle.None
        Name = "Teacher_register"
        Text = "Teacher_register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backtoclass3 As Button
    Friend WithEvents regnowteacher As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents teachdepartment As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents teachmajor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents teachid As TextBox
    Friend WithEvents teachgender As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents teachage As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents teachname As TextBox
End Class
