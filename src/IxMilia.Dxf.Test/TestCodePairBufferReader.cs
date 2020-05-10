// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;

namespace IxMilia.Dxf.Test
{
    public class TestCodePairBufferReader : IDxfCodePairReader
    {
        public List<DxfCodePair> Pairs { get; }

        public TestCodePairBufferReader(IEnumerable<(int code, object value)> codePairs)
        {
            Pairs = codePairs.Select(cp => new DxfCodePair(cp.code, cp.value)).ToList();
        }

        public IEnumerable<DxfCodePair> GetCodePairs() => Pairs;

        public void SetUtf8Reader()
        {
        }
    }
}
