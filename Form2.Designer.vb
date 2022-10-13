<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CreatNode
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lab_NodeType = New System.Windows.Forms.Label()
        Me.lab_NodeValue = New System.Windows.Forms.Label()
        Me.cb_NodeType = New System.Windows.Forms.ComboBox()
        Me.txt_NodeName = New System.Windows.Forms.TextBox()
        Me.b_Ok = New System.Windows.Forms.Button()
        Me.b_Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lab_NodeType
        '
        Me.lab_NodeType.AutoSize = True
        Me.lab_NodeType.Location = New System.Drawing.Point(12, 18)
        Me.lab_NodeType.Name = "lab_NodeType"
        Me.lab_NodeType.Size = New System.Drawing.Size(61, 13)
        Me.lab_NodeType.TabIndex = 0
        Me.lab_NodeType.Text = "Тип ветки:"
        '
        'lab_NodeValue
        '
        Me.lab_NodeValue.AutoSize = True
        Me.lab_NodeValue.Location = New System.Drawing.Point(12, 53)
        Me.lab_NodeValue.Name = "lab_NodeValue"
        Me.lab_NodeValue.Size = New System.Drawing.Size(86, 13)
        Me.lab_NodeValue.TabIndex = 1
        Me.lab_NodeValue.Text = "Наименование:"
        '
        'cb_NodeType
        '
        Me.cb_NodeType.FormattingEnabled = True
        Me.cb_NodeType.Location = New System.Drawing.Point(113, 15)
        Me.cb_NodeType.Name = "cb_NodeType"
        Me.cb_NodeType.Size = New System.Drawing.Size(230, 21)
        Me.cb_NodeType.TabIndex = 2
        '
        'txt_NodeName
        '
        Me.txt_NodeName.Location = New System.Drawing.Point(113, 50)
        Me.txt_NodeName.Name = "txt_NodeName"
        Me.txt_NodeName.Size = New System.Drawing.Size(230, 20)
        Me.txt_NodeName.TabIndex = 3
        '
        'b_Ok
        '
        Me.b_Ok.Location = New System.Drawing.Point(187, 83)
        Me.b_Ok.Name = "b_Ok"
        Me.b_Ok.Size = New System.Drawing.Size(75, 23)
        Me.b_Ok.TabIndex = 4
        Me.b_Ok.TabStop = False
        Me.b_Ok.Text = "OК"
        Me.b_Ok.UseVisualStyleBackColor = True
        '
        'b_Cancel
        '
        Me.b_Cancel.Location = New System.Drawing.Point(268, 83)
        Me.b_Cancel.Name = "b_Cancel"
        Me.b_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.b_Cancel.TabIndex = 5
        Me.b_Cancel.Text = "Отмена"
        Me.b_Cancel.UseVisualStyleBackColor = True
        '
        'frm_CreatNode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 118)
        Me.Controls.Add(Me.b_Cancel)
        Me.Controls.Add(Me.b_Ok)
        Me.Controls.Add(Me.txt_NodeName)
        Me.Controls.Add(Me.cb_NodeType)
        Me.Controls.Add(Me.lab_NodeValue)
        Me.Controls.Add(Me.lab_NodeType)
        Me.Name = "frm_CreatNode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Изменение ветки"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lab_NodeType As Label
    Friend WithEvents lab_NodeValue As Label
    Friend WithEvents cb_NodeType As ComboBox
    Friend WithEvents txt_NodeName As TextBox
    Friend WithEvents b_Ok As Button
    Friend WithEvents b_Cancel As Button
End Class
