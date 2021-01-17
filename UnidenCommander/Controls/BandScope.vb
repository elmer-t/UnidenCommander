Public Class BandScope

	Public MaxValue As Single = 100
	Public MinValue As Single = 0
	Public LowerFrequency As Integer = 25000
	Public UpperFrequency As Integer = 28000
	Public StepSize As Single = 50

	Public XGridLines As Integer = 10
	Public YGridLines As Integer = 6

	Private values As New Dictionary(Of Integer, Single)

	Private Sub BandScope_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		FillTestData()
		'DrawGrid()
	End Sub

	Public Sub AddValue(ByVal frequency As Integer, ByVal value As Single)
		values.Add(frequency, value)
	End Sub

	Private Sub DrawGrid()

		Me.SuspendLayout()

		Dim g As Graphics = Me.Graph.CreateGraphics
		Dim p As Pen = New Pen(Color.Black, 1)
		Dim x, y As Integer

		For i As Integer = 0 To XGridLines

			If i = 0 Or i = XGridLines Then
				p.DashStyle = Drawing2D.DashStyle.Solid
			Else
				p.DashStyle = Drawing2D.DashStyle.Dot
			End If

			x = Convert.ToInt32((Me.Graph.Width - 1) / XGridLines * i)
			g.DrawLine(p, x, 0, x, Me.Height)

		Next

		For i As Integer = 0 To YGridLines

			If i = 0 Or i = YGridLines Then
				p.DashStyle = Drawing2D.DashStyle.Solid
			Else
				p.DashStyle = Drawing2D.DashStyle.Dot
			End If

			y = Convert.ToInt32((Me.Graph.Height - 1) / YGridLines * i)
			g.DrawLine(p, 0, y, Me.Width, y)

		Next

		Me.ResumeLayout()

	End Sub

	Private Sub DrawLabels()
		Me.lblLowerBound.Text = Me.LowerFrequency.ToString("F4")
		Me.lblUpperBound.Text = Me.UpperFrequency.ToString("F4")
		Me.lblStepSize.Text = Me.StepSize.ToString("F1") & "k"
	End Sub

	Private Sub DrawGraph()

		Dim g As Graphics = Me.Graph.CreateGraphics
		Dim p As Pen = New Pen(Color.Blue, 1)
		p.Brush = Brushes.AliceBlue

		Dim steps As Integer = Convert.ToInt32((Me.UpperFrequency - Me.LowerFrequency) / Me.StepSize)
		Dim itemWidth As Single = Convert.ToSingle(Me.Graph.Width / steps)
		Dim x As Single

		For Each freq As Integer In Me.values.Keys

			x = Convert.ToSingle(((freq - Me.LowerFrequency) * steps) / (Me.UpperFrequency - Me.LowerFrequency))
			g.DrawRectangle(p, x, (Me.MaxValue - Me.values(freq)), itemWidth, Me.values(freq))

		Next

	End Sub

	Private Sub BandScope_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
		DrawGrid()
		DrawLabels()
		DrawGraph()
	End Sub

	Public Sub Reset()

		Me.values.Clear()
		Dim g As Graphics = Me.Graph.CreateGraphics
		g.Clear(Color.DarkOrange)

	End Sub

	Public Sub FillTestData()

		Me.MaxValue = 100
		Me.MinValue = 0
		Me.UpperFrequency = 146000
		Me.LowerFrequency = 145000
		Me.StepSize = 50

		Dim rnd As New Random

		For i As Double = Me.LowerFrequency To Me.UpperFrequency Step Me.StepSize

			Me.AddValue(Convert.ToInt32(i), rnd.Next(Convert.ToInt32(Me.MinValue), Convert.ToInt32(Me.MaxValue - 20)))

		Next

		Me.Invalidate()

	End Sub

End Class
