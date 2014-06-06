<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lstWordBox1 = New System.Windows.Forms.ListBox()
        Me.lstWordBox2 = New System.Windows.Forms.ListBox()
        Me.lstWordBox3 = New System.Windows.Forms.ListBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnRandomStart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picScore = New System.Windows.Forms.PictureBox()
        Me.picTimer = New System.Windows.Forms.PictureBox()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lstInputWord = New System.Windows.Forms.ListBox()
        Me.txtInputBox = New System.Windows.Forms.TextBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.lblState = New System.Windows.Forms.Label()
        Me.timTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstWordBox1
        '
        Me.lstWordBox1.FormattingEnabled = True
        Me.lstWordBox1.ItemHeight = 12
        Me.lstWordBox1.Items.AddRange(New Object() {"ㄱ", "ㄴ", "ㄷ", "ㄹ", "ㅁ", "ㅂ", "ㅅ", "ㅇ", "ㅈ", "ㅊ", "ㅋ", "ㅌ", "ㅍ", "ㅎ"})
        Me.lstWordBox1.Location = New System.Drawing.Point(12, 270)
        Me.lstWordBox1.Name = "lstWordBox1"
        Me.lstWordBox1.Size = New System.Drawing.Size(120, 160)
        Me.lstWordBox1.TabIndex = 0
        '
        'lstWordBox2
        '
        Me.lstWordBox2.FormattingEnabled = True
        Me.lstWordBox2.ItemHeight = 12
        Me.lstWordBox2.Items.AddRange(New Object() {"ㄱ", "ㄴ", "ㄷ", "ㄹ", "ㅁ", "ㅂ", "ㅅ", "ㅇ", "ㅈ", "ㅊ", "ㅋ", "ㅌ", "ㅍ", "ㅎ"})
        Me.lstWordBox2.Location = New System.Drawing.Point(138, 270)
        Me.lstWordBox2.Name = "lstWordBox2"
        Me.lstWordBox2.Size = New System.Drawing.Size(120, 160)
        Me.lstWordBox2.TabIndex = 1
        '
        'lstWordBox3
        '
        Me.lstWordBox3.FormattingEnabled = True
        Me.lstWordBox3.ItemHeight = 12
        Me.lstWordBox3.Items.AddRange(New Object() {"", "ㄱ", "ㄴ", "ㄷ", "ㄹ", "ㅁ", "ㅂ", "ㅅ", "ㅇ", "ㅈ", "ㅊ", "ㅋ", "ㅌ", "ㅍ", "ㅎ"})
        Me.lstWordBox3.Location = New System.Drawing.Point(264, 270)
        Me.lstWordBox3.Name = "lstWordBox3"
        Me.lstWordBox3.Size = New System.Drawing.Size(120, 160)
        Me.lstWordBox3.TabIndex = 2
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(390, 270)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(119, 50)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "게임 시작"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnRandomStart
        '
        Me.btnRandomStart.Location = New System.Drawing.Point(390, 326)
        Me.btnRandomStart.Name = "btnRandomStart"
        Me.btnRandomStart.Size = New System.Drawing.Size(119, 50)
        Me.btnRandomStart.TabIndex = 4
        Me.btnRandomStart.Text = "랜덤 선택 시작"
        Me.btnRandomStart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(390, 380)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(119, 50)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "훈민정음 종료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picScore
        '
        Me.picScore.Image = Global.HunMinJeongEum.My.Resources.Resources.Score
        Me.picScore.Location = New System.Drawing.Point(324, 12)
        Me.picScore.Name = "picScore"
        Me.picScore.Size = New System.Drawing.Size(60, 60)
        Me.picScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picScore.TabIndex = 7
        Me.picScore.TabStop = False
        '
        'picTimer
        '
        Me.picTimer.Image = Global.HunMinJeongEum.My.Resources.Resources.Timer
        Me.picTimer.Location = New System.Drawing.Point(12, 12)
        Me.picTimer.Name = "picTimer"
        Me.picTimer.Size = New System.Drawing.Size(60, 60)
        Me.picTimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTimer.TabIndex = 6
        Me.picTimer.TabStop = False
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Enabled = False
        Me.lblTimer.Location = New System.Drawing.Point(78, 60)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(71, 12)
        Me.lblTimer.TabIndex = 8
        Me.lblTimer.Text = "남은 시간: 0"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Enabled = False
        Me.lblScore.Location = New System.Drawing.Point(390, 60)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(55, 12)
        Me.lblScore.TabIndex = 9
        Me.lblScore.Text = "스코어: 0"
        '
        'lstInputWord
        '
        Me.lstInputWord.Enabled = False
        Me.lstInputWord.FormattingEnabled = True
        Me.lstInputWord.ItemHeight = 12
        Me.lstInputWord.Location = New System.Drawing.Point(12, 113)
        Me.lstInputWord.Name = "lstInputWord"
        Me.lstInputWord.ScrollAlwaysVisible = True
        Me.lstInputWord.Size = New System.Drawing.Size(497, 112)
        Me.lstInputWord.TabIndex = 10
        '
        'txtInputBox
        '
        Me.txtInputBox.Enabled = False
        Me.txtInputBox.Location = New System.Drawing.Point(12, 231)
        Me.txtInputBox.Name = "txtInputBox"
        Me.txtInputBox.Size = New System.Drawing.Size(246, 21)
        Me.txtInputBox.TabIndex = 11
        '
        'btnInput
        '
        Me.btnInput.Enabled = False
        Me.btnInput.Location = New System.Drawing.Point(264, 231)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 23)
        Me.btnInput.TabIndex = 12
        Me.btnInput.Text = "입력"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(345, 236)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(117, 12)
        Me.lblState.TabIndex = 13
        Me.lblState.Text = "상태: 단어 선택 중..."
        '
        'timTimer
        '
        Me.timTimer.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 442)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.txtInputBox)
        Me.Controls.Add(Me.lstInputWord)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.picScore)
        Me.Controls.Add(Me.picTimer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRandomStart)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lstWordBox3)
        Me.Controls.Add(Me.lstWordBox2)
        Me.Controls.Add(Me.lstWordBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(538, 480)
        Me.MinimumSize = New System.Drawing.Size(538, 480)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "훈민정음 게임"
        CType(Me.picScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTimer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstWordBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lstWordBox2 As System.Windows.Forms.ListBox
    Friend WithEvents lstWordBox3 As System.Windows.Forms.ListBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnRandomStart As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picTimer As System.Windows.Forms.PictureBox
    Friend WithEvents picScore As System.Windows.Forms.PictureBox
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lstInputWord As System.Windows.Forms.ListBox
    Friend WithEvents txtInputBox As System.Windows.Forms.TextBox
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents timTimer As System.Windows.Forms.Timer

End Class
