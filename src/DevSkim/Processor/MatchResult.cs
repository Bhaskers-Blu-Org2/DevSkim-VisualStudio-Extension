﻿// Copyright (C) Microsoft. All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace DevSkim
{
    public class MatchResult
    {
        public MatchResult()
        {
            Success = false;
            Location = -1;
            Length = 0;
            Rule = null;
        }
        public bool Success { get; set; }
        public int Location { get; set; }
        public int Length { get; set; }        
        public Rule Rule { get; set; }
    }
}
