<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Flag = New System.Windows.Forms.CheckBox()
        Me.NoActiveRadio = New System.Windows.Forms.RadioButton()
        Me.TurnOffRadio = New System.Windows.Forms.RadioButton()
        Me.TurnOnRadio = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.Flag)
        Me.Panel1.Controls.Add(Me.NoActiveRadio)
        Me.Panel1.Controls.Add(Me.TurnOffRadio)
        Me.Panel1.Controls.Add(Me.TurnOnRadio)
        Me.Panel1.Location = New System.Drawing.Point(16, 16)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 216)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cостояния:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Панель состояния:"
        '
        'ListBox1
        '
        Me.ListBox1.AllowDrop = True
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 22
        Me.ListBox1.Location = New System.Drawing.Point(153, 37)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(179, 158)
        Me.ListBox1.TabIndex = 6
        '
        'Flag
        '
        Me.Flag.AutoSize = True
        Me.Flag.Location = New System.Drawing.Point(18, 36)
        Me.Flag.Margin = New System.Windows.Forms.Padding(4)
        Me.Flag.Name = "Flag"
        Me.Flag.Size = New System.Drawing.Size(101, 26)
        Me.Flag.TabIndex = 3
        Me.Flag.Text = "Удалить"
        Me.Flag.UseVisualStyleBackColor = True
        '
        'NoActiveRadio
        '
        Me.NoActiveRadio.AutoSize = True
        Me.NoActiveRadio.Location = New System.Drawing.Point(18, 169)
        Me.NoActiveRadio.Margin = New System.Windows.Forms.Padding(4)
        Me.NoActiveRadio.Name = "NoActiveRadio"
        Me.NoActiveRadio.Size = New System.Drawing.Size(127, 26)
        Me.NoActiveRadio.TabIndex = 2
        Me.NoActiveRadio.TabStop = True
        Me.NoActiveRadio.Text = "Не активен"
        Me.NoActiveRadio.UseVisualStyleBackColor = True
        '
        'TurnOffRadio
        '
        Me.TurnOffRadio.AutoSize = True
        Me.TurnOffRadio.Location = New System.Drawing.Point(18, 132)
        Me.TurnOffRadio.Margin = New System.Windows.Forms.Padding(4)
        Me.TurnOffRadio.Name = "TurnOffRadio"
        Me.TurnOffRadio.Size = New System.Drawing.Size(121, 26)
        Me.TurnOffRadio.TabIndex = 1
        Me.TurnOffRadio.TabStop = True
        Me.TurnOffRadio.Text = "Выключен"
        Me.TurnOffRadio.UseVisualStyleBackColor = True
        '
        'TurnOnRadio
        '
        Me.TurnOnRadio.AutoSize = True
        Me.TurnOnRadio.Location = New System.Drawing.Point(18, 96)
        Me.TurnOnRadio.Margin = New System.Windows.Forms.Padding(4)
        Me.TurnOnRadio.Name = "TurnOnRadio"
        Me.TurnOnRadio.Size = New System.Drawing.Size(108, 26)
        Me.TurnOnRadio.TabIndex = 0
        Me.TurnOnRadio.TabStop = True
        Me.TurnOnRadio.Text = "Включен"
        Me.TurnOnRadio.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 245)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Элемент управления"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Flag As CheckBox
    Friend WithEvents NoActiveRadio As RadioButton
    Friend WithEvents TurnOffRadio As RadioButton
    Friend WithEvents TurnOnRadio As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
