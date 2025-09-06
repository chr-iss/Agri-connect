<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home_page
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnHire = New System.Windows.Forms.Button()
        Me.btnEducation = New System.Windows.Forms.Button()
        Me.btnMarketing = New System.Windows.Forms.Button()
        Me.btnWhyUs = New System.Windows.Forms.Button()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSignOut)
        Me.Panel1.Controls.Add(Me.btnWhyUs)
        Me.Panel1.Controls.Add(Me.btnMarketing)
        Me.Panel1.Controls.Add(Me.btnEducation)
        Me.Panel1.Controls.Add(Me.btnHire)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(144, 450)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(21, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 60)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnHire
        '
        Me.btnHire.Location = New System.Drawing.Point(31, 114)
        Me.btnHire.Name = "btnHire"
        Me.btnHire.Size = New System.Drawing.Size(75, 23)
        Me.btnHire.TabIndex = 1
        Me.btnHire.Text = "Hire"
        Me.btnHire.UseVisualStyleBackColor = True
        '
        'btnEducation
        '
        Me.btnEducation.Location = New System.Drawing.Point(31, 164)
        Me.btnEducation.Name = "btnEducation"
        Me.btnEducation.Size = New System.Drawing.Size(75, 23)
        Me.btnEducation.TabIndex = 2
        Me.btnEducation.Text = "Education"
        Me.btnEducation.UseVisualStyleBackColor = True
        '
        'btnMarketing
        '
        Me.btnMarketing.Location = New System.Drawing.Point(31, 215)
        Me.btnMarketing.Name = "btnMarketing"
        Me.btnMarketing.Size = New System.Drawing.Size(75, 23)
        Me.btnMarketing.TabIndex = 3
        Me.btnMarketing.Text = "Marketing"
        Me.btnMarketing.UseVisualStyleBackColor = True
        '
        'btnWhyUs
        '
        Me.btnWhyUs.Location = New System.Drawing.Point(31, 264)
        Me.btnWhyUs.Name = "btnWhyUs"
        Me.btnWhyUs.Size = New System.Drawing.Size(75, 23)
        Me.btnWhyUs.TabIndex = 4
        Me.btnWhyUs.Text = "Why Us ?"
        Me.btnWhyUs.UseVisualStyleBackColor = True
        '
        'btnSignOut
        '
        Me.btnSignOut.Location = New System.Drawing.Point(31, 415)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(75, 23)
        Me.btnSignOut.TabIndex = 5
        Me.btnSignOut.Text = "Sign Out"
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'home_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "home_page"
        Me.Text = "home_page"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSignOut As Button
    Friend WithEvents btnWhyUs As Button
    Friend WithEvents btnMarketing As Button
    Friend WithEvents btnEducation As Button
    Friend WithEvents btnHire As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
