Public Class ProjectGarden

Public Sub StartGardenProject()
    Dim dirt As Integer
    Dim water As Double
    Dim seeds As Integer
    
    'Create a loop to loop through the project
    For x = 0 to 2000
        dirt = dirt + 10 'Add 10 units of dirt
        water = water + 0.5 'Add 0.5 units of water
        seeds = seeds + 5 'Add 5 units of seeds
    Next
    
    'Call the appropriate methods
    CheckWaterLevel(water)
    CheckDirtLevel(dirt)
    CheckSeedLevel(seeds)
    DistributeDirt(dirt)
    DistributeWater(water)
    DistributeSeeds(seeds)
    
End Sub


Public Sub CheckWaterLevel(ByRef water As Double)
    'Check the current water level
    If water <= 0 Then
        Return False
    Else
        Return True
    End If
End Sub

Public Sub CheckDirtLevel(ByRef dirt As Integer)
    'Check the current dirt level
    If dirt <= 0 Then
        Return False
    Else
        Return True
    End If
End Sub

Public Sub CheckSeedLevel(ByRef seeds As Integer)
    'Check the current seed level
    If seeds <= 0 Then
        Return False
    Else
        Return True
    End If
End Sub

Public Sub DistributeDirt(ByRef dirt As Integer)
    'Distribute the dirt
    For x = 0 to 2000
        If dirt > 0 Then
            dirt = dirt - 5 'Subtract 5 units of dirt
        End If
    Next
End Sub

Public Sub DistributeWater(ByRef water As Double)
    'Distribute the water
    For x = 0 to 2000
        If water > 0 Then
            water = water - 0.5 'Subtract 0.5 units of water
        End If
    Next
End Sub

Public Sub DistributeSeeds(ByRef seeds As Integer)
    'Distribute the seeds
    For x = 0 to 2000
        If seeds > 0 Then
            seeds = seeds - 1 'Subtract 1 unit of seeds
        End If
    Next
End Sub


End Class