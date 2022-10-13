<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_GuidePerson
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_GuidePerson))
        Me.ts_TopMenu = New System.Windows.Forms.ToolStrip()
        Me.tsb_AddPerson = New System.Windows.Forms.ToolStripButton()
        Me.tbs_EditPerson = New System.Windows.Forms.ToolStripButton()
        Me.tsb_DelPerson = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.dgv_Person = New System.Windows.Forms.DataGridView()
        Me.IdPersonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FamilyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatronymicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ManagementDataSet = New Структура_предприятия.ManagementDataSet()
        Me.PersonTableAdapter = New Структура_предприятия.ManagementDataSetTableAdapters.PersonTableAdapter()
        Me.ts_TopMenu.SuspendLayout()
        CType(Me.dgv_Person, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ts_TopMenu
        '
        Me.ts_TopMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_AddPerson, Me.tbs_EditPerson, Me.tsb_DelPerson, Me.ToolStripButton1})
        Me.ts_TopMenu.Location = New System.Drawing.Point(0, 0)
        Me.ts_TopMenu.Name = "ts_TopMenu"
        Me.ts_TopMenu.Size = New System.Drawing.Size(800, 25)
        Me.ts_TopMenu.TabIndex = 1
        Me.ts_TopMenu.Text = "ToolStrip1"
        '
        'tsb_AddPerson
        '
        Me.tsb_AddPerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_AddPerson.Image = Global.Структура_предприятия.My.Resources.Resources.free_icon_plus_3285480
        Me.tsb_AddPerson.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_AddPerson.Name = "tsb_AddPerson"
        Me.tsb_AddPerson.Size = New System.Drawing.Size(23, 22)
        Me.tsb_AddPerson.Text = "ToolStripButton1"
        Me.tsb_AddPerson.ToolTipText = "Добавить запись"
        '
        'tbs_EditPerson
        '
        Me.tbs_EditPerson.CheckOnClick = True
        Me.tbs_EditPerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbs_EditPerson.Image = Global.Структура_предприятия.My.Resources.Resources.free_icon_paper_sheet_5607410
        Me.tbs_EditPerson.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbs_EditPerson.Name = "tbs_EditPerson"
        Me.tbs_EditPerson.Size = New System.Drawing.Size(23, 22)
        Me.tbs_EditPerson.Text = "ToolStripButton2"
        Me.tbs_EditPerson.ToolTipText = "Редактировать запись"
        '
        'tsb_DelPerson
        '
        Me.tsb_DelPerson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_DelPerson.Image = Global.Структура_предприятия.My.Resources.Resources.free_icon_cancel_179429
        Me.tsb_DelPerson.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_DelPerson.Name = "tsb_DelPerson"
        Me.tsb_DelPerson.Size = New System.Drawing.Size(23, 22)
        Me.tsb_DelPerson.Text = "ToolStripButton3"
        Me.tsb_DelPerson.ToolTipText = "Удалить запись"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'dgv_Person
        '
        Me.dgv_Person.AllowUserToAddRows = False
        Me.dgv_Person.AutoGenerateColumns = False
        Me.dgv_Person.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Person.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_Person.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Person.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPersonDataGridViewTextBoxColumn, Me.FamilyDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PatronymicDataGridViewTextBoxColumn})
        Me.dgv_Person.DataSource = Me.PersonBindingSource
        Me.dgv_Person.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Person.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgv_Person.Location = New System.Drawing.Point(0, 25)
        Me.dgv_Person.Name = "dgv_Person"
        Me.dgv_Person.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_Person.Size = New System.Drawing.Size(800, 425)
        Me.dgv_Person.TabIndex = 2
        '
        'IdPersonDataGridViewTextBoxColumn
        '
        Me.IdPersonDataGridViewTextBoxColumn.DataPropertyName = "idPerson"
        Me.IdPersonDataGridViewTextBoxColumn.HeaderText = "idPerson"
        Me.IdPersonDataGridViewTextBoxColumn.Name = "IdPersonDataGridViewTextBoxColumn"
        Me.IdPersonDataGridViewTextBoxColumn.Visible = False
        '
        'FamilyDataGridViewTextBoxColumn
        '
        Me.FamilyDataGridViewTextBoxColumn.DataPropertyName = "Family"
        Me.FamilyDataGridViewTextBoxColumn.HeaderText = "Фамилия"
        Me.FamilyDataGridViewTextBoxColumn.Name = "FamilyDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Имя"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'PatronymicDataGridViewTextBoxColumn
        '
        Me.PatronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic"
        Me.PatronymicDataGridViewTextBoxColumn.HeaderText = "Отчество"
        Me.PatronymicDataGridViewTextBoxColumn.Name = "PatronymicDataGridViewTextBoxColumn"
        '
        'PersonBindingSource
        '
        Me.PersonBindingSource.DataMember = "Person"
        Me.PersonBindingSource.DataSource = Me.BindingSource1
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.ManagementDataSet
        Me.BindingSource1.Position = 0
        '
        'ManagementDataSet
        '
        Me.ManagementDataSet.DataSetName = "ManagementDataSet"
        Me.ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
        '
        'frm_GuidePerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgv_Person)
        Me.Controls.Add(Me.ts_TopMenu)
        Me.Name = "frm_GuidePerson"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Справочник физических лиц"
        Me.ts_TopMenu.ResumeLayout(False)
        Me.ts_TopMenu.PerformLayout()
        CType(Me.dgv_Person, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ts_TopMenu As ToolStrip
    Friend WithEvents tsb_AddPerson As ToolStripButton
    Friend WithEvents tbs_EditPerson As ToolStripButton
    Friend WithEvents tsb_DelPerson As ToolStripButton
    Friend WithEvents dgv_Person As DataGridView
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ManagementDataSet As ManagementDataSet
    Friend WithEvents PersonBindingSource As BindingSource
    Friend WithEvents PersonTableAdapter As ManagementDataSetTableAdapters.PersonTableAdapter
    Friend WithEvents IdPersonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FamilyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatronymicDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
