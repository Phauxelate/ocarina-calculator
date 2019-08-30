Imports System.IO

Public Class Main

#Region "Variables"
    Protected holes As New ArrayList
    Protected baseVolume As Double
    Protected thickness As Double
    Protected baseFrequency As Double
    Protected fippleDiam As Double
    Protected previousFreq As Double
    Protected firstTime As Boolean
    Protected numberOfHoles As Integer
#End Region

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        firstTime = True
    End Sub

    ''' <summary>
    ''' Calculates volume of an Ocarina.
    ''' </summary>
    ''' <param name="F">The base frequency.</param>
    ''' <param name="D">The diameter of the Fipple</param>
    ''' <returns>DOUBLE - The Volume of the Ocarina.</returns>
    Private Function CalculateVolume(F As Double, D As Double) As Double

        Dim V As Double = 1 / ((Math.Pow((F / 2148.14), 2)) / D)
        Return V
    End Function

    ''' <summary>
    '''  Calculates total thickness of the clay.
    ''' </summary>
    ''' <param name="V">The volume of the Ocarina.</param>
    ''' <param name="F">The base frequency of the Ocarina.</param>
    ''' <param name="D">The diameter of the fipple.</param>
    ''' <returns>DOUBLE - Thickness of the Ocarina.</returns>
    Private Function CalculateTotalThickness(V As Double, F As Double, D As Double) As Double

        'Converts the diameter to Area
        Dim A = (Math.PI * Math.Pow((D / 2), 2))

        'Calculates the thickness
        Dim T As Double = ((A / 4) * Math.Pow(13503.9 / (2 * Math.PI), 2)) / (((Math.Pow(F, 2)) / 4) * V)

        Return T
    End Function

    ''' <summary>
    ''' Calculates total open area on the Ocarina.
    ''' </summary>
    ''' <param name="V">Volume of the Ocarina.</param>
    ''' <param name="T">Thickness of the Ocarina.</param>
    ''' <param name="F">Frequency of the Ocarina.</param>
    ''' <returns>DOUBLE - Total open area of the Ocarina.</returns>

    Private Function CalculateTotalOpenArea(V As Double, T As Double, F As Double) As Double

        Dim totalArea = (((Math.Pow(F, 2) / 4 * V * T)) / Math.Pow((13503.9 / (2 * Math.PI)), 2))

        Return totalArea
    End Function

    ''' <summary>
    ''' Calculates the diameter for a hole.
    ''' </summary>
    ''' <param name="A">Area of the hole.</param>
    ''' <returns>DOUBLE - The area of the hole.</returns>
    Private Function CalculateDiameter(A As Double) As Double
        Dim area = Math.Sqrt((A * 4) / Math.PI)

        Return area
    End Function

    ''' <summary>
    ''' Calculates the frequency of a note by the number of steps it takes.
    ''' </summary>
    ''' <param name="f0">The base note frequency.</param>
    ''' <param name="n">The number of steps higher the note to calculate is.</param>
    ''' <returns>DOUBLE - The frequency of the new note.</returns>
    Function CalculateStepFrequency(ByVal f0 As Double, ByVal n As Double) As Double
        Dim a As Double = Math.Pow(2, (1 / 12))
        Dim fn As Double

        ' Add up numbers.
        fn = f0 * Math.Pow(a, n)

        Return fn
    End Function

    ''' <summary>
    ''' This calculates the Ocarina hole diameter.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Try
            'Sets the global variables to the text box values
            baseVolume = CType(CalculateVolume(CType(baseFreqTxt.Text, Double), CType(fippleDiamTxt.Text, Double)), Double)
            fippleDiam = CType(fippleDiamTxt.Text, Double)
            thickness = CType(CalculateTotalThickness(baseVolume, CType(baseFreqTxt.Text, Double), CType(fippleDiamTxt.Text, Double)), Double)
            baseFrequency = CType(baseFreqTxt.Text, Double)
            volTxt.Text = baseVolume.ToString
            thickTxt.Text = thickness.ToString


            'Creates temp variables to store the hole area and diameter
            Dim targetHoleArea As Double
            Dim targetHoleDiam As Double

            'If this is the first time the program is running, add the fipple diameter to the holes array
            If firstTime Then
                holes.Add(CalculateTotalOpenArea(baseVolume, thickness, baseFrequency))
                targetHoleArea = holes.Item(holes.Count - 1)
                targetHoleDiam = CalculateDiameter(targetHoleArea)

                previousFreq = baseFrequency
                firstTime = False
            End If

            'Adds the hole to the array
            holes.Add(CalculateTotalOpenArea(baseVolume, thickness, CType(desiredFreqTxt.Text, Double)) - CalculateTotalOpenArea(baseVolume, thickness, previousFreq))

            'Calculates the diameter of the new hole
            targetHoleArea = holes.Item(holes.Count - 1)
            targetHoleDiam = CalculateDiameter(targetHoleArea)

            'Sets the text box to display the hole diameter
            previousFreq = desiredFreqTxt.Text
            holeDiamTxt.Text = targetHoleDiam.ToString

            'Increases the number of holes counter
            numberOfHoles += 1

            'Sets the text file name to store the measurements
            Dim strFile As String = "Ocarina Measurements.txt"

            'If the file doesn't exist, create it and add the base measurements
            If Not File.Exists("Ocarina Measurements.txt") Then
                Using sw As New StreamWriter(File.Open(strFile, FileMode.Create))
                    sw.WriteLine("Fipple Diameter: " + fippleDiam.ToString)
                    sw.WriteLine("Volume: " + baseVolume.ToString)
                    sw.WriteLine("Thickness: " + thickness.ToString)
                    sw.WriteLine("Base Frequency: " + baseFrequency.ToString)
                    sw.WriteLine("")
                End Using
            End If

            'Open the text file and write the newly generated hole diameter into it
            Using sw As New StreamWriter(strFile, True)
                sw.WriteLine("Hole " + numberOfHoles.ToString + " Diameter: " + targetHoleDiam.ToString)
            End Using

        Catch ex As InvalidCastException
            'Creates a temporary variable as a double
            Dim temp As Double

            'Checks if the text box is a number. If it isn't, handle the case whether it's missing or a character
            If Not Double.TryParse(fippleDiamTxt.Text, temp) Then
                'If the text box is not a number
                If fippleDiamTxt.Text <> "" And fippleDiamTxt.Text <> "MISSING!" Then
                    fippleDiamTxt.Text = "NUMBERS ONLY!"
                End If
                'If the text box is empty
                If fippleDiamTxt.Text = "" Then
                    fippleDiamTxt.Text = "MISSING!"
                End If
            End If

            'Checks if the text box is a number. If it isn't, handle the case whether it's missing or a character
            If Not Double.TryParse(baseFreqTxt.Text, temp) Then
                'If the text box is not a number
                If baseFreqTxt.Text <> "" And baseFreqTxt.Text <> "MISSING!" Then
                    baseFreqTxt.Text = "NUMBERS ONLY!"
                End If
                'If the text box is empty
                If baseFreqTxt.Text = "" Then
                    baseFreqTxt.Text = "MISSING!"
                End If
            End If

            'Checks if the text box is a number. If it isn't, handle the case whether it's missing or a character
            If Not Double.TryParse(desiredFreqTxt.Text, temp) Then
                'If the text box is not a number
                If desiredFreqTxt.Text <> "" And desiredFreqTxt.Text <> "MISSING!" Then
                    desiredFreqTxt.Text = "NUMBERS ONLY!"
                End If
                'If the text box is empty
                If desiredFreqTxt.Text = "" Then
                    desiredFreqTxt.Text = "MISSING!"
                End If
            End If



        End Try

    End Sub

    ''' <summary>
    ''' This button shows a window of how to use the program properly.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub HelpBttn_Click(sender As Object, e As EventArgs) Handles helpBttn.Click
        MessageBox.Show("This program calculates the diameter of finger holes for an ocarina (or possibly some other similar instrument). I have not found a single source that showed how to do this either mathematically or programatically, so I decided figure it out myself.

All units are in inches and hertz.

To start, enter a desired fipple diameter. All other measurements are based off of this value, so you'll need to choose something semi random for this. For an AC ocarina, this could be around 0.15 inches.

Next, enter the base frequency of the ocarina. This is the frequency where every finger hole is closed.

Now here's the funky part: The way the diameter of holes are calculated is by the total area of open holes. So to start calculating the holes, you'll need to choose a note higher than what you want in order for it to be physically open. When you calculate the last hole (On a 12 hole AC Ocarina this would be F with a frequency of 1396.91 Hz), that hole will be open if you try to physically play the note, so you won't need a higher note frequency for it.

After each caluclation, the program spits out a text file containing the measurements in the same folder so you won't have to manually record them.

If you add in a number wrong, you have to press restart and try again. The hole diameters are linked to eachother, which means you can't just ignore that you just added an unwanted hole into your measurement calculations!


Created by Ethan Strike, August 30th, 2019.")
    End Sub

    ''' <summary>
    ''' This button shows the equations used in the program, or other equations that never got used but still work.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Equations_Click(sender As Object, e As EventArgs) Handles equations.Click
        MessageBox.Show("V = Volume
A = Area
F = Frequency
D = Diameter
L = Length
W = Width

Calculate Frequency (from Diameter and Volume) = 2148.14 * ((D / V)^(1/2))
Calculate Volume (from Frequency and Diameter) = 1 / ((((F / 2148.14)^2)) / D)
Calculate Diameter (from Length and Width) = 2 * (((l * w) / Math.PI)^(1/2))
Calculate Diameter (from Volume and Frequency) =  ((F / 2148.14)^2) * V
Calculate Thickness (from Volume, Frequency, and Area) = ((A / 4) * (13503.9 / (2 * PI)^2)) / (((F^2) / 4) * V)
Calculate Total Area (from Volume, Thickness, Frequency) = (((F^2) / 4 * V * T)) / ((13503.9 / (2 * Math.PI))^2)
Calculate Diameter (from Area of a Hole) = Math.sqrt((A * 4) / PI)
Calculate Area of Fipple (from Width and Circular Fipple Diameter) = (PI * ((D/2)^2))/W")
    End Sub

    ''' <summary>
    ''' This button resets the window in case someone funks up inputting numbers.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        'Wipes all the variables
        holes.Clear()
        baseVolume = 0
        thickness = 0
        baseFrequency = 0
        fippleDiam = 0
        previousFreq = 0
        firstTime = 0
        numberOfHoles = 0

        'Checks to see if a text file has already been generated. If it has, delete it
        If File.Exists("Ocarina Measurements.txt") Then
            File.Delete("Ocarina Measurements.txt")
        End If

        Me.Controls.Clear() 'Removes all the controls on the form
        InitializeComponent() 'Load all the controls again
        Main_Load(e, e) 'Load everything in your form load event again
    End Sub
End Class