


@Code
    ViewData("Title") = "Index"

End Code

<div align="center">
    <img src="~/Content/psuedoipsumlogo.jpg" />
</div>
<br />
<div align="center">
    <font face="lucida">
        <h2><strong>Pseudo-Intellectual Ipsum</strong></h2>
    </font>

</div>

@Using (Html.BeginForm())
    @<text>
                <div align="center" Class="form-horizontal">
                    <div Class="col-sm-12 col-md-12 col-lg-12">
                        <div Class="form-group">
                            <div>
                                <br />
                                <font face="verdana" size="3">
                                    I seek
                                </font>
                                <select name="numberoflines">
                                    <option value="0"> 0</option>
                                    <option value="5"> 5</option>
                                    <option value="10"> 10</option>
                                    <option value="20"> 20</option>
                                    <option value="40"> 40</option>
                                    <option value="80"> 80</option>
                                    <option value="160"> 160</option>
                                    <option value="320"> 320</option>
                                    <option value="640"> 640</option>
                                    <option value="1280"> 1280</option>
                                </select>
                                <font face="verdana" size="3">
                                    apothegms of fallacy.
                                </font>
                            </div>
                        </div>

                    </div>

                    <br />
                    <div Class="form-group">
                        <div>
                            <input type="submit" value="Caveat Emptor" Class="btn btn-primary" />
                        </div>
                    </div>
                </div>

    </text>

End Using







<br />

<br />

@Code

    If (ViewBag.numberoflines = 0) Then

        @<text>
            <br /><br /><br /><br /><br /><br />
            <hr />
            <font face="verdana">
                <h3>An Explanation of this project:</h3> < br />
                This program will generate For you what I Call Psuedo Intellectual Ipsum. This Is a knock off Of Lorem Ipsum For comedic effect. It uses nonsense phrases associated With pseudo intellectuals To generate nonsense filler text. <br /><br />
                Lorem Ipsum refers to text that the DTP (Desktop Publishing) industry use as replacement text when the real text Is Not available.
                For example, when designing a brochure Or book, a designer will insert Lorem ipsum text if the real text Is Not available. The Lorem ipsum text looks real enough that the brochure Or book looks complete. The book Or brochure can be shown To the client For approval.
                The important factor when using Lorem ipsum text Is that the text looks realistic otherwise the brochure Or book will Not look very good. Lorem Ipsum Is dummy text which has no meaning however looks very similar to real text.

            </font>
        </text>

    End If

    If (ViewBag.numberoflines > 0) Then
        Dim count As Int32 = ViewBag.numberoflines
        Dim randomrange As Int32 = listclasslist.linesegmentFilledList.Count
        Dim random As New Random

        @<span>&nbsp;</span>

        For i As Int32 = 1 To count
            Dim randomindex As Int32 = random.Next(0, randomrange - 1)
            Dim display As listclass = listclasslist.linesegmentFilledList(randomindex)
            @<font face = "verdana" size="3">
                <span>
                @display.linesegment
                </span>
            </font>

            If (i Mod 5 = 0) Then
                Dim paragraphrandom As Int32 = random.Next(1, 4)

                If (paragraphrandom = 1) Then

                End If
                If (paragraphrandom = 2) Then
                    @<br /> @<br /> @<span>&nbsp;</span>
                End If
                If (paragraphrandom = 3) Then

                End If
                If (paragraphrandom = 4) Then

                End If



            End If

        Next
    End If

End Code


