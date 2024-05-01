<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class seleksi_final
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_final_verification = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Lks_testDataSet = New Ngetes_Admin.lks_testDataSet()
        Me.LkstestDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lks_testDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LkstestDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.LkstestDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(776, 288)
        Me.DataGridView1.TabIndex = 1
        '
        'btn_final_verification
        '
        Me.btn_final_verification.Location = New System.Drawing.Point(294, 364)
        Me.btn_final_verification.Name = "btn_final_verification"
        Me.btn_final_verification.Size = New System.Drawing.Size(228, 63)
        Me.btn_final_verification.TabIndex = 2
        Me.btn_final_verification.Text = "Verifikasi Final"
        Me.btn_final_verification.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(12, 12)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(95, 40)
        Me.btn_back.TabIndex = 3
        Me.btn_back.Text = "Kembali"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'Lks_testDataSet
        '
        Me.Lks_testDataSet.DataSetName = "lks_testDataSet"
        Me.Lks_testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LkstestDataSetBindingSource
        '
        Me.LkstestDataSetBindingSource.DataSource = Me.Lks_testDataSet
        Me.LkstestDataSetBindingSource.Position = 0
        '
        'seleksi_final
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_final_verification)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "seleksi_final"
        Me.Text = "seleksi_final"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lks_testDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LkstestDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_final_verification As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents LkstestDataSetBindingSource As BindingSource
    Friend WithEvents Lks_testDataSet As lks_testDataSet
End Class
