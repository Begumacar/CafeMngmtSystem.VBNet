<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewOrders))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.OrdersDGV = New System.Windows.Forms.DataGridView()
        CType(Me.OrdersDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(276, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 38)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Orders List"
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Font = New System.Drawing.Font("Franklin Gothic Book", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BackBtn.ForeColor = System.Drawing.Color.RosyBrown
        Me.BackBtn.Location = New System.Drawing.Point(308, 642)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(89, 33)
        Me.BackBtn.TabIndex = 23
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'OrdersDGV
        '
        Me.OrdersDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.OrdersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrdersDGV.Location = New System.Drawing.Point(31, 72)
        Me.OrdersDGV.Name = "OrdersDGV"
        Me.OrdersDGV.RowHeadersWidth = 51
        Me.OrdersDGV.RowTemplate.Height = 24
        Me.OrdersDGV.Size = New System.Drawing.Size(668, 549)
        Me.OrdersDGV.TabIndex = 32
        '
        'ViewOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(731, 705)
        Me.Controls.Add(Me.OrdersDGV)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewOrders"
        CType(Me.OrdersDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents BackBtn As Button
    Friend WithEvents OrdersDGV As DataGridView
End Class
