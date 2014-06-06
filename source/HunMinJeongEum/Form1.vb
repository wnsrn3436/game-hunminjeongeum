Public Class frmMain

    Dim outgame(4) As Object
    Dim ingame(5) As Object
    Dim browser As New WebBrowser

    Enum STATE As Integer
        GAME_START
        GAME_END
    End Enum

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstWordBox1.SelectedIndex = 0
        lstWordBox2.SelectedIndex = 0
        lstWordBox3.SelectedIndex = 0
        outgame = {lstWordBox1, lstWordBox2, lstWordBox3, btnStart, btnRandomStart}
        ingame = {lblTimer, lblScore, lstInputWord, txtInputBox, btnInput, timTimer}
        AddHandler browser.DocumentCompleted, AddressOf Result
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        SetGameState(STATE.GAME_START)
    End Sub

    Private Sub btnRandomStart_Click(sender As Object, e As EventArgs) Handles btnRandomStart.Click
        Randomize()
        lstWordBox1.SelectedIndex = Fix(Rnd() * 14)
        lstWordBox2.SelectedIndex = Fix(Rnd() * 14)
        lstWordBox3.SelectedIndex = Fix(Rnd() * 15)
        SetGameState(STATE.GAME_START)
    End Sub

    Public Sub SetGameState(ByVal state As STATE)
        If (state = state.GAME_START) Then
            For Each instance In outgame
                instance.Enabled = False
            Next
            For Each instance In ingame
                instance.Enabled = True
            Next
            txtInputBox.Focus()
            lblState.Text = "상태: 단어를 입력해주세요."
            lblTimer.Text = "남은 시간: 15"
            lblScore.Text = "스코어: 0"
            lstInputWord.Items.Clear()
        Else
            For Each instance In outgame
                instance.Enabled = True
            Next
            For Each instance In ingame
                instance.Enabled = False
            Next
            lblState.Text = "상태: 단어 선택 중..."
        End If
    End Sub

    Private Sub txtInputBox_KeyUp(sender As Object, e As KeyEventArgs) Handles txtInputBox.KeyUp
        If (e.KeyValue = 13) Then InputWord()
    End Sub

    Private Sub btnInput_MouseUp(sender As Object, e As MouseEventArgs) Handles btnInput.MouseUp
        InputWord()
    End Sub

    Public Sub InputWord()
        For Each word In lstInputWord.Items
            If (word = txtInputBox.Text) Then
                lblState.Text = "상태: 중복된 단어입니다."
                txtInputBox.Text = ""
                Exit Sub
            End If
        Next
        If (txtInputBox.Text.Length > 1) Then
            If ((WordCheck(txtInputBox.Text(0), lstWordBox1.SelectedIndex) = True) And (WordCheck(txtInputBox.Text(1), lstWordBox2.SelectedIndex) = True) And (txtInputBox.Text.Length = 2 OrElse (txtInputBox.Text.Length = 3 AndAlso (WordCheck(txtInputBox.Text(2), lstWordBox3.SelectedIndex - 1) = True)))) Then
                browser.Navigate(New Uri("http://stdweb2.korean.go.kr/search/List_dic.jsp?PageRow=10&Table=words%7Cword&Gubun=0&SearchPart=Simple&SearchText=" & Uri.EscapeDataString(txtInputBox.Text)))
                lblState.Text = "상태: 단어 확인 중..."
                For Each instance In ingame
                    instance.Enabled = False
                Next
                Exit Sub
            End If
        End If
        lblState.Text = "상태: 문자 구성을 확인하세요."
        txtInputBox.Text = ""
    End Sub

    Public Function WordCheck(ByVal word As Char, ByVal index As Integer) As Boolean
        If (index >= 1) Then index += 1
        If (index >= 4) Then index += 1
        If (index >= 8) Then index += 1
        If (index >= 10) Then index += 1
        If (index >= 13) Then index += 1
        If ((((AscW(word) - &HAC00) \ 28) \ 21) = index) Then Return True
        Return False
    End Function

    Private Sub Result(sender As Object, e As WebBrowserDocumentCompletedEventArgs)
        Dim result As HtmlElementCollection = browser.Document.GetElementsByTagName("td")
        Dim htmltag As HtmlElement
        For Each htmltag In result
            If (htmltag.GetAttribute("className") = "sword") Then
                If (htmltag.InnerText <> "‘" & txtInputBox.Text & "’에 대한 검색 결과입니다.(0건) ") Then
                    lstInputWord.Items.Add(txtInputBox.Text)
                    lstInputWord.SelectedIndex = lstInputWord.Items.Count - 1
                    lblState.Text = "상태: 단어를 입력해주세요."
                    lblTimer.Text = "남은 시간: 15"
                    lblScore.Text = "스코어: " & (String_Digits(lblScore.Text) + 1)
                Else
                    lblState.Text = "잘못된 단어입니다."
                End If
                For Each instance In ingame
                    instance.Enabled = True
                Next
                txtInputBox.Text = ""
                txtInputBox.Focus()
                Exit Sub
            End If
        Next
    End Sub

    Private Sub timTimer_Tick(sender As Object, e As EventArgs) Handles timTimer.Tick
        If (lblTimer.Text = "남은 시간: 0") Then
            SetGameState(STATE.GAME_END)
            MsgBox(Space(10) & "게임이 끝났습니다." & Space(5) & vbCrLf & Space(13) & "최종 " & lblScore.Text)
        Else
            lblTimer.Text = "남은 시간: " & (String_Digits(lblTimer.Text) - 1)
        End If
    End Sub

    Public Function String_Digits(ByVal str As String) As Integer
        Dim newstr As String = ""
        For Each word In str
            If (Char.IsDigit(word) = True) Then newstr &= word
        Next
        Return Integer.Parse(newstr)
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class