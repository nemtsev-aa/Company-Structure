<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_SelectPerson
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
        Me.txt_Patronymic = New System.Windows.Forms.TextBox()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.txt_Family = New System.Windows.Forms.TextBox()
        Me.lab_Patronymic = New System.Windows.Forms.Label()
        Me.lab_Name = New System.Windows.Forms.Label()
        Me.lab_FamilyName = New System.Windows.Forms.Label()
        Me.b_FindPerson = New System.Windows.Forms.Button()
        Me.dgv_Person = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.b_Ok = New System.Windows.Forms.Button()
        Me.b_Cancel = New System.Windows.Forms.Button()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ManagementDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ManagementDataSet = New Структура_предприятия.ManagementDataSet()
        Me.PersonTableAdapter = New Структура_предприятия.ManagementDataSetTableAdapters.PersonTableAdapter()
        CType(Me.dgv_Person, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagementDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Patronymic
        '
        Me.txt_Patronymic.Location = New System.Drawing.Point(628, 10)
        Me.txt_Patronymic.Name = "txt_Patronymic"
        Me.txt_Patronymic.Size = New System.Drawing.Size(150, 20)
        Me.txt_Patronymic.TabIndex = 13
        '
        'txt_Name
        '
        Me.txt_Name.Location = New System.Drawing.Point(339, 10)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(150, 20)
        Me.txt_Name.TabIndex = 12
        '
        'txt_Family
        '
        Me.txt_Family.Location = New System.Drawing.Point(89, 10)
        Me.txt_Family.Name = "txt_Family"
        Me.txt_Family.Size = New System.Drawing.Size(150, 20)
        Me.txt_Family.TabIndex = 11
        '
        'lab_Patronymic
        '
        Me.lab_Patronymic.AutoSize = True
        Me.lab_Patronymic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lab_Patronymic.Location = New System.Drawing.Point(539, 12)
        Me.lab_Patronymic.Name = "lab_Patronymic"
        Me.lab_Patronymic.Size = New System.Drawing.Size(74, 16)
        Me.lab_Patronymic.TabIndex = 10
        Me.lab_Patronymic.Text = "Отчество:"
        '
        'lab_Name
        '
        Me.lab_Name.AutoSize = True
        Me.lab_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lab_Name.Location = New System.Drawing.Point(296, 12)
        Me.lab_Name.Name = "lab_Name"
        Me.lab_Name.Size = New System.Drawing.Size(37, 16)
        Me.lab_Name.TabIndex = 9
        Me.lab_Name.Text = "Имя:"
        '
        'lab_FamilyName
        '
        Me.lab_FamilyName.AutoSize = True
        Me.lab_FamilyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lab_FamilyName.Location = New System.Drawing.Point(13, 12)
        Me.lab_FamilyName.Name = "lab_FamilyName"
        Me.lab_FamilyName.Size = New System.Drawing.Size(70, 16)
        Me.lab_FamilyName.TabIndex = 8
        Me.lab_FamilyName.Text = "Фамилия:"
        '
        'b_FindPerson
        '
        Me.b_FindPerson.Location = New System.Drawing.Point(16, 45)
        Me.b_FindPerson.Name = "b_FindPerson"
        Me.b_FindPerson.Size = New System.Drawing.Size(762, 25)
        Me.b_FindPerson.TabIndex = 14
        Me.b_FindPerson.Text = "Найти"
        Me.b_FindPerson.UseVisualStyleBackColor = True
        '
        'dgv_Person
        '
        Me.dgv_Person.AllowUserToAddRows = False
        Me.dgv_Person.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Person.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_Person.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Person.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgv_Person.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Person.Name = "dgv_Person"
        Me.dgv_Person.ReadOnly = True
        Me.dgv_Person.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Person.Size = New System.Drawing.Size(798, 150)
        Me.dgv_Person.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgv_Person)
        Me.Panel1.Location = New System.Drawing.Point(2, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(798, 313)
        Me.Panel1.TabIndex = 16
        '
        'b_Ok
        '
        Me.b_Ok.Image = Global.Структура_предприятия.My.Resources.Resources.free_icon_check_5610944
        Me.b_Ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_Ok.Location = New System.Drawing.Point(628, 404)
        Me.b_Ok.Name = "b_Ok"
        Me.b_Ok.Size = New System.Drawing.Size(67, 33)
        Me.b_Ok.TabIndex = 17
        Me.b_Ok.Text = "ОК"
        Me.b_Ok.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_Ok.UseVisualStyleBackColor = True
        '
        'b_Cancel
        '
        Me.b_Cancel.Image = Global.Структура_предприятия.My.Resources.Resources.free_icon_cancelled_7080047
        Me.b_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_Cancel.Location = New System.Drawing.Point(709, 404)
        Me.b_Cancel.Name = "b_Cancel"
        Me.b_Cancel.Size = New System.Drawing.Size(79, 33)
        Me.b_Cancel.TabIndex = 18
        Me.b_Cancel.Text = "Отмена"
        Me.b_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_Cancel.UseVisualStyleBackColor = True
        '
        'PersonBindingSource
        '
        Me.PersonBindingSource.DataMember = "Person"
        Me.PersonBindingSource.DataSource = Me.ManagementDataSetBindingSource
        '
        'ManagementDataSetBindingSource
        '
        Me.ManagementDataSetBindingSource.DataSource = Me.ManagementDataSet
        Me.ManagementDataSetBindingSource.Position = 0
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
        'frm_SelectPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 442)
        Me.Controls.Add(Me.b_Cancel)
        Me.Controls.Add(Me.b_Ok)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.b_FindPerson)
        Me.Controls.Add(Me.txt_Patronymic)
        Me.Controls.Add(Me.txt_Name)
        Me.Controls.Add(Me.txt_Family)
        Me.Controls.Add(Me.lab_Patronymic)
        Me.Controls.Add(Me.lab_Name)
        Me.Controls.Add(Me.lab_FamilyName)
        Me.Name = "frm_SelectPerson"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Выберите сотрудника"
        CType(Me.dgv_Person, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagementDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Patronymic As TextBox
    Friend WithEvents txt_Name As TextBox
    Friend WithEvents txt_Family As TextBox
    Friend WithEvents lab_Patronymic As Label
    Friend WithEvents lab_Name As Label
    Friend WithEvents lab_FamilyName As Label
    Friend WithEvents b_FindPerson As Button
    Friend WithEvents dgv_Person As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents b_Ok As Button
    Friend WithEvents b_Cancel As Button
    Friend WithEvents ManagementDataSetBindingSource As BindingSource
    Friend WithEvents ManagementDataSet As ManagementDataSet
    Friend WithEvents PersonBindingSource As BindingSource
    Friend WithEvents PersonTableAdapter As ManagementDataSetTableAdapters.PersonTableAdapter
End Class
