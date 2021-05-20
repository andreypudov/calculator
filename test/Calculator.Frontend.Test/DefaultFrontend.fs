﻿// Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.

namespace Calculator.Frontend.Test

module DefaultFrontend =

    open LexicalAnalyzer
    open NUnit.Framework

    [<Test>]
    let ``When 2 is added to 2 expect 4``() =
        Assert.AreEqual(4, 2+2)