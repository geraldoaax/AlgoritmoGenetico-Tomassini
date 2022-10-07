Imports System.Windows.Forms.DataVisualization.Charting
Public Class AG
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim ag As New AGClass()
        ag.randPop()

        agChart.Series.Clear()

        Dim s1 As New Series
        s1.Points.Clear()
        s1.Name = "Função de Aptidão"
        s1.ChartType = SeriesChartType.Line
        agChart.Series.Add(s1)
        'Trocar a plotagem de -1 a 2 (ex 1)
        For i As Integer = -512 To 512
            s1.Points.AddXY(i, -ag.Fnfitness(i))


        Next

        Dim s2 As New Series
        s2.Points.Clear()
        s2.Name = "População"
        s2.ChartType = SeriesChartType.Point
        agChart.Series.Add(s2)

        For d As Integer = 0 To txtEvolve.Text
            dgvPopulacao.Rows.Clear()
            s2.Points.Clear()
            System.Threading.Thread.Sleep(200)

            ag.evolve(1)

            txtX.Text = CStr(ag.bestInd())
            txtfx.Text = CStr(ag.Fnfitness(ag.bestInd()))
            txtFitness.Text = CStr(ag.bestFitness())

            'X - For de -512 a 512
            'Y - Formula (-)Fnfitness 


            'agChart.Titles.Add("AG")

            'X - Point Função de decodificação do indvíduo



            Dim x = 0

            For i As Integer = 0 To ag.popSz - 1
                x = ag.decodeInd(ag.pop(i))
                s2.Points.AddXY(x, -ag.Fnfitness(x))
                dgvPopulacao.Rows.Add(x, -ag.Fnfitness(x))
            Next
            Application.DoEvents()
        Next
        'Y - Formula (-)Fnfitness 'Configurar como pontos
        'MessageBox.Show(String.Format("X = {0} f(x) = {1} fitness = {2} ", AG.bestInd(), AG.Fnfitness(AG.bestInd()), AG.bestFitness()))
    End Sub
End Class
