<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Home
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Заводоуправление")
        Me.ts_TopMenu = New System.Windows.Forms.ToolStrip()
        Me.tsb_AddNode = New System.Windows.Forms.ToolStripButton()
        Me.tbs_CreateNode = New System.Windows.Forms.ToolStripButton()
        Me.tsb_DelNode = New System.Windows.Forms.ToolStripButton()
        Me.tsb_PersonInfo = New System.Windows.Forms.ToolStripButton()
        Me.tv_Structure = New System.Windows.Forms.TreeView()
        Me.lab_FamilyName = New System.Windows.Forms.Label()
        Me.lab_Name = New System.Windows.Forms.Label()
        Me.lab_Patronymic = New System.Windows.Forms.Label()
        Me.txt_FamilyName = New System.Windows.Forms.TextBox()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.txt_Patronymic = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_AddData = New System.Windows.Forms.DateTimePicker()
        Me.b_Select = New System.Windows.Forms.Button()
        Me.b_Clear = New System.Windows.Forms.Button()
        Me.ts_TopMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ts_TopMenu
        '
        Me.ts_TopMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_AddNode, Me.tbs_CreateNode, Me.tsb_DelNode, Me.tsb_PersonInfo})
        Me.ts_TopMenu.Location = New System.Drawing.Point(0, 0)
        Me.ts_TopMenu.Name = "ts_TopMenu"
        Me.ts_TopMenu.Size = New System.Drawing.Size(800, 25)
        Me.ts_TopMenu.TabIndex = 0
        Me.ts_TopMenu.Text = "ToolStrip1"
        '
        'tsb_AddNode
        '
        Me.tsb_AddNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_AddNode.Image = Global.Структура_предприятия.My.Resources.Resources.free_icon_plus_3285480
        Me.tsb_AddNode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_AddNode.Name = "tsb_AddNode"
        Me.tsb_AddNode.Size = New System.Drawing.Size(23, 22)
        Me.tsb_AddNode.Text = "ToolStripButton1"
        Me.tsb_AddNode.ToolTipText = "Добавить подразделение/должность"
        '
        'tbs_CreateNode
        '
        Me.tbs_CreateNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbs_CreateNode.Image = Global.Структура_предприятия.My.Resources.Resources.free_icon_paper_sheet_5607410
        Me.tbs_CreateNode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbs_CreateNode.Name = "tbs_CreateNode"
        Me.tbs_CreateNode.Size = New System.Drawing.Size(23, 22)
        Me.tbs_CreateNode.Text = "ToolStripButton2"
        Me.tbs_CreateNode.ToolTipText = "Редактировать подразделение/должность"
        '
        'tsb_DelNode
        '
        Me.tsb_DelNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_DelNode.Image = Global.Структура_предприятия.My.Resources.Resources.free_icon_cancel_179429
        Me.tsb_DelNode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_DelNode.Name = "tsb_DelNode"
        Me.tsb_DelNode.Size = New System.Drawing.Size(23, 22)
        Me.tsb_DelNode.Text = "ToolStripButton3"
        Me.tsb_DelNode.ToolTipText = "Удалить подразделение/должность"
        '
        'tsb_PersonInfo
        '
        Me.tsb_PersonInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_PersonInfo.Image = Global.Структура_предприятия.My.Resources.Resources.free_icon_networking_1006642
        Me.tsb_PersonInfo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_PersonInfo.Name = "tsb_PersonInfo"
        Me.tsb_PersonInfo.Size = New System.Drawing.Size(23, 22)
        Me.tsb_PersonInfo.Text = "ToolStripButton4"
        Me.tsb_PersonInfo.ToolTipText = "Справочних физических лиц"
        '
        'tv_Structure
        '
        Me.tv_Structure.Location = New System.Drawing.Point(33, 40)
        Me.tv_Structure.Name = "tv_Structure"
        TreeNode1.Name = "TopNode"
        TreeNode1.Tag = "General"
        TreeNode1.Text = "Заводоуправление"
        Me.tv_Structure.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.tv_Structure.Size = New System.Drawing.Size(372, 398)
        Me.tv_Structure.TabIndex = 1
        '
        'lab_FamilyName
        '
        Me.lab_FamilyName.AutoSize = True
        Me.lab_FamilyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lab_FamilyName.Location = New System.Drawing.Point(408, 40)
        Me.lab_FamilyName.Name = "lab_FamilyName"
        Me.lab_FamilyName.Size = New System.Drawing.Size(70, 16)
        Me.lab_FamilyName.TabIndex = 2
        Me.lab_FamilyName.Text = "Фамилия:"
        '
        'lab_Name
        '
        Me.lab_Name.AutoSize = True
        Me.lab_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lab_Name.Location = New System.Drawing.Point(408, 66)
        Me.lab_Name.Name = "lab_Name"
        Me.lab_Name.Size = New System.Drawing.Size(37, 16)
        Me.lab_Name.TabIndex = 3
        Me.lab_Name.Text = "Имя:"
        '
        'lab_Patronymic
        '
        Me.lab_Patronymic.AutoSize = True
        Me.lab_Patronymic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lab_Patronymic.Location = New System.Drawing.Point(408, 94)
        Me.lab_Patronymic.Name = "lab_Patronymic"
        Me.lab_Patronymic.Size = New System.Drawing.Size(74, 16)
        Me.lab_Patronymic.TabIndex = 4
        Me.lab_Patronymic.Text = "Отчество:"
        '
        'txt_FamilyName
        '
        Me.txt_FamilyName.Location = New System.Drawing.Point(518, 38)
        Me.txt_FamilyName.Name = "txt_FamilyName"
        Me.txt_FamilyName.Size = New System.Drawing.Size(260, 20)
        Me.txt_FamilyName.TabIndex = 5
        '
        'txt_Name
        '
        Me.txt_Name.Location = New System.Drawing.Point(518, 64)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(260, 20)
        Me.txt_Name.TabIndex = 6
        '
        'txt_Patronymic
        '
        Me.txt_Patronymic.Location = New System.Drawing.Point(518, 92)
        Me.txt_Patronymic.Name = "txt_Patronymic"
        Me.txt_Patronymic.Size = New System.Drawing.Size(260, 20)
        Me.txt_Patronymic.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(408, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Дата принятия:"
        '
        'dtp_AddData
        '
        Me.dtp_AddData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.dtp_AddData.Location = New System.Drawing.Point(518, 120)
        Me.dtp_AddData.Name = "dtp_AddData"
        Me.dtp_AddData.Size = New System.Drawing.Size(130, 22)
        Me.dtp_AddData.TabIndex = 9
        '
        'b_Select
        '
        Me.b_Select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.b_Select.Image = Global.Структура_предприятия.My.Resources.Resources.free_icon_talent_search_2272580
        Me.b_Select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_Select.Location = New System.Drawing.Point(411, 159)
        Me.b_Select.Name = "b_Select"
        Me.b_Select.Size = New System.Drawing.Size(92, 34)
        Me.b_Select.TabIndex = 10
        Me.b_Select.Text = "Выбрать"
        Me.b_Select.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_Select.UseVisualStyleBackColor = True
        '
        'b_Clear
        '
        Me.b_Clear.Image = Global.Структура_предприятия.My.Resources.Resources.free_icon_eraser_2661282
        Me.b_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_Clear.Location = New System.Drawing.Point(518, 159)
        Me.b_Clear.Name = "b_Clear"
        Me.b_Clear.Size = New System.Drawing.Size(92, 34)
        Me.b_Clear.TabIndex = 11
        Me.b_Clear.Text = "Очистить"
        Me.b_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_Clear.UseVisualStyleBackColor = True
        '
        'frm_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.b_Clear)
        Me.Controls.Add(Me.b_Select)
        Me.Controls.Add(Me.dtp_AddData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Patronymic)
        Me.Controls.Add(Me.txt_Name)
        Me.Controls.Add(Me.txt_FamilyName)
        Me.Controls.Add(Me.lab_Patronymic)
        Me.Controls.Add(Me.lab_Name)
        Me.Controls.Add(Me.lab_FamilyName)
        Me.Controls.Add(Me.tv_Structure)
        Me.Controls.Add(Me.ts_TopMenu)
        Me.Name = "frm_Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Структура предприятия"
        Me.ts_TopMenu.ResumeLayout(False)
        Me.ts_TopMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ts_TopMenu As ToolStrip
    Friend WithEvents tsb_AddNode As ToolStripButton
    Friend WithEvents tbs_CreateNode As ToolStripButton
    Friend WithEvents tsb_DelNode As ToolStripButton
    Friend WithEvents tsb_PersonInfo As ToolStripButton
    Friend WithEvents tv_Structure As TreeView
    Friend WithEvents lab_FamilyName As Label
    Friend WithEvents lab_Name As Label
    Friend WithEvents lab_Patronymic As Label
    Friend WithEvents txt_FamilyName As TextBox
    Friend WithEvents txt_Name As TextBox
    Friend WithEvents txt_Patronymic As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_AddData As DateTimePicker
    Friend WithEvents b_Select As Button
    Friend WithEvents b_Clear As Button
End Class
