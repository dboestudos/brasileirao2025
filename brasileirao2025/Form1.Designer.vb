<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEquipes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEquipes))
        Me.label_equipe = New System.Windows.Forms.Label()
        Me.txt_equipe = New System.Windows.Forms.TextBox()
        Me.label_razaosocial = New System.Windows.Forms.Label()
        Me.txt_razaosocial = New System.Windows.Forms.TextBox()
        Me.label_equipeCidade = New System.Windows.Forms.Label()
        Me.txt_cidadeEquipe = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_equipesUF = New System.Windows.Forms.ComboBox()
        Me.label_CNPJ = New System.Windows.Forms.Label()
        Me.img_equipe = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Equipe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.img_equipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_equipe
        '
        Me.label_equipe.AutoSize = True
        Me.label_equipe.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.label_equipe.Location = New System.Drawing.Point(13, 13)
        Me.label_equipe.Name = "label_equipe"
        Me.label_equipe.Size = New System.Drawing.Size(73, 23)
        Me.label_equipe.TabIndex = 0
        Me.label_equipe.Text = "EQUIPE:"
        '
        'txt_equipe
        '
        Me.txt_equipe.Location = New System.Drawing.Point(13, 39)
        Me.txt_equipe.Name = "txt_equipe"
        Me.txt_equipe.Size = New System.Drawing.Size(232, 22)
        Me.txt_equipe.TabIndex = 1
        '
        'label_razaosocial
        '
        Me.label_razaosocial.AutoSize = True
        Me.label_razaosocial.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.label_razaosocial.Location = New System.Drawing.Point(9, 71)
        Me.label_razaosocial.Name = "label_razaosocial"
        Me.label_razaosocial.Size = New System.Drawing.Size(133, 23)
        Me.label_razaosocial.TabIndex = 2
        Me.label_razaosocial.Text = "RAZÃO SOCIAL:"
        '
        'txt_razaosocial
        '
        Me.txt_razaosocial.Location = New System.Drawing.Point(9, 98)
        Me.txt_razaosocial.Name = "txt_razaosocial"
        Me.txt_razaosocial.Size = New System.Drawing.Size(534, 22)
        Me.txt_razaosocial.TabIndex = 3
        '
        'label_equipeCidade
        '
        Me.label_equipeCidade.AutoSize = True
        Me.label_equipeCidade.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.label_equipeCidade.Location = New System.Drawing.Point(9, 132)
        Me.label_equipeCidade.Name = "label_equipeCidade"
        Me.label_equipeCidade.Size = New System.Drawing.Size(75, 23)
        Me.label_equipeCidade.TabIndex = 4
        Me.label_equipeCidade.Text = "CIDADE:"
        '
        'txt_cidadeEquipe
        '
        Me.txt_cidadeEquipe.Location = New System.Drawing.Point(13, 158)
        Me.txt_cidadeEquipe.Name = "txt_cidadeEquipe"
        Me.txt_cidadeEquipe.Size = New System.Drawing.Size(313, 22)
        Me.txt_cidadeEquipe.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(341, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "UF:"
        '
        'cmb_equipesUF
        '
        Me.cmb_equipesUF.FormattingEnabled = True
        Me.cmb_equipesUF.Location = New System.Drawing.Point(345, 158)
        Me.cmb_equipesUF.Name = "cmb_equipesUF"
        Me.cmb_equipesUF.Size = New System.Drawing.Size(55, 24)
        Me.cmb_equipesUF.TabIndex = 7
        '
        'label_CNPJ
        '
        Me.label_CNPJ.AutoSize = True
        Me.label_CNPJ.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.label_CNPJ.Location = New System.Drawing.Point(416, 131)
        Me.label_CNPJ.Name = "label_CNPJ"
        Me.label_CNPJ.Size = New System.Drawing.Size(53, 23)
        Me.label_CNPJ.TabIndex = 8
        Me.label_CNPJ.Text = "CNPJ:"
        '
        'img_equipe
        '
        Me.img_equipe.Image = CType(resources.GetObject("img_equipe.Image"), System.Drawing.Image)
        Me.img_equipe.Location = New System.Drawing.Point(588, 16)
        Me.img_equipe.Name = "img_equipe"
        Me.img_equipe.Size = New System.Drawing.Size(159, 165)
        Me.img_equipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.img_equipe.TabIndex = 10
        Me.img_equipe.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Equipe})
        Me.DataGridView1.Location = New System.Drawing.Point(17, 196)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(729, 246)
        Me.DataGridView1.TabIndex = 11
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(420, 159)
        Me.MaskedTextBox1.Mask = "00\.000\.000\/0000\-00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(123, 22)
        Me.MaskedTextBox1.TabIndex = 12
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'id
        '
        Me.id.HeaderText = "Column1"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Visible = False
        Me.id.Width = 125
        '
        'Equipe
        '
        Me.Equipe.HeaderText = "Equipe"
        Me.Equipe.MinimumWidth = 6
        Me.Equipe.Name = "Equipe"
        Me.Equipe.Width = 125
        '
        'FormEquipes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.img_equipe)
        Me.Controls.Add(Me.label_CNPJ)
        Me.Controls.Add(Me.cmb_equipesUF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cidadeEquipe)
        Me.Controls.Add(Me.label_equipeCidade)
        Me.Controls.Add(Me.txt_razaosocial)
        Me.Controls.Add(Me.label_razaosocial)
        Me.Controls.Add(Me.txt_equipe)
        Me.Controls.Add(Me.label_equipe)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormEquipes"
        Me.Text = "Equipes - Brasileirão 2025"
        CType(Me.img_equipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_equipe As Label
    Friend WithEvents txt_equipe As TextBox
    Friend WithEvents label_razaosocial As Label
    Friend WithEvents txt_razaosocial As TextBox
    Friend WithEvents label_equipeCidade As Label
    Friend WithEvents txt_cidadeEquipe As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_equipesUF As ComboBox
    Friend WithEvents label_CNPJ As Label
    Friend WithEvents img_equipe As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Equipe As DataGridViewTextBoxColumn
End Class
