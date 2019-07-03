<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Printer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Printer))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_Back = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Argos = New System.Windows.Forms.PictureBox()
        Me.HP = New System.Windows.Forms.PictureBox()
        Me.Brother = New System.Windows.Forms.PictureBox()
        Me.CANON = New System.Windows.Forms.PictureBox()
        Me.EPSON = New System.Windows.Forms.PictureBox()
        Me.Carrys = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.Argos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Brother, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPSON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carrys, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(794, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Btn_Back, 1, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 413)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(794, 34)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'Btn_Back
        '
        Me.Btn_Back.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Back.Location = New System.Drawing.Point(717, 3)
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.Size = New System.Drawing.Size(74, 28)
        Me.Btn_Back.TabIndex = 1
        Me.Btn_Back.Text = "Back"
        Me.Btn_Back.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 85)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(794, 322)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Brother, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.CANON, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.HP, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Carrys, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.EPSON, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Argos, 0, 3)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(241, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(311, 316)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Argos
        '
        Me.Argos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Argos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Argos.Image = CType(resources.GetObject("Argos.Image"), System.Drawing.Image)
        Me.Argos.Location = New System.Drawing.Point(3, 192)
        Me.Argos.Name = "Argos"
        Me.Argos.Size = New System.Drawing.Size(149, 57)
        Me.Argos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Argos.TabIndex = 9
        Me.Argos.TabStop = False
        '
        'HP
        '
        Me.HP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HP.Image = CType(resources.GetObject("HP.Image"), System.Drawing.Image)
        Me.HP.Location = New System.Drawing.Point(158, 66)
        Me.HP.Name = "HP"
        Me.HP.Size = New System.Drawing.Size(150, 57)
        Me.HP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HP.TabIndex = 8
        Me.HP.TabStop = False
        '
        'Brother
        '
        Me.Brother.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Brother.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Brother.Image = CType(resources.GetObject("Brother.Image"), System.Drawing.Image)
        Me.Brother.Location = New System.Drawing.Point(3, 66)
        Me.Brother.Name = "Brother"
        Me.Brother.Size = New System.Drawing.Size(149, 57)
        Me.Brother.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Brother.TabIndex = 1
        Me.Brother.TabStop = False
        '
        'CANON
        '
        Me.CANON.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CANON.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CANON.Image = CType(resources.GetObject("CANON.Image"), System.Drawing.Image)
        Me.CANON.Location = New System.Drawing.Point(3, 129)
        Me.CANON.Name = "CANON"
        Me.CANON.Size = New System.Drawing.Size(149, 57)
        Me.CANON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CANON.TabIndex = 4
        Me.CANON.TabStop = False
        '
        'EPSON
        '
        Me.EPSON.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EPSON.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPSON.Image = CType(resources.GetObject("EPSON.Image"), System.Drawing.Image)
        Me.EPSON.Location = New System.Drawing.Point(158, 129)
        Me.EPSON.Name = "EPSON"
        Me.EPSON.Size = New System.Drawing.Size(150, 57)
        Me.EPSON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EPSON.TabIndex = 7
        Me.EPSON.TabStop = False
        '
        'Carrys
        '
        Me.Carrys.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Carrys.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Carrys.Image = CType(resources.GetObject("Carrys.Image"), System.Drawing.Image)
        Me.Carrys.Location = New System.Drawing.Point(158, 192)
        Me.Carrys.Name = "Carrys"
        Me.Carrys.Size = New System.Drawing.Size(150, 57)
        Me.Carrys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carrys.TabIndex = 10
        Me.Carrys.TabStop = False
        '
        'Printer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Printer"
        Me.Text = "Printer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.Argos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Brother, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPSON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carrys, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Btn_Back As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Brother As PictureBox
    Friend WithEvents CANON As PictureBox
    Friend WithEvents EPSON As PictureBox
    Friend WithEvents HP As PictureBox
    Friend WithEvents Argos As PictureBox
    Friend WithEvents Carrys As PictureBox
End Class
