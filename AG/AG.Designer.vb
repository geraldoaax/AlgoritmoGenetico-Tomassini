<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AG
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtEvolve = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFitness = New System.Windows.Forms.TextBox()
        Me.agChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgvPopulacao = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cromo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.agChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPopulacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(999, 11)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(175, 49)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "Calcular AG"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtEvolve
        '
        Me.txtEvolve.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEvolve.Location = New System.Drawing.Point(179, 20)
        Me.txtEvolve.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEvolve.Name = "txtEvolve"
        Me.txtEvolve.Size = New System.Drawing.Size(132, 30)
        Me.txtEvolve.TabIndex = 1
        Me.txtEvolve.Text = "50"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Gerações ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(320, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "X = "
        '
        'txtX
        '
        Me.txtX.Enabled = False
        Me.txtX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtX.Location = New System.Drawing.Point(377, 20)
        Me.txtX.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(132, 30)
        Me.txtX.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(519, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "f(x) = "
        '
        'txtfx
        '
        Me.txtfx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfx.Location = New System.Drawing.Point(591, 20)
        Me.txtfx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtfx.Name = "txtfx"
        Me.txtfx.Size = New System.Drawing.Size(132, 30)
        Me.txtfx.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(732, 23)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fitness ="
        '
        'txtFitness
        '
        Me.txtFitness.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFitness.Location = New System.Drawing.Point(839, 20)
        Me.txtFitness.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFitness.Name = "txtFitness"
        Me.txtFitness.Size = New System.Drawing.Size(132, 30)
        Me.txtFitness.TabIndex = 7
        '
        'agChart
        '
        Me.agChart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.agChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.agChart.Legends.Add(Legend1)
        Me.agChart.Location = New System.Drawing.Point(16, 68)
        Me.agChart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.agChart.Name = "agChart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.agChart.Series.Add(Series1)
        Me.agChart.Size = New System.Drawing.Size(841, 438)
        Me.agChart.TabIndex = 9
        Me.agChart.Text = "AG"
        Title1.Name = "Tomassini"
        Title1.Text = "Tomassini"
        Me.agChart.Titles.Add(Title1)
        '
        'dgvPopulacao
        '
        Me.dgvPopulacao.AllowUserToAddRows = False
        Me.dgvPopulacao.AllowUserToDeleteRows = False
        Me.dgvPopulacao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPopulacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPopulacao.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.Cromo})
        Me.dgvPopulacao.Location = New System.Drawing.Point(865, 68)
        Me.dgvPopulacao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvPopulacao.MultiSelect = False
        Me.dgvPopulacao.Name = "dgvPopulacao"
        Me.dgvPopulacao.ReadOnly = True
        Me.dgvPopulacao.RowHeadersWidth = 51
        Me.dgvPopulacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPopulacao.Size = New System.Drawing.Size(324, 438)
        Me.dgvPopulacao.TabIndex = 10
        '
        'Item
        '
        Me.Item.HeaderText = "Item"
        Me.Item.MinimumWidth = 6
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 125
        '
        'Cromo
        '
        Me.Cromo.HeaderText = "Cromo"
        Me.Cromo.MinimumWidth = 6
        Me.Cromo.Name = "Cromo"
        Me.Cromo.ReadOnly = True
        Me.Cromo.Width = 125
        '
        'AG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 512)
        Me.Controls.Add(Me.dgvPopulacao)
        Me.Controls.Add(Me.agChart)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFitness)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtfx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEvolve)
        Me.Controls.Add(Me.btnCalcular)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AG"
        Me.Text = "AG"
        CType(Me.agChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPopulacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtEvolve As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtX As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtfx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFitness As TextBox
    Friend WithEvents agChart As DataVisualization.Charting.Chart
    Friend WithEvents dgvPopulacao As DataGridView
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents Cromo As DataGridViewTextBoxColumn
End Class
