Option Explicit On
Public Module modBattlelist


    Public ffx8(7) As Byte



    Private Function fillCollectionDictionaryMIN(ByRef pid As Long, ByVal adrCurrentItem As Long, _
                                         ByVal adrPrev As Long, _
                                         ByRef dict As Dictionary(Of Integer, Integer), _
                                         ByVal currentDepth As Long, _
                                         ByRef maxDepth As Long, ByRef adrRoot As Long) As Long
        On Error GoTo gotErr
        Dim Id As Long
        Dim c0, c1, c2 As Long
        Dim Count As Long
        Count = 1
        Id = QMemory_Read4Bytes(pid, adrCurrentItem + &H10)
        If (dict.ContainsKey(Id) = False) Then
            dict(Id) = adrCurrentItem
            If (currentDepth < maxDepth) Then
                Dim p0, p1, p2 As Long
                p0 = QMemory_Read4Bytes(pid, adrCurrentItem)
                p1 = QMemory_Read4Bytes(pid, adrCurrentItem + 4)
                p2 = QMemory_Read4Bytes(pid, adrCurrentItem + 8)
                If Not ((p0 = adrPrev) Or (p0 = adrRoot)) Then
                    c0 = fillCollectionDictionaryMIN(pid, p0, adrCurrentItem, dict, currentDepth + 1, maxDepth, adrRoot)
                    Count = Count + c0
                End If
                If Not ((p1 = adrPrev) Or (p1 = adrRoot)) Then
                    c1 = fillCollectionDictionaryMIN(pid, p1, adrCurrentItem, dict, currentDepth + 1, maxDepth, adrRoot)
                    Count = Count + c1
                End If
                If Not ((p2 = adrPrev) Or (p2 = adrRoot)) Then
                    c2 = fillCollectionDictionaryMIN(pid, p2, adrCurrentItem, dict, currentDepth + 1, maxDepth, adrRoot)
                    Count = Count + c2
                End If
            End If
        End If
        fillCollectionDictionaryMIN = Count
        Exit Function
gotErr:
        fillCollectionDictionaryMIN = 0
        Debug.Print("Something failed: " + Err.Description)
    End Function

    Public Sub ReadTibia11CollectionMIN(ByRef pid As Long, adrPath As AddressPath, _
                                          ByRef dict As Dictionary(Of Integer, Integer))

        Dim adrCOLLECTION_START As Long
        Dim totalItems As Long
        Dim adrSTARTER_ITEM As Long
        Dim maxDepth As Long
        Dim p0, p1, p2 As Long
        Dim iterCount As Long
        Dim c0, c1, c2 As Long
        Dim adrRoot As Long
        iterCount = 0
        dict = New Dictionary(Of Integer, Integer)
        adrCOLLECTION_START = ReadCurrentAddress(pid, adrPath, -1, False)
        totalItems = QMemory_Read4Bytes(pid, adrCOLLECTION_START + 4)
        If (totalItems = 0) Then
            Exit Sub
        End If
        maxDepth = totalItems
        adrSTARTER_ITEM = QMemory_Read4Bytes(pid, adrCOLLECTION_START)
        adrRoot = adrSTARTER_ITEM
        p0 = QMemory_Read4Bytes(pid, adrSTARTER_ITEM)
        p1 = QMemory_Read4Bytes(pid, adrSTARTER_ITEM + 4)
        p2 = QMemory_Read4Bytes(pid, adrSTARTER_ITEM + 8)
        c0 = fillCollectionDictionaryMIN(pid, p0, adrSTARTER_ITEM, dict, 0, maxDepth, adrRoot)
        c1 = fillCollectionDictionaryMIN(pid, p1, adrSTARTER_ITEM, dict, 0, maxDepth, adrRoot)
        c2 = fillCollectionDictionaryMIN(pid, p2, adrSTARTER_ITEM, dict, 0, maxDepth, adrRoot)
        iterCount = c0 + c1 + c2
        'Debug.Print("Collection size " & CStr(totalItems) & " took " & CStr(iterCount) & " iterations")
        'For Each item In dict.Keys
        '    Debug.Print(CStr(item) & " (" & CStr(Hex(item)) & ") found at " & CStr(Hex(dict(item))))
        'Next item
    End Sub

    Public Function GetCharCID(ByVal pid As Integer, ByRef adrBattlelist_CollectionStart As AddressPath) As Integer
        Dim adrCID As Integer
        Dim cid As Integer
        adrCID = ReadCurrentAddress(pid, adrBattlelist_CollectionStart, -1, False)
        If adrCID = -1 Then
            GetCharCID = -1
            Exit Function
        End If
        adrCID = adrCID + &H8
        cid = QMemory_Read4Bytes(pid, adrCID)
        GetCharCID = cid
    End Function

    Public Sub UpdateMyXYZfromBattlelist(ByVal pid As Integer, ByRef dictBattleList As Dictionary(Of Integer, Integer), ByVal cid As Integer, ByRef myx As Integer, ByRef myy As Integer, ByRef myz As Integer)
        Dim adrEntry As Integer
        adrEntry = dictBattleList(cid)
        myx = GetBattlelistEntry_info(pid, adrEntry, &H24, 2)
        myy = GetBattlelistEntry_info(pid, adrEntry, &H28, 2)
        myz = GetBattlelistEntry_info(pid, adrEntry, &H2C, 1)
        'Debug.Print("my xyz=" & CStr(myx) & "," & CStr(myy) & "," & CStr(myz))
    End Sub

    Public Sub RefreshDictionaryOfFriendHPs(ByVal pid As Integer, ByRef dictBattleList As Dictionary(Of Integer, Integer), ByVal myx As Integer, ByVal myy As Integer, ByVal myz As Integer)
        Dim creatureName As String = ""
        Dim res As Integer
        Dim adrEntry As Integer
        Dim hp As Integer
        Dim onScreen As Integer
        Dim x, y, z As Integer
        Const exuraSioRange As Integer = 8
        dictFriendHP.Clear()
        For Each cid As Integer In dictBattleList.Keys
            adrEntry = dictBattleList(cid)
            res = GetBattlelistEntry_info(pid, adrEntry, &H1C, 0, creatureName)
            hp = GetBattlelistEntry_info(pid, adrEntry, &H7C, 1)
            x = GetBattlelistEntry_info(pid, adrEntry, &H24, 2)
            y = GetBattlelistEntry_info(pid, adrEntry, &H28, 2)
            z = GetBattlelistEntry_info(pid, adrEntry, &H2C, 1)
            onScreen = GetBattlelistEntry_info(pid, adrEntry, &HC0, 1)

            If (onScreen = 1) Then
                If z = myz Then
                    If ((Math.Abs(myx - x) <= exuraSioRange) And _
                        (Math.Abs(myy - y) <= exuraSioRange)) Then
                        ' Debug.Print(creatureName & " = " & CStr(hp) & "% , onScreen = " & CStr(onScreen) & " xyz=" & CStr(x) & "," & CStr(y) & "," & CStr(z))
                        dictFriendHP(creatureName) = hp
                    End If
                End If
            End If
        Next cid
        '   dictFriendHP("pepe") = 1

    End Sub
    Public Function GetBattlelistEntry_info(ByVal pid As Integer, ByVal adrEntry As Integer, ByVal posToRead As Integer, ByVal bytesToRead As Integer, Optional ByRef stringResult As String = "") As Integer
        Dim adrUsefull As Integer
        Dim adrPos As Integer
        Dim res As Integer
        adrUsefull = QMemory_Read4Bytes(pid, adrEntry + &H14)
        '    Debug.Print(Hex(adrUsefull))
        adrPos = adrUsefull + posToRead

        Select Case bytesToRead
            Case 0
                res = QMemory_Read4Bytes(pid, adrPos)
                stringResult = QMemory_ReadString(pid, res)
                GetBattlelistEntry_info = res
            Case 1
                res = QMemory_Read1Byte(pid, adrPos)
            Case 2
                res = QMemory_Read2Bytes(pid, adrPos)
            Case Else
                res = QMemory_Read4Bytes(pid, adrPos)
        End Select
        GetBattlelistEntry_info = res
    End Function

    Public Sub SetFullLight(ByVal pid As Integer, ByRef adrCharEntry As Integer)
        Dim adrUsefull As Integer
        Dim adrPos As Integer
        adrUsefull = QMemory_Read4Bytes(pid, adrCharEntry + &H14)
        adrPos = adrUsefull + &H38
        QMemory_Write1Byte(pid, adrPos, &HF)
        '  Debug.Print(Hex(adrPos))
        adrPos = adrPos + 8
        QMemory_WriteBytes(pid, adrPos, ffx8)
    End Sub

    Public Function charIsInvisible(ByVal pid As Integer, ByRef charName As String, ByVal adrCharEntry As Integer) As Boolean
        Dim adrUsefull As Integer
        Dim adrPos As Integer
        Dim adrOutfit As Integer
        ' Dim humanColor(3) As Integer
        Dim tileIDadr As Integer
        Dim tileID As Integer
        adrUsefull = QMemory_Read4Bytes(pid, adrCharEntry + &H14)
        adrPos = adrUsefull + &H64
        ' Debug.Print("adr pos=" & Hex(adrPos))
        adrOutfit = QMemory_Read4Bytes(pid, adrPos)
        ' Debug.Print("adr outfit=" & Hex(adrOutfit))
        tileIDadr = QMemory_Read4Bytes(pid, adrOutfit + &H8)
        tileID = QMemory_Read4Bytes(pid, tileIDadr)
        'humanColor(0) = QMemory_Read4Bytes(pid, adrOutfit + &H58)
        'humanColor(1) = QMemory_Read4Bytes(pid, adrOutfit + &H68)
        'humanColor(2) = QMemory_Read4Bytes(pid, adrOutfit + &H78)
        'humanColor(3) = QMemory_Read4Bytes(pid, adrOutfit + &H88)
        ' Debug.Print(CStr(tileID) & " > " & CStr(humanColor(0)) & " " & CStr(humanColor(1)) & " " & CStr(humanColor(2)) & " " & CStr(humanColor(3)))
        If (tileID = 0) Then
            'Debug.Print("invisible=TRUE")
            charIsInvisible = True
        Else
            ' Debug.Print("invisible=FALSE")
            charIsInvisible = False
        End If
    End Function
End Module
